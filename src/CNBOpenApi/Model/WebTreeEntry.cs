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
    /// WebTreeEntry
    /// </summary>
    public partial class WebTreeEntry : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WebTreeEntry" /> class.
        /// </summary>
        /// <param name="isLfs">isLfs</param>
        /// <param name="name">name</param>
        /// <param name="path">path</param>
        /// <param name="sha">sha</param>
        /// <param name="submodule">submodule</param>
        /// <param name="type">type</param>
        [JsonConstructor]
        public WebTreeEntry(Option<bool?> isLfs = default, Option<string?> name = default, Option<string?> path = default, Option<string?> sha = default, Option<WebSubmodule?> submodule = default, Option<string?> type = default)
        {
            IsLfsOption = isLfs;
            NameOption = name;
            PathOption = path;
            ShaOption = sha;
            SubmoduleOption = submodule;
            TypeOption = type;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Used to track the state of IsLfs
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<bool?> IsLfsOption { get; private set; }

        /// <summary>
        /// Gets or Sets IsLfs
        /// </summary>
        [JsonPropertyName("is_lfs")]
        public bool? IsLfs { get { return this.IsLfsOption; } set { this.IsLfsOption = new(value); } }

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
        /// Used to track the state of Path
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> PathOption { get; private set; }

        /// <summary>
        /// Gets or Sets Path
        /// </summary>
        [JsonPropertyName("path")]
        public string? Path { get { return this.PathOption; } set { this.PathOption = new(value); } }

        /// <summary>
        /// Used to track the state of Sha
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> ShaOption { get; private set; }

        /// <summary>
        /// Gets or Sets Sha
        /// </summary>
        [JsonPropertyName("sha")]
        public string? Sha { get { return this.ShaOption; } set { this.ShaOption = new(value); } }

        /// <summary>
        /// Used to track the state of Submodule
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<WebSubmodule?> SubmoduleOption { get; private set; }

        /// <summary>
        /// Gets or Sets Submodule
        /// </summary>
        [JsonPropertyName("submodule")]
        public WebSubmodule? Submodule { get { return this.SubmoduleOption; } set { this.SubmoduleOption = new(value); } }

        /// <summary>
        /// Used to track the state of Type
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> TypeOption { get; private set; }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [JsonPropertyName("type")]
        public string? Type { get { return this.TypeOption; } set { this.TypeOption = new(value); } }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class WebTreeEntry {\n");
            sb.Append("  IsLfs: ").Append(IsLfs).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Path: ").Append(Path).Append("\n");
            sb.Append("  Sha: ").Append(Sha).Append("\n");
            sb.Append("  Submodule: ").Append(Submodule).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
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
    /// A Json converter for type <see cref="WebTreeEntry" />
    /// </summary>
    public class WebTreeEntryJsonConverter : JsonConverter<WebTreeEntry>
    {
        /// <summary>
        /// Deserializes json to <see cref="WebTreeEntry" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override WebTreeEntry Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<bool?> isLfs = default;
            Option<string?> name = default;
            Option<string?> path = default;
            Option<string?> sha = default;
            Option<WebSubmodule?> submodule = default;
            Option<string?> type = default;

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
                        case "is_lfs":
                            isLfs = new Option<bool?>(utf8JsonReader.TokenType == JsonTokenType.Null ? (bool?)null : utf8JsonReader.GetBoolean());
                            break;
                        case "name":
                            name = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "path":
                            path = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "sha":
                            sha = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "submodule":
                            submodule = new Option<WebSubmodule?>(JsonSerializer.Deserialize<WebSubmodule>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        case "type":
                            type = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        default:
                            break;
                    }
                }
            }

            if (isLfs.IsSet && isLfs.Value == null)
                throw new ArgumentNullException(nameof(isLfs), "Property is not nullable for class WebTreeEntry.");

            if (name.IsSet && name.Value == null)
                throw new ArgumentNullException(nameof(name), "Property is not nullable for class WebTreeEntry.");

            if (path.IsSet && path.Value == null)
                throw new ArgumentNullException(nameof(path), "Property is not nullable for class WebTreeEntry.");

            if (sha.IsSet && sha.Value == null)
                throw new ArgumentNullException(nameof(sha), "Property is not nullable for class WebTreeEntry.");

            if (submodule.IsSet && submodule.Value == null)
                throw new ArgumentNullException(nameof(submodule), "Property is not nullable for class WebTreeEntry.");

            if (type.IsSet && type.Value == null)
                throw new ArgumentNullException(nameof(type), "Property is not nullable for class WebTreeEntry.");

            return new WebTreeEntry(isLfs, name, path, sha, submodule, type);
        }

        /// <summary>
        /// Serializes a <see cref="WebTreeEntry" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="webTreeEntry"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, WebTreeEntry webTreeEntry, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, webTreeEntry, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="WebTreeEntry" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="webTreeEntry"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, WebTreeEntry webTreeEntry, JsonSerializerOptions jsonSerializerOptions)
        {
            if (webTreeEntry.NameOption.IsSet && webTreeEntry.Name == null)
                throw new ArgumentNullException(nameof(webTreeEntry.Name), "Property is required for class WebTreeEntry.");

            if (webTreeEntry.PathOption.IsSet && webTreeEntry.Path == null)
                throw new ArgumentNullException(nameof(webTreeEntry.Path), "Property is required for class WebTreeEntry.");

            if (webTreeEntry.ShaOption.IsSet && webTreeEntry.Sha == null)
                throw new ArgumentNullException(nameof(webTreeEntry.Sha), "Property is required for class WebTreeEntry.");

            if (webTreeEntry.SubmoduleOption.IsSet && webTreeEntry.Submodule == null)
                throw new ArgumentNullException(nameof(webTreeEntry.Submodule), "Property is required for class WebTreeEntry.");

            if (webTreeEntry.TypeOption.IsSet && webTreeEntry.Type == null)
                throw new ArgumentNullException(nameof(webTreeEntry.Type), "Property is required for class WebTreeEntry.");

            if (webTreeEntry.IsLfsOption.IsSet)
                writer.WriteBoolean("is_lfs", webTreeEntry.IsLfsOption.Value!.Value);

            if (webTreeEntry.NameOption.IsSet)
                writer.WriteString("name", webTreeEntry.Name);

            if (webTreeEntry.PathOption.IsSet)
                writer.WriteString("path", webTreeEntry.Path);

            if (webTreeEntry.ShaOption.IsSet)
                writer.WriteString("sha", webTreeEntry.Sha);

            if (webTreeEntry.SubmoduleOption.IsSet)
            {
                writer.WritePropertyName("submodule");
                JsonSerializer.Serialize(writer, webTreeEntry.Submodule, jsonSerializerOptions);
            }
            if (webTreeEntry.TypeOption.IsSet)
                writer.WriteString("type", webTreeEntry.Type);
        }
    }
}
