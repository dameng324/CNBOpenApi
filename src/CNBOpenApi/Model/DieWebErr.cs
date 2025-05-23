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
    /// DieWebErr
    /// </summary>
    public partial class DieWebErr : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DieWebErr" /> class.
        /// </summary>
        /// <param name="errcode">errcode</param>
        /// <param name="errmsg">errmsg</param>
        /// <param name="errparam">errparam</param>
        [JsonConstructor]
        public DieWebErr(Option<int?> errcode = default, Option<string?> errmsg = default, Option<Dictionary<string, Object>?> errparam = default)
        {
            ErrcodeOption = errcode;
            ErrmsgOption = errmsg;
            ErrparamOption = errparam;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Used to track the state of Errcode
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<int?> ErrcodeOption { get; private set; }

        /// <summary>
        /// Gets or Sets Errcode
        /// </summary>
        [JsonPropertyName("errcode")]
        public int? Errcode { get { return this.ErrcodeOption; } set { this.ErrcodeOption = new(value); } }

        /// <summary>
        /// Used to track the state of Errmsg
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> ErrmsgOption { get; private set; }

        /// <summary>
        /// Gets or Sets Errmsg
        /// </summary>
        [JsonPropertyName("errmsg")]
        public string? Errmsg { get { return this.ErrmsgOption; } set { this.ErrmsgOption = new(value); } }

        /// <summary>
        /// Used to track the state of Errparam
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<Dictionary<string, Object>?> ErrparamOption { get; private set; }

        /// <summary>
        /// Gets or Sets Errparam
        /// </summary>
        [JsonPropertyName("errparam")]
        public Dictionary<string, Object>? Errparam { get { return this.ErrparamOption; } set { this.ErrparamOption = new(value); } }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DieWebErr {\n");
            sb.Append("  Errcode: ").Append(Errcode).Append("\n");
            sb.Append("  Errmsg: ").Append(Errmsg).Append("\n");
            sb.Append("  Errparam: ").Append(Errparam).Append("\n");
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
    /// A Json converter for type <see cref="DieWebErr" />
    /// </summary>
    public class DieWebErrJsonConverter : JsonConverter<DieWebErr>
    {
        /// <summary>
        /// Deserializes json to <see cref="DieWebErr" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override DieWebErr Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<int?> errcode = default;
            Option<string?> errmsg = default;
            Option<Dictionary<string, Object>?> errparam = default;

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
                        case "errcode":
                            errcode = new Option<int?>(utf8JsonReader.TokenType == JsonTokenType.Null ? (int?)null : utf8JsonReader.GetInt32());
                            break;
                        case "errmsg":
                            errmsg = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "errparam":
                            errparam = new Option<Dictionary<string, Object>?>(JsonSerializer.Deserialize<Dictionary<string, Object>>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        default:
                            break;
                    }
                }
            }

            if (errcode.IsSet && errcode.Value == null)
                throw new ArgumentNullException(nameof(errcode), "Property is not nullable for class DieWebErr.");

            if (errmsg.IsSet && errmsg.Value == null)
                throw new ArgumentNullException(nameof(errmsg), "Property is not nullable for class DieWebErr.");

            if (errparam.IsSet && errparam.Value == null)
                throw new ArgumentNullException(nameof(errparam), "Property is not nullable for class DieWebErr.");

            return new DieWebErr(errcode, errmsg, errparam);
        }

        /// <summary>
        /// Serializes a <see cref="DieWebErr" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="dieWebErr"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, DieWebErr dieWebErr, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, dieWebErr, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="DieWebErr" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="dieWebErr"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, DieWebErr dieWebErr, JsonSerializerOptions jsonSerializerOptions)
        {
            if (dieWebErr.ErrmsgOption.IsSet && dieWebErr.Errmsg == null)
                throw new ArgumentNullException(nameof(dieWebErr.Errmsg), "Property is required for class DieWebErr.");

            if (dieWebErr.ErrparamOption.IsSet && dieWebErr.Errparam == null)
                throw new ArgumentNullException(nameof(dieWebErr.Errparam), "Property is required for class DieWebErr.");

            if (dieWebErr.ErrcodeOption.IsSet)
                writer.WriteNumber("errcode", dieWebErr.ErrcodeOption.Value!.Value);

            if (dieWebErr.ErrmsgOption.IsSet)
                writer.WriteString("errmsg", dieWebErr.Errmsg);

            if (dieWebErr.ErrparamOption.IsSet)
            {
                writer.WritePropertyName("errparam");
                JsonSerializer.Serialize(writer, dieWebErr.Errparam, jsonSerializerOptions);
            }
        }
    }
}
