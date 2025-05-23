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
    /// DtoGetActivityMineDetailRsp
    /// </summary>
    public partial class DtoGetActivityMineDetailRsp : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DtoGetActivityMineDetailRsp" /> class.
        /// </summary>
        /// <param name="activityMineDatas">activityMineDatas</param>
        /// <param name="nextOffset">nextOffset</param>
        [JsonConstructor]
        public DtoGetActivityMineDetailRsp(Option<List<DtoActivityMineData>?> activityMineDatas = default, Option<string?> nextOffset = default)
        {
            ActivityMineDatasOption = activityMineDatas;
            NextOffsetOption = nextOffset;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Used to track the state of ActivityMineDatas
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<List<DtoActivityMineData>?> ActivityMineDatasOption { get; private set; }

        /// <summary>
        /// Gets or Sets ActivityMineDatas
        /// </summary>
        [JsonPropertyName("activity_mine_datas")]
        public List<DtoActivityMineData>? ActivityMineDatas { get { return this.ActivityMineDatasOption; } set { this.ActivityMineDatasOption = new(value); } }

        /// <summary>
        /// Used to track the state of NextOffset
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> NextOffsetOption { get; private set; }

        /// <summary>
        /// Gets or Sets NextOffset
        /// </summary>
        [JsonPropertyName("next_offset")]
        public string? NextOffset { get { return this.NextOffsetOption; } set { this.NextOffsetOption = new(value); } }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DtoGetActivityMineDetailRsp {\n");
            sb.Append("  ActivityMineDatas: ").Append(ActivityMineDatas).Append("\n");
            sb.Append("  NextOffset: ").Append(NextOffset).Append("\n");
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
    /// A Json converter for type <see cref="DtoGetActivityMineDetailRsp" />
    /// </summary>
    public class DtoGetActivityMineDetailRspJsonConverter : JsonConverter<DtoGetActivityMineDetailRsp>
    {
        /// <summary>
        /// Deserializes json to <see cref="DtoGetActivityMineDetailRsp" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override DtoGetActivityMineDetailRsp Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<List<DtoActivityMineData>?> activityMineDatas = default;
            Option<string?> nextOffset = default;

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
                        case "activity_mine_datas":
                            activityMineDatas = new Option<List<DtoActivityMineData>?>(JsonSerializer.Deserialize<List<DtoActivityMineData>>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        case "next_offset":
                            nextOffset = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        default:
                            break;
                    }
                }
            }

            if (activityMineDatas.IsSet && activityMineDatas.Value == null)
                throw new ArgumentNullException(nameof(activityMineDatas), "Property is not nullable for class DtoGetActivityMineDetailRsp.");

            if (nextOffset.IsSet && nextOffset.Value == null)
                throw new ArgumentNullException(nameof(nextOffset), "Property is not nullable for class DtoGetActivityMineDetailRsp.");

            return new DtoGetActivityMineDetailRsp(activityMineDatas, nextOffset);
        }

        /// <summary>
        /// Serializes a <see cref="DtoGetActivityMineDetailRsp" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="dtoGetActivityMineDetailRsp"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, DtoGetActivityMineDetailRsp dtoGetActivityMineDetailRsp, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, dtoGetActivityMineDetailRsp, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="DtoGetActivityMineDetailRsp" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="dtoGetActivityMineDetailRsp"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, DtoGetActivityMineDetailRsp dtoGetActivityMineDetailRsp, JsonSerializerOptions jsonSerializerOptions)
        {
            if (dtoGetActivityMineDetailRsp.ActivityMineDatasOption.IsSet && dtoGetActivityMineDetailRsp.ActivityMineDatas == null)
                throw new ArgumentNullException(nameof(dtoGetActivityMineDetailRsp.ActivityMineDatas), "Property is required for class DtoGetActivityMineDetailRsp.");

            if (dtoGetActivityMineDetailRsp.NextOffsetOption.IsSet && dtoGetActivityMineDetailRsp.NextOffset == null)
                throw new ArgumentNullException(nameof(dtoGetActivityMineDetailRsp.NextOffset), "Property is required for class DtoGetActivityMineDetailRsp.");

            if (dtoGetActivityMineDetailRsp.ActivityMineDatasOption.IsSet)
            {
                writer.WritePropertyName("activity_mine_datas");
                JsonSerializer.Serialize(writer, dtoGetActivityMineDetailRsp.ActivityMineDatas, jsonSerializerOptions);
            }
            if (dtoGetActivityMineDetailRsp.NextOffsetOption.IsSet)
                writer.WriteString("next_offset", dtoGetActivityMineDetailRsp.NextOffset);
        }
    }
}
