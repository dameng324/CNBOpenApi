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
    /// WebapiCreatePullRequestForm
    /// </summary>
    public partial class WebapiCreatePullRequestForm : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WebapiCreatePullRequestForm" /> class.
        /// </summary>
        /// <param name="assignees">assignees</param>
        /// <param name="baseBranch">baseBranch</param>
        /// <param name="body">body</param>
        /// <param name="headBranch">headBranch</param>
        /// <param name="headRepoSlug">headRepoSlug</param>
        /// <param name="labels">labels</param>
        /// <param name="reviewers">reviewers</param>
        /// <param name="title">title</param>
        [JsonConstructor]
        public WebapiCreatePullRequestForm(Option<List<string>?> assignees = default, Option<string?> baseBranch = default, Option<string?> body = default, Option<string?> headBranch = default, Option<string?> headRepoSlug = default, Option<List<string>?> labels = default, Option<List<string>?> reviewers = default, Option<string?> title = default)
        {
            AssigneesOption = assignees;
            BaseBranchOption = baseBranch;
            BodyOption = body;
            HeadBranchOption = headBranch;
            HeadRepoSlugOption = headRepoSlug;
            LabelsOption = labels;
            ReviewersOption = reviewers;
            TitleOption = title;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Used to track the state of Assignees
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<List<string>?> AssigneesOption { get; private set; }

        /// <summary>
        /// Gets or Sets Assignees
        /// </summary>
        [JsonPropertyName("assignees")]
        public List<string>? Assignees { get { return this.AssigneesOption; } set { this.AssigneesOption = new(value); } }

        /// <summary>
        /// Used to track the state of BaseBranch
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> BaseBranchOption { get; private set; }

        /// <summary>
        /// Gets or Sets BaseBranch
        /// </summary>
        [JsonPropertyName("base_branch")]
        public string? BaseBranch { get { return this.BaseBranchOption; } set { this.BaseBranchOption = new(value); } }

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
        /// Used to track the state of HeadBranch
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> HeadBranchOption { get; private set; }

        /// <summary>
        /// Gets or Sets HeadBranch
        /// </summary>
        [JsonPropertyName("head_branch")]
        public string? HeadBranch { get { return this.HeadBranchOption; } set { this.HeadBranchOption = new(value); } }

        /// <summary>
        /// Used to track the state of HeadRepoSlug
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> HeadRepoSlugOption { get; private set; }

        /// <summary>
        /// Gets or Sets HeadRepoSlug
        /// </summary>
        [JsonPropertyName("head_repo_slug")]
        public string? HeadRepoSlug { get { return this.HeadRepoSlugOption; } set { this.HeadRepoSlugOption = new(value); } }

        /// <summary>
        /// Used to track the state of Labels
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<List<string>?> LabelsOption { get; private set; }

        /// <summary>
        /// Gets or Sets Labels
        /// </summary>
        [JsonPropertyName("labels")]
        public List<string>? Labels { get { return this.LabelsOption; } set { this.LabelsOption = new(value); } }

        /// <summary>
        /// Used to track the state of Reviewers
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<List<string>?> ReviewersOption { get; private set; }

        /// <summary>
        /// Gets or Sets Reviewers
        /// </summary>
        [JsonPropertyName("reviewers")]
        public List<string>? Reviewers { get { return this.ReviewersOption; } set { this.ReviewersOption = new(value); } }

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
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class WebapiCreatePullRequestForm {\n");
            sb.Append("  Assignees: ").Append(Assignees).Append("\n");
            sb.Append("  BaseBranch: ").Append(BaseBranch).Append("\n");
            sb.Append("  Body: ").Append(Body).Append("\n");
            sb.Append("  HeadBranch: ").Append(HeadBranch).Append("\n");
            sb.Append("  HeadRepoSlug: ").Append(HeadRepoSlug).Append("\n");
            sb.Append("  Labels: ").Append(Labels).Append("\n");
            sb.Append("  Reviewers: ").Append(Reviewers).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
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
    /// A Json converter for type <see cref="WebapiCreatePullRequestForm" />
    /// </summary>
    public class WebapiCreatePullRequestFormJsonConverter : JsonConverter<WebapiCreatePullRequestForm>
    {
        /// <summary>
        /// Deserializes json to <see cref="WebapiCreatePullRequestForm" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override WebapiCreatePullRequestForm Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<List<string>?> assignees = default;
            Option<string?> baseBranch = default;
            Option<string?> body = default;
            Option<string?> headBranch = default;
            Option<string?> headRepoSlug = default;
            Option<List<string>?> labels = default;
            Option<List<string>?> reviewers = default;
            Option<string?> title = default;

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
                            assignees = new Option<List<string>?>(JsonSerializer.Deserialize<List<string>>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        case "base_branch":
                            baseBranch = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "body":
                            body = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "head_branch":
                            headBranch = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "head_repo_slug":
                            headRepoSlug = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "labels":
                            labels = new Option<List<string>?>(JsonSerializer.Deserialize<List<string>>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        case "reviewers":
                            reviewers = new Option<List<string>?>(JsonSerializer.Deserialize<List<string>>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        case "title":
                            title = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        default:
                            break;
                    }
                }
            }

            if (assignees.IsSet && assignees.Value == null)
                throw new ArgumentNullException(nameof(assignees), "Property is not nullable for class WebapiCreatePullRequestForm.");

            if (baseBranch.IsSet && baseBranch.Value == null)
                throw new ArgumentNullException(nameof(baseBranch), "Property is not nullable for class WebapiCreatePullRequestForm.");

            if (body.IsSet && body.Value == null)
                throw new ArgumentNullException(nameof(body), "Property is not nullable for class WebapiCreatePullRequestForm.");

            if (headBranch.IsSet && headBranch.Value == null)
                throw new ArgumentNullException(nameof(headBranch), "Property is not nullable for class WebapiCreatePullRequestForm.");

            if (headRepoSlug.IsSet && headRepoSlug.Value == null)
                throw new ArgumentNullException(nameof(headRepoSlug), "Property is not nullable for class WebapiCreatePullRequestForm.");

            if (labels.IsSet && labels.Value == null)
                throw new ArgumentNullException(nameof(labels), "Property is not nullable for class WebapiCreatePullRequestForm.");

            if (reviewers.IsSet && reviewers.Value == null)
                throw new ArgumentNullException(nameof(reviewers), "Property is not nullable for class WebapiCreatePullRequestForm.");

            if (title.IsSet && title.Value == null)
                throw new ArgumentNullException(nameof(title), "Property is not nullable for class WebapiCreatePullRequestForm.");

            return new WebapiCreatePullRequestForm(assignees, baseBranch, body, headBranch, headRepoSlug, labels, reviewers, title);
        }

        /// <summary>
        /// Serializes a <see cref="WebapiCreatePullRequestForm" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="webapiCreatePullRequestForm"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, WebapiCreatePullRequestForm webapiCreatePullRequestForm, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, webapiCreatePullRequestForm, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="WebapiCreatePullRequestForm" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="webapiCreatePullRequestForm"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, WebapiCreatePullRequestForm webapiCreatePullRequestForm, JsonSerializerOptions jsonSerializerOptions)
        {
            if (webapiCreatePullRequestForm.AssigneesOption.IsSet && webapiCreatePullRequestForm.Assignees == null)
                throw new ArgumentNullException(nameof(webapiCreatePullRequestForm.Assignees), "Property is required for class WebapiCreatePullRequestForm.");

            if (webapiCreatePullRequestForm.BaseBranchOption.IsSet && webapiCreatePullRequestForm.BaseBranch == null)
                throw new ArgumentNullException(nameof(webapiCreatePullRequestForm.BaseBranch), "Property is required for class WebapiCreatePullRequestForm.");

            if (webapiCreatePullRequestForm.BodyOption.IsSet && webapiCreatePullRequestForm.Body == null)
                throw new ArgumentNullException(nameof(webapiCreatePullRequestForm.Body), "Property is required for class WebapiCreatePullRequestForm.");

            if (webapiCreatePullRequestForm.HeadBranchOption.IsSet && webapiCreatePullRequestForm.HeadBranch == null)
                throw new ArgumentNullException(nameof(webapiCreatePullRequestForm.HeadBranch), "Property is required for class WebapiCreatePullRequestForm.");

            if (webapiCreatePullRequestForm.HeadRepoSlugOption.IsSet && webapiCreatePullRequestForm.HeadRepoSlug == null)
                throw new ArgumentNullException(nameof(webapiCreatePullRequestForm.HeadRepoSlug), "Property is required for class WebapiCreatePullRequestForm.");

            if (webapiCreatePullRequestForm.LabelsOption.IsSet && webapiCreatePullRequestForm.Labels == null)
                throw new ArgumentNullException(nameof(webapiCreatePullRequestForm.Labels), "Property is required for class WebapiCreatePullRequestForm.");

            if (webapiCreatePullRequestForm.ReviewersOption.IsSet && webapiCreatePullRequestForm.Reviewers == null)
                throw new ArgumentNullException(nameof(webapiCreatePullRequestForm.Reviewers), "Property is required for class WebapiCreatePullRequestForm.");

            if (webapiCreatePullRequestForm.TitleOption.IsSet && webapiCreatePullRequestForm.Title == null)
                throw new ArgumentNullException(nameof(webapiCreatePullRequestForm.Title), "Property is required for class WebapiCreatePullRequestForm.");

            if (webapiCreatePullRequestForm.AssigneesOption.IsSet)
            {
                writer.WritePropertyName("assignees");
                JsonSerializer.Serialize(writer, webapiCreatePullRequestForm.Assignees, jsonSerializerOptions);
            }
            if (webapiCreatePullRequestForm.BaseBranchOption.IsSet)
                writer.WriteString("base_branch", webapiCreatePullRequestForm.BaseBranch);

            if (webapiCreatePullRequestForm.BodyOption.IsSet)
                writer.WriteString("body", webapiCreatePullRequestForm.Body);

            if (webapiCreatePullRequestForm.HeadBranchOption.IsSet)
                writer.WriteString("head_branch", webapiCreatePullRequestForm.HeadBranch);

            if (webapiCreatePullRequestForm.HeadRepoSlugOption.IsSet)
                writer.WriteString("head_repo_slug", webapiCreatePullRequestForm.HeadRepoSlug);

            if (webapiCreatePullRequestForm.LabelsOption.IsSet)
            {
                writer.WritePropertyName("labels");
                JsonSerializer.Serialize(writer, webapiCreatePullRequestForm.Labels, jsonSerializerOptions);
            }
            if (webapiCreatePullRequestForm.ReviewersOption.IsSet)
            {
                writer.WritePropertyName("reviewers");
                JsonSerializer.Serialize(writer, webapiCreatePullRequestForm.Reviewers, jsonSerializerOptions);
            }
            if (webapiCreatePullRequestForm.TitleOption.IsSet)
                writer.WriteString("title", webapiCreatePullRequestForm.Title);
        }
    }
}
