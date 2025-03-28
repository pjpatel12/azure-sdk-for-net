// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Azure.Messaging.EventGrid.SystemEvents
{
    [JsonConverter(typeof(AcsEmailEngagementTrackingReportReceivedEventDataConverter))]
    public partial class AcsEmailEngagementTrackingReportReceivedEventData
    {
        internal static AcsEmailEngagementTrackingReportReceivedEventData DeserializeAcsEmailEngagementTrackingReportReceivedEventData(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string sender = default;
            string recipient = default;
            string messageId = default;
            DateTimeOffset? userActionTimestamp = default;
            string engagementContext = default;
            string userAgent = default;
            AcsUserEngagement? engagementType = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("sender"u8))
                {
                    sender = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("recipient"u8))
                {
                    recipient = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("messageId"u8))
                {
                    messageId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("userActionTimestamp"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    userActionTimestamp = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("engagementContext"u8))
                {
                    engagementContext = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("userAgent"u8))
                {
                    userAgent = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("engagementType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    engagementType = new AcsUserEngagement(property.Value.GetString());
                    continue;
                }
            }
            return new AcsEmailEngagementTrackingReportReceivedEventData(
                sender,
                recipient,
                messageId,
                userActionTimestamp,
                engagementContext,
                userAgent,
                engagementType);
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static AcsEmailEngagementTrackingReportReceivedEventData FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content, ModelSerializationExtensions.JsonDocumentOptions);
            return DeserializeAcsEmailEngagementTrackingReportReceivedEventData(document.RootElement);
        }

        internal partial class AcsEmailEngagementTrackingReportReceivedEventDataConverter : JsonConverter<AcsEmailEngagementTrackingReportReceivedEventData>
        {
            public override void Write(Utf8JsonWriter writer, AcsEmailEngagementTrackingReportReceivedEventData model, JsonSerializerOptions options)
            {
                throw new NotImplementedException();
            }

            public override AcsEmailEngagementTrackingReportReceivedEventData Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeAcsEmailEngagementTrackingReportReceivedEventData(document.RootElement);
            }
        }
    }
}
