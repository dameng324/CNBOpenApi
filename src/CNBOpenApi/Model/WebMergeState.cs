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
    /// WebMergeState
    /// </summary>
    public partial class WebMergeState : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WebMergeState" /> class.
        /// </summary>
        /// <param name="conflicts">conflicts</param>
        /// <param name="state">state</param>
        [JsonConstructor]
        public WebMergeState(Option<List<string>?> conflicts = default, Option<string?> state = default)
        {
            ConflictsOption = conflicts;
            StateOption = state;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Used to track the state of Conflicts
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<List<string>?> ConflictsOption { get; private set; }

        /// <summary>
        /// Gets or Sets Conflicts
        /// </summary>
        [JsonPropertyName("conflicts")]
        public List<string>? Conflicts { get { return this.ConflictsOption; } set { this.ConflictsOption = new(value); } }

        /// <summary>
        /// Used to track the state of State
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> StateOption { get; private set; }

        /// <summary>
        /// Gets or Sets State
        /// </summary>
        [JsonPropertyName("state")]
        public string? State { get { return this.StateOption; } set { this.StateOption = new(value); } }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class WebMergeState {\n");
            sb.Append("  Conflicts: ").Append(Conflicts).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
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
    /// A Json converter for type <see cref="WebMergeState" />
    /// </summary>
    public class WebMergeStateJsonConverter : JsonConverter<WebMergeState>
    {
        /// <summary>
        /// Deserializes json to <see cref="WebMergeState" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override WebMergeState Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<List<string>?> conflicts = default;
            Option<string?> state = default;

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
                        case "conflicts":
                            conflicts = new Option<List<string>?>(JsonSerializer.Deserialize<List<string>>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        case "state":
                            state = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        default:
                            break;
                    }
                }
            }

            if (conflicts.IsSet && conflicts.Value == null)
                throw new ArgumentNullException(nameof(conflicts), "Property is not nullable for class WebMergeState.");

            if (state.IsSet && state.Value == null)
                throw new ArgumentNullException(nameof(state), "Property is not nullable for class WebMergeState.");

            return new WebMergeState(conflicts, state);
        }

        /// <summary>
        /// Serializes a <see cref="WebMergeState" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="webMergeState"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, WebMergeState webMergeState, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, webMergeState, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="WebMergeState" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="webMergeState"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, WebMergeState webMergeState, JsonSerializerOptions jsonSerializerOptions)
        {
            if (webMergeState.ConflictsOption.IsSet && webMergeState.Conflicts == null)
                throw new ArgumentNullException(nameof(webMergeState.Conflicts), "Property is required for class WebMergeState.");

            if (webMergeState.StateOption.IsSet && webMergeState.State == null)
                throw new ArgumentNullException(nameof(webMergeState.State), "Property is required for class WebMergeState.");

            if (webMergeState.ConflictsOption.IsSet)
            {
                writer.WritePropertyName("conflicts");
                JsonSerializer.Serialize(writer, webMergeState.Conflicts, jsonSerializerOptions);
            }
            if (webMergeState.StateOption.IsSet)
                writer.WriteString("state", webMergeState.State);
        }
    }
}
