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
    /// ApiTag
    /// </summary>
    public partial class ApiTag : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ApiTag" /> class.
        /// </summary>
        /// <param name="commit">commit</param>
        /// <param name="name">name</param>
        /// <param name="target">target</param>
        /// <param name="targetType">targetType</param>
        [JsonConstructor]
        public ApiTag(Option<ApiCommit?> commit = default, Option<string?> name = default, Option<string?> target = default, Option<string?> targetType = default)
        {
            CommitOption = commit;
            NameOption = name;
            TargetOption = target;
            TargetTypeOption = targetType;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Used to track the state of Commit
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<ApiCommit?> CommitOption { get; private set; }

        /// <summary>
        /// Gets or Sets Commit
        /// </summary>
        [JsonPropertyName("commit")]
        public ApiCommit? Commit { get { return this.CommitOption; } set { this.CommitOption = new(value); } }

        /// <summary>
        /// Used to track the state of Name
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> NameOption { get; private set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [JsonPropertyName("name")]
        public string? Name { get { return this.NameOption; } set { this.NameOption = new(value); } }

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
            sb.Append("class ApiTag {\n");
            sb.Append("  Commit: ").Append(Commit).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Target: ").Append(Target).Append("\n");
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
    /// A Json converter for type <see cref="ApiTag" />
    /// </summary>
    public class ApiTagJsonConverter : JsonConverter<ApiTag>
    {
        /// <summary>
        /// Deserializes json to <see cref="ApiTag" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override ApiTag Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<ApiCommit?> commit = default;
            Option<string?> name = default;
            Option<string?> target = default;
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
                        case "commit":
                            commit = new Option<ApiCommit?>(JsonSerializer.Deserialize<ApiCommit>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        case "name":
                            name = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "target":
                            target = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "target_type":
                            targetType = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        default:
                            break;
                    }
                }
            }

            if (commit.IsSet && commit.Value == null)
                throw new ArgumentNullException(nameof(commit), "Property is not nullable for class ApiTag.");

            if (name.IsSet && name.Value == null)
                throw new ArgumentNullException(nameof(name), "Property is not nullable for class ApiTag.");

            if (target.IsSet && target.Value == null)
                throw new ArgumentNullException(nameof(target), "Property is not nullable for class ApiTag.");

            if (targetType.IsSet && targetType.Value == null)
                throw new ArgumentNullException(nameof(targetType), "Property is not nullable for class ApiTag.");

            return new ApiTag(commit, name, target, targetType);
        }

        /// <summary>
        /// Serializes a <see cref="ApiTag" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="apiTag"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, ApiTag apiTag, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, apiTag, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="ApiTag" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="apiTag"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, ApiTag apiTag, JsonSerializerOptions jsonSerializerOptions)
        {
            if (apiTag.CommitOption.IsSet && apiTag.Commit == null)
                throw new ArgumentNullException(nameof(apiTag.Commit), "Property is required for class ApiTag.");

            if (apiTag.NameOption.IsSet && apiTag.Name == null)
                throw new ArgumentNullException(nameof(apiTag.Name), "Property is required for class ApiTag.");

            if (apiTag.TargetOption.IsSet && apiTag.Target == null)
                throw new ArgumentNullException(nameof(apiTag.Target), "Property is required for class ApiTag.");

            if (apiTag.TargetTypeOption.IsSet && apiTag.TargetType == null)
                throw new ArgumentNullException(nameof(apiTag.TargetType), "Property is required for class ApiTag.");

            if (apiTag.CommitOption.IsSet)
            {
                writer.WritePropertyName("commit");
                JsonSerializer.Serialize(writer, apiTag.Commit, jsonSerializerOptions);
            }
            if (apiTag.NameOption.IsSet)
                writer.WriteString("name", apiTag.Name);

            if (apiTag.TargetOption.IsSet)
                writer.WriteString("target", apiTag.Target);

            if (apiTag.TargetTypeOption.IsSet)
                writer.WriteString("target_type", apiTag.TargetType);
        }
    }
}
