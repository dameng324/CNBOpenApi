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
    /// DtoActivityWorkflowData
    /// </summary>
    public partial class DtoActivityWorkflowData : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DtoActivityWorkflowData" /> class.
        /// </summary>
        /// <param name="activityType">activityType</param>
        /// <param name="createdAt">createdAt</param>
        /// <param name="group">group</param>
        /// <param name="release">release</param>
        /// <param name="repo">repo</param>
        /// <param name="user">user</param>
        [JsonConstructor]
        public DtoActivityWorkflowData(Option<ConstantActivityType?> activityType = default, Option<ConvertNullTime?> createdAt = default, Option<DtoOrganizationUnion?> group = default, Option<DtoActivityRelease?> release = default, Option<DtoActivityRepos?> repo = default, Option<DtoActivityUsers?> user = default)
        {
            ActivityTypeOption = activityType;
            CreatedAtOption = createdAt;
            GroupOption = group;
            ReleaseOption = release;
            RepoOption = repo;
            UserOption = user;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Used to track the state of ActivityType
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<ConstantActivityType?> ActivityTypeOption { get; private set; }

        /// <summary>
        /// Gets or Sets ActivityType
        /// </summary>
        [JsonPropertyName("activity_type")]
        public ConstantActivityType? ActivityType { get { return this.ActivityTypeOption; } set { this.ActivityTypeOption = new(value); } }

        /// <summary>
        /// Used to track the state of CreatedAt
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<ConvertNullTime?> CreatedAtOption { get; private set; }

        /// <summary>
        /// Gets or Sets CreatedAt
        /// </summary>
        [JsonPropertyName("created_at")]
        public ConvertNullTime? CreatedAt { get { return this.CreatedAtOption; } set { this.CreatedAtOption = new(value); } }

        /// <summary>
        /// Used to track the state of Group
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<DtoOrganizationUnion?> GroupOption { get; private set; }

        /// <summary>
        /// Gets or Sets Group
        /// </summary>
        [JsonPropertyName("group")]
        public DtoOrganizationUnion? Group { get { return this.GroupOption; } set { this.GroupOption = new(value); } }

        /// <summary>
        /// Used to track the state of Release
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<DtoActivityRelease?> ReleaseOption { get; private set; }

        /// <summary>
        /// Gets or Sets Release
        /// </summary>
        [JsonPropertyName("release")]
        public DtoActivityRelease? Release { get { return this.ReleaseOption; } set { this.ReleaseOption = new(value); } }

        /// <summary>
        /// Used to track the state of Repo
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<DtoActivityRepos?> RepoOption { get; private set; }

        /// <summary>
        /// Gets or Sets Repo
        /// </summary>
        [JsonPropertyName("repo")]
        public DtoActivityRepos? Repo { get { return this.RepoOption; } set { this.RepoOption = new(value); } }

        /// <summary>
        /// Used to track the state of User
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<DtoActivityUsers?> UserOption { get; private set; }

        /// <summary>
        /// Gets or Sets User
        /// </summary>
        [JsonPropertyName("user")]
        public DtoActivityUsers? User { get { return this.UserOption; } set { this.UserOption = new(value); } }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DtoActivityWorkflowData {\n");
            sb.Append("  ActivityType: ").Append(ActivityType).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  Group: ").Append(Group).Append("\n");
            sb.Append("  Release: ").Append(Release).Append("\n");
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
    /// A Json converter for type <see cref="DtoActivityWorkflowData" />
    /// </summary>
    public class DtoActivityWorkflowDataJsonConverter : JsonConverter<DtoActivityWorkflowData>
    {
        /// <summary>
        /// Deserializes json to <see cref="DtoActivityWorkflowData" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override DtoActivityWorkflowData Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<ConstantActivityType?> activityType = default;
            Option<ConvertNullTime?> createdAt = default;
            Option<DtoOrganizationUnion?> group = default;
            Option<DtoActivityRelease?> release = default;
            Option<DtoActivityRepos?> repo = default;
            Option<DtoActivityUsers?> user = default;

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
                        case "activity_type":
                            string? activityTypeRawValue = utf8JsonReader.GetString();
                            if (activityTypeRawValue != null)
                                activityType = new Option<ConstantActivityType?>(ConstantActivityTypeValueConverter.FromStringOrDefault(activityTypeRawValue));
                            break;
                        case "created_at":
                            createdAt = new Option<ConvertNullTime?>(JsonSerializer.Deserialize<ConvertNullTime>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        case "group":
                            group = new Option<DtoOrganizationUnion?>(JsonSerializer.Deserialize<DtoOrganizationUnion>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        case "release":
                            release = new Option<DtoActivityRelease?>(JsonSerializer.Deserialize<DtoActivityRelease>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        case "repo":
                            repo = new Option<DtoActivityRepos?>(JsonSerializer.Deserialize<DtoActivityRepos>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        case "user":
                            user = new Option<DtoActivityUsers?>(JsonSerializer.Deserialize<DtoActivityUsers>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        default:
                            break;
                    }
                }
            }

            if (activityType.IsSet && activityType.Value == null)
                throw new ArgumentNullException(nameof(activityType), "Property is not nullable for class DtoActivityWorkflowData.");

            if (createdAt.IsSet && createdAt.Value == null)
                throw new ArgumentNullException(nameof(createdAt), "Property is not nullable for class DtoActivityWorkflowData.");

            if (group.IsSet && group.Value == null)
                throw new ArgumentNullException(nameof(group), "Property is not nullable for class DtoActivityWorkflowData.");

            if (release.IsSet && release.Value == null)
                throw new ArgumentNullException(nameof(release), "Property is not nullable for class DtoActivityWorkflowData.");

            if (repo.IsSet && repo.Value == null)
                throw new ArgumentNullException(nameof(repo), "Property is not nullable for class DtoActivityWorkflowData.");

            if (user.IsSet && user.Value == null)
                throw new ArgumentNullException(nameof(user), "Property is not nullable for class DtoActivityWorkflowData.");

            return new DtoActivityWorkflowData(activityType, createdAt, group, release, repo, user);
        }

        /// <summary>
        /// Serializes a <see cref="DtoActivityWorkflowData" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="dtoActivityWorkflowData"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, DtoActivityWorkflowData dtoActivityWorkflowData, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, dtoActivityWorkflowData, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="DtoActivityWorkflowData" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="dtoActivityWorkflowData"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, DtoActivityWorkflowData dtoActivityWorkflowData, JsonSerializerOptions jsonSerializerOptions)
        {
            if (dtoActivityWorkflowData.CreatedAtOption.IsSet && dtoActivityWorkflowData.CreatedAt == null)
                throw new ArgumentNullException(nameof(dtoActivityWorkflowData.CreatedAt), "Property is required for class DtoActivityWorkflowData.");

            if (dtoActivityWorkflowData.GroupOption.IsSet && dtoActivityWorkflowData.Group == null)
                throw new ArgumentNullException(nameof(dtoActivityWorkflowData.Group), "Property is required for class DtoActivityWorkflowData.");

            if (dtoActivityWorkflowData.ReleaseOption.IsSet && dtoActivityWorkflowData.Release == null)
                throw new ArgumentNullException(nameof(dtoActivityWorkflowData.Release), "Property is required for class DtoActivityWorkflowData.");

            if (dtoActivityWorkflowData.RepoOption.IsSet && dtoActivityWorkflowData.Repo == null)
                throw new ArgumentNullException(nameof(dtoActivityWorkflowData.Repo), "Property is required for class DtoActivityWorkflowData.");

            if (dtoActivityWorkflowData.UserOption.IsSet && dtoActivityWorkflowData.User == null)
                throw new ArgumentNullException(nameof(dtoActivityWorkflowData.User), "Property is required for class DtoActivityWorkflowData.");

            if (dtoActivityWorkflowData.ActivityTypeOption.IsSet)
            {
                var activityTypeRawValue = ConstantActivityTypeValueConverter.ToJsonValue(dtoActivityWorkflowData.ActivityType!.Value);
                writer.WriteString("activity_type", activityTypeRawValue);
            }
            if (dtoActivityWorkflowData.CreatedAtOption.IsSet)
            {
                writer.WritePropertyName("created_at");
                JsonSerializer.Serialize(writer, dtoActivityWorkflowData.CreatedAt, jsonSerializerOptions);
            }
            if (dtoActivityWorkflowData.GroupOption.IsSet)
            {
                writer.WritePropertyName("group");
                JsonSerializer.Serialize(writer, dtoActivityWorkflowData.Group, jsonSerializerOptions);
            }
            if (dtoActivityWorkflowData.ReleaseOption.IsSet)
            {
                writer.WritePropertyName("release");
                JsonSerializer.Serialize(writer, dtoActivityWorkflowData.Release, jsonSerializerOptions);
            }
            if (dtoActivityWorkflowData.RepoOption.IsSet)
            {
                writer.WritePropertyName("repo");
                JsonSerializer.Serialize(writer, dtoActivityWorkflowData.Repo, jsonSerializerOptions);
            }
            if (dtoActivityWorkflowData.UserOption.IsSet)
            {
                writer.WritePropertyName("user");
                JsonSerializer.Serialize(writer, dtoActivityWorkflowData.User, jsonSerializerOptions);
            }
        }
    }
}
