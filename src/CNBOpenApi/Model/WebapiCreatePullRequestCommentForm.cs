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
    /// WebapiCreatePullRequestCommentForm
    /// </summary>
    public partial class WebapiCreatePullRequestCommentForm : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WebapiCreatePullRequestCommentForm" /> class.
        /// </summary>
        /// <param name="body">body</param>
        [JsonConstructor]
        public WebapiCreatePullRequestCommentForm(Option<string?> body = default)
        {
            BodyOption = body;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Used to track the state of Body
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> BodyOption { get; private set; }

        /// <summary>
        /// Gets or Sets Body
        /// </summary>
        [JsonPropertyName("body")]
        public string? Body { get { return this.BodyOption; } set { this.BodyOption = new(value); } }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class WebapiCreatePullRequestCommentForm {\n");
            sb.Append("  Body: ").Append(Body).Append("\n");
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
    /// A Json converter for type <see cref="WebapiCreatePullRequestCommentForm" />
    /// </summary>
    public class WebapiCreatePullRequestCommentFormJsonConverter : JsonConverter<WebapiCreatePullRequestCommentForm>
    {
        /// <summary>
        /// Deserializes json to <see cref="WebapiCreatePullRequestCommentForm" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override WebapiCreatePullRequestCommentForm Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<string?> body = default;

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
                        case "body":
                            body = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        default:
                            break;
                    }
                }
            }

            if (body.IsSet && body.Value == null)
                throw new ArgumentNullException(nameof(body), "Property is not nullable for class WebapiCreatePullRequestCommentForm.");

            return new WebapiCreatePullRequestCommentForm(body);
        }

        /// <summary>
        /// Serializes a <see cref="WebapiCreatePullRequestCommentForm" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="webapiCreatePullRequestCommentForm"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, WebapiCreatePullRequestCommentForm webapiCreatePullRequestCommentForm, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, webapiCreatePullRequestCommentForm, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="WebapiCreatePullRequestCommentForm" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="webapiCreatePullRequestCommentForm"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, WebapiCreatePullRequestCommentForm webapiCreatePullRequestCommentForm, JsonSerializerOptions jsonSerializerOptions)
        {
            if (webapiCreatePullRequestCommentForm.BodyOption.IsSet && webapiCreatePullRequestCommentForm.Body == null)
                throw new ArgumentNullException(nameof(webapiCreatePullRequestCommentForm.Body), "Property is required for class WebapiCreatePullRequestCommentForm.");

            if (webapiCreatePullRequestCommentForm.BodyOption.IsSet)
                writer.WriteString("body", webapiCreatePullRequestCommentForm.Body);
        }
    }
}
