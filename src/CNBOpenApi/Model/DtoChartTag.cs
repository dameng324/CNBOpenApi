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
    /// DtoChartTag
    /// </summary>
    public partial class DtoChartTag : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DtoChartTag" /> class.
        /// </summary>
        /// <param name="address">address</param>
        /// <param name="digest">digest</param>
        /// <param name="isDeprecated">isDeprecated</param>
        /// <param name="lastPusher">lastPusher</param>
        /// <param name="metadata">metadata</param>
        /// <param name="name">name</param>
        /// <param name="pullCount">pullCount</param>
        /// <param name="recentPullCount">recentPullCount</param>
        /// <param name="size">size</param>
        [JsonConstructor]
        public DtoChartTag(Option<string?> address = default, Option<string?> digest = default, Option<bool?> isDeprecated = default, Option<DtoLastPusher?> lastPusher = default, Option<ChartMetadata?> metadata = default, Option<string?> name = default, Option<int?> pullCount = default, Option<int?> recentPullCount = default, Option<int?> size = default)
        {
            AddressOption = address;
            DigestOption = digest;
            IsDeprecatedOption = isDeprecated;
            LastPusherOption = lastPusher;
            MetadataOption = metadata;
            NameOption = name;
            PullCountOption = pullCount;
            RecentPullCountOption = recentPullCount;
            SizeOption = size;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Used to track the state of Address
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> AddressOption { get; private set; }

        /// <summary>
        /// Gets or Sets Address
        /// </summary>
        [JsonPropertyName("address")]
        public string? Address { get { return this.AddressOption; } set { this.AddressOption = new(value); } }

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
        /// Used to track the state of IsDeprecated
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<bool?> IsDeprecatedOption { get; private set; }

        /// <summary>
        /// Gets or Sets IsDeprecated
        /// </summary>
        [JsonPropertyName("is_deprecated")]
        public bool? IsDeprecated { get { return this.IsDeprecatedOption; } set { this.IsDeprecatedOption = new(value); } }

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
        /// Used to track the state of Metadata
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<ChartMetadata?> MetadataOption { get; private set; }

        /// <summary>
        /// Gets or Sets Metadata
        /// </summary>
        [JsonPropertyName("metadata")]
        public ChartMetadata? Metadata { get { return this.MetadataOption; } set { this.MetadataOption = new(value); } }

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
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DtoChartTag {\n");
            sb.Append("  Address: ").Append(Address).Append("\n");
            sb.Append("  Digest: ").Append(Digest).Append("\n");
            sb.Append("  IsDeprecated: ").Append(IsDeprecated).Append("\n");
            sb.Append("  LastPusher: ").Append(LastPusher).Append("\n");
            sb.Append("  Metadata: ").Append(Metadata).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  PullCount: ").Append(PullCount).Append("\n");
            sb.Append("  RecentPullCount: ").Append(RecentPullCount).Append("\n");
            sb.Append("  Size: ").Append(Size).Append("\n");
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
    /// A Json converter for type <see cref="DtoChartTag" />
    /// </summary>
    public class DtoChartTagJsonConverter : JsonConverter<DtoChartTag>
    {
        /// <summary>
        /// Deserializes json to <see cref="DtoChartTag" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override DtoChartTag Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<string?> address = default;
            Option<string?> digest = default;
            Option<bool?> isDeprecated = default;
            Option<DtoLastPusher?> lastPusher = default;
            Option<ChartMetadata?> metadata = default;
            Option<string?> name = default;
            Option<int?> pullCount = default;
            Option<int?> recentPullCount = default;
            Option<int?> size = default;

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
                        case "address":
                            address = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "digest":
                            digest = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "is_deprecated":
                            isDeprecated = new Option<bool?>(utf8JsonReader.TokenType == JsonTokenType.Null ? (bool?)null : utf8JsonReader.GetBoolean());
                            break;
                        case "last_pusher":
                            lastPusher = new Option<DtoLastPusher?>(JsonSerializer.Deserialize<DtoLastPusher>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        case "metadata":
                            metadata = new Option<ChartMetadata?>(JsonSerializer.Deserialize<ChartMetadata>(ref utf8JsonReader, jsonSerializerOptions)!);
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
                        default:
                            break;
                    }
                }
            }

            if (address.IsSet && address.Value == null)
                throw new ArgumentNullException(nameof(address), "Property is not nullable for class DtoChartTag.");

            if (digest.IsSet && digest.Value == null)
                throw new ArgumentNullException(nameof(digest), "Property is not nullable for class DtoChartTag.");

            if (isDeprecated.IsSet && isDeprecated.Value == null)
                throw new ArgumentNullException(nameof(isDeprecated), "Property is not nullable for class DtoChartTag.");

            if (lastPusher.IsSet && lastPusher.Value == null)
                throw new ArgumentNullException(nameof(lastPusher), "Property is not nullable for class DtoChartTag.");

            if (metadata.IsSet && metadata.Value == null)
                throw new ArgumentNullException(nameof(metadata), "Property is not nullable for class DtoChartTag.");

            if (name.IsSet && name.Value == null)
                throw new ArgumentNullException(nameof(name), "Property is not nullable for class DtoChartTag.");

            if (pullCount.IsSet && pullCount.Value == null)
                throw new ArgumentNullException(nameof(pullCount), "Property is not nullable for class DtoChartTag.");

            if (recentPullCount.IsSet && recentPullCount.Value == null)
                throw new ArgumentNullException(nameof(recentPullCount), "Property is not nullable for class DtoChartTag.");

            if (size.IsSet && size.Value == null)
                throw new ArgumentNullException(nameof(size), "Property is not nullable for class DtoChartTag.");

            return new DtoChartTag(address, digest, isDeprecated, lastPusher, metadata, name, pullCount, recentPullCount, size);
        }

        /// <summary>
        /// Serializes a <see cref="DtoChartTag" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="dtoChartTag"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, DtoChartTag dtoChartTag, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, dtoChartTag, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="DtoChartTag" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="dtoChartTag"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, DtoChartTag dtoChartTag, JsonSerializerOptions jsonSerializerOptions)
        {
            if (dtoChartTag.AddressOption.IsSet && dtoChartTag.Address == null)
                throw new ArgumentNullException(nameof(dtoChartTag.Address), "Property is required for class DtoChartTag.");

            if (dtoChartTag.DigestOption.IsSet && dtoChartTag.Digest == null)
                throw new ArgumentNullException(nameof(dtoChartTag.Digest), "Property is required for class DtoChartTag.");

            if (dtoChartTag.LastPusherOption.IsSet && dtoChartTag.LastPusher == null)
                throw new ArgumentNullException(nameof(dtoChartTag.LastPusher), "Property is required for class DtoChartTag.");

            if (dtoChartTag.MetadataOption.IsSet && dtoChartTag.Metadata == null)
                throw new ArgumentNullException(nameof(dtoChartTag.Metadata), "Property is required for class DtoChartTag.");

            if (dtoChartTag.NameOption.IsSet && dtoChartTag.Name == null)
                throw new ArgumentNullException(nameof(dtoChartTag.Name), "Property is required for class DtoChartTag.");

            if (dtoChartTag.AddressOption.IsSet)
                writer.WriteString("address", dtoChartTag.Address);

            if (dtoChartTag.DigestOption.IsSet)
                writer.WriteString("digest", dtoChartTag.Digest);

            if (dtoChartTag.IsDeprecatedOption.IsSet)
                writer.WriteBoolean("is_deprecated", dtoChartTag.IsDeprecatedOption.Value!.Value);

            if (dtoChartTag.LastPusherOption.IsSet)
            {
                writer.WritePropertyName("last_pusher");
                JsonSerializer.Serialize(writer, dtoChartTag.LastPusher, jsonSerializerOptions);
            }
            if (dtoChartTag.MetadataOption.IsSet)
            {
                writer.WritePropertyName("metadata");
                JsonSerializer.Serialize(writer, dtoChartTag.Metadata, jsonSerializerOptions);
            }
            if (dtoChartTag.NameOption.IsSet)
                writer.WriteString("name", dtoChartTag.Name);

            if (dtoChartTag.PullCountOption.IsSet)
                writer.WriteNumber("pull_count", dtoChartTag.PullCountOption.Value!.Value);

            if (dtoChartTag.RecentPullCountOption.IsSet)
                writer.WriteNumber("recent_pull_count", dtoChartTag.RecentPullCountOption.Value!.Value);

            if (dtoChartTag.SizeOption.IsSet)
                writer.WriteNumber("size", dtoChartTag.SizeOption.Value!.Value);
        }
    }
}
