using System;
using System.Net;
using System.Collections;
using System.Collections.Generic;

using Lidgren.Network;

using CrunchyDough;
using CrunchySalt;
using CrunchyNoodle;
using CrunchySodium;

namespace CrunchyCart
{
    public partial class Syncronizer
    {
        public abstract class ConstantSubManager<T> : ConstantSubManager
        {
            private HashSet<T> requested_constant_values;

            private Dictionary<T, Constant<T>> constant_by_values;
            private Dictionary<int, Constant<T>> constant_by_compressed_ids;

            protected abstract T ReadConstantValue(Buffer buffer);
            protected abstract void WriteConstantValue(T value, Buffer buffer);

            private Constant<T> ReadConstant(Buffer buffer)
            {
                return new Constant<T>(ReadConstantValue(buffer), buffer.ReadInt24());
            }
            private void WriteConstant(Constant<T> constant, Buffer buffer)
            {
                WriteConstantValue(constant.GetValue(), buffer);

                buffer.WriteInt24(constant.GetCompressedId());
            }

            private void Request(T value)
            {
                if (requested_constant_values.Add(value))
                {
                    if (GetNetworkActor().IsServer())
                        Add(new Constant<T>(value));
                    else
                    {
                        GetSyncronizer().Send(NetworkRecipient_All.INSTANCE, MessageType.RequestConstant, NetDeliveryMethod.ReliableUnordered, ConstantDeliveryChannel, delegate(Buffer buffer) {
                            buffer.WriteByte(GetIndex());
                            WriteConstantValue(value, buffer);
                        });
                    }
                }
            }

            private void Add(Constant<T> constant)
            {
                constant_by_values.Add(constant.GetValue(), constant);
                constant_by_compressed_ids.Add(constant.GetCompressedId(), constant);

                if (GetNetworkActor().IsServer())
                {
                    GetSyncronizer().Send(NetworkRecipient_All.INSTANCE, MessageType.UpdateConstant, NetDeliveryMethod.ReliableUnordered, ConstantDeliveryChannel, delegate(Buffer buffer) {
                        buffer.WriteByte(GetIndex());
                        WriteConstant(constant, buffer);
                    });
                }
            }
            private void Add(IEnumerable<Constant<T>> constants)
            {
                constants.Process(c => Add(c));
            }

            public ConstantSubManager(ConstantManager m) : base(m)
            {
                requested_constant_values = new HashSet<T>();

                constant_by_values = new Dictionary<T, Constant<T>>();
                constant_by_compressed_ids = new Dictionary<int, Constant<T>>();
            }

            public override void SendFullUpdate(NetworkRecipient recipient)
            {
                if (GetNetworkActor().IsServer())
                {
                    GetSyncronizer().Send(recipient, MessageType.FullUpdateConstant, NetDeliveryMethod.ReliableUnordered, ConstantDeliveryChannel, delegate(Buffer buffer) {
                        buffer.WriteByte(GetIndex());
                        buffer.WriteCollection(constant_by_values.Values, c => WriteConstant(c, buffer));
                    });
                }
            }
            public override void ReadFullUpdate(Buffer buffer)
            {
                if (buffer.GetSender().IsServer())
                    Add(buffer.ReadCollection(b => ReadConstant(b)));
            }

            public override void ReadRequest(Buffer buffer)
            {
                if (GetNetworkActor().IsServer())
                    Request(ReadConstantValue(buffer));
            }

            public override void ReadUpdate(Buffer buffer)
            {
                if (buffer.GetSender().IsServer())
                    Add(ReadConstant(buffer));
            }

            public T ReadConstantReference(Buffer buffer)
            {
                Constant<T> constant;

                if (buffer.ReadBoolean())
                {
                    int compressed_id = buffer.ReadInt24();

                    if (constant_by_compressed_ids.TryGetValue(compressed_id, out constant))
                        return constant.GetValue();

                    throw new BufferDefermentException_MissingConstant(compressed_id, this);
                }
                
                return ReadConstantValue(buffer);
            }
            public void WriteConstantReference(T value, Buffer buffer)
            {
                Constant<T> constant;

                if (constant_by_values.TryGetValue(value, out constant))
                {
                    if (constant.ShouldCompress())
                    {
                        buffer.WriteBoolean(true);
                        buffer.WriteInt24(constant.GetCompressedId());
                    }
                }
                else
                {
                    Request(value);
                }

                buffer.WriteBoolean(false);
                WriteConstantValue(value, buffer);
            }

            public override bool CanUncompress(int compressed_id)
            {
                if (constant_by_compressed_ids.ContainsKey(compressed_id))
                    return true;

                return false;
            }
        }

        public abstract class ConstantSubManager
        {
            private byte index;
            private ConstantManager manager;

            public const int ConstantDeliveryChannel = 31;

            public abstract void SendFullUpdate(NetworkRecipient recipient);
            public abstract void ReadFullUpdate(Buffer buffer);

            public abstract void ReadRequest(Buffer buffer);
            public abstract void ReadUpdate(Buffer buffer);

            public abstract bool CanUncompress(int compressed_id);

            public ConstantSubManager(ConstantManager m)
            {
                manager = m;
            }

            public void SetIndex(byte i)
            {
                index = i;
            }

            public byte GetIndex()
            {
                return index;
            }

            public ConstantManager GetManager()
            {
                return manager;
            }

            public Syncronizer GetSyncronizer()
            {
                return GetManager().GetSyncronizer();
            }

            public NetworkActor GetNetworkActor()
            {
                return GetSyncronizer().GetNetworkActor();
            }
        }
    }
}