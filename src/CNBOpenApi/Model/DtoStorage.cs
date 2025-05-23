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
    /// DtoStorage
    /// </summary>
    public partial class DtoStorage : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DtoStorage" /> class.
        /// </summary>
        /// <param name="storage">example: { \&quot;hard\&quot;: { \&quot;storage\&quot;: -1}},移除 omitempty ，Storage &#x3D; 0，会生成 {\&quot;hard\&quot;:{\&quot;storage\&quot;:0}}</param>
        [JsonConstructor]
        public DtoStorage(Option<int?> storage = default)
        {
            StorageOption = storage;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Used to track the state of Storage
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<int?> StorageOption { get; private set; }

        /// <summary>
        /// example: { \&quot;hard\&quot;: { \&quot;storage\&quot;: -1}},移除 omitempty ，Storage &#x3D; 0，会生成 {\&quot;hard\&quot;:{\&quot;storage\&quot;:0}}
        /// </summary>
        /// <value>example: { \&quot;hard\&quot;: { \&quot;storage\&quot;: -1}},移除 omitempty ，Storage &#x3D; 0，会生成 {\&quot;hard\&quot;:{\&quot;storage\&quot;:0}}</value>
        [JsonPropertyName("storage")]
        public int? Storage { get { return this.StorageOption; } set { this.StorageOption = new(value); } }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DtoStorage {\n");
            sb.Append("  Storage: ").Append(Storage).Append("\n");
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
    /// A Json converter for type <see cref="DtoStorage" />
    /// </summary>
    public class DtoStorageJsonConverter : JsonConverter<DtoStorage>
    {
        /// <summary>
        /// Deserializes json to <see cref="DtoStorage" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override DtoStorage Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<int?> storage = default;

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
                        case "storage":
                            storage = new Option<int?>(utf8JsonReader.TokenType == JsonTokenType.Null ? (int?)null : utf8JsonReader.GetInt32());
                            break;
                        default:
                            break;
                    }
                }
            }

            if (storage.IsSet && storage.Value == null)
                throw new ArgumentNullException(nameof(storage), "Property is not nullable for class DtoStorage.");

            return new DtoStorage(storage);
        }

        /// <summary>
        /// Serializes a <see cref="DtoStorage" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="dtoStorage"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, DtoStorage dtoStorage, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, dtoStorage, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="DtoStorage" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="dtoStorage"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, DtoStorage dtoStorage, JsonSerializerOptions jsonSerializerOptions)
        {
            if (dtoStorage.StorageOption.IsSet)
                writer.WriteNumber("storage", dtoStorage.StorageOption.Value!.Value);
        }
    }
}
