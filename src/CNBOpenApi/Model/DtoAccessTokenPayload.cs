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
    /// DtoAccessTokenPayload
    /// </summary>
    public partial class DtoAccessTokenPayload : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DtoAccessTokenPayload" /> class.
        /// </summary>
        /// <param name="description">description</param>
        /// <param name="expiredAt">expiredAt</param>
        /// <param name="scope">scope</param>
        /// <param name="slug">slug</param>
        /// <param name="token">token</param>
        [JsonConstructor]
        public DtoAccessTokenPayload(Option<string?> description = default, Option<ConvertNullTime?> expiredAt = default, Option<string?> scope = default, Option<string?> slug = default, Option<string?> token = default)
        {
            DescriptionOption = description;
            ExpiredAtOption = expiredAt;
            ScopeOption = scope;
            SlugOption = slug;
            TokenOption = token;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Used to track the state of Description
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> DescriptionOption { get; private set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [JsonPropertyName("description")]
        public string? Description { get { return this.DescriptionOption; } set { this.DescriptionOption = new(value); } }

        /// <summary>
        /// Used to track the state of ExpiredAt
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<ConvertNullTime?> ExpiredAtOption { get; private set; }

        /// <summary>
        /// Gets or Sets ExpiredAt
        /// </summary>
        [JsonPropertyName("expired_at")]
        public ConvertNullTime? ExpiredAt { get { return this.ExpiredAtOption; } set { this.ExpiredAtOption = new(value); } }

        /// <summary>
        /// Used to track the state of Scope
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> ScopeOption { get; private set; }

        /// <summary>
        /// Gets or Sets Scope
        /// </summary>
        [JsonPropertyName("scope")]
        public string? Scope { get { return this.ScopeOption; } set { this.ScopeOption = new(value); } }

        /// <summary>
        /// Used to track the state of Slug
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> SlugOption { get; private set; }

        /// <summary>
        /// Gets or Sets Slug
        /// </summary>
        [JsonPropertyName("slug")]
        public string? Slug { get { return this.SlugOption; } set { this.SlugOption = new(value); } }

        /// <summary>
        /// Used to track the state of Token
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> TokenOption { get; private set; }

        /// <summary>
        /// Gets or Sets Token
        /// </summary>
        [JsonPropertyName("token")]
        public string? Token { get { return this.TokenOption; } set { this.TokenOption = new(value); } }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DtoAccessTokenPayload {\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  ExpiredAt: ").Append(ExpiredAt).Append("\n");
            sb.Append("  Scope: ").Append(Scope).Append("\n");
            sb.Append("  Slug: ").Append(Slug).Append("\n");
            sb.Append("  Token: ").Append(Token).Append("\n");
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
    /// A Json converter for type <see cref="DtoAccessTokenPayload" />
    /// </summary>
    public class DtoAccessTokenPayloadJsonConverter : JsonConverter<DtoAccessTokenPayload>
    {
        /// <summary>
        /// Deserializes json to <see cref="DtoAccessTokenPayload" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override DtoAccessTokenPayload Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<string?> description = default;
            Option<ConvertNullTime?> expiredAt = default;
            Option<string?> scope = default;
            Option<string?> slug = default;
            Option<string?> token = default;

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
                        case "description":
                            description = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "expired_at":
                            expiredAt = new Option<ConvertNullTime?>(JsonSerializer.Deserialize<ConvertNullTime>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        case "scope":
                            scope = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "slug":
                            slug = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "token":
                            token = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        default:
                            break;
                    }
                }
            }

            if (description.IsSet && description.Value == null)
                throw new ArgumentNullException(nameof(description), "Property is not nullable for class DtoAccessTokenPayload.");

            if (expiredAt.IsSet && expiredAt.Value == null)
                throw new ArgumentNullException(nameof(expiredAt), "Property is not nullable for class DtoAccessTokenPayload.");

            if (scope.IsSet && scope.Value == null)
                throw new ArgumentNullException(nameof(scope), "Property is not nullable for class DtoAccessTokenPayload.");

            if (slug.IsSet && slug.Value == null)
                throw new ArgumentNullException(nameof(slug), "Property is not nullable for class DtoAccessTokenPayload.");

            if (token.IsSet && token.Value == null)
                throw new ArgumentNullException(nameof(token), "Property is not nullable for class DtoAccessTokenPayload.");

            return new DtoAccessTokenPayload(description, expiredAt, scope, slug, token);
        }

        /// <summary>
        /// Serializes a <see cref="DtoAccessTokenPayload" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="dtoAccessTokenPayload"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, DtoAccessTokenPayload dtoAccessTokenPayload, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, dtoAccessTokenPayload, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="DtoAccessTokenPayload" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="dtoAccessTokenPayload"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, DtoAccessTokenPayload dtoAccessTokenPayload, JsonSerializerOptions jsonSerializerOptions)
        {
            if (dtoAccessTokenPayload.DescriptionOption.IsSet && dtoAccessTokenPayload.Description == null)
                throw new ArgumentNullException(nameof(dtoAccessTokenPayload.Description), "Property is required for class DtoAccessTokenPayload.");

            if (dtoAccessTokenPayload.ExpiredAtOption.IsSet && dtoAccessTokenPayload.ExpiredAt == null)
                throw new ArgumentNullException(nameof(dtoAccessTokenPayload.ExpiredAt), "Property is required for class DtoAccessTokenPayload.");

            if (dtoAccessTokenPayload.ScopeOption.IsSet && dtoAccessTokenPayload.Scope == null)
                throw new ArgumentNullException(nameof(dtoAccessTokenPayload.Scope), "Property is required for class DtoAccessTokenPayload.");

            if (dtoAccessTokenPayload.SlugOption.IsSet && dtoAccessTokenPayload.Slug == null)
                throw new ArgumentNullException(nameof(dtoAccessTokenPayload.Slug), "Property is required for class DtoAccessTokenPayload.");

            if (dtoAccessTokenPayload.TokenOption.IsSet && dtoAccessTokenPayload.Token == null)
                throw new ArgumentNullException(nameof(dtoAccessTokenPayload.Token), "Property is required for class DtoAccessTokenPayload.");

            if (dtoAccessTokenPayload.DescriptionOption.IsSet)
                writer.WriteString("description", dtoAccessTokenPayload.Description);

            if (dtoAccessTokenPayload.ExpiredAtOption.IsSet)
            {
                writer.WritePropertyName("expired_at");
                JsonSerializer.Serialize(writer, dtoAccessTokenPayload.ExpiredAt, jsonSerializerOptions);
            }
            if (dtoAccessTokenPayload.ScopeOption.IsSet)
                writer.WriteString("scope", dtoAccessTokenPayload.Scope);

            if (dtoAccessTokenPayload.SlugOption.IsSet)
                writer.WriteString("slug", dtoAccessTokenPayload.Slug);

            if (dtoAccessTokenPayload.TokenOption.IsSet)
                writer.WriteString("token", dtoAccessTokenPayload.Token);
        }
    }
}
