// <auto-generated>
/*
 * CNB OPENAPI
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 1.0
 * Contact: cnb@tencent.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

#nullable enable

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
using CNBOpenApi.Client;

namespace CNBOpenApi.Model
{
    /// <summary>
    /// DtoBoolResponse
    /// </summary>
    public partial class DtoBoolResponse : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DtoBoolResponse" /> class.
        /// </summary>
        /// <param name="message">message</param>
        /// <param name="result">result</param>
        [JsonConstructor]
        public DtoBoolResponse(Option<string?> message = default, Option<bool?> result = default)
        {
            MessageOption = message;
            ResultOption = result;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Used to track the state of Message
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> MessageOption { get; private set; }

        /// <summary>
        /// Gets or Sets Message
        /// </summary>
        [JsonPropertyName("message")]
        public string? Message { get { return this.MessageOption; } set { this.MessageOption = new(value); } }

        /// <summary>
        /// Used to track the state of Result
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<bool?> ResultOption { get; private set; }

        /// <summary>
        /// Gets or Sets Result
        /// </summary>
        [JsonPropertyName("result")]
        public bool? Result { get { return this.ResultOption; } set { this.ResultOption = new(value); } }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DtoBoolResponse {\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
            sb.Append("  Result: ").Append(Result).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

    /// <summary>
    /// A Json converter for type <see cref="DtoBoolResponse" />
    /// </summary>
    public class DtoBoolResponseJsonConverter : JsonConverter<DtoBoolResponse>
    {
        /// <summary>
        /// Deserializes json to <see cref="DtoBoolResponse" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override DtoBoolResponse Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<string?> message = default;
            Option<bool?> result = default;

            while (utf8JsonReader.Read())
            {
                if (startingTokenType == JsonTokenType.StartObject && utf8JsonReader.TokenType == JsonTokenType.EndObject && currentDepth == utf8JsonReader.CurrentDepth)
                    break;

                if (startingTokenType == JsonTokenType.StartArray && utf8JsonReader.TokenType == JsonTokenType.EndArray && currentDepth == utf8JsonReader.CurrentDepth)
                    break;

                if (utf8JsonReader.TokenType == JsonTokenType.PropertyName && currentDepth == utf8JsonReader.CurrentDepth - 1)
                {
                    string? localVarJsonPropertyName = utf8JsonReader.GetString();
                    utf8JsonReader.Read();

                    switch (localVarJsonPropertyName)
                    {
                        case "message":
                            message = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "result":
                            result = new Option<bool?>(utf8JsonReader.TokenType == JsonTokenType.Null ? (bool?)null : utf8JsonReader.GetBoolean());
                            break;
                        default:
                            break;
                    }
                }
            }

            if (message.IsSet && message.Value == null)
                throw new ArgumentNullException(nameof(message), "Property is not nullable for class DtoBoolResponse.");

            if (result.IsSet && result.Value == null)
                throw new ArgumentNullException(nameof(result), "Property is not nullable for class DtoBoolResponse.");

            return new DtoBoolResponse(message, result);
        }

        /// <summary>
        /// Serializes a <see cref="DtoBoolResponse" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="dtoBoolResponse"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, DtoBoolResponse dtoBoolResponse, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, dtoBoolResponse, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="DtoBoolResponse" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="dtoBoolResponse"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, DtoBoolResponse dtoBoolResponse, JsonSerializerOptions jsonSerializerOptions)
        {
            if (dtoBoolResponse.MessageOption.IsSet && dtoBoolResponse.Message == null)
                throw new ArgumentNullException(nameof(dtoBoolResponse.Message), "Property is required for class DtoBoolResponse.");

            if (dtoBoolResponse.MessageOption.IsSet)
                writer.WriteString("message", dtoBoolResponse.Message);

            if (dtoBoolResponse.ResultOption.IsSet)
                writer.WriteBoolean("result", dtoBoolResponse.ResultOption.Value!.Value);
        }
    }
}
