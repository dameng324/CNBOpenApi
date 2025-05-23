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
    /// WebIssueTemplates
    /// </summary>
    public partial class WebIssueTemplates : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WebIssueTemplates" /> class.
        /// </summary>
        /// <param name="templates">templates</param>
        [JsonConstructor]
        public WebIssueTemplates(Option<List<WebIssueTemplate>?> templates = default)
        {
            TemplatesOption = templates;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Used to track the state of Templates
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<List<WebIssueTemplate>?> TemplatesOption { get; private set; }

        /// <summary>
        /// Gets or Sets Templates
        /// </summary>
        [JsonPropertyName("templates")]
        public List<WebIssueTemplate>? Templates { get { return this.TemplatesOption; } set { this.TemplatesOption = new(value); } }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class WebIssueTemplates {\n");
            sb.Append("  Templates: ").Append(Templates).Append("\n");
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
    /// A Json converter for type <see cref="WebIssueTemplates" />
    /// </summary>
    public class WebIssueTemplatesJsonConverter : JsonConverter<WebIssueTemplates>
    {
        /// <summary>
        /// Deserializes json to <see cref="WebIssueTemplates" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override WebIssueTemplates Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<List<WebIssueTemplate>?> templates = default;

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
                        case "templates":
                            templates = new Option<List<WebIssueTemplate>?>(JsonSerializer.Deserialize<List<WebIssueTemplate>>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        default:
                            break;
                    }
                }
            }

            if (templates.IsSet && templates.Value == null)
                throw new ArgumentNullException(nameof(templates), "Property is not nullable for class WebIssueTemplates.");

            return new WebIssueTemplates(templates);
        }

        /// <summary>
        /// Serializes a <see cref="WebIssueTemplates" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="webIssueTemplates"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, WebIssueTemplates webIssueTemplates, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, webIssueTemplates, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="WebIssueTemplates" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="webIssueTemplates"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, WebIssueTemplates webIssueTemplates, JsonSerializerOptions jsonSerializerOptions)
        {
            if (webIssueTemplates.TemplatesOption.IsSet && webIssueTemplates.Templates == null)
                throw new ArgumentNullException(nameof(webIssueTemplates.Templates), "Property is required for class WebIssueTemplates.");

            if (webIssueTemplates.TemplatesOption.IsSet)
            {
                writer.WritePropertyName("templates");
                JsonSerializer.Serialize(writer, webIssueTemplates.Templates, jsonSerializerOptions);
            }
        }
    }
}
