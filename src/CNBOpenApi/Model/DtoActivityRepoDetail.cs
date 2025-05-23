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
    /// DtoActivityRepoDetail
    /// </summary>
    public partial class DtoActivityRepoDetail : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DtoActivityRepoDetail" /> class.
        /// </summary>
        /// <param name="detail">公仓转私仓或仓库被删除后为 null</param>
        /// <param name="exposedRepoPath">activity 发生时仓库的 path，这时的 path 是可以公开的</param>
        /// <param name="freeze">仓库是否封禁</param>
        /// <param name="repoUnaccessible">仓库是否不可访问（公仓转私仓或仓库被删除后不可访问）</param>
        /// <param name="time">time</param>
        /// <param name="visibilityLevel">仓库可见性</param>
        [JsonConstructor]
        public DtoActivityRepoDetail(Option<DtoActivitySlugDetail?> detail = default, Option<string?> exposedRepoPath = default, Option<bool?> freeze = default, Option<bool?> repoUnaccessible = default, Option<decimal?> time = default, Option<ConstantVisibility?> visibilityLevel = default)
        {
            DetailOption = detail;
            ExposedRepoPathOption = exposedRepoPath;
            FreezeOption = freeze;
            RepoUnaccessibleOption = repoUnaccessible;
            TimeOption = time;
            VisibilityLevelOption = visibilityLevel;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Used to track the state of VisibilityLevel
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<ConstantVisibility?> VisibilityLevelOption { get; private set; }

        /// <summary>
        /// 仓库可见性
        /// </summary>
        /// <value>仓库可见性</value>
        [JsonPropertyName("visibility_level")]
        public ConstantVisibility? VisibilityLevel { get { return this.VisibilityLevelOption; } set { this.VisibilityLevelOption = new(value); } }

        /// <summary>
        /// Used to track the state of Detail
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<DtoActivitySlugDetail?> DetailOption { get; private set; }

        /// <summary>
        /// 公仓转私仓或仓库被删除后为 null
        /// </summary>
        /// <value>公仓转私仓或仓库被删除后为 null</value>
        [JsonPropertyName("detail")]
        public DtoActivitySlugDetail? Detail { get { return this.DetailOption; } set { this.DetailOption = new(value); } }

        /// <summary>
        /// Used to track the state of ExposedRepoPath
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> ExposedRepoPathOption { get; private set; }

        /// <summary>
        /// activity 发生时仓库的 path，这时的 path 是可以公开的
        /// </summary>
        /// <value>activity 发生时仓库的 path，这时的 path 是可以公开的</value>
        [JsonPropertyName("exposed_repo_path")]
        public string? ExposedRepoPath { get { return this.ExposedRepoPathOption; } set { this.ExposedRepoPathOption = new(value); } }

        /// <summary>
        /// Used to track the state of Freeze
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<bool?> FreezeOption { get; private set; }

        /// <summary>
        /// 仓库是否封禁
        /// </summary>
        /// <value>仓库是否封禁</value>
        [JsonPropertyName("freeze")]
        public bool? Freeze { get { return this.FreezeOption; } set { this.FreezeOption = new(value); } }

        /// <summary>
        /// Used to track the state of RepoUnaccessible
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<bool?> RepoUnaccessibleOption { get; private set; }

        /// <summary>
        /// 仓库是否不可访问（公仓转私仓或仓库被删除后不可访问）
        /// </summary>
        /// <value>仓库是否不可访问（公仓转私仓或仓库被删除后不可访问）</value>
        [JsonPropertyName("repo_unaccessible")]
        public bool? RepoUnaccessible { get { return this.RepoUnaccessibleOption; } set { this.RepoUnaccessibleOption = new(value); } }

        /// <summary>
        /// Used to track the state of Time
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<decimal?> TimeOption { get; private set; }

        /// <summary>
        /// Gets or Sets Time
        /// </summary>
        [JsonPropertyName("time")]
        public decimal? Time { get { return this.TimeOption; } set { this.TimeOption = new(value); } }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DtoActivityRepoDetail {\n");
            sb.Append("  Detail: ").Append(Detail).Append("\n");
            sb.Append("  ExposedRepoPath: ").Append(ExposedRepoPath).Append("\n");
            sb.Append("  Freeze: ").Append(Freeze).Append("\n");
            sb.Append("  RepoUnaccessible: ").Append(RepoUnaccessible).Append("\n");
            sb.Append("  Time: ").Append(Time).Append("\n");
            sb.Append("  VisibilityLevel: ").Append(VisibilityLevel).Append("\n");
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
    /// A Json converter for type <see cref="DtoActivityRepoDetail" />
    /// </summary>
    public class DtoActivityRepoDetailJsonConverter : JsonConverter<DtoActivityRepoDetail>
    {
        /// <summary>
        /// Deserializes json to <see cref="DtoActivityRepoDetail" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override DtoActivityRepoDetail Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<DtoActivitySlugDetail?> detail = default;
            Option<string?> exposedRepoPath = default;
            Option<bool?> freeze = default;
            Option<bool?> repoUnaccessible = default;
            Option<decimal?> time = default;
            Option<ConstantVisibility?> visibilityLevel = default;

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
                        case "detail":
                            detail = new Option<DtoActivitySlugDetail?>(JsonSerializer.Deserialize<DtoActivitySlugDetail>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        case "exposed_repo_path":
                            exposedRepoPath = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "freeze":
                            freeze = new Option<bool?>(utf8JsonReader.TokenType == JsonTokenType.Null ? (bool?)null : utf8JsonReader.GetBoolean());
                            break;
                        case "repo_unaccessible":
                            repoUnaccessible = new Option<bool?>(utf8JsonReader.TokenType == JsonTokenType.Null ? (bool?)null : utf8JsonReader.GetBoolean());
                            break;
                        case "time":
                            time = new Option<decimal?>(utf8JsonReader.TokenType == JsonTokenType.Null ? (decimal?)null : utf8JsonReader.GetDecimal());
                            break;
                        case "visibility_level":
                            string? visibilityLevelRawValue = utf8JsonReader.GetString();
                            if (visibilityLevelRawValue != null)
                                visibilityLevel = new Option<ConstantVisibility?>(ConstantVisibilityValueConverter.FromStringOrDefault(visibilityLevelRawValue));
                            break;
                        default:
                            break;
                    }
                }
            }

            if (detail.IsSet && detail.Value == null)
                throw new ArgumentNullException(nameof(detail), "Property is not nullable for class DtoActivityRepoDetail.");

            if (exposedRepoPath.IsSet && exposedRepoPath.Value == null)
                throw new ArgumentNullException(nameof(exposedRepoPath), "Property is not nullable for class DtoActivityRepoDetail.");

            if (freeze.IsSet && freeze.Value == null)
                throw new ArgumentNullException(nameof(freeze), "Property is not nullable for class DtoActivityRepoDetail.");

            if (repoUnaccessible.IsSet && repoUnaccessible.Value == null)
                throw new ArgumentNullException(nameof(repoUnaccessible), "Property is not nullable for class DtoActivityRepoDetail.");

            if (time.IsSet && time.Value == null)
                throw new ArgumentNullException(nameof(time), "Property is not nullable for class DtoActivityRepoDetail.");

            if (visibilityLevel.IsSet && visibilityLevel.Value == null)
                throw new ArgumentNullException(nameof(visibilityLevel), "Property is not nullable for class DtoActivityRepoDetail.");

            return new DtoActivityRepoDetail(detail, exposedRepoPath, freeze, repoUnaccessible, time, visibilityLevel);
        }

        /// <summary>
        /// Serializes a <see cref="DtoActivityRepoDetail" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="dtoActivityRepoDetail"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, DtoActivityRepoDetail dtoActivityRepoDetail, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, dtoActivityRepoDetail, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="DtoActivityRepoDetail" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="dtoActivityRepoDetail"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, DtoActivityRepoDetail dtoActivityRepoDetail, JsonSerializerOptions jsonSerializerOptions)
        {
            if (dtoActivityRepoDetail.DetailOption.IsSet && dtoActivityRepoDetail.Detail == null)
                throw new ArgumentNullException(nameof(dtoActivityRepoDetail.Detail), "Property is required for class DtoActivityRepoDetail.");

            if (dtoActivityRepoDetail.ExposedRepoPathOption.IsSet && dtoActivityRepoDetail.ExposedRepoPath == null)
                throw new ArgumentNullException(nameof(dtoActivityRepoDetail.ExposedRepoPath), "Property is required for class DtoActivityRepoDetail.");

            if (dtoActivityRepoDetail.DetailOption.IsSet)
            {
                writer.WritePropertyName("detail");
                JsonSerializer.Serialize(writer, dtoActivityRepoDetail.Detail, jsonSerializerOptions);
            }
            if (dtoActivityRepoDetail.ExposedRepoPathOption.IsSet)
                writer.WriteString("exposed_repo_path", dtoActivityRepoDetail.ExposedRepoPath);

            if (dtoActivityRepoDetail.FreezeOption.IsSet)
                writer.WriteBoolean("freeze", dtoActivityRepoDetail.FreezeOption.Value!.Value);

            if (dtoActivityRepoDetail.RepoUnaccessibleOption.IsSet)
                writer.WriteBoolean("repo_unaccessible", dtoActivityRepoDetail.RepoUnaccessibleOption.Value!.Value);

            if (dtoActivityRepoDetail.TimeOption.IsSet)
                writer.WriteNumber("time", dtoActivityRepoDetail.TimeOption.Value!.Value);

            if (dtoActivityRepoDetail.VisibilityLevelOption.IsSet)
            {
                var visibilityLevelRawValue = ConstantVisibilityValueConverter.ToJsonValue(dtoActivityRepoDetail.VisibilityLevel!.Value);
                writer.WriteNumber("visibility_level", visibilityLevelRawValue);
            }
        }
    }
}
