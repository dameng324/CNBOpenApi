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
    /// DtoContainerAnnotation
    /// </summary>
    public partial class DtoContainerAnnotation : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DtoContainerAnnotation" /> class.
        /// </summary>
        /// <param name="revision">revision</param>
        /// <param name="varVersion">varVersion</param>
        [JsonConstructor]
        public DtoContainerAnnotation(Option<string?> revision = default, Option<string?> varVersion = default)
        {
            RevisionOption = revision;
            VarVersionOption = varVersion;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Used to track the state of Revision
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> RevisionOption { get; private set; }

        /// <summary>
        /// Gets or Sets Revision
        /// </summary>
        [JsonPropertyName("revision")]
        public string? Revision { get { return this.RevisionOption; } set { this.RevisionOption = new(value); } }

        /// <summary>
        /// Used to track the state of VarVersion
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> VarVersionOption { get; private set; }

        /// <summary>
        /// Gets or Sets VarVersion
        /// </summary>
        [JsonPropertyName("version")]
        public string? VarVersion { get { return this.VarVersionOption; } set { this.VarVersionOption = new(value); } }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DtoContainerAnnotation {\n");
            sb.Append("  Revision: ").Append(Revision).Append("\n");
            sb.Append("  VarVersion: ").Append(VarVersion).Append("\n");
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
    /// A Json converter for type <see cref="DtoContainerAnnotation" />
    /// </summary>
    public class DtoContainerAnnotationJsonConverter : JsonConverter<DtoContainerAnnotation>
    {
        /// <summary>
        /// Deserializes json to <see cref="DtoContainerAnnotation" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override DtoContainerAnnotation Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<string?> revision = default;
            Option<string?> varVersion = default;

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
                        case "revision":
                            revision = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "version":
                            varVersion = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        default:
                            break;
                    }
                }
            }

            if (revision.IsSet && revision.Value == null)
                throw new ArgumentNullException(nameof(revision), "Property is not nullable for class DtoContainerAnnotation.");

            if (varVersion.IsSet && varVersion.Value == null)
                throw new ArgumentNullException(nameof(varVersion), "Property is not nullable for class DtoContainerAnnotation.");

            return new DtoContainerAnnotation(revision, varVersion);
        }

        /// <summary>
        /// Serializes a <see cref="DtoContainerAnnotation" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="dtoContainerAnnotation"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, DtoContainerAnnotation dtoContainerAnnotation, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, dtoContainerAnnotation, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="DtoContainerAnnotation" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="dtoContainerAnnotation"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, DtoContainerAnnotation dtoContainerAnnotation, JsonSerializerOptions jsonSerializerOptions)
        {
            if (dtoContainerAnnotation.RevisionOption.IsSet && dtoContainerAnnotation.Revision == null)
                throw new ArgumentNullException(nameof(dtoContainerAnnotation.Revision), "Property is required for class DtoContainerAnnotation.");

            if (dtoContainerAnnotation.VarVersionOption.IsSet && dtoContainerAnnotation.VarVersion == null)
                throw new ArgumentNullException(nameof(dtoContainerAnnotation.VarVersion), "Property is required for class DtoContainerAnnotation.");

            if (dtoContainerAnnotation.RevisionOption.IsSet)
                writer.WriteString("revision", dtoContainerAnnotation.Revision);

            if (dtoContainerAnnotation.VarVersionOption.IsSet)
                writer.WriteString("version", dtoContainerAnnotation.VarVersion);
        }
    }
}
