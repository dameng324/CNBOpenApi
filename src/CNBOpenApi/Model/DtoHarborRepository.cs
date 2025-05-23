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
    /// DtoHarborRepository
    /// </summary>
    public partial class DtoHarborRepository : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DtoHarborRepository" /> class.
        /// </summary>
        /// <param name="description">The description of the repository</param>
        /// <param name="labels">The repository labels</param>
        /// <param name="pushTime">The push time of the artifact inside the repository Format: date-time</param>
        /// <param name="pusherId">The ID of the pusher who push the artifact.</param>
        /// <param name="recentPullCount">The count that the artifact inside the repository recent pulled</param>
        [JsonConstructor]
        public DtoHarborRepository(Option<string?> description = default, Option<List<string>?> labels = default, Option<string?> pushTime = default, Option<int?> pusherId = default, Option<int?> recentPullCount = default)
        {
            DescriptionOption = description;
            LabelsOption = labels;
            PushTimeOption = pushTime;
            PusherIdOption = pusherId;
            RecentPullCountOption = recentPullCount;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Used to track the state of Description
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> DescriptionOption { get; private set; }

        /// <summary>
        /// The description of the repository
        /// </summary>
        /// <value>The description of the repository</value>
        [JsonPropertyName("description")]
        public string? Description { get { return this.DescriptionOption; } set { this.DescriptionOption = new(value); } }

        /// <summary>
        /// Used to track the state of Labels
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<List<string>?> LabelsOption { get; private set; }

        /// <summary>
        /// The repository labels
        /// </summary>
        /// <value>The repository labels</value>
        [JsonPropertyName("labels")]
        public List<string>? Labels { get { return this.LabelsOption; } set { this.LabelsOption = new(value); } }

        /// <summary>
        /// Used to track the state of PushTime
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> PushTimeOption { get; private set; }

        /// <summary>
        /// The push time of the artifact inside the repository Format: date-time
        /// </summary>
        /// <value>The push time of the artifact inside the repository Format: date-time</value>
        [JsonPropertyName("push_time")]
        public string? PushTime { get { return this.PushTimeOption; } set { this.PushTimeOption = new(value); } }

        /// <summary>
        /// Used to track the state of PusherId
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<int?> PusherIdOption { get; private set; }

        /// <summary>
        /// The ID of the pusher who push the artifact.
        /// </summary>
        /// <value>The ID of the pusher who push the artifact.</value>
        [JsonPropertyName("pusher_id")]
        public int? PusherId { get { return this.PusherIdOption; } set { this.PusherIdOption = new(value); } }

        /// <summary>
        /// Used to track the state of RecentPullCount
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<int?> RecentPullCountOption { get; private set; }

        /// <summary>
        /// The count that the artifact inside the repository recent pulled
        /// </summary>
        /// <value>The count that the artifact inside the repository recent pulled</value>
        [JsonPropertyName("recent_pull_count")]
        public int? RecentPullCount { get { return this.RecentPullCountOption; } set { this.RecentPullCountOption = new(value); } }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DtoHarborRepository {\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Labels: ").Append(Labels).Append("\n");
            sb.Append("  PushTime: ").Append(PushTime).Append("\n");
            sb.Append("  PusherId: ").Append(PusherId).Append("\n");
            sb.Append("  RecentPullCount: ").Append(RecentPullCount).Append("\n");
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
    /// A Json converter for type <see cref="DtoHarborRepository" />
    /// </summary>
    public class DtoHarborRepositoryJsonConverter : JsonConverter<DtoHarborRepository>
    {
        /// <summary>
        /// Deserializes json to <see cref="DtoHarborRepository" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override DtoHarborRepository Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<string?> description = default;
            Option<List<string>?> labels = default;
            Option<string?> pushTime = default;
            Option<int?> pusherId = default;
            Option<int?> recentPullCount = default;

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
                        case "description":
                            description = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "labels":
                            labels = new Option<List<string>?>(JsonSerializer.Deserialize<List<string>>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        case "push_time":
                            pushTime = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "pusher_id":
                            pusherId = new Option<int?>(utf8JsonReader.TokenType == JsonTokenType.Null ? (int?)null : utf8JsonReader.GetInt32());
                            break;
                        case "recent_pull_count":
                            recentPullCount = new Option<int?>(utf8JsonReader.TokenType == JsonTokenType.Null ? (int?)null : utf8JsonReader.GetInt32());
                            break;
                        default:
                            break;
                    }
                }
            }

            if (description.IsSet && description.Value == null)
                throw new ArgumentNullException(nameof(description), "Property is not nullable for class DtoHarborRepository.");

            if (labels.IsSet && labels.Value == null)
                throw new ArgumentNullException(nameof(labels), "Property is not nullable for class DtoHarborRepository.");

            if (pushTime.IsSet && pushTime.Value == null)
                throw new ArgumentNullException(nameof(pushTime), "Property is not nullable for class DtoHarborRepository.");

            if (pusherId.IsSet && pusherId.Value == null)
                throw new ArgumentNullException(nameof(pusherId), "Property is not nullable for class DtoHarborRepository.");

            if (recentPullCount.IsSet && recentPullCount.Value == null)
                throw new ArgumentNullException(nameof(recentPullCount), "Property is not nullable for class DtoHarborRepository.");

            return new DtoHarborRepository(description, labels, pushTime, pusherId, recentPullCount);
        }

        /// <summary>
        /// Serializes a <see cref="DtoHarborRepository" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="dtoHarborRepository"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, DtoHarborRepository dtoHarborRepository, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, dtoHarborRepository, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="DtoHarborRepository" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="dtoHarborRepository"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, DtoHarborRepository dtoHarborRepository, JsonSerializerOptions jsonSerializerOptions)
        {
            if (dtoHarborRepository.DescriptionOption.IsSet && dtoHarborRepository.Description == null)
                throw new ArgumentNullException(nameof(dtoHarborRepository.Description), "Property is required for class DtoHarborRepository.");

            if (dtoHarborRepository.LabelsOption.IsSet && dtoHarborRepository.Labels == null)
                throw new ArgumentNullException(nameof(dtoHarborRepository.Labels), "Property is required for class DtoHarborRepository.");

            if (dtoHarborRepository.PushTimeOption.IsSet && dtoHarborRepository.PushTime == null)
                throw new ArgumentNullException(nameof(dtoHarborRepository.PushTime), "Property is required for class DtoHarborRepository.");

            if (dtoHarborRepository.DescriptionOption.IsSet)
                writer.WriteString("description", dtoHarborRepository.Description);

            if (dtoHarborRepository.LabelsOption.IsSet)
            {
                writer.WritePropertyName("labels");
                JsonSerializer.Serialize(writer, dtoHarborRepository.Labels, jsonSerializerOptions);
            }
            if (dtoHarborRepository.PushTimeOption.IsSet)
                writer.WriteString("push_time", dtoHarborRepository.PushTime);

            if (dtoHarborRepository.PusherIdOption.IsSet)
                writer.WriteNumber("pusher_id", dtoHarborRepository.PusherIdOption.Value!.Value);

            if (dtoHarborRepository.RecentPullCountOption.IsSet)
                writer.WriteNumber("recent_pull_count", dtoHarborRepository.RecentPullCountOption.Value!.Value);
        }
    }
}
