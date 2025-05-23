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
    /// WebMIMEType
    /// </summary>
    public partial class WebMIMEType : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WebMIMEType" /> class.
        /// </summary>
        /// <param name="contentType">contentType</param>
        /// <param name="externsion">externsion</param>
        /// <param name="isAudio">isAudio</param>
        /// <param name="isBrowsableBinaryType">isBrowsableBinaryType</param>
        /// <param name="isImage">isImage</param>
        /// <param name="isPdf">isPdf</param>
        /// <param name="isRepresentableAsText">isRepresentableAsText</param>
        /// <param name="isSvgImage">isSvgImage</param>
        /// <param name="isText">isText</param>
        /// <param name="isVideo">isVideo</param>
        [JsonConstructor]
        public WebMIMEType(Option<string?> contentType = default, Option<string?> externsion = default, Option<bool?> isAudio = default, Option<bool?> isBrowsableBinaryType = default, Option<bool?> isImage = default, Option<bool?> isPdf = default, Option<bool?> isRepresentableAsText = default, Option<bool?> isSvgImage = default, Option<bool?> isText = default, Option<bool?> isVideo = default)
        {
            ContentTypeOption = contentType;
            ExternsionOption = externsion;
            IsAudioOption = isAudio;
            IsBrowsableBinaryTypeOption = isBrowsableBinaryType;
            IsImageOption = isImage;
            IsPdfOption = isPdf;
            IsRepresentableAsTextOption = isRepresentableAsText;
            IsSvgImageOption = isSvgImage;
            IsTextOption = isText;
            IsVideoOption = isVideo;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Used to track the state of ContentType
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> ContentTypeOption { get; private set; }

        /// <summary>
        /// Gets or Sets ContentType
        /// </summary>
        [JsonPropertyName("content_type")]
        public string? ContentType { get { return this.ContentTypeOption; } set { this.ContentTypeOption = new(value); } }

        /// <summary>
        /// Used to track the state of Externsion
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> ExternsionOption { get; private set; }

        /// <summary>
        /// Gets or Sets Externsion
        /// </summary>
        [JsonPropertyName("externsion")]
        public string? Externsion { get { return this.ExternsionOption; } set { this.ExternsionOption = new(value); } }

        /// <summary>
        /// Used to track the state of IsAudio
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<bool?> IsAudioOption { get; private set; }

        /// <summary>
        /// Gets or Sets IsAudio
        /// </summary>
        [JsonPropertyName("is_audio")]
        public bool? IsAudio { get { return this.IsAudioOption; } set { this.IsAudioOption = new(value); } }

        /// <summary>
        /// Used to track the state of IsBrowsableBinaryType
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<bool?> IsBrowsableBinaryTypeOption { get; private set; }

        /// <summary>
        /// Gets or Sets IsBrowsableBinaryType
        /// </summary>
        [JsonPropertyName("is_browsable_binary_type")]
        public bool? IsBrowsableBinaryType { get { return this.IsBrowsableBinaryTypeOption; } set { this.IsBrowsableBinaryTypeOption = new(value); } }

        /// <summary>
        /// Used to track the state of IsImage
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<bool?> IsImageOption { get; private set; }

        /// <summary>
        /// Gets or Sets IsImage
        /// </summary>
        [JsonPropertyName("is_image")]
        public bool? IsImage { get { return this.IsImageOption; } set { this.IsImageOption = new(value); } }

        /// <summary>
        /// Used to track the state of IsPdf
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<bool?> IsPdfOption { get; private set; }

        /// <summary>
        /// Gets or Sets IsPdf
        /// </summary>
        [JsonPropertyName("is_pdf")]
        public bool? IsPdf { get { return this.IsPdfOption; } set { this.IsPdfOption = new(value); } }

        /// <summary>
        /// Used to track the state of IsRepresentableAsText
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<bool?> IsRepresentableAsTextOption { get; private set; }

        /// <summary>
        /// Gets or Sets IsRepresentableAsText
        /// </summary>
        [JsonPropertyName("is_representable_as_text")]
        public bool? IsRepresentableAsText { get { return this.IsRepresentableAsTextOption; } set { this.IsRepresentableAsTextOption = new(value); } }

        /// <summary>
        /// Used to track the state of IsSvgImage
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<bool?> IsSvgImageOption { get; private set; }

        /// <summary>
        /// Gets or Sets IsSvgImage
        /// </summary>
        [JsonPropertyName("is_svg_image")]
        public bool? IsSvgImage { get { return this.IsSvgImageOption; } set { this.IsSvgImageOption = new(value); } }

        /// <summary>
        /// Used to track the state of IsText
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<bool?> IsTextOption { get; private set; }

        /// <summary>
        /// Gets or Sets IsText
        /// </summary>
        [JsonPropertyName("is_text")]
        public bool? IsText { get { return this.IsTextOption; } set { this.IsTextOption = new(value); } }

        /// <summary>
        /// Used to track the state of IsVideo
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<bool?> IsVideoOption { get; private set; }

        /// <summary>
        /// Gets or Sets IsVideo
        /// </summary>
        [JsonPropertyName("is_video")]
        public bool? IsVideo { get { return this.IsVideoOption; } set { this.IsVideoOption = new(value); } }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class WebMIMEType {\n");
            sb.Append("  ContentType: ").Append(ContentType).Append("\n");
            sb.Append("  Externsion: ").Append(Externsion).Append("\n");
            sb.Append("  IsAudio: ").Append(IsAudio).Append("\n");
            sb.Append("  IsBrowsableBinaryType: ").Append(IsBrowsableBinaryType).Append("\n");
            sb.Append("  IsImage: ").Append(IsImage).Append("\n");
            sb.Append("  IsPdf: ").Append(IsPdf).Append("\n");
            sb.Append("  IsRepresentableAsText: ").Append(IsRepresentableAsText).Append("\n");
            sb.Append("  IsSvgImage: ").Append(IsSvgImage).Append("\n");
            sb.Append("  IsText: ").Append(IsText).Append("\n");
            sb.Append("  IsVideo: ").Append(IsVideo).Append("\n");
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
    /// A Json converter for type <see cref="WebMIMEType" />
    /// </summary>
    public class WebMIMETypeJsonConverter : JsonConverter<WebMIMEType>
    {
        /// <summary>
        /// Deserializes json to <see cref="WebMIMEType" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override WebMIMEType Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<string?> contentType = default;
            Option<string?> externsion = default;
            Option<bool?> isAudio = default;
            Option<bool?> isBrowsableBinaryType = default;
            Option<bool?> isImage = default;
            Option<bool?> isPdf = default;
            Option<bool?> isRepresentableAsText = default;
            Option<bool?> isSvgImage = default;
            Option<bool?> isText = default;
            Option<bool?> isVideo = default;

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
                        case "content_type":
                            contentType = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "externsion":
                            externsion = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "is_audio":
                            isAudio = new Option<bool?>(utf8JsonReader.TokenType == JsonTokenType.Null ? (bool?)null : utf8JsonReader.GetBoolean());
                            break;
                        case "is_browsable_binary_type":
                            isBrowsableBinaryType = new Option<bool?>(utf8JsonReader.TokenType == JsonTokenType.Null ? (bool?)null : utf8JsonReader.GetBoolean());
                            break;
                        case "is_image":
                            isImage = new Option<bool?>(utf8JsonReader.TokenType == JsonTokenType.Null ? (bool?)null : utf8JsonReader.GetBoolean());
                            break;
                        case "is_pdf":
                            isPdf = new Option<bool?>(utf8JsonReader.TokenType == JsonTokenType.Null ? (bool?)null : utf8JsonReader.GetBoolean());
                            break;
                        case "is_representable_as_text":
                            isRepresentableAsText = new Option<bool?>(utf8JsonReader.TokenType == JsonTokenType.Null ? (bool?)null : utf8JsonReader.GetBoolean());
                            break;
                        case "is_svg_image":
                            isSvgImage = new Option<bool?>(utf8JsonReader.TokenType == JsonTokenType.Null ? (bool?)null : utf8JsonReader.GetBoolean());
                            break;
                        case "is_text":
                            isText = new Option<bool?>(utf8JsonReader.TokenType == JsonTokenType.Null ? (bool?)null : utf8JsonReader.GetBoolean());
                            break;
                        case "is_video":
                            isVideo = new Option<bool?>(utf8JsonReader.TokenType == JsonTokenType.Null ? (bool?)null : utf8JsonReader.GetBoolean());
                            break;
                        default:
                            break;
                    }
                }
            }

            if (contentType.IsSet && contentType.Value == null)
                throw new ArgumentNullException(nameof(contentType), "Property is not nullable for class WebMIMEType.");

            if (externsion.IsSet && externsion.Value == null)
                throw new ArgumentNullException(nameof(externsion), "Property is not nullable for class WebMIMEType.");

            if (isAudio.IsSet && isAudio.Value == null)
                throw new ArgumentNullException(nameof(isAudio), "Property is not nullable for class WebMIMEType.");

            if (isBrowsableBinaryType.IsSet && isBrowsableBinaryType.Value == null)
                throw new ArgumentNullException(nameof(isBrowsableBinaryType), "Property is not nullable for class WebMIMEType.");

            if (isImage.IsSet && isImage.Value == null)
                throw new ArgumentNullException(nameof(isImage), "Property is not nullable for class WebMIMEType.");

            if (isPdf.IsSet && isPdf.Value == null)
                throw new ArgumentNullException(nameof(isPdf), "Property is not nullable for class WebMIMEType.");

            if (isRepresentableAsText.IsSet && isRepresentableAsText.Value == null)
                throw new ArgumentNullException(nameof(isRepresentableAsText), "Property is not nullable for class WebMIMEType.");

            if (isSvgImage.IsSet && isSvgImage.Value == null)
                throw new ArgumentNullException(nameof(isSvgImage), "Property is not nullable for class WebMIMEType.");

            if (isText.IsSet && isText.Value == null)
                throw new ArgumentNullException(nameof(isText), "Property is not nullable for class WebMIMEType.");

            if (isVideo.IsSet && isVideo.Value == null)
                throw new ArgumentNullException(nameof(isVideo), "Property is not nullable for class WebMIMEType.");

            return new WebMIMEType(contentType, externsion, isAudio, isBrowsableBinaryType, isImage, isPdf, isRepresentableAsText, isSvgImage, isText, isVideo);
        }

        /// <summary>
        /// Serializes a <see cref="WebMIMEType" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="webMIMEType"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, WebMIMEType webMIMEType, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, webMIMEType, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="WebMIMEType" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="webMIMEType"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, WebMIMEType webMIMEType, JsonSerializerOptions jsonSerializerOptions)
        {
            if (webMIMEType.ContentTypeOption.IsSet && webMIMEType.ContentType == null)
                throw new ArgumentNullException(nameof(webMIMEType.ContentType), "Property is required for class WebMIMEType.");

            if (webMIMEType.ExternsionOption.IsSet && webMIMEType.Externsion == null)
                throw new ArgumentNullException(nameof(webMIMEType.Externsion), "Property is required for class WebMIMEType.");

            if (webMIMEType.ContentTypeOption.IsSet)
                writer.WriteString("content_type", webMIMEType.ContentType);

            if (webMIMEType.ExternsionOption.IsSet)
                writer.WriteString("externsion", webMIMEType.Externsion);

            if (webMIMEType.IsAudioOption.IsSet)
                writer.WriteBoolean("is_audio", webMIMEType.IsAudioOption.Value!.Value);

            if (webMIMEType.IsBrowsableBinaryTypeOption.IsSet)
                writer.WriteBoolean("is_browsable_binary_type", webMIMEType.IsBrowsableBinaryTypeOption.Value!.Value);

            if (webMIMEType.IsImageOption.IsSet)
                writer.WriteBoolean("is_image", webMIMEType.IsImageOption.Value!.Value);

            if (webMIMEType.IsPdfOption.IsSet)
                writer.WriteBoolean("is_pdf", webMIMEType.IsPdfOption.Value!.Value);

            if (webMIMEType.IsRepresentableAsTextOption.IsSet)
                writer.WriteBoolean("is_representable_as_text", webMIMEType.IsRepresentableAsTextOption.Value!.Value);

            if (webMIMEType.IsSvgImageOption.IsSet)
                writer.WriteBoolean("is_svg_image", webMIMEType.IsSvgImageOption.Value!.Value);

            if (webMIMEType.IsTextOption.IsSet)
                writer.WriteBoolean("is_text", webMIMEType.IsTextOption.Value!.Value);

            if (webMIMEType.IsVideoOption.IsSet)
                writer.WriteBoolean("is_video", webMIMEType.IsVideoOption.Value!.Value);
        }
    }
}
