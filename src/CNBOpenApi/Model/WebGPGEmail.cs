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
    /// WebGPGEmail
    /// </summary>
    public partial class WebGPGEmail : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WebGPGEmail" /> class.
        /// </summary>
        /// <param name="email">邮箱</param>
        /// <param name="verified">是否已验证</param>
        [JsonConstructor]
        public WebGPGEmail(Option<string?> email = default, Option<bool?> verified = default)
        {
            EmailOption = email;
            VerifiedOption = verified;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Used to track the state of Email
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> EmailOption { get; private set; }

        /// <summary>
        /// 邮箱
        /// </summary>
        /// <value>邮箱</value>
        [JsonPropertyName("email")]
        public string? Email { get { return this.EmailOption; } set { this.EmailOption = new(value); } }

        /// <summary>
        /// Used to track the state of Verified
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<bool?> VerifiedOption { get; private set; }

        /// <summary>
        /// 是否已验证
        /// </summary>
        /// <value>是否已验证</value>
        [JsonPropertyName("verified")]
        public bool? Verified { get { return this.VerifiedOption; } set { this.VerifiedOption = new(value); } }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class WebGPGEmail {\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  Verified: ").Append(Verified).Append("\n");
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
    /// A Json converter for type <see cref="WebGPGEmail" />
    /// </summary>
    public class WebGPGEmailJsonConverter : JsonConverter<WebGPGEmail>
    {
        /// <summary>
        /// Deserializes json to <see cref="WebGPGEmail" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override WebGPGEmail Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<string?> email = default;
            Option<bool?> verified = default;

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
                        case "email":
                            email = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "verified":
                            verified = new Option<bool?>(utf8JsonReader.TokenType == JsonTokenType.Null ? (bool?)null : utf8JsonReader.GetBoolean());
                            break;
                        default:
                            break;
                    }
                }
            }

            if (email.IsSet && email.Value == null)
                throw new ArgumentNullException(nameof(email), "Property is not nullable for class WebGPGEmail.");

            if (verified.IsSet && verified.Value == null)
                throw new ArgumentNullException(nameof(verified), "Property is not nullable for class WebGPGEmail.");

            return new WebGPGEmail(email, verified);
        }

        /// <summary>
        /// Serializes a <see cref="WebGPGEmail" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="webGPGEmail"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, WebGPGEmail webGPGEmail, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, webGPGEmail, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="WebGPGEmail" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="webGPGEmail"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, WebGPGEmail webGPGEmail, JsonSerializerOptions jsonSerializerOptions)
        {
            if (webGPGEmail.EmailOption.IsSet && webGPGEmail.Email == null)
                throw new ArgumentNullException(nameof(webGPGEmail.Email), "Property is required for class WebGPGEmail.");

            if (webGPGEmail.EmailOption.IsSet)
                writer.WriteString("email", webGPGEmail.Email);

            if (webGPGEmail.VerifiedOption.IsSet)
                writer.WriteBoolean("verified", webGPGEmail.VerifiedOption.Value!.Value);
        }
    }
}
