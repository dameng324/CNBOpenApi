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
    /// DtoCountResponse
    /// </summary>
    public partial class DtoCountResponse : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DtoCountResponse" /> class.
        /// </summary>
        /// <param name="group">group</param>
        /// <param name="repo">repo</param>
        /// <param name="user">user</param>
        [JsonConstructor]
        public DtoCountResponse(Option<int?> group = default, Option<int?> repo = default, Option<int?> user = default)
        {
            GroupOption = group;
            RepoOption = repo;
            UserOption = user;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Used to track the state of Group
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<int?> GroupOption { get; private set; }

        /// <summary>
        /// Gets or Sets Group
        /// </summary>
        [JsonPropertyName("group")]
        public int? Group { get { return this.GroupOption; } set { this.GroupOption = new(value); } }

        /// <summary>
        /// Used to track the state of Repo
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<int?> RepoOption { get; private set; }

        /// <summary>
        /// Gets or Sets Repo
        /// </summary>
        [JsonPropertyName("repo")]
        public int? Repo { get { return this.RepoOption; } set { this.RepoOption = new(value); } }

        /// <summary>
        /// Used to track the state of User
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<int?> UserOption { get; private set; }

        /// <summary>
        /// Gets or Sets User
        /// </summary>
        [JsonPropertyName("user")]
        public int? User { get { return this.UserOption; } set { this.UserOption = new(value); } }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DtoCountResponse {\n");
            sb.Append("  Group: ").Append(Group).Append("\n");
            sb.Append("  Repo: ").Append(Repo).Append("\n");
            sb.Append("  User: ").Append(User).Append("\n");
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
    /// A Json converter for type <see cref="DtoCountResponse" />
    /// </summary>
    public class DtoCountResponseJsonConverter : JsonConverter<DtoCountResponse>
    {
        /// <summary>
        /// Deserializes json to <see cref="DtoCountResponse" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override DtoCountResponse Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<int?> group = default;
            Option<int?> repo = default;
            Option<int?> user = default;

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
                        case "group":
                            group = new Option<int?>(utf8JsonReader.TokenType == JsonTokenType.Null ? (int?)null : utf8JsonReader.GetInt32());
                            break;
                        case "repo":
                            repo = new Option<int?>(utf8JsonReader.TokenType == JsonTokenType.Null ? (int?)null : utf8JsonReader.GetInt32());
                            break;
                        case "user":
                            user = new Option<int?>(utf8JsonReader.TokenType == JsonTokenType.Null ? (int?)null : utf8JsonReader.GetInt32());
                            break;
                        default:
                            break;
                    }
                }
            }

            if (group.IsSet && group.Value == null)
                throw new ArgumentNullException(nameof(group), "Property is not nullable for class DtoCountResponse.");

            if (repo.IsSet && repo.Value == null)
                throw new ArgumentNullException(nameof(repo), "Property is not nullable for class DtoCountResponse.");

            if (user.IsSet && user.Value == null)
                throw new ArgumentNullException(nameof(user), "Property is not nullable for class DtoCountResponse.");

            return new DtoCountResponse(group, repo, user);
        }

        /// <summary>
        /// Serializes a <see cref="DtoCountResponse" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="dtoCountResponse"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, DtoCountResponse dtoCountResponse, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, dtoCountResponse, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="DtoCountResponse" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="dtoCountResponse"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, DtoCountResponse dtoCountResponse, JsonSerializerOptions jsonSerializerOptions)
        {
            if (dtoCountResponse.GroupOption.IsSet)
                writer.WriteNumber("group", dtoCountResponse.GroupOption.Value!.Value);

            if (dtoCountResponse.RepoOption.IsSet)
                writer.WriteNumber("repo", dtoCountResponse.RepoOption.Value!.Value);

            if (dtoCountResponse.UserOption.IsSet)
                writer.WriteNumber("user", dtoCountResponse.UserOption.Value!.Value);
        }
    }
}
