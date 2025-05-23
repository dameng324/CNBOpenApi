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
    /// WebCodeSensitiveDetail
    /// </summary>
    public partial class WebCodeSensitiveDetail : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WebCodeSensitiveDetail" /> class.
        /// </summary>
        /// <param name="createdAt">问题创建时间</param>
        /// <param name="fileName">包含问题的文件名</param>
        /// <param name="filePath">包含问题的文件路径</param>
        /// <param name="handler">忽略人(平台信息)</param>
        /// <param name="id">问题id</param>
        /// <param name="ignoreReason">忽略原因</param>
        /// <param name="ignoredAt">忽略时间</param>
        /// <param name="issueDetail">问题详情</param>
        /// <param name="issueSubType">问题子类型</param>
        /// <param name="issueType">问题类型</param>
        /// <param name="lineNo">问题行号</param>
        /// <param name="occurVersion">问题发生版本</param>
        /// <param name="owner">问题责任人(平台信息)</param>
        /// <param name="rawAuthor">问题责任人原生git信息</param>
        /// <param name="reopenAt">重新开启时间</param>
        /// <param name="reopenHandler">重新开启人</param>
        /// <param name="revision">问题所在版本</param>
        /// <param name="riskLevel">问题等级</param>
        /// <param name="state">问题状态 开启/忽略</param>
        /// <param name="tool">扫描工具</param>
        [JsonConstructor]
        public WebCodeSensitiveDetail(Option<string?> createdAt = default, Option<string?> fileName = default, Option<string?> filePath = default, Option<GitWoaComCnbMonorepoGitInternalDtoWebUserInfo?> handler = default, Option<string?> id = default, Option<string?> ignoreReason = default, Option<string?> ignoredAt = default, Option<List<WebCSDetail>?> issueDetail = default, Option<string?> issueSubType = default, Option<string?> issueType = default, Option<List<int>?> lineNo = default, Option<string?> occurVersion = default, Option<GitWoaComCnbMonorepoGitInternalDtoWebUserInfo?> owner = default, Option<WebRawAuthor?> rawAuthor = default, Option<string?> reopenAt = default, Option<GitWoaComCnbMonorepoGitInternalDtoWebUserInfo?> reopenHandler = default, Option<string?> revision = default, Option<string?> riskLevel = default, Option<string?> state = default, Option<string?> tool = default)
        {
            CreatedAtOption = createdAt;
            FileNameOption = fileName;
            FilePathOption = filePath;
            HandlerOption = handler;
            IdOption = id;
            IgnoreReasonOption = ignoreReason;
            IgnoredAtOption = ignoredAt;
            IssueDetailOption = issueDetail;
            IssueSubTypeOption = issueSubType;
            IssueTypeOption = issueType;
            LineNoOption = lineNo;
            OccurVersionOption = occurVersion;
            OwnerOption = owner;
            RawAuthorOption = rawAuthor;
            ReopenAtOption = reopenAt;
            ReopenHandlerOption = reopenHandler;
            RevisionOption = revision;
            RiskLevelOption = riskLevel;
            StateOption = state;
            ToolOption = tool;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Used to track the state of CreatedAt
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> CreatedAtOption { get; private set; }

        /// <summary>
        /// 问题创建时间
        /// </summary>
        /// <value>问题创建时间</value>
        [JsonPropertyName("created_at")]
        public string? CreatedAt { get { return this.CreatedAtOption; } set { this.CreatedAtOption = new(value); } }

        /// <summary>
        /// Used to track the state of FileName
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> FileNameOption { get; private set; }

        /// <summary>
        /// 包含问题的文件名
        /// </summary>
        /// <value>包含问题的文件名</value>
        [JsonPropertyName("file_name")]
        public string? FileName { get { return this.FileNameOption; } set { this.FileNameOption = new(value); } }

        /// <summary>
        /// Used to track the state of FilePath
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> FilePathOption { get; private set; }

        /// <summary>
        /// 包含问题的文件路径
        /// </summary>
        /// <value>包含问题的文件路径</value>
        [JsonPropertyName("file_path")]
        public string? FilePath { get { return this.FilePathOption; } set { this.FilePathOption = new(value); } }

        /// <summary>
        /// Used to track the state of Handler
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<GitWoaComCnbMonorepoGitInternalDtoWebUserInfo?> HandlerOption { get; private set; }

        /// <summary>
        /// 忽略人(平台信息)
        /// </summary>
        /// <value>忽略人(平台信息)</value>
        [JsonPropertyName("handler")]
        public GitWoaComCnbMonorepoGitInternalDtoWebUserInfo? Handler { get { return this.HandlerOption; } set { this.HandlerOption = new(value); } }

        /// <summary>
        /// Used to track the state of Id
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> IdOption { get; private set; }

        /// <summary>
        /// 问题id
        /// </summary>
        /// <value>问题id</value>
        [JsonPropertyName("id")]
        public string? Id { get { return this.IdOption; } set { this.IdOption = new(value); } }

        /// <summary>
        /// Used to track the state of IgnoreReason
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> IgnoreReasonOption { get; private set; }

        /// <summary>
        /// 忽略原因
        /// </summary>
        /// <value>忽略原因</value>
        [JsonPropertyName("ignore_reason")]
        public string? IgnoreReason { get { return this.IgnoreReasonOption; } set { this.IgnoreReasonOption = new(value); } }

        /// <summary>
        /// Used to track the state of IgnoredAt
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> IgnoredAtOption { get; private set; }

        /// <summary>
        /// 忽略时间
        /// </summary>
        /// <value>忽略时间</value>
        [JsonPropertyName("ignored_at")]
        public string? IgnoredAt { get { return this.IgnoredAtOption; } set { this.IgnoredAtOption = new(value); } }

        /// <summary>
        /// Used to track the state of IssueDetail
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<List<WebCSDetail>?> IssueDetailOption { get; private set; }

        /// <summary>
        /// 问题详情
        /// </summary>
        /// <value>问题详情</value>
        [JsonPropertyName("issue_detail")]
        public List<WebCSDetail>? IssueDetail { get { return this.IssueDetailOption; } set { this.IssueDetailOption = new(value); } }

        /// <summary>
        /// Used to track the state of IssueSubType
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> IssueSubTypeOption { get; private set; }

        /// <summary>
        /// 问题子类型
        /// </summary>
        /// <value>问题子类型</value>
        [JsonPropertyName("issue_sub_type")]
        public string? IssueSubType { get { return this.IssueSubTypeOption; } set { this.IssueSubTypeOption = new(value); } }

        /// <summary>
        /// Used to track the state of IssueType
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> IssueTypeOption { get; private set; }

        /// <summary>
        /// 问题类型
        /// </summary>
        /// <value>问题类型</value>
        [JsonPropertyName("issue_type")]
        public string? IssueType { get { return this.IssueTypeOption; } set { this.IssueTypeOption = new(value); } }

        /// <summary>
        /// Used to track the state of LineNo
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<List<int>?> LineNoOption { get; private set; }

        /// <summary>
        /// 问题行号
        /// </summary>
        /// <value>问题行号</value>
        [JsonPropertyName("line_no")]
        public List<int>? LineNo { get { return this.LineNoOption; } set { this.LineNoOption = new(value); } }

        /// <summary>
        /// Used to track the state of OccurVersion
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> OccurVersionOption { get; private set; }

        /// <summary>
        /// 问题发生版本
        /// </summary>
        /// <value>问题发生版本</value>
        [JsonPropertyName("occur_version")]
        public string? OccurVersion { get { return this.OccurVersionOption; } set { this.OccurVersionOption = new(value); } }

        /// <summary>
        /// Used to track the state of Owner
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<GitWoaComCnbMonorepoGitInternalDtoWebUserInfo?> OwnerOption { get; private set; }

        /// <summary>
        /// 问题责任人(平台信息)
        /// </summary>
        /// <value>问题责任人(平台信息)</value>
        [JsonPropertyName("owner")]
        public GitWoaComCnbMonorepoGitInternalDtoWebUserInfo? Owner { get { return this.OwnerOption; } set { this.OwnerOption = new(value); } }

        /// <summary>
        /// Used to track the state of RawAuthor
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<WebRawAuthor?> RawAuthorOption { get; private set; }

        /// <summary>
        /// 问题责任人原生git信息
        /// </summary>
        /// <value>问题责任人原生git信息</value>
        [JsonPropertyName("raw_author")]
        public WebRawAuthor? RawAuthor { get { return this.RawAuthorOption; } set { this.RawAuthorOption = new(value); } }

        /// <summary>
        /// Used to track the state of ReopenAt
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> ReopenAtOption { get; private set; }

        /// <summary>
        /// 重新开启时间
        /// </summary>
        /// <value>重新开启时间</value>
        [JsonPropertyName("reopen_at")]
        public string? ReopenAt { get { return this.ReopenAtOption; } set { this.ReopenAtOption = new(value); } }

        /// <summary>
        /// Used to track the state of ReopenHandler
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<GitWoaComCnbMonorepoGitInternalDtoWebUserInfo?> ReopenHandlerOption { get; private set; }

        /// <summary>
        /// 重新开启人
        /// </summary>
        /// <value>重新开启人</value>
        [JsonPropertyName("reopen_handler")]
        public GitWoaComCnbMonorepoGitInternalDtoWebUserInfo? ReopenHandler { get { return this.ReopenHandlerOption; } set { this.ReopenHandlerOption = new(value); } }

        /// <summary>
        /// Used to track the state of Revision
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> RevisionOption { get; private set; }

        /// <summary>
        /// 问题所在版本
        /// </summary>
        /// <value>问题所在版本</value>
        [JsonPropertyName("revision")]
        public string? Revision { get { return this.RevisionOption; } set { this.RevisionOption = new(value); } }

        /// <summary>
        /// Used to track the state of RiskLevel
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> RiskLevelOption { get; private set; }

        /// <summary>
        /// 问题等级
        /// </summary>
        /// <value>问题等级</value>
        [JsonPropertyName("risk_level")]
        public string? RiskLevel { get { return this.RiskLevelOption; } set { this.RiskLevelOption = new(value); } }

        /// <summary>
        /// Used to track the state of State
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> StateOption { get; private set; }

        /// <summary>
        /// 问题状态 开启/忽略
        /// </summary>
        /// <value>问题状态 开启/忽略</value>
        [JsonPropertyName("state")]
        public string? State { get { return this.StateOption; } set { this.StateOption = new(value); } }

        /// <summary>
        /// Used to track the state of Tool
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> ToolOption { get; private set; }

        /// <summary>
        /// 扫描工具
        /// </summary>
        /// <value>扫描工具</value>
        [JsonPropertyName("tool")]
        public string? Tool { get { return this.ToolOption; } set { this.ToolOption = new(value); } }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class WebCodeSensitiveDetail {\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  FileName: ").Append(FileName).Append("\n");
            sb.Append("  FilePath: ").Append(FilePath).Append("\n");
            sb.Append("  Handler: ").Append(Handler).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  IgnoreReason: ").Append(IgnoreReason).Append("\n");
            sb.Append("  IgnoredAt: ").Append(IgnoredAt).Append("\n");
            sb.Append("  IssueDetail: ").Append(IssueDetail).Append("\n");
            sb.Append("  IssueSubType: ").Append(IssueSubType).Append("\n");
            sb.Append("  IssueType: ").Append(IssueType).Append("\n");
            sb.Append("  LineNo: ").Append(LineNo).Append("\n");
            sb.Append("  OccurVersion: ").Append(OccurVersion).Append("\n");
            sb.Append("  Owner: ").Append(Owner).Append("\n");
            sb.Append("  RawAuthor: ").Append(RawAuthor).Append("\n");
            sb.Append("  ReopenAt: ").Append(ReopenAt).Append("\n");
            sb.Append("  ReopenHandler: ").Append(ReopenHandler).Append("\n");
            sb.Append("  Revision: ").Append(Revision).Append("\n");
            sb.Append("  RiskLevel: ").Append(RiskLevel).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  Tool: ").Append(Tool).Append("\n");
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
    /// A Json converter for type <see cref="WebCodeSensitiveDetail" />
    /// </summary>
    public class WebCodeSensitiveDetailJsonConverter : JsonConverter<WebCodeSensitiveDetail>
    {
        /// <summary>
        /// Deserializes json to <see cref="WebCodeSensitiveDetail" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override WebCodeSensitiveDetail Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<string?> createdAt = default;
            Option<string?> fileName = default;
            Option<string?> filePath = default;
            Option<GitWoaComCnbMonorepoGitInternalDtoWebUserInfo?> handler = default;
            Option<string?> id = default;
            Option<string?> ignoreReason = default;
            Option<string?> ignoredAt = default;
            Option<List<WebCSDetail>?> issueDetail = default;
            Option<string?> issueSubType = default;
            Option<string?> issueType = default;
            Option<List<int>?> lineNo = default;
            Option<string?> occurVersion = default;
            Option<GitWoaComCnbMonorepoGitInternalDtoWebUserInfo?> owner = default;
            Option<WebRawAuthor?> rawAuthor = default;
            Option<string?> reopenAt = default;
            Option<GitWoaComCnbMonorepoGitInternalDtoWebUserInfo?> reopenHandler = default;
            Option<string?> revision = default;
            Option<string?> riskLevel = default;
            Option<string?> state = default;
            Option<string?> tool = default;

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
                        case "created_at":
                            createdAt = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "file_name":
                            fileName = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "file_path":
                            filePath = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "handler":
                            handler = new Option<GitWoaComCnbMonorepoGitInternalDtoWebUserInfo?>(JsonSerializer.Deserialize<GitWoaComCnbMonorepoGitInternalDtoWebUserInfo>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        case "id":
                            id = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "ignore_reason":
                            ignoreReason = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "ignored_at":
                            ignoredAt = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "issue_detail":
                            issueDetail = new Option<List<WebCSDetail>?>(JsonSerializer.Deserialize<List<WebCSDetail>>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        case "issue_sub_type":
                            issueSubType = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "issue_type":
                            issueType = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "line_no":
                            lineNo = new Option<List<int>?>(JsonSerializer.Deserialize<List<int>>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        case "occur_version":
                            occurVersion = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "owner":
                            owner = new Option<GitWoaComCnbMonorepoGitInternalDtoWebUserInfo?>(JsonSerializer.Deserialize<GitWoaComCnbMonorepoGitInternalDtoWebUserInfo>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        case "raw_author":
                            rawAuthor = new Option<WebRawAuthor?>(JsonSerializer.Deserialize<WebRawAuthor>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        case "reopen_at":
                            reopenAt = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "reopen_handler":
                            reopenHandler = new Option<GitWoaComCnbMonorepoGitInternalDtoWebUserInfo?>(JsonSerializer.Deserialize<GitWoaComCnbMonorepoGitInternalDtoWebUserInfo>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        case "revision":
                            revision = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "risk_level":
                            riskLevel = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "state":
                            state = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "tool":
                            tool = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        default:
                            break;
                    }
                }
            }

            if (createdAt.IsSet && createdAt.Value == null)
                throw new ArgumentNullException(nameof(createdAt), "Property is not nullable for class WebCodeSensitiveDetail.");

            if (fileName.IsSet && fileName.Value == null)
                throw new ArgumentNullException(nameof(fileName), "Property is not nullable for class WebCodeSensitiveDetail.");

            if (filePath.IsSet && filePath.Value == null)
                throw new ArgumentNullException(nameof(filePath), "Property is not nullable for class WebCodeSensitiveDetail.");

            if (handler.IsSet && handler.Value == null)
                throw new ArgumentNullException(nameof(handler), "Property is not nullable for class WebCodeSensitiveDetail.");

            if (id.IsSet && id.Value == null)
                throw new ArgumentNullException(nameof(id), "Property is not nullable for class WebCodeSensitiveDetail.");

            if (ignoreReason.IsSet && ignoreReason.Value == null)
                throw new ArgumentNullException(nameof(ignoreReason), "Property is not nullable for class WebCodeSensitiveDetail.");

            if (ignoredAt.IsSet && ignoredAt.Value == null)
                throw new ArgumentNullException(nameof(ignoredAt), "Property is not nullable for class WebCodeSensitiveDetail.");

            if (issueDetail.IsSet && issueDetail.Value == null)
                throw new ArgumentNullException(nameof(issueDetail), "Property is not nullable for class WebCodeSensitiveDetail.");

            if (issueSubType.IsSet && issueSubType.Value == null)
                throw new ArgumentNullException(nameof(issueSubType), "Property is not nullable for class WebCodeSensitiveDetail.");

            if (issueType.IsSet && issueType.Value == null)
                throw new ArgumentNullException(nameof(issueType), "Property is not nullable for class WebCodeSensitiveDetail.");

            if (lineNo.IsSet && lineNo.Value == null)
                throw new ArgumentNullException(nameof(lineNo), "Property is not nullable for class WebCodeSensitiveDetail.");

            if (occurVersion.IsSet && occurVersion.Value == null)
                throw new ArgumentNullException(nameof(occurVersion), "Property is not nullable for class WebCodeSensitiveDetail.");

            if (owner.IsSet && owner.Value == null)
                throw new ArgumentNullException(nameof(owner), "Property is not nullable for class WebCodeSensitiveDetail.");

            if (rawAuthor.IsSet && rawAuthor.Value == null)
                throw new ArgumentNullException(nameof(rawAuthor), "Property is not nullable for class WebCodeSensitiveDetail.");

            if (reopenAt.IsSet && reopenAt.Value == null)
                throw new ArgumentNullException(nameof(reopenAt), "Property is not nullable for class WebCodeSensitiveDetail.");

            if (reopenHandler.IsSet && reopenHandler.Value == null)
                throw new ArgumentNullException(nameof(reopenHandler), "Property is not nullable for class WebCodeSensitiveDetail.");

            if (revision.IsSet && revision.Value == null)
                throw new ArgumentNullException(nameof(revision), "Property is not nullable for class WebCodeSensitiveDetail.");

            if (riskLevel.IsSet && riskLevel.Value == null)
                throw new ArgumentNullException(nameof(riskLevel), "Property is not nullable for class WebCodeSensitiveDetail.");

            if (state.IsSet && state.Value == null)
                throw new ArgumentNullException(nameof(state), "Property is not nullable for class WebCodeSensitiveDetail.");

            if (tool.IsSet && tool.Value == null)
                throw new ArgumentNullException(nameof(tool), "Property is not nullable for class WebCodeSensitiveDetail.");

            return new WebCodeSensitiveDetail(createdAt, fileName, filePath, handler, id, ignoreReason, ignoredAt, issueDetail, issueSubType, issueType, lineNo, occurVersion, owner, rawAuthor, reopenAt, reopenHandler, revision, riskLevel, state, tool);
        }

        /// <summary>
        /// Serializes a <see cref="WebCodeSensitiveDetail" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="webCodeSensitiveDetail"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, WebCodeSensitiveDetail webCodeSensitiveDetail, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, webCodeSensitiveDetail, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="WebCodeSensitiveDetail" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="webCodeSensitiveDetail"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, WebCodeSensitiveDetail webCodeSensitiveDetail, JsonSerializerOptions jsonSerializerOptions)
        {
            if (webCodeSensitiveDetail.CreatedAtOption.IsSet && webCodeSensitiveDetail.CreatedAt == null)
                throw new ArgumentNullException(nameof(webCodeSensitiveDetail.CreatedAt), "Property is required for class WebCodeSensitiveDetail.");

            if (webCodeSensitiveDetail.FileNameOption.IsSet && webCodeSensitiveDetail.FileName == null)
                throw new ArgumentNullException(nameof(webCodeSensitiveDetail.FileName), "Property is required for class WebCodeSensitiveDetail.");

            if (webCodeSensitiveDetail.FilePathOption.IsSet && webCodeSensitiveDetail.FilePath == null)
                throw new ArgumentNullException(nameof(webCodeSensitiveDetail.FilePath), "Property is required for class WebCodeSensitiveDetail.");

            if (webCodeSensitiveDetail.HandlerOption.IsSet && webCodeSensitiveDetail.Handler == null)
                throw new ArgumentNullException(nameof(webCodeSensitiveDetail.Handler), "Property is required for class WebCodeSensitiveDetail.");

            if (webCodeSensitiveDetail.IdOption.IsSet && webCodeSensitiveDetail.Id == null)
                throw new ArgumentNullException(nameof(webCodeSensitiveDetail.Id), "Property is required for class WebCodeSensitiveDetail.");

            if (webCodeSensitiveDetail.IgnoreReasonOption.IsSet && webCodeSensitiveDetail.IgnoreReason == null)
                throw new ArgumentNullException(nameof(webCodeSensitiveDetail.IgnoreReason), "Property is required for class WebCodeSensitiveDetail.");

            if (webCodeSensitiveDetail.IgnoredAtOption.IsSet && webCodeSensitiveDetail.IgnoredAt == null)
                throw new ArgumentNullException(nameof(webCodeSensitiveDetail.IgnoredAt), "Property is required for class WebCodeSensitiveDetail.");

            if (webCodeSensitiveDetail.IssueDetailOption.IsSet && webCodeSensitiveDetail.IssueDetail == null)
                throw new ArgumentNullException(nameof(webCodeSensitiveDetail.IssueDetail), "Property is required for class WebCodeSensitiveDetail.");

            if (webCodeSensitiveDetail.IssueSubTypeOption.IsSet && webCodeSensitiveDetail.IssueSubType == null)
                throw new ArgumentNullException(nameof(webCodeSensitiveDetail.IssueSubType), "Property is required for class WebCodeSensitiveDetail.");

            if (webCodeSensitiveDetail.IssueTypeOption.IsSet && webCodeSensitiveDetail.IssueType == null)
                throw new ArgumentNullException(nameof(webCodeSensitiveDetail.IssueType), "Property is required for class WebCodeSensitiveDetail.");

            if (webCodeSensitiveDetail.LineNoOption.IsSet && webCodeSensitiveDetail.LineNo == null)
                throw new ArgumentNullException(nameof(webCodeSensitiveDetail.LineNo), "Property is required for class WebCodeSensitiveDetail.");

            if (webCodeSensitiveDetail.OccurVersionOption.IsSet && webCodeSensitiveDetail.OccurVersion == null)
                throw new ArgumentNullException(nameof(webCodeSensitiveDetail.OccurVersion), "Property is required for class WebCodeSensitiveDetail.");

            if (webCodeSensitiveDetail.OwnerOption.IsSet && webCodeSensitiveDetail.Owner == null)
                throw new ArgumentNullException(nameof(webCodeSensitiveDetail.Owner), "Property is required for class WebCodeSensitiveDetail.");

            if (webCodeSensitiveDetail.RawAuthorOption.IsSet && webCodeSensitiveDetail.RawAuthor == null)
                throw new ArgumentNullException(nameof(webCodeSensitiveDetail.RawAuthor), "Property is required for class WebCodeSensitiveDetail.");

            if (webCodeSensitiveDetail.ReopenAtOption.IsSet && webCodeSensitiveDetail.ReopenAt == null)
                throw new ArgumentNullException(nameof(webCodeSensitiveDetail.ReopenAt), "Property is required for class WebCodeSensitiveDetail.");

            if (webCodeSensitiveDetail.ReopenHandlerOption.IsSet && webCodeSensitiveDetail.ReopenHandler == null)
                throw new ArgumentNullException(nameof(webCodeSensitiveDetail.ReopenHandler), "Property is required for class WebCodeSensitiveDetail.");

            if (webCodeSensitiveDetail.RevisionOption.IsSet && webCodeSensitiveDetail.Revision == null)
                throw new ArgumentNullException(nameof(webCodeSensitiveDetail.Revision), "Property is required for class WebCodeSensitiveDetail.");

            if (webCodeSensitiveDetail.RiskLevelOption.IsSet && webCodeSensitiveDetail.RiskLevel == null)
                throw new ArgumentNullException(nameof(webCodeSensitiveDetail.RiskLevel), "Property is required for class WebCodeSensitiveDetail.");

            if (webCodeSensitiveDetail.StateOption.IsSet && webCodeSensitiveDetail.State == null)
                throw new ArgumentNullException(nameof(webCodeSensitiveDetail.State), "Property is required for class WebCodeSensitiveDetail.");

            if (webCodeSensitiveDetail.ToolOption.IsSet && webCodeSensitiveDetail.Tool == null)
                throw new ArgumentNullException(nameof(webCodeSensitiveDetail.Tool), "Property is required for class WebCodeSensitiveDetail.");

            if (webCodeSensitiveDetail.CreatedAtOption.IsSet)
                writer.WriteString("created_at", webCodeSensitiveDetail.CreatedAt);

            if (webCodeSensitiveDetail.FileNameOption.IsSet)
                writer.WriteString("file_name", webCodeSensitiveDetail.FileName);

            if (webCodeSensitiveDetail.FilePathOption.IsSet)
                writer.WriteString("file_path", webCodeSensitiveDetail.FilePath);

            if (webCodeSensitiveDetail.HandlerOption.IsSet)
            {
                writer.WritePropertyName("handler");
                JsonSerializer.Serialize(writer, webCodeSensitiveDetail.Handler, jsonSerializerOptions);
            }
            if (webCodeSensitiveDetail.IdOption.IsSet)
                writer.WriteString("id", webCodeSensitiveDetail.Id);

            if (webCodeSensitiveDetail.IgnoreReasonOption.IsSet)
                writer.WriteString("ignore_reason", webCodeSensitiveDetail.IgnoreReason);

            if (webCodeSensitiveDetail.IgnoredAtOption.IsSet)
                writer.WriteString("ignored_at", webCodeSensitiveDetail.IgnoredAt);

            if (webCodeSensitiveDetail.IssueDetailOption.IsSet)
            {
                writer.WritePropertyName("issue_detail");
                JsonSerializer.Serialize(writer, webCodeSensitiveDetail.IssueDetail, jsonSerializerOptions);
            }
            if (webCodeSensitiveDetail.IssueSubTypeOption.IsSet)
                writer.WriteString("issue_sub_type", webCodeSensitiveDetail.IssueSubType);

            if (webCodeSensitiveDetail.IssueTypeOption.IsSet)
                writer.WriteString("issue_type", webCodeSensitiveDetail.IssueType);

            if (webCodeSensitiveDetail.LineNoOption.IsSet)
            {
                writer.WritePropertyName("line_no");
                JsonSerializer.Serialize(writer, webCodeSensitiveDetail.LineNo, jsonSerializerOptions);
            }
            if (webCodeSensitiveDetail.OccurVersionOption.IsSet)
                writer.WriteString("occur_version", webCodeSensitiveDetail.OccurVersion);

            if (webCodeSensitiveDetail.OwnerOption.IsSet)
            {
                writer.WritePropertyName("owner");
                JsonSerializer.Serialize(writer, webCodeSensitiveDetail.Owner, jsonSerializerOptions);
            }
            if (webCodeSensitiveDetail.RawAuthorOption.IsSet)
            {
                writer.WritePropertyName("raw_author");
                JsonSerializer.Serialize(writer, webCodeSensitiveDetail.RawAuthor, jsonSerializerOptions);
            }
            if (webCodeSensitiveDetail.ReopenAtOption.IsSet)
                writer.WriteString("reopen_at", webCodeSensitiveDetail.ReopenAt);

            if (webCodeSensitiveDetail.ReopenHandlerOption.IsSet)
            {
                writer.WritePropertyName("reopen_handler");
                JsonSerializer.Serialize(writer, webCodeSensitiveDetail.ReopenHandler, jsonSerializerOptions);
            }
            if (webCodeSensitiveDetail.RevisionOption.IsSet)
                writer.WriteString("revision", webCodeSensitiveDetail.Revision);

            if (webCodeSensitiveDetail.RiskLevelOption.IsSet)
                writer.WriteString("risk_level", webCodeSensitiveDetail.RiskLevel);

            if (webCodeSensitiveDetail.StateOption.IsSet)
                writer.WriteString("state", webCodeSensitiveDetail.State);

            if (webCodeSensitiveDetail.ToolOption.IsSet)
                writer.WriteString("tool", webCodeSensitiveDetail.Tool);
        }
    }
}
