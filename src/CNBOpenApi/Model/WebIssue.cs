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
    /// WebIssue
    /// </summary>
    public partial class WebIssue : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WebIssue" /> class.
        /// </summary>
        /// <param name="assignees">assignees</param>
        /// <param name="author">author</param>
        /// <param name="commentCount">commentCount</param>
        /// <param name="createdAt">createdAt</param>
        /// <param name="labels">labels</param>
        /// <param name="lastActedAt">lastActedAt</param>
        /// <param name="number">number</param>
        /// <param name="priority">priority</param>
        /// <param name="state">state</param>
        /// <param name="stateReason">stateReason</param>
        /// <param name="title">title</param>
        /// <param name="updatedAt">updatedAt</param>
        [JsonConstructor]
        public WebIssue(Option<List<GitWoaComCnbMonorepoGitInternalDtoWebUserInfo>?> assignees = default, Option<GitWoaComCnbMonorepoGitInternalDtoWebUserInfo?> author = default, Option<int?> commentCount = default, Option<string?> createdAt = default, Option<List<LabelOption>?> labels = default, Option<string?> lastActedAt = default, Option<string?> number = default, Option<string?> priority = default, Option<string?> state = default, Option<string?> stateReason = default, Option<string?> title = default, Option<string?> updatedAt = default)
        {
            AssigneesOption = assignees;
            AuthorOption = author;
            CommentCountOption = commentCount;
            CreatedAtOption = createdAt;
            LabelsOption = labels;
            LastActedAtOption = lastActedAt;
            NumberOption = number;
            PriorityOption = priority;
            StateOption = state;
            StateReasonOption = stateReason;
            TitleOption = title;
            UpdatedAtOption = updatedAt;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Used to track the state of Assignees
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<List<GitWoaComCnbMonorepoGitInternalDtoWebUserInfo>?> AssigneesOption { get; private set; }

        /// <summary>
        /// Gets or Sets Assignees
        /// </summary>
        [JsonPropertyName("assignees")]
        public List<GitWoaComCnbMonorepoGitInternalDtoWebUserInfo>? Assignees { get { return this.AssigneesOption; } set { this.AssigneesOption = new(value); } }

        /// <summary>
        /// Used to track the state of Author
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<GitWoaComCnbMonorepoGitInternalDtoWebUserInfo?> AuthorOption { get; private set; }

        /// <summary>
        /// Gets or Sets Author
        /// </summary>
        [JsonPropertyName("author")]
        public GitWoaComCnbMonorepoGitInternalDtoWebUserInfo? Author { get { return this.AuthorOption; } set { this.AuthorOption = new(value); } }

        /// <summary>
        /// Used to track the state of CommentCount
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<int?> CommentCountOption { get; private set; }

        /// <summary>
        /// Gets or Sets CommentCount
        /// </summary>
        [JsonPropertyName("comment_count")]
        public int? CommentCount { get { return this.CommentCountOption; } set { this.CommentCountOption = new(value); } }

        /// <summary>
        /// Used to track the state of CreatedAt
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> CreatedAtOption { get; private set; }

        /// <summary>
        /// Gets or Sets CreatedAt
        /// </summary>
        [JsonPropertyName("created_at")]
        public string? CreatedAt { get { return this.CreatedAtOption; } set { this.CreatedAtOption = new(value); } }

        /// <summary>
        /// Used to track the state of Labels
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<List<LabelOption>?> LabelsOption { get; private set; }

        /// <summary>
        /// Gets or Sets Labels
        /// </summary>
        [JsonPropertyName("labels")]
        public List<LabelOption>? Labels { get { return this.LabelsOption; } set { this.LabelsOption = new(value); } }

        /// <summary>
        /// Used to track the state of LastActedAt
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> LastActedAtOption { get; private set; }

        /// <summary>
        /// Gets or Sets LastActedAt
        /// </summary>
        [JsonPropertyName("last_acted_at")]
        public string? LastActedAt { get { return this.LastActedAtOption; } set { this.LastActedAtOption = new(value); } }

        /// <summary>
        /// Used to track the state of Number
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> NumberOption { get; private set; }

        /// <summary>
        /// Gets or Sets Number
        /// </summary>
        [JsonPropertyName("number")]
        public string? Number { get { return this.NumberOption; } set { this.NumberOption = new(value); } }

        /// <summary>
        /// Used to track the state of Priority
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> PriorityOption { get; private set; }

        /// <summary>
        /// Gets or Sets Priority
        /// </summary>
        [JsonPropertyName("priority")]
        public string? Priority { get { return this.PriorityOption; } set { this.PriorityOption = new(value); } }

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
        /// Used to track the state of StateReason
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> StateReasonOption { get; private set; }

        /// <summary>
        /// Gets or Sets StateReason
        /// </summary>
        [JsonPropertyName("state_reason")]
        public string? StateReason { get { return this.StateReasonOption; } set { this.StateReasonOption = new(value); } }

        /// <summary>
        /// Used to track the state of Title
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> TitleOption { get; private set; }

        /// <summary>
        /// Gets or Sets Title
        /// </summary>
        [JsonPropertyName("title")]
        public string? Title { get { return this.TitleOption; } set { this.TitleOption = new(value); } }

        /// <summary>
        /// Used to track the state of UpdatedAt
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> UpdatedAtOption { get; private set; }

        /// <summary>
        /// Gets or Sets UpdatedAt
        /// </summary>
        [JsonPropertyName("updated_at")]
        public string? UpdatedAt { get { return this.UpdatedAtOption; } set { this.UpdatedAtOption = new(value); } }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class WebIssue {\n");
            sb.Append("  Assignees: ").Append(Assignees).Append("\n");
            sb.Append("  Author: ").Append(Author).Append("\n");
            sb.Append("  CommentCount: ").Append(CommentCount).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  Labels: ").Append(Labels).Append("\n");
            sb.Append("  LastActedAt: ").Append(LastActedAt).Append("\n");
            sb.Append("  Number: ").Append(Number).Append("\n");
            sb.Append("  Priority: ").Append(Priority).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  StateReason: ").Append(StateReason).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
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
    /// A Json converter for type <see cref="WebIssue" />
    /// </summary>
    public class WebIssueJsonConverter : JsonConverter<WebIssue>
    {
        /// <summary>
        /// Deserializes json to <see cref="WebIssue" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override WebIssue Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<List<GitWoaComCnbMonorepoGitInternalDtoWebUserInfo>?> assignees = default;
            Option<GitWoaComCnbMonorepoGitInternalDtoWebUserInfo?> author = default;
            Option<int?> commentCount = default;
            Option<string?> createdAt = default;
            Option<List<LabelOption>?> labels = default;
            Option<string?> lastActedAt = default;
            Option<string?> number = default;
            Option<string?> priority = default;
            Option<string?> state = default;
            Option<string?> stateReason = default;
            Option<string?> title = default;
            Option<string?> updatedAt = default;

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
                        case "assignees":
                            assignees = new Option<List<GitWoaComCnbMonorepoGitInternalDtoWebUserInfo>?>(JsonSerializer.Deserialize<List<GitWoaComCnbMonorepoGitInternalDtoWebUserInfo>>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        case "author":
                            author = new Option<GitWoaComCnbMonorepoGitInternalDtoWebUserInfo?>(JsonSerializer.Deserialize<GitWoaComCnbMonorepoGitInternalDtoWebUserInfo>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        case "comment_count":
                            commentCount = new Option<int?>(utf8JsonReader.TokenType == JsonTokenType.Null ? (int?)null : utf8JsonReader.GetInt32());
                            break;
                        case "created_at":
                            createdAt = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "labels":
                            labels = new Option<List<LabelOption>?>(JsonSerializer.Deserialize<List<LabelOption>>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        case "last_acted_at":
                            lastActedAt = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "number":
                            number = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "priority":
                            priority = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "state":
                            state = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "state_reason":
                            stateReason = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "title":
                            title = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "updated_at":
                            updatedAt = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        default:
                            break;
                    }
                }
            }

            if (assignees.IsSet && assignees.Value == null)
                throw new ArgumentNullException(nameof(assignees), "Property is not nullable for class WebIssue.");

            if (author.IsSet && author.Value == null)
                throw new ArgumentNullException(nameof(author), "Property is not nullable for class WebIssue.");

            if (commentCount.IsSet && commentCount.Value == null)
                throw new ArgumentNullException(nameof(commentCount), "Property is not nullable for class WebIssue.");

            if (createdAt.IsSet && createdAt.Value == null)
                throw new ArgumentNullException(nameof(createdAt), "Property is not nullable for class WebIssue.");

            if (labels.IsSet && labels.Value == null)
                throw new ArgumentNullException(nameof(labels), "Property is not nullable for class WebIssue.");

            if (lastActedAt.IsSet && lastActedAt.Value == null)
                throw new ArgumentNullException(nameof(lastActedAt), "Property is not nullable for class WebIssue.");

            if (number.IsSet && number.Value == null)
                throw new ArgumentNullException(nameof(number), "Property is not nullable for class WebIssue.");

            if (priority.IsSet && priority.Value == null)
                throw new ArgumentNullException(nameof(priority), "Property is not nullable for class WebIssue.");

            if (state.IsSet && state.Value == null)
                throw new ArgumentNullException(nameof(state), "Property is not nullable for class WebIssue.");

            if (stateReason.IsSet && stateReason.Value == null)
                throw new ArgumentNullException(nameof(stateReason), "Property is not nullable for class WebIssue.");

            if (title.IsSet && title.Value == null)
                throw new ArgumentNullException(nameof(title), "Property is not nullable for class WebIssue.");

            if (updatedAt.IsSet && updatedAt.Value == null)
                throw new ArgumentNullException(nameof(updatedAt), "Property is not nullable for class WebIssue.");

            return new WebIssue(assignees, author, commentCount, createdAt, labels, lastActedAt, number, priority, state, stateReason, title, updatedAt);
        }

        /// <summary>
        /// Serializes a <see cref="WebIssue" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="webIssue"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, WebIssue webIssue, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, webIssue, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="WebIssue" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="webIssue"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, WebIssue webIssue, JsonSerializerOptions jsonSerializerOptions)
        {
            if (webIssue.AssigneesOption.IsSet && webIssue.Assignees == null)
                throw new ArgumentNullException(nameof(webIssue.Assignees), "Property is required for class WebIssue.");

            if (webIssue.AuthorOption.IsSet && webIssue.Author == null)
                throw new ArgumentNullException(nameof(webIssue.Author), "Property is required for class WebIssue.");

            if (webIssue.CreatedAtOption.IsSet && webIssue.CreatedAt == null)
                throw new ArgumentNullException(nameof(webIssue.CreatedAt), "Property is required for class WebIssue.");

            if (webIssue.LabelsOption.IsSet && webIssue.Labels == null)
                throw new ArgumentNullException(nameof(webIssue.Labels), "Property is required for class WebIssue.");

            if (webIssue.LastActedAtOption.IsSet && webIssue.LastActedAt == null)
                throw new ArgumentNullException(nameof(webIssue.LastActedAt), "Property is required for class WebIssue.");

            if (webIssue.NumberOption.IsSet && webIssue.Number == null)
                throw new ArgumentNullException(nameof(webIssue.Number), "Property is required for class WebIssue.");

            if (webIssue.PriorityOption.IsSet && webIssue.Priority == null)
                throw new ArgumentNullException(nameof(webIssue.Priority), "Property is required for class WebIssue.");

            if (webIssue.StateOption.IsSet && webIssue.State == null)
                throw new ArgumentNullException(nameof(webIssue.State), "Property is required for class WebIssue.");

            if (webIssue.StateReasonOption.IsSet && webIssue.StateReason == null)
                throw new ArgumentNullException(nameof(webIssue.StateReason), "Property is required for class WebIssue.");

            if (webIssue.TitleOption.IsSet && webIssue.Title == null)
                throw new ArgumentNullException(nameof(webIssue.Title), "Property is required for class WebIssue.");

            if (webIssue.UpdatedAtOption.IsSet && webIssue.UpdatedAt == null)
                throw new ArgumentNullException(nameof(webIssue.UpdatedAt), "Property is required for class WebIssue.");

            if (webIssue.AssigneesOption.IsSet)
            {
                writer.WritePropertyName("assignees");
                JsonSerializer.Serialize(writer, webIssue.Assignees, jsonSerializerOptions);
            }
            if (webIssue.AuthorOption.IsSet)
            {
                writer.WritePropertyName("author");
                JsonSerializer.Serialize(writer, webIssue.Author, jsonSerializerOptions);
            }
            if (webIssue.CommentCountOption.IsSet)
                writer.WriteNumber("comment_count", webIssue.CommentCountOption.Value!.Value);

            if (webIssue.CreatedAtOption.IsSet)
                writer.WriteString("created_at", webIssue.CreatedAt);

            if (webIssue.LabelsOption.IsSet)
            {
                writer.WritePropertyName("labels");
                JsonSerializer.Serialize(writer, webIssue.Labels, jsonSerializerOptions);
            }
            if (webIssue.LastActedAtOption.IsSet)
                writer.WriteString("last_acted_at", webIssue.LastActedAt);

            if (webIssue.NumberOption.IsSet)
                writer.WriteString("number", webIssue.Number);

            if (webIssue.PriorityOption.IsSet)
                writer.WriteString("priority", webIssue.Priority);

            if (webIssue.StateOption.IsSet)
                writer.WriteString("state", webIssue.State);

            if (webIssue.StateReasonOption.IsSet)
                writer.WriteString("state_reason", webIssue.StateReason);

            if (webIssue.TitleOption.IsSet)
                writer.WriteString("title", webIssue.Title);

            if (webIssue.UpdatedAtOption.IsSet)
                writer.WriteString("updated_at", webIssue.UpdatedAt);
        }
    }
}
