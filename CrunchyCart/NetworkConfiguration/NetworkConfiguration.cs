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
    public class NetworkConfiguration
    {
        private int port;

        private bool auto_expand_mtu;
        private float expand_mtu_frequency;
        private int expand_mtu_fail_attempts;

        private float connection_timeout;
        private int maximum_connections;

        private float resend_handshake_interval;
        private int maximum_handshake_attempts;

        private int default_outgoing_message_capacity;
        private int send_buffer_size;
        private int receive_buffer_size;
        private NetUnreliableSizeBehaviour unreliable_size_behaviour;

        private float ping_interval;
        private int recycled_cache_max_count;
        private int maximum_transmission_unit;

        private bool enable_upnp;
        private bool suppress_unreliable_unordered_acks;

        private NetPeerConfiguration CreateNetPeerConfiguration()
        {
            NetPeerConfiguration configuration = new NetPeerConfiguration(ProgramInfo.GetId()) {
                UseMessageRecycling = true,
                AutoFlushSendQueue = false,

                AutoExpandMTU = auto_expand_mtu,
                ExpandMTUFrequency = expand_mtu_frequency,
                ExpandMTUFailAttempts = expand_mtu_fail_attempts,

                ConnectionTimeout = connection_timeout,
                MaximumConnections = maximum_connections,

                ResendHandshakeInterval = resend_handshake_interval,
                MaximumHandshakeAttempts = maximum_handshake_attempts,

                DefaultOutgoingMessageCapacity = default_outgoing_message_capacity,
                SendBufferSize = send_buffer_size,
                ReceiveBufferSize = receive_buffer_size,
                UnreliableSizeBehaviour = unreliable_size_behaviour,

                PingInterval = ping_interval,
                RecycledCacheMaxCount = recycled_cache_max_count,
                MaximumTransmissionUnit = maximum_transmission_unit,

                EnableUPnP = enable_upnp,
                SuppressUnreliableUnorderedAcks = suppress_unreliable_unordered_acks
            };

            configuration.EnableMessageType(NetIncomingMessageType.StatusChanged);
            configuration.EnableMessageType(NetIncomingMessageType.UnconnectedData);
            configuration.EnableMessageType(NetIncomingMessageType.ConnectionApproval);
            configuration.EnableMessageType(NetIncomingMessageType.Data);
            configuration.EnableMessageType(NetIncomingMessageType.DiscoveryRequest);
            configuration.EnableMessageType(NetIncomingMessageType.DiscoveryResponse);
            configuration.EnableMessageType(NetIncomingMessageType.VerboseDebugMessage);
            configuration.EnableMessageType(NetIncomingMessageType.DebugMessage);
            configuration.EnableMessageType(NetIncomingMessageType.WarningMessage);
            configuration.EnableMessageType(NetIncomingMessageType.ErrorMessage);
            configuration.EnableMessageType(NetIncomingMessageType.NatIntroductionSuccess);
            configuration.EnableMessageType(NetIncomingMessageType.ConnectionLatencyUpdated);
            return configuration;
        }

        public NetworkConfiguration(int p)
        {
            port = p;

            auto_expand_mtu = false;
            expand_mtu_frequency = 2.0f;
            expand_mtu_fail_attempts = 5;

            connection_timeout = 25.0f;
            maximum_connections = 32;

            resend_handshake_interval = 3.0f;
            maximum_handshake_attempts = 5;

            default_outgoing_message_capacity = 16;
            send_buffer_size = 131071;
            receive_buffer_size = 131071;
            unreliable_size_behaviour = NetUnreliableSizeBehaviour.IgnoreMTU;

            ping_interval = 4.0f;
            recycled_cache_max_count = 64;
            maximum_transmission_unit = 1408;

            enable_upnp = false;
            suppress_unreliable_unordered_acks = false;
        }

        public int GetPort()
        {
            return port;
        }

        public NetPeerConfiguration CreateNetServerConfiguration()
        {
            NetPeerConfiguration configuration = CreateNetPeerConfiguration();

            configuration.Port = port;
            return configuration;
        }

        public NetPeerConfiguration CreateNetClientConfiguration()
        {
            NetPeerConfiguration configuration = CreateNetPeerConfiguration();

            return configuration;
        }
    }
}