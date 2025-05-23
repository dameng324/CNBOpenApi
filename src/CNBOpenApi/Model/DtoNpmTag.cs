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
    /// DtoNpmTag
    /// </summary>
    public partial class DtoNpmTag : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DtoNpmTag" /> class.
        /// </summary>
        /// <param name="desc">desc</param>
        /// <param name="digest">digest</param>
        /// <param name="lastPusher">lastPusher</param>
        /// <param name="name">name</param>
        /// <param name="pullCount">pullCount</param>
        /// <param name="recentPullCount">recentPullCount</param>
        /// <param name="size">size</param>
        /// <param name="status">status</param>
        [JsonConstructor]
        public DtoNpmTag(Option<string?> desc = default, Option<string?> digest = default, Option<DtoLastPusher?> lastPusher = default, Option<string?> name = default, Option<int?> pullCount = default, Option<int?> recentPullCount = default, Option<int?> size = default, Option<string?> status = default)
        {
            DescOption = desc;
            DigestOption = digest;
            LastPusherOption = lastPusher;
            NameOption = name;
            PullCountOption = pullCount;
            RecentPullCountOption = recentPullCount;
            SizeOption = size;
            StatusOption = status;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Used to track the state of Desc
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> DescOption { get; private set; }

        /// <summary>
        /// Gets or Sets Desc
        /// </summary>
        [JsonPropertyName("desc")]
        public string? Desc { get { return this.DescOption; } set { this.DescOption = new(value); } }

        /// <summary>
        /// Used to track the state of Digest
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> DigestOption { get; private set; }

        /// <summary>
        /// Gets or Sets Digest
        /// </summary>
        [JsonPropertyName("digest")]
        public string? Digest { get { return this.DigestOption; } set { this.DigestOption = new(value); } }

        /// <summary>
        /// Used to track the state of LastPusher
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<DtoLastPusher?> LastPusherOption { get; private set; }

        /// <summary>
        /// Gets or Sets LastPusher
        /// </summary>
        [JsonPropertyName("last_pusher")]
        public DtoLastPusher? LastPusher { get { return this.LastPusherOption; } set { this.LastPusherOption = new(value); } }

        /// <summary>
        /// Used to track the state of Name
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> NameOption { get; private set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [JsonPropertyName("name")]
        public string? Name { get { return this.NameOption; } set { this.NameOption = new(value); } }

        /// <summary>
        /// Used to track the state of PullCount
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<int?> PullCountOption { get; private set; }

        /// <summary>
        /// Gets or Sets PullCount
        /// </summary>
        [JsonPropertyName("pull_count")]
        public int? PullCount { get { return this.PullCountOption; } set { this.PullCountOption = new(value); } }

        /// <summary>
        /// Used to track the state of RecentPullCount
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<int?> RecentPullCountOption { get; private set; }

        /// <summary>
        /// Gets or Sets RecentPullCount
        /// </summary>
        [JsonPropertyName("recent_pull_count")]
        public int? RecentPullCount { get { return this.RecentPullCountOption; } set { this.RecentPullCountOption = new(value); } }

        /// <summary>
        /// Used to track the state of Size
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<int?> SizeOption { get; private set; }

        /// <summary>
        /// Gets or Sets Size
        /// </summary>
        [JsonPropertyName("size")]
        public int? Size { get { return this.SizeOption; } set { this.SizeOption = new(value); } }

        /// <summary>
        /// Used to track the state of Status
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> StatusOption { get; private set; }

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [JsonPropertyName("status")]
        public string? Status { get { return this.StatusOption; } set { this.StatusOption = new(value); } }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DtoNpmTag {\n");
            sb.Append("  Desc: ").Append(Desc).Append("\n");
            sb.Append("  Digest: ").Append(Digest).Append("\n");
            sb.Append("  LastPusher: ").Append(LastPusher).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  PullCount: ").Append(PullCount).Append("\n");
            sb.Append("  RecentPullCount: ").Append(RecentPullCount).Append("\n");
            sb.Append("  Size: ").Append(Size).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
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
    /// A Json converter for type <see cref="DtoNpmTag" />
    /// </summary>
    public class DtoNpmTagJsonConverter : JsonConverter<DtoNpmTag>
    {
        /// <summary>
        /// Deserializes json to <see cref="DtoNpmTag" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override DtoNpmTag Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<string?> desc = default;
            Option<string?> digest = default;
            Option<DtoLastPusher?> lastPusher = default;
            Option<string?> name = default;
            Option<int?> pullCount = default;
            Option<int?> recentPullCount = default;
            Option<int?> size = default;
            Option<string?> status = default;

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
                        case "desc":
                            desc = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "digest":
                            digest = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "last_pusher":
                            lastPusher = new Option<DtoLastPusher?>(JsonSerializer.Deserialize<DtoLastPusher>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        case "name":
                            name = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "pull_count":
                            pullCount = new Option<int?>(utf8JsonReader.TokenType == JsonTokenType.Null ? (int?)null : utf8JsonReader.GetInt32());
                            break;
                        case "recent_pull_count":
                            recentPullCount = new Option<int?>(utf8JsonReader.TokenType == JsonTokenType.Null ? (int?)null : utf8JsonReader.GetInt32());
                            break;
                        case "size":
                            size = new Option<int?>(utf8JsonReader.TokenType == JsonTokenType.Null ? (int?)null : utf8JsonReader.GetInt32());
                            break;
                        case "status":
                            status = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        default:
                            break;
                    }
                }
            }

            if (desc.IsSet && desc.Value == null)
                throw new ArgumentNullException(nameof(desc), "Property is not nullable for class DtoNpmTag.");

            if (digest.IsSet && digest.Value == null)
                throw new ArgumentNullException(nameof(digest), "Property is not nullable for class DtoNpmTag.");

            if (lastPusher.IsSet && lastPusher.Value == null)
                throw new ArgumentNullException(nameof(lastPusher), "Property is not nullable for class DtoNpmTag.");

            if (name.IsSet && name.Value == null)
                throw new ArgumentNullException(nameof(name), "Property is not nullable for class DtoNpmTag.");

            if (pullCount.IsSet && pullCount.Value == null)
                throw new ArgumentNullException(nameof(pullCount), "Property is not nullable for class DtoNpmTag.");

            if (recentPullCount.IsSet && recentPullCount.Value == null)
                throw new ArgumentNullException(nameof(recentPullCount), "Property is not nullable for class DtoNpmTag.");

            if (size.IsSet && size.Value == null)
                throw new ArgumentNullException(nameof(size), "Property is not nullable for class DtoNpmTag.");

            if (status.IsSet && status.Value == null)
                throw new ArgumentNullException(nameof(status), "Property is not nullable for class DtoNpmTag.");

            return new DtoNpmTag(desc, digest, lastPusher, name, pullCount, recentPullCount, size, status);
        }

        /// <summary>
        /// Serializes a <see cref="DtoNpmTag" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="dtoNpmTag"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, DtoNpmTag dtoNpmTag, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, dtoNpmTag, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="DtoNpmTag" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="dtoNpmTag"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, DtoNpmTag dtoNpmTag, JsonSerializerOptions jsonSerializerOptions)
        {
            if (dtoNpmTag.DescOption.IsSet && dtoNpmTag.Desc == null)
                throw new ArgumentNullException(nameof(dtoNpmTag.Desc), "Property is required for class DtoNpmTag.");

            if (dtoNpmTag.DigestOption.IsSet && dtoNpmTag.Digest == null)
                throw new ArgumentNullException(nameof(dtoNpmTag.Digest), "Property is required for class DtoNpmTag.");

            if (dtoNpmTag.LastPusherOption.IsSet && dtoNpmTag.LastPusher == null)
                throw new ArgumentNullException(nameof(dtoNpmTag.LastPusher), "Property is required for class DtoNpmTag.");

            if (dtoNpmTag.NameOption.IsSet && dtoNpmTag.Name == null)
                throw new ArgumentNullException(nameof(dtoNpmTag.Name), "Property is required for class DtoNpmTag.");

            if (dtoNpmTag.StatusOption.IsSet && dtoNpmTag.Status == null)
                throw new ArgumentNullException(nameof(dtoNpmTag.Status), "Property is required for class DtoNpmTag.");

            if (dtoNpmTag.DescOption.IsSet)
                writer.WriteString("desc", dtoNpmTag.Desc);

            if (dtoNpmTag.DigestOption.IsSet)
                writer.WriteString("digest", dtoNpmTag.Digest);

            if (dtoNpmTag.LastPusherOption.IsSet)
            {
                writer.WritePropertyName("last_pusher");
                JsonSerializer.Serialize(writer, dtoNpmTag.LastPusher, jsonSerializerOptions);
            }
            if (dtoNpmTag.NameOption.IsSet)
                writer.WriteString("name", dtoNpmTag.Name);

            if (dtoNpmTag.PullCountOption.IsSet)
                writer.WriteNumber("pull_count", dtoNpmTag.PullCountOption.Value!.Value);

            if (dtoNpmTag.RecentPullCountOption.IsSet)
                writer.WriteNumber("recent_pull_count", dtoNpmTag.RecentPullCountOption.Value!.Value);

            if (dtoNpmTag.SizeOption.IsSet)
                writer.WriteNumber("size", dtoNpmTag.SizeOption.Value!.Value);

            if (dtoNpmTag.StatusOption.IsSet)
                writer.WriteString("status", dtoNpmTag.Status);
        }
    }
}
