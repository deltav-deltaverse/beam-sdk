// <auto-generated>
/*
 * Beam game development API
 *
 * The Beam game development API is a service to integrate your game with Beam
 *
 * The version of the OpenAPI document: 1.0.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.ComponentModel.DataAnnotations;
using Beam.Client;

namespace Beam.Model
{
    /// <summary>
    /// TradeTokensRequestInput
    /// </summary>
    public partial class TradeTokensRequestInput : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TradeTokensRequestInput" /> class.
        /// </summary>
        /// <param name="counterparty">counterparty</param>
        /// <param name="initiator">initiator</param>
        /// <param name="chainId">chainId (default to 13337M)</param>
        /// <param name="policyId">policyId</param>
        /// <param name="sponsor">sponsor (default to true)</param>
        [JsonConstructor]
        public TradeTokensRequestInput(TradeTokensRequestInputInitiator counterparty, TradeTokensRequestInputInitiator initiator, Option<decimal?> chainId = default, Option<string> policyId = default, Option<bool?> sponsor = default)
        {
            Counterparty = counterparty;
            Initiator = initiator;
            ChainIdOption = chainId;
            PolicyIdOption = policyId;
            SponsorOption = sponsor;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Gets or Sets Counterparty
        /// </summary>
        [JsonPropertyName("counterparty")]
        public TradeTokensRequestInputInitiator Counterparty { get; set; }

        /// <summary>
        /// Gets or Sets Initiator
        /// </summary>
        [JsonPropertyName("initiator")]
        public TradeTokensRequestInputInitiator Initiator { get; set; }

        /// <summary>
        /// Used to track the state of ChainId
        /// </summary>
        [JsonIgnore]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Option<decimal?> ChainIdOption { get; private set; }

        /// <summary>
        /// Gets or Sets ChainId
        /// </summary>
        [JsonPropertyName("chainId")]
        public decimal? ChainId { get { return this. ChainIdOption; } set { this.ChainIdOption = new(value); } }

        /// <summary>
        /// Used to track the state of PolicyId
        /// </summary>
        [JsonIgnore]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string> PolicyIdOption { get; private set; }

        /// <summary>
        /// Gets or Sets PolicyId
        /// </summary>
        [JsonPropertyName("policyId")]
        public string PolicyId { get { return this. PolicyIdOption; } set { this.PolicyIdOption = new(value); } }

        /// <summary>
        /// Used to track the state of Sponsor
        /// </summary>
        [JsonIgnore]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Option<bool?> SponsorOption { get; private set; }

        /// <summary>
        /// Gets or Sets Sponsor
        /// </summary>
        [JsonPropertyName("sponsor")]
        public bool? Sponsor { get { return this. SponsorOption; } set { this.SponsorOption = new(value); } }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TradeTokensRequestInput {\n");
            sb.Append("  Counterparty: ").Append(Counterparty).Append("\n");
            sb.Append("  Initiator: ").Append(Initiator).Append("\n");
            sb.Append("  ChainId: ").Append(ChainId).Append("\n");
            sb.Append("  PolicyId: ").Append(PolicyId).Append("\n");
            sb.Append("  Sponsor: ").Append(Sponsor).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

    /// <summary>
    /// A Json converter for type <see cref="TradeTokensRequestInput" />
    /// </summary>
    public class TradeTokensRequestInputJsonConverter : JsonConverter<TradeTokensRequestInput>
    {
        /// <summary>
        /// Deserializes json to <see cref="TradeTokensRequestInput" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override TradeTokensRequestInput Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<TradeTokensRequestInputInitiator> counterparty = default;
            Option<TradeTokensRequestInputInitiator> initiator = default;
            Option<decimal?> chainId = default;
            Option<string> policyId = default;
            Option<bool?> sponsor = default;

            while (utf8JsonReader.Read())
            {
                if (startingTokenType == JsonTokenType.StartObject && utf8JsonReader.TokenType == JsonTokenType.EndObject && currentDepth == utf8JsonReader.CurrentDepth)
                    break;

                if (startingTokenType == JsonTokenType.StartArray && utf8JsonReader.TokenType == JsonTokenType.EndArray && currentDepth == utf8JsonReader.CurrentDepth)
                    break;

                if (utf8JsonReader.TokenType == JsonTokenType.PropertyName && currentDepth == utf8JsonReader.CurrentDepth - 1)
                {
                    string localVarJsonPropertyName = utf8JsonReader.GetString();
                    utf8JsonReader.Read();

                    switch (localVarJsonPropertyName)
                    {
                        case "counterparty":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                counterparty = new Option<TradeTokensRequestInputInitiator>(JsonSerializer.Deserialize<TradeTokensRequestInputInitiator>(ref utf8JsonReader, jsonSerializerOptions));
                            break;
                        case "initiator":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                initiator = new Option<TradeTokensRequestInputInitiator>(JsonSerializer.Deserialize<TradeTokensRequestInputInitiator>(ref utf8JsonReader, jsonSerializerOptions));
                            break;
                        case "chainId":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                chainId = new Option<decimal?>(utf8JsonReader.GetDecimal());
                            break;
                        case "policyId":
                            policyId = new Option<string>(utf8JsonReader.GetString());
                            break;
                        case "sponsor":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                sponsor = new Option<bool?>(utf8JsonReader.GetBoolean());
                            break;
                        default:
                            break;
                    }
                }
            }

            if (!counterparty.IsSet)
                throw new ArgumentException("Property is required for class TradeTokensRequestInput.", nameof(counterparty));

            if (!initiator.IsSet)
                throw new ArgumentException("Property is required for class TradeTokensRequestInput.", nameof(initiator));

            if (counterparty.IsSet && counterparty.Value == null)
                throw new ArgumentNullException(nameof(counterparty), "Property is not nullable for class TradeTokensRequestInput.");

            if (initiator.IsSet && initiator.Value == null)
                throw new ArgumentNullException(nameof(initiator), "Property is not nullable for class TradeTokensRequestInput.");

            if (chainId.IsSet && chainId.Value == null)
                throw new ArgumentNullException(nameof(chainId), "Property is not nullable for class TradeTokensRequestInput.");

            if (policyId.IsSet && policyId.Value == null)
                throw new ArgumentNullException(nameof(policyId), "Property is not nullable for class TradeTokensRequestInput.");

            if (sponsor.IsSet && sponsor.Value == null)
                throw new ArgumentNullException(nameof(sponsor), "Property is not nullable for class TradeTokensRequestInput.");

            return new TradeTokensRequestInput(counterparty.Value, initiator.Value, chainId, policyId, sponsor);
        }

        /// <summary>
        /// Serializes a <see cref="TradeTokensRequestInput" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="tradeTokensRequestInput"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, TradeTokensRequestInput tradeTokensRequestInput, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(ref writer, tradeTokensRequestInput, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="TradeTokensRequestInput" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="tradeTokensRequestInput"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(ref Utf8JsonWriter writer, TradeTokensRequestInput tradeTokensRequestInput, JsonSerializerOptions jsonSerializerOptions)
        {
            if (tradeTokensRequestInput.Counterparty == null)
                throw new ArgumentNullException(nameof(tradeTokensRequestInput.Counterparty), "Property is required for class TradeTokensRequestInput.");

            if (tradeTokensRequestInput.Initiator == null)
                throw new ArgumentNullException(nameof(tradeTokensRequestInput.Initiator), "Property is required for class TradeTokensRequestInput.");

            if (tradeTokensRequestInput.PolicyIdOption.IsSet && tradeTokensRequestInput.PolicyId == null)
                throw new ArgumentNullException(nameof(tradeTokensRequestInput.PolicyId), "Property is required for class TradeTokensRequestInput.");

            writer.WritePropertyName("counterparty");
            JsonSerializer.Serialize(writer, tradeTokensRequestInput.Counterparty, jsonSerializerOptions);
            writer.WritePropertyName("initiator");
            JsonSerializer.Serialize(writer, tradeTokensRequestInput.Initiator, jsonSerializerOptions);
            if (tradeTokensRequestInput.ChainIdOption.IsSet)
                writer.WriteNumber("chainId", tradeTokensRequestInput.ChainIdOption.Value.Value);

            if (tradeTokensRequestInput.PolicyIdOption.IsSet)
                writer.WriteString("policyId", tradeTokensRequestInput.PolicyId);

            if (tradeTokensRequestInput.SponsorOption.IsSet)
                writer.WriteBoolean("sponsor", tradeTokensRequestInput.SponsorOption.Value.Value);
        }
    }
}