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
    /// WebDiff
    /// </summary>
    public partial class WebDiff : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WebDiff" /> class.
        /// </summary>
        /// <param name="baseCommit">baseCommit</param>
        /// <param name="fileExceeded">fileExceeded</param>
        /// <param name="fileLimit">fileLimit</param>
        /// <param name="files">files</param>
        /// <param name="headCommit">headCommit</param>
        /// <param name="stat">stat</param>
        [JsonConstructor]
        public WebDiff(Option<string?> baseCommit = default, Option<bool?> fileExceeded = default, Option<int?> fileLimit = default, Option<List<WebDiffFile>?> files = default, Option<string?> headCommit = default, Option<WebDiffStat?> stat = default)
        {
            BaseCommitOption = baseCommit;
            FileExceededOption = fileExceeded;
            FileLimitOption = fileLimit;
            FilesOption = files;
            HeadCommitOption = headCommit;
            StatOption = stat;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Used to track the state of BaseCommit
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> BaseCommitOption { get; private set; }

        /// <summary>
        /// Gets or Sets BaseCommit
        /// </summary>
        [JsonPropertyName("base_commit")]
        public string? BaseCommit { get { return this.BaseCommitOption; } set { this.BaseCommitOption = new(value); } }

        /// <summary>
        /// Used to track the state of FileExceeded
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<bool?> FileExceededOption { get; private set; }

        /// <summary>
        /// Gets or Sets FileExceeded
        /// </summary>
        [JsonPropertyName("file_exceeded")]
        public bool? FileExceeded { get { return this.FileExceededOption; } set { this.FileExceededOption = new(value); } }

        /// <summary>
        /// Used to track the state of FileLimit
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<int?> FileLimitOption { get; private set; }

        /// <summary>
        /// Gets or Sets FileLimit
        /// </summary>
        [JsonPropertyName("file_limit")]
        public int? FileLimit { get { return this.FileLimitOption; } set { this.FileLimitOption = new(value); } }

        /// <summary>
        /// Used to track the state of Files
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<List<WebDiffFile>?> FilesOption { get; private set; }

        /// <summary>
        /// Gets or Sets Files
        /// </summary>
        [JsonPropertyName("files")]
        public List<WebDiffFile>? Files { get { return this.FilesOption; } set { this.FilesOption = new(value); } }

        /// <summary>
        /// Used to track the state of HeadCommit
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> HeadCommitOption { get; private set; }

        /// <summary>
        /// Gets or Sets HeadCommit
        /// </summary>
        [JsonPropertyName("head_commit")]
        public string? HeadCommit { get { return this.HeadCommitOption; } set { this.HeadCommitOption = new(value); } }

        /// <summary>
        /// Used to track the state of Stat
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<WebDiffStat?> StatOption { get; private set; }

        /// <summary>
        /// Gets or Sets Stat
        /// </summary>
        [JsonPropertyName("stat")]
        public WebDiffStat? Stat { get { return this.StatOption; } set { this.StatOption = new(value); } }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class WebDiff {\n");
            sb.Append("  BaseCommit: ").Append(BaseCommit).Append("\n");
            sb.Append("  FileExceeded: ").Append(FileExceeded).Append("\n");
            sb.Append("  FileLimit: ").Append(FileLimit).Append("\n");
            sb.Append("  Files: ").Append(Files).Append("\n");
            sb.Append("  HeadCommit: ").Append(HeadCommit).Append("\n");
            sb.Append("  Stat: ").Append(Stat).Append("\n");
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
    /// A Json converter for type <see cref="WebDiff" />
    /// </summary>
    public class WebDiffJsonConverter : JsonConverter<WebDiff>
    {
        /// <summary>
        /// Deserializes json to <see cref="WebDiff" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override WebDiff Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<string?> baseCommit = default;
            Option<bool?> fileExceeded = default;
            Option<int?> fileLimit = default;
            Option<List<WebDiffFile>?> files = default;
            Option<string?> headCommit = default;
            Option<WebDiffStat?> stat = default;

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
                            baseCommit = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "file_exceeded":
                            fileExceeded = new Option<bool?>(utf8JsonReader.TokenType == JsonTokenType.Null ? (bool?)null : utf8JsonReader.GetBoolean());
                            break;
                        case "file_limit":
                            fileLimit = new Option<int?>(utf8JsonReader.TokenType == JsonTokenType.Null ? (int?)null : utf8JsonReader.GetInt32());
                            break;
                        case "files":
                            files = new Option<List<WebDiffFile>?>(JsonSerializer.Deserialize<List<WebDiffFile>>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        case "head_commit":
                            headCommit = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "stat":
                            stat = new Option<WebDiffStat?>(JsonSerializer.Deserialize<WebDiffStat>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        default:
                            break;
                    }
                }
            }

            if (baseCommit.IsSet && baseCommit.Value == null)
                throw new ArgumentNullException(nameof(baseCommit), "Property is not nullable for class WebDiff.");

            if (fileExceeded.IsSet && fileExceeded.Value == null)
                throw new ArgumentNullException(nameof(fileExceeded), "Property is not nullable for class WebDiff.");

            if (fileLimit.IsSet && fileLimit.Value == null)
                throw new ArgumentNullException(nameof(fileLimit), "Property is not nullable for class WebDiff.");

            if (files.IsSet && files.Value == null)
                throw new ArgumentNullException(nameof(files), "Property is not nullable for class WebDiff.");

            if (headCommit.IsSet && headCommit.Value == null)
                throw new ArgumentNullException(nameof(headCommit), "Property is not nullable for class WebDiff.");

            if (stat.IsSet && stat.Value == null)
                throw new ArgumentNullException(nameof(stat), "Property is not nullable for class WebDiff.");

            return new WebDiff(baseCommit, fileExceeded, fileLimit, files, headCommit, stat);
        }

        /// <summary>
        /// Serializes a <see cref="WebDiff" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="webDiff"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, WebDiff webDiff, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, webDiff, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="WebDiff" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="webDiff"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, WebDiff webDiff, JsonSerializerOptions jsonSerializerOptions)
        {
            if (webDiff.BaseCommitOption.IsSet && webDiff.BaseCommit == null)
                throw new ArgumentNullException(nameof(webDiff.BaseCommit), "Property is required for class WebDiff.");

            if (webDiff.FilesOption.IsSet && webDiff.Files == null)
                throw new ArgumentNullException(nameof(webDiff.Files), "Property is required for class WebDiff.");

            if (webDiff.HeadCommitOption.IsSet && webDiff.HeadCommit == null)
                throw new ArgumentNullException(nameof(webDiff.HeadCommit), "Property is required for class WebDiff.");

            if (webDiff.StatOption.IsSet && webDiff.Stat == null)
                throw new ArgumentNullException(nameof(webDiff.Stat), "Property is required for class WebDiff.");

            if (webDiff.BaseCommitOption.IsSet)
                writer.WriteString("base_commit", webDiff.BaseCommit);

            if (webDiff.FileExceededOption.IsSet)
                writer.WriteBoolean("file_exceeded", webDiff.FileExceededOption.Value!.Value);

            if (webDiff.FileLimitOption.IsSet)
                writer.WriteNumber("file_limit", webDiff.FileLimitOption.Value!.Value);

            if (webDiff.FilesOption.IsSet)
            {
                writer.WritePropertyName("files");
                JsonSerializer.Serialize(writer, webDiff.Files, jsonSerializerOptions);
            }
            if (webDiff.HeadCommitOption.IsSet)
                writer.WriteString("head_commit", webDiff.HeadCommit);

            if (webDiff.StatOption.IsSet)
            {
                writer.WritePropertyName("stat");
                JsonSerializer.Serialize(writer, webDiff.Stat, jsonSerializerOptions);
            }
        }
    }
}
