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
    /// DtoTransferSlugReq
    /// </summary>
    public partial class DtoTransferSlugReq : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DtoTransferSlugReq" /> class.
        /// </summary>
        /// <param name="source">source</param>
        /// <param name="target">target</param>
        [JsonConstructor]
        public DtoTransferSlugReq(Option<string?> source = default, Option<string?> target = default)
        {
            SourceOption = source;
            TargetOption = target;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Used to track the state of Source
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> SourceOption { get; private set; }

        /// <summary>
        /// Gets or Sets Source
        /// </summary>
        [JsonPropertyName("source")]
        public string? Source { get { return this.SourceOption; } set { this.SourceOption = new(value); } }

        /// <summary>
        /// Used to track the state of Target
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> TargetOption { get; private set; }

        /// <summary>
        /// Gets or Sets Target
        /// </summary>
        [JsonPropertyName("target")]
        public string? Target { get { return this.TargetOption; } set { this.TargetOption = new(value); } }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DtoTransferSlugReq {\n");
            sb.Append("  Source: ").Append(Source).Append("\n");
            sb.Append("  Target: ").Append(Target).Append("\n");
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
    /// A Json converter for type <see cref="DtoTransferSlugReq" />
    /// </summary>
    public class DtoTransferSlugReqJsonConverter : JsonConverter<DtoTransferSlugReq>
    {
        /// <summary>
        /// Deserializes json to <see cref="DtoTransferSlugReq" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override DtoTransferSlugReq Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<string?> source = default;
            Option<string?> target = default;

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
                        case "source":
                            source = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "target":
                            target = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        default:
                            break;
                    }
                }
            }

            if (source.IsSet && source.Value == null)
                throw new ArgumentNullException(nameof(source), "Property is not nullable for class DtoTransferSlugReq.");

            if (target.IsSet && target.Value == null)
                throw new ArgumentNullException(nameof(target), "Property is not nullable for class DtoTransferSlugReq.");

            return new DtoTransferSlugReq(source, target);
        }

        /// <summary>
        /// Serializes a <see cref="DtoTransferSlugReq" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="dtoTransferSlugReq"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, DtoTransferSlugReq dtoTransferSlugReq, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, dtoTransferSlugReq, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="DtoTransferSlugReq" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="dtoTransferSlugReq"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, DtoTransferSlugReq dtoTransferSlugReq, JsonSerializerOptions jsonSerializerOptions)
        {
            if (dtoTransferSlugReq.SourceOption.IsSet && dtoTransferSlugReq.Source == null)
                throw new ArgumentNullException(nameof(dtoTransferSlugReq.Source), "Property is required for class DtoTransferSlugReq.");

            if (dtoTransferSlugReq.TargetOption.IsSet && dtoTransferSlugReq.Target == null)
                throw new ArgumentNullException(nameof(dtoTransferSlugReq.Target), "Property is required for class DtoTransferSlugReq.");

            if (dtoTransferSlugReq.SourceOption.IsSet)
                writer.WriteString("source", dtoTransferSlugReq.Source);

            if (dtoTransferSlugReq.TargetOption.IsSet)
                writer.WriteString("target", dtoTransferSlugReq.Target);
        }
    }
}
