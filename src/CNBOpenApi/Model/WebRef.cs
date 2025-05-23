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
    /// WebRef
    /// </summary>
    public partial class WebRef : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WebRef" /> class.
        /// </summary>
        /// <param name="isHead">isHead</param>
        /// <param name="isProtected">isProtected</param>
        /// <param name="ref">ref</param>
        /// <param name="targetDate">targetDate</param>
        /// <param name="targetHash">targetHash</param>
        /// <param name="targetType">targetType</param>
        [JsonConstructor]
        public WebRef(Option<bool?> isHead = default, Option<bool?> isProtected = default, Option<string?> @ref = default, Option<string?> targetDate = default, Option<string?> targetHash = default, Option<string?> targetType = default)
        {
            IsHeadOption = isHead;
            IsProtectedOption = isProtected;
            RefOption = @ref;
            TargetDateOption = targetDate;
            TargetHashOption = targetHash;
            TargetTypeOption = targetType;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Used to track the state of IsHead
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<bool?> IsHeadOption { get; private set; }

        /// <summary>
        /// Gets or Sets IsHead
        /// </summary>
        [JsonPropertyName("is_head")]
        public bool? IsHead { get { return this.IsHeadOption; } set { this.IsHeadOption = new(value); } }

        /// <summary>
        /// Used to track the state of IsProtected
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<bool?> IsProtectedOption { get; private set; }

        /// <summary>
        /// Gets or Sets IsProtected
        /// </summary>
        [JsonPropertyName("is_protected")]
        public bool? IsProtected { get { return this.IsProtectedOption; } set { this.IsProtectedOption = new(value); } }

        /// <summary>
        /// Used to track the state of Ref
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> RefOption { get; private set; }

        /// <summary>
        /// Gets or Sets Ref
        /// </summary>
        [JsonPropertyName("ref")]
        public string? Ref { get { return this.RefOption; } set { this.RefOption = new(value); } }

        /// <summary>
        /// Used to track the state of TargetDate
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> TargetDateOption { get; private set; }

        /// <summary>
        /// Gets or Sets TargetDate
        /// </summary>
        [JsonPropertyName("target_date")]
        public string? TargetDate { get { return this.TargetDateOption; } set { this.TargetDateOption = new(value); } }

        /// <summary>
        /// Used to track the state of TargetHash
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> TargetHashOption { get; private set; }

        /// <summary>
        /// Gets or Sets TargetHash
        /// </summary>
        [JsonPropertyName("target_hash")]
        public string? TargetHash { get { return this.TargetHashOption; } set { this.TargetHashOption = new(value); } }

        /// <summary>
        /// Used to track the state of TargetType
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> TargetTypeOption { get; private set; }

        /// <summary>
        /// Gets or Sets TargetType
        /// </summary>
        [JsonPropertyName("target_type")]
        public string? TargetType { get { return this.TargetTypeOption; } set { this.TargetTypeOption = new(value); } }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class WebRef {\n");
            sb.Append("  IsHead: ").Append(IsHead).Append("\n");
            sb.Append("  IsProtected: ").Append(IsProtected).Append("\n");
            sb.Append("  Ref: ").Append(Ref).Append("\n");
            sb.Append("  TargetDate: ").Append(TargetDate).Append("\n");
            sb.Append("  TargetHash: ").Append(TargetHash).Append("\n");
            sb.Append("  TargetType: ").Append(TargetType).Append("\n");
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
    /// A Json converter for type <see cref="WebRef" />
    /// </summary>
    public class WebRefJsonConverter : JsonConverter<WebRef>
    {
        /// <summary>
        /// Deserializes json to <see cref="WebRef" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override WebRef Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<bool?> isHead = default;
            Option<bool?> isProtected = default;
            Option<string?> varRef = default;
            Option<string?> targetDate = default;
            Option<string?> targetHash = default;
            Option<string?> targetType = default;

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
                        case "is_head":
                            isHead = new Option<bool?>(utf8JsonReader.TokenType == JsonTokenType.Null ? (bool?)null : utf8JsonReader.GetBoolean());
                            break;
                        case "is_protected":
                            isProtected = new Option<bool?>(utf8JsonReader.TokenType == JsonTokenType.Null ? (bool?)null : utf8JsonReader.GetBoolean());
                            break;
                        case "ref":
                            varRef = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "target_date":
                            targetDate = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "target_hash":
                            targetHash = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "target_type":
                            targetType = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        default:
                            break;
                    }
                }
            }

            if (isHead.IsSet && isHead.Value == null)
                throw new ArgumentNullException(nameof(isHead), "Property is not nullable for class WebRef.");

            if (isProtected.IsSet && isProtected.Value == null)
                throw new ArgumentNullException(nameof(isProtected), "Property is not nullable for class WebRef.");

            if (varRef.IsSet && varRef.Value == null)
                throw new ArgumentNullException(nameof(varRef), "Property is not nullable for class WebRef.");

            if (targetDate.IsSet && targetDate.Value == null)
                throw new ArgumentNullException(nameof(targetDate), "Property is not nullable for class WebRef.");

            if (targetHash.IsSet && targetHash.Value == null)
                throw new ArgumentNullException(nameof(targetHash), "Property is not nullable for class WebRef.");

            if (targetType.IsSet && targetType.Value == null)
                throw new ArgumentNullException(nameof(targetType), "Property is not nullable for class WebRef.");

            return new WebRef(isHead, isProtected, varRef, targetDate, targetHash, targetType);
        }

        /// <summary>
        /// Serializes a <see cref="WebRef" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="webRef"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, WebRef webRef, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, webRef, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="WebRef" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="webRef"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, WebRef webRef, JsonSerializerOptions jsonSerializerOptions)
        {
            if (webRef.RefOption.IsSet && webRef.Ref == null)
                throw new ArgumentNullException(nameof(webRef.Ref), "Property is required for class WebRef.");

            if (webRef.TargetDateOption.IsSet && webRef.TargetDate == null)
                throw new ArgumentNullException(nameof(webRef.TargetDate), "Property is required for class WebRef.");

            if (webRef.TargetHashOption.IsSet && webRef.TargetHash == null)
                throw new ArgumentNullException(nameof(webRef.TargetHash), "Property is required for class WebRef.");

            if (webRef.TargetTypeOption.IsSet && webRef.TargetType == null)
                throw new ArgumentNullException(nameof(webRef.TargetType), "Property is required for class WebRef.");

            if (webRef.IsHeadOption.IsSet)
                writer.WriteBoolean("is_head", webRef.IsHeadOption.Value!.Value);

            if (webRef.IsProtectedOption.IsSet)
                writer.WriteBoolean("is_protected", webRef.IsProtectedOption.Value!.Value);

            if (webRef.RefOption.IsSet)
                writer.WriteString("ref", webRef.Ref);

            if (webRef.TargetDateOption.IsSet)
                writer.WriteString("target_date", webRef.TargetDate);

            if (webRef.TargetHashOption.IsSet)
                writer.WriteString("target_hash", webRef.TargetHash);

            if (webRef.TargetTypeOption.IsSet)
                writer.WriteString("target_type", webRef.TargetType);
        }
    }
}
