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
    /// WebTreeInfoEntry
    /// </summary>
    public partial class WebTreeInfoEntry : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WebTreeInfoEntry" /> class.
        /// </summary>
        /// <param name="lastCommit">lastCommit</param>
        /// <param name="name">name</param>
        /// <param name="path">path</param>
        [JsonConstructor]
        public WebTreeInfoEntry(Option<WebCommit?> lastCommit = default, Option<string?> name = default, Option<string?> path = default)
        {
            LastCommitOption = lastCommit;
            NameOption = name;
            PathOption = path;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Used to track the state of LastCommit
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<WebCommit?> LastCommitOption { get; private set; }

        /// <summary>
        /// Gets or Sets LastCommit
        /// </summary>
        [JsonPropertyName("last_commit")]
        public WebCommit? LastCommit { get { return this.LastCommitOption; } set { this.LastCommitOption = new(value); } }

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
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class WebTreeInfoEntry {\n");
            sb.Append("  LastCommit: ").Append(LastCommit).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Path: ").Append(Path).Append("\n");
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
    /// A Json converter for type <see cref="WebTreeInfoEntry" />
    /// </summary>
    public class WebTreeInfoEntryJsonConverter : JsonConverter<WebTreeInfoEntry>
    {
        /// <summary>
        /// Deserializes json to <see cref="WebTreeInfoEntry" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override WebTreeInfoEntry Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<WebCommit?> lastCommit = default;
            Option<string?> name = default;
            Option<string?> path = default;

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
                        case "last_commit":
                            lastCommit = new Option<WebCommit?>(JsonSerializer.Deserialize<WebCommit>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        case "name":
                            name = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "path":
                            path = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        default:
                            break;
                    }
                }
            }

            if (lastCommit.IsSet && lastCommit.Value == null)
                throw new ArgumentNullException(nameof(lastCommit), "Property is not nullable for class WebTreeInfoEntry.");

            if (name.IsSet && name.Value == null)
                throw new ArgumentNullException(nameof(name), "Property is not nullable for class WebTreeInfoEntry.");

            if (path.IsSet && path.Value == null)
                throw new ArgumentNullException(nameof(path), "Property is not nullable for class WebTreeInfoEntry.");

            return new WebTreeInfoEntry(lastCommit, name, path);
        }

        /// <summary>
        /// Serializes a <see cref="WebTreeInfoEntry" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="webTreeInfoEntry"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, WebTreeInfoEntry webTreeInfoEntry, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, webTreeInfoEntry, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="WebTreeInfoEntry" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="webTreeInfoEntry"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, WebTreeInfoEntry webTreeInfoEntry, JsonSerializerOptions jsonSerializerOptions)
        {
            if (webTreeInfoEntry.LastCommitOption.IsSet && webTreeInfoEntry.LastCommit == null)
                throw new ArgumentNullException(nameof(webTreeInfoEntry.LastCommit), "Property is required for class WebTreeInfoEntry.");

            if (webTreeInfoEntry.NameOption.IsSet && webTreeInfoEntry.Name == null)
                throw new ArgumentNullException(nameof(webTreeInfoEntry.Name), "Property is required for class WebTreeInfoEntry.");

            if (webTreeInfoEntry.PathOption.IsSet && webTreeInfoEntry.Path == null)
                throw new ArgumentNullException(nameof(webTreeInfoEntry.Path), "Property is required for class WebTreeInfoEntry.");

            if (webTreeInfoEntry.LastCommitOption.IsSet)
            {
                writer.WritePropertyName("last_commit");
                JsonSerializer.Serialize(writer, webTreeInfoEntry.LastCommit, jsonSerializerOptions);
            }
            if (webTreeInfoEntry.NameOption.IsSet)
                writer.WriteString("name", webTreeInfoEntry.Name);

            if (webTreeInfoEntry.PathOption.IsSet)
                writer.WriteString("path", webTreeInfoEntry.Path);
        }
    }
}
