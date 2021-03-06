// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Management.Network.Models
{
    public partial class ExpressRouteCrossConnectionPeering : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Name != null)
            {
                writer.WritePropertyName("name");
                writer.WriteStringValue(Name);
            }
            if (Etag != null)
            {
                writer.WritePropertyName("etag");
                writer.WriteStringValue(Etag);
            }
            if (Id != null)
            {
                writer.WritePropertyName("id");
                writer.WriteStringValue(Id);
            }
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (PeeringType != null)
            {
                writer.WritePropertyName("peeringType");
                writer.WriteStringValue(PeeringType.Value.ToString());
            }
            if (State != null)
            {
                writer.WritePropertyName("state");
                writer.WriteStringValue(State.Value.ToString());
            }
            if (AzureASN != null)
            {
                writer.WritePropertyName("azureASN");
                writer.WriteNumberValue(AzureASN.Value);
            }
            if (PeerASN != null)
            {
                writer.WritePropertyName("peerASN");
                writer.WriteNumberValue(PeerASN.Value);
            }
            if (PrimaryPeerAddressPrefix != null)
            {
                writer.WritePropertyName("primaryPeerAddressPrefix");
                writer.WriteStringValue(PrimaryPeerAddressPrefix);
            }
            if (SecondaryPeerAddressPrefix != null)
            {
                writer.WritePropertyName("secondaryPeerAddressPrefix");
                writer.WriteStringValue(SecondaryPeerAddressPrefix);
            }
            if (PrimaryAzurePort != null)
            {
                writer.WritePropertyName("primaryAzurePort");
                writer.WriteStringValue(PrimaryAzurePort);
            }
            if (SecondaryAzurePort != null)
            {
                writer.WritePropertyName("secondaryAzurePort");
                writer.WriteStringValue(SecondaryAzurePort);
            }
            if (SharedKey != null)
            {
                writer.WritePropertyName("sharedKey");
                writer.WriteStringValue(SharedKey);
            }
            if (VlanId != null)
            {
                writer.WritePropertyName("vlanId");
                writer.WriteNumberValue(VlanId.Value);
            }
            if (MicrosoftPeeringConfig != null)
            {
                writer.WritePropertyName("microsoftPeeringConfig");
                writer.WriteObjectValue(MicrosoftPeeringConfig);
            }
            if (ProvisioningState != null)
            {
                writer.WritePropertyName("provisioningState");
                writer.WriteStringValue(ProvisioningState.Value.ToString());
            }
            if (GatewayManagerEtag != null)
            {
                writer.WritePropertyName("gatewayManagerEtag");
                writer.WriteStringValue(GatewayManagerEtag);
            }
            if (LastModifiedBy != null)
            {
                writer.WritePropertyName("lastModifiedBy");
                writer.WriteStringValue(LastModifiedBy);
            }
            if (Ipv6PeeringConfig != null)
            {
                writer.WritePropertyName("ipv6PeeringConfig");
                writer.WriteObjectValue(Ipv6PeeringConfig);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static ExpressRouteCrossConnectionPeering DeserializeExpressRouteCrossConnectionPeering(JsonElement element)
        {
            string name = default;
            string etag = default;
            string id = default;
            ExpressRoutePeeringType? peeringType = default;
            ExpressRoutePeeringState? state = default;
            int? azureASN = default;
            long? peerASN = default;
            string primaryPeerAddressPrefix = default;
            string secondaryPeerAddressPrefix = default;
            string primaryAzurePort = default;
            string secondaryAzurePort = default;
            string sharedKey = default;
            int? vlanId = default;
            ExpressRouteCircuitPeeringConfig microsoftPeeringConfig = default;
            ProvisioningState? provisioningState = default;
            string gatewayManagerEtag = default;
            string lastModifiedBy = default;
            Ipv6ExpressRouteCircuitPeeringConfig ipv6PeeringConfig = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("etag"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    etag = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("id"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("properties"))
                {
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("peeringType"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            peeringType = new ExpressRoutePeeringType(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("state"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            state = new ExpressRoutePeeringState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("azureASN"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            azureASN = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("peerASN"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            peerASN = property0.Value.GetInt64();
                            continue;
                        }
                        if (property0.NameEquals("primaryPeerAddressPrefix"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            primaryPeerAddressPrefix = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("secondaryPeerAddressPrefix"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            secondaryPeerAddressPrefix = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("primaryAzurePort"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            primaryAzurePort = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("secondaryAzurePort"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            secondaryAzurePort = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("sharedKey"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            sharedKey = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("vlanId"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            vlanId = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("microsoftPeeringConfig"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            microsoftPeeringConfig = ExpressRouteCircuitPeeringConfig.DeserializeExpressRouteCircuitPeeringConfig(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            provisioningState = new ProvisioningState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("gatewayManagerEtag"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            gatewayManagerEtag = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("lastModifiedBy"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            lastModifiedBy = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("ipv6PeeringConfig"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            ipv6PeeringConfig = Ipv6ExpressRouteCircuitPeeringConfig.DeserializeIpv6ExpressRouteCircuitPeeringConfig(property0.Value);
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new ExpressRouteCrossConnectionPeering(id, name, etag, peeringType, state, azureASN, peerASN, primaryPeerAddressPrefix, secondaryPeerAddressPrefix, primaryAzurePort, secondaryAzurePort, sharedKey, vlanId, microsoftPeeringConfig, provisioningState, gatewayManagerEtag, lastModifiedBy, ipv6PeeringConfig);
        }
    }
}
