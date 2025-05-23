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
    /// ApiCompareResponse
    /// </summary>
    public partial class ApiCompareResponse : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ApiCompareResponse" /> class.
        /// </summary>
        /// <param name="baseCommit">baseCommit</param>
        /// <param name="commits">commits</param>
        /// <param name="files">files</param>
        /// <param name="headCommit">headCommit</param>
        /// <param name="mergeBaseCommit">mergeBaseCommit</param>
        /// <param name="totalCommits">totalCommits</param>
        [JsonConstructor]
        public ApiCompareResponse(Option<ApiCommit?> baseCommit = default, Option<List<ApiCommit>?> commits = default, Option<List<ApiCommitDiffFilePatch>?> files = default, Option<ApiCommit?> headCommit = default, Option<ApiCommit?> mergeBaseCommit = default, Option<int?> totalCommits = default)
        {
            BaseCommitOption = baseCommit;
            CommitsOption = commits;
            FilesOption = files;
            HeadCommitOption = headCommit;
            MergeBaseCommitOption = mergeBaseCommit;
            TotalCommitsOption = totalCommits;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Used to track the state of BaseCommit
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<ApiCommit?> BaseCommitOption { get; private set; }

        /// <summary>
        /// Gets or Sets BaseCommit
        /// </summary>
        [JsonPropertyName("base_commit")]
        public ApiCommit? BaseCommit { get { return this.BaseCommitOption; } set { this.BaseCommitOption = new(value); } }

        /// <summary>
        /// Used to track the state of Commits
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<List<ApiCommit>?> CommitsOption { get; private set; }

        /// <summary>
        /// Gets or Sets Commits
        /// </summary>
        [JsonPropertyName("commits")]
        public List<ApiCommit>? Commits { get { return this.CommitsOption; } set { this.CommitsOption = new(value); } }

        /// <summary>
        /// Used to track the state of Files
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<List<ApiCommitDiffFilePatch>?> FilesOption { get; private set; }

        /// <summary>
        /// Gets or Sets Files
        /// </summary>
        [JsonPropertyName("files")]
        public List<ApiCommitDiffFilePatch>? Files { get { return this.FilesOption; } set { this.FilesOption = new(value); } }

        /// <summary>
        /// Used to track the state of HeadCommit
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<ApiCommit?> HeadCommitOption { get; private set; }

        /// <summary>
        /// Gets or Sets HeadCommit
        /// </summary>
        [JsonPropertyName("head_commit")]
        public ApiCommit? HeadCommit { get { return this.HeadCommitOption; } set { this.HeadCommitOption = new(value); } }

        /// <summary>
        /// Used to track the state of MergeBaseCommit
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<ApiCommit?> MergeBaseCommitOption { get; private set; }

        /// <summary>
        /// Gets or Sets MergeBaseCommit
        /// </summary>
        [JsonPropertyName("merge_base_commit")]
        public ApiCommit? MergeBaseCommit { get { return this.MergeBaseCommitOption; } set { this.MergeBaseCommitOption = new(value); } }

        /// <summary>
        /// Used to track the state of TotalCommits
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<int?> TotalCommitsOption { get; private set; }

        /// <summary>
        /// Gets or Sets TotalCommits
        /// </summary>
        [JsonPropertyName("total_commits")]
        public int? TotalCommits { get { return this.TotalCommitsOption; } set { this.TotalCommitsOption = new(value); } }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ApiCompareResponse {\n");
            sb.Append("  BaseCommit: ").Append(BaseCommit).Append("\n");
            sb.Append("  Commits: ").Append(Commits).Append("\n");
            sb.Append("  Files: ").Append(Files).Append("\n");
            sb.Append("  HeadCommit: ").Append(HeadCommit).Append("\n");
            sb.Append("  MergeBaseCommit: ").Append(MergeBaseCommit).Append("\n");
            sb.Append("  TotalCommits: ").Append(TotalCommits).Append("\n");
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
    /// A Json converter for type <see cref="ApiCompareResponse" />
    /// </summary>
    public class ApiCompareResponseJsonConverter : JsonConverter<ApiCompareResponse>
    {
        /// <summary>
        /// Deserializes json to <see cref="ApiCompareResponse" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override ApiCompareResponse Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<ApiCommit?> baseCommit = default;
            Option<List<ApiCommit>?> commits = default;
            Option<List<ApiCommitDiffFilePatch>?> files = default;
            Option<ApiCommit?> headCommit = default;
            Option<ApiCommit?> mergeBaseCommit = default;
            Option<int?> totalCommits = default;

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
                        case "base_commit":
                            baseCommit = new Option<ApiCommit?>(JsonSerializer.Deserialize<ApiCommit>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        case "commits":
                            commits = new Option<List<ApiCommit>?>(JsonSerializer.Deserialize<List<ApiCommit>>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        case "files":
                            files = new Option<List<ApiCommitDiffFilePatch>?>(JsonSerializer.Deserialize<List<ApiCommitDiffFilePatch>>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        case "head_commit":
                            headCommit = new Option<ApiCommit?>(JsonSerializer.Deserialize<ApiCommit>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        case "merge_base_commit":
                            mergeBaseCommit = new Option<ApiCommit?>(JsonSerializer.Deserialize<ApiCommit>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        case "total_commits":
                            totalCommits = new Option<int?>(utf8JsonReader.TokenType == JsonTokenType.Null ? (int?)null : utf8JsonReader.GetInt32());
                            break;
                        default:
                            break;
                    }
                }
            }

            if (baseCommit.IsSet && baseCommit.Value == null)
                throw new ArgumentNullException(nameof(baseCommit), "Property is not nullable for class ApiCompareResponse.");

            if (commits.IsSet && commits.Value == null)
                throw new ArgumentNullException(nameof(commits), "Property is not nullable for class ApiCompareResponse.");

            if (files.IsSet && files.Value == null)
                throw new ArgumentNullException(nameof(files), "Property is not nullable for class ApiCompareResponse.");

            if (headCommit.IsSet && headCommit.Value == null)
                throw new ArgumentNullException(nameof(headCommit), "Property is not nullable for class ApiCompareResponse.");

            if (mergeBaseCommit.IsSet && mergeBaseCommit.Value == null)
                throw new ArgumentNullException(nameof(mergeBaseCommit), "Property is not nullable for class ApiCompareResponse.");

            if (totalCommits.IsSet && totalCommits.Value == null)
                throw new ArgumentNullException(nameof(totalCommits), "Property is not nullable for class ApiCompareResponse.");

            return new ApiCompareResponse(baseCommit, commits, files, headCommit, mergeBaseCommit, totalCommits);
        }

        /// <summary>
        /// Serializes a <see cref="ApiCompareResponse" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="apiCompareResponse"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, ApiCompareResponse apiCompareResponse, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, apiCompareResponse, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="ApiCompareResponse" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="apiCompareResponse"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, ApiCompareResponse apiCompareResponse, JsonSerializerOptions jsonSerializerOptions)
        {
            if (apiCompareResponse.BaseCommitOption.IsSet && apiCompareResponse.BaseCommit == null)
                throw new ArgumentNullException(nameof(apiCompareResponse.BaseCommit), "Property is required for class ApiCompareResponse.");

            if (apiCompareResponse.CommitsOption.IsSet && apiCompareResponse.Commits == null)
                throw new ArgumentNullException(nameof(apiCompareResponse.Commits), "Property is required for class ApiCompareResponse.");

            if (apiCompareResponse.FilesOption.IsSet && apiCompareResponse.Files == null)
                throw new ArgumentNullException(nameof(apiCompareResponse.Files), "Property is required for class ApiCompareResponse.");

            if (apiCompareResponse.HeadCommitOption.IsSet && apiCompareResponse.HeadCommit == null)
                throw new ArgumentNullException(nameof(apiCompareResponse.HeadCommit), "Property is required for class ApiCompareResponse.");

            if (apiCompareResponse.MergeBaseCommitOption.IsSet && apiCompareResponse.MergeBaseCommit == null)
                throw new ArgumentNullException(nameof(apiCompareResponse.MergeBaseCommit), "Property is required for class ApiCompareResponse.");

            if (apiCompareResponse.BaseCommitOption.IsSet)
            {
                writer.WritePropertyName("base_commit");
                JsonSerializer.Serialize(writer, apiCompareResponse.BaseCommit, jsonSerializerOptions);
            }
            if (apiCompareResponse.CommitsOption.IsSet)
            {
                writer.WritePropertyName("commits");
                JsonSerializer.Serialize(writer, apiCompareResponse.Commits, jsonSerializerOptions);
            }
            if (apiCompareResponse.FilesOption.IsSet)
            {
                writer.WritePropertyName("files");
                JsonSerializer.Serialize(writer, apiCompareResponse.Files, jsonSerializerOptions);
            }
            if (apiCompareResponse.HeadCommitOption.IsSet)
            {
                writer.WritePropertyName("head_commit");
                JsonSerializer.Serialize(writer, apiCompareResponse.HeadCommit, jsonSerializerOptions);
            }
            if (apiCompareResponse.MergeBaseCommitOption.IsSet)
            {
                writer.WritePropertyName("merge_base_commit");
                JsonSerializer.Serialize(writer, apiCompareResponse.MergeBaseCommit, jsonSerializerOptions);
            }
            if (apiCompareResponse.TotalCommitsOption.IsSet)
                writer.WriteNumber("total_commits", apiCompareResponse.TotalCommitsOption.Value!.Value);
        }
    }
}
