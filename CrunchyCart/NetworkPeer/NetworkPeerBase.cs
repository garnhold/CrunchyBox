using System;
using System.Collections;
using System.Collections.Generic;

using Lidgren.Network;

using CrunchyDough;
using CrunchySalt;
using CrunchyNoodle;
using CrunchySodium;

namespace CrunchyCart
{
    public abstract class NetworkPeerBase
    {
        protected virtual bool ProcessStatusInitiatedConnect(NetIncomingMessage message) { return true; }
        protected virtual bool ProcessStatusReceivedInitiation(NetIncomingMessage message) { return true; }
        protected virtual bool ProcessStatusRespondedAwaitingApproval(NetIncomingMessage message) { return true; }
        protected virtual bool ProcessStatusRespondedConnect(NetIncomingMessage message) { return true; }
        protected virtual bool ProcessStatusConnected(NetIncomingMessage message) { return true; }
        protected virtual bool ProcessStatusDisconnecting(NetIncomingMessage message) { return true; }
        protected virtual bool ProcessStatusDisconnected(NetIncomingMessage message) { return true; }

        protected virtual bool ProcessConnectionApproval(NetIncomingMessage message) { return true; }

        protected virtual bool ProcessDiscoveryRequest(NetIncomingMessage message) { return true; }
        protected virtual bool ProcessDiscoveryResponse(NetIncomingMessage message) { return true; }

        protected virtual bool ProcessNatIntroductionSuccess(NetIncomingMessage message) { return true; }
        protected virtual bool ProcessConnectionLatencyUpdated(NetIncomingMessage message) { return true; }

        protected virtual bool ProcessData(NetIncomingMessage message) { return true; }
        protected virtual bool ProcessUnconnectedData(NetIncomingMessage message) { return true; }

        protected virtual bool ProcessVerboseDebugMessage(NetIncomingMessage message) { return true; }
        protected virtual bool ProcessDebugMessage(NetIncomingMessage message) { return true; }
        protected virtual bool ProcessWarningMessage(NetIncomingMessage message) { return true; }
        protected virtual bool ProcessErrorMessage(NetIncomingMessage message) { return true; }

        protected abstract NetPeer GetNetPeer();

        private bool ProcessStatusChanged(NetIncomingMessage message)
        {
            NetConnectionStatus status = (NetConnectionStatus)message.ReadByte();

            switch (status)
            {
                case NetConnectionStatus.InitiatedConnect: return ProcessStatusInitiatedConnect(message);
                case NetConnectionStatus.ReceivedInitiation: return ProcessStatusReceivedInitiation(message);
                case NetConnectionStatus.RespondedAwaitingApproval: return ProcessStatusRespondedAwaitingApproval(message);
                case NetConnectionStatus.RespondedConnect: return ProcessStatusRespondedConnect(message);

                case NetConnectionStatus.Connected: return ProcessStatusConnected(message);

                case NetConnectionStatus.Disconnecting: return ProcessStatusDisconnecting(message);
                case NetConnectionStatus.Disconnected: return ProcessStatusDisconnected(message);
            }

            throw new UnaccountedBranchException("status", status);
        }

        private bool ProcessMessage(NetIncomingMessage message)
        {
            switch (message.MessageType)
            {
                case NetIncomingMessageType.StatusChanged: return ProcessStatusChanged(message);

                case NetIncomingMessageType.ConnectionApproval: return ProcessConnectionApproval(message);

                case NetIncomingMessageType.DiscoveryRequest: return ProcessDiscoveryRequest(message);
                case NetIncomingMessageType.DiscoveryResponse: return ProcessDiscoveryResponse(message);

                case NetIncomingMessageType.NatIntroductionSuccess: return ProcessNatIntroductionSuccess(message);
                case NetIncomingMessageType.ConnectionLatencyUpdated: return ProcessConnectionLatencyUpdated(message);

                case NetIncomingMessageType.Data: return ProcessData(message);
                case NetIncomingMessageType.UnconnectedData: return ProcessUnconnectedData(message);

                case NetIncomingMessageType.VerboseDebugMessage: return ProcessVerboseDebugMessage(message);
                case NetIncomingMessageType.DebugMessage: return ProcessDebugMessage(message);
                case NetIncomingMessageType.WarningMessage: return ProcessWarningMessage(message);
                case NetIncomingMessageType.ErrorMessage: return ProcessErrorMessage(message);
            }

            throw new UnaccountedBranchException("message.MessageType", message.MessageType);
        }

        public NetworkPeerBase()
        {
        }

        public void SendMessage(NetworkRecipient recipient, NetDeliveryMethod delivery_method, int delivery_channel, Process<NetOutgoingMessage> process)
        {
            NetOutgoingMessage message = GetNetPeer().CreateMessage();

            process(message);
            recipient.Send(delivery_method, delivery_channel, message, GetNetPeer());
        }

        public void Flush()
        {
            GetNetPeer().FlushSendQueue();
        }

        public bool ProcessNextMessage()
        {
            NetIncomingMessage message = GetNetPeer().ReadMessage();

            if (message != null)
            {
                if(ProcessMessage(message))
                    GetNetPeer().Recycle(message);

                return true;
            }

            return false;
        }

        public void ProcessMessages()
        {
            while (ProcessNextMessage()) ;
        }

        public NetworkActor GetNetworkActor()
        {
            return GetNetPeer().GetNetworkActor();
        }

        public NetworkActor GetNetworkActorById(long id)
        {
            return GetNetPeer().GetNetworkActorById(id);
        }
    }
}