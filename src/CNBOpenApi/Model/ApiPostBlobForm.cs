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
    /// ApiPostBlobForm
    /// </summary>
    public partial class ApiPostBlobForm : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ApiPostBlobForm" /> class.
        /// </summary>
        /// <param name="content">content</param>
        /// <param name="encoding">当前编码只支持 &#x60;\&quot;utf-8\&quot;&#x60; and &#x60;\&quot;base64\&quot;&#x60; 。默认: &#x60;utf-8&#x60;</param>
        [JsonConstructor]
        public ApiPostBlobForm(Option<string?> content = default, Option<string?> encoding = default)
        {
            ContentOption = content;
            EncodingOption = encoding;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Used to track the state of Content
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> ContentOption { get; private set; }

        /// <summary>
        /// Gets or Sets Content
        /// </summary>
        [JsonPropertyName("content")]
        public string? Content { get { return this.ContentOption; } set { this.ContentOption = new(value); } }

        /// <summary>
        /// Used to track the state of Encoding
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> EncodingOption { get; private set; }

        /// <summary>
        /// 当前编码只支持 &#x60;\&quot;utf-8\&quot;&#x60; and &#x60;\&quot;base64\&quot;&#x60; 。默认: &#x60;utf-8&#x60;
        /// </summary>
        /// <value>当前编码只支持 &#x60;\&quot;utf-8\&quot;&#x60; and &#x60;\&quot;base64\&quot;&#x60; 。默认: &#x60;utf-8&#x60;</value>
        [JsonPropertyName("encoding")]
        public string? Encoding { get { return this.EncodingOption; } set { this.EncodingOption = new(value); } }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ApiPostBlobForm {\n");
            sb.Append("  Content: ").Append(Content).Append("\n");
            sb.Append("  Encoding: ").Append(Encoding).Append("\n");
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
    /// A Json converter for type <see cref="ApiPostBlobForm" />
    /// </summary>
    public class ApiPostBlobFormJsonConverter : JsonConverter<ApiPostBlobForm>
    {
        /// <summary>
        /// Deserializes json to <see cref="ApiPostBlobForm" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override ApiPostBlobForm Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<string?> content = default;
            Option<string?> encoding = default;

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
                        case "content":
                            content = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "encoding":
                            encoding = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        default:
                            break;
                    }
                }
            }

            if (content.IsSet && content.Value == null)
                throw new ArgumentNullException(nameof(content), "Property is not nullable for class ApiPostBlobForm.");

            if (encoding.IsSet && encoding.Value == null)
                throw new ArgumentNullException(nameof(encoding), "Property is not nullable for class ApiPostBlobForm.");

            return new ApiPostBlobForm(content, encoding);
        }

        /// <summary>
        /// Serializes a <see cref="ApiPostBlobForm" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="apiPostBlobForm"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, ApiPostBlobForm apiPostBlobForm, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, apiPostBlobForm, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="ApiPostBlobForm" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="apiPostBlobForm"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, ApiPostBlobForm apiPostBlobForm, JsonSerializerOptions jsonSerializerOptions)
        {
            if (apiPostBlobForm.ContentOption.IsSet && apiPostBlobForm.Content == null)
                throw new ArgumentNullException(nameof(apiPostBlobForm.Content), "Property is required for class ApiPostBlobForm.");

            if (apiPostBlobForm.EncodingOption.IsSet && apiPostBlobForm.Encoding == null)
                throw new ArgumentNullException(nameof(apiPostBlobForm.Encoding), "Property is required for class ApiPostBlobForm.");

            if (apiPostBlobForm.ContentOption.IsSet)
                writer.WriteString("content", apiPostBlobForm.Content);

            if (apiPostBlobForm.EncodingOption.IsSet)
                writer.WriteString("encoding", apiPostBlobForm.Encoding);
        }
    }
}
