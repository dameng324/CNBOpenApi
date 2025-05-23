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
    /// DtoContainerTagDetail
    /// </summary>
    public partial class DtoContainerTagDetail : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DtoContainerTagDetail" /> class.
        /// </summary>
        /// <param name="address">address</param>
        /// <param name="annotations">annotations</param>
        /// <param name="image">image</param>
        /// <param name="lastPusher">lastPusher</param>
        /// <param name="options">options</param>
        /// <param name="package">package</param>
        /// <param name="pullCount">pullCount</param>
        /// <param name="recentPullCount">recentPullCount</param>
        /// <param name="slug">slug</param>
        /// <param name="tag">tag</param>
        [JsonConstructor]
        public DtoContainerTagDetail(Option<string?> address = default, Option<DtoContainerAnnotation?> annotations = default, Option<DtoContainerImage?> image = default, Option<DtoLastPusher?> lastPusher = default, Option<List<DtoContainerImage>?> options = default, Option<string?> package = default, Option<int?> pullCount = default, Option<int?> recentPullCount = default, Option<string?> slug = default, Option<string?> tag = default)
        {
            AddressOption = address;
            AnnotationsOption = annotations;
            ImageOption = image;
            LastPusherOption = lastPusher;
            OptionsOption = options;
            PackageOption = package;
            PullCountOption = pullCount;
            RecentPullCountOption = recentPullCount;
            SlugOption = slug;
            TagOption = tag;
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
        /// Used to track the state of Annotations
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<DtoContainerAnnotation?> AnnotationsOption { get; private set; }

        /// <summary>
        /// Gets or Sets Annotations
        /// </summary>
        [JsonPropertyName("annotations")]
        public DtoContainerAnnotation? Annotations { get { return this.AnnotationsOption; } set { this.AnnotationsOption = new(value); } }

        /// <summary>
        /// Used to track the state of Image
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<DtoContainerImage?> ImageOption { get; private set; }

        /// <summary>
        /// Gets or Sets Image
        /// </summary>
        [JsonPropertyName("image")]
        public DtoContainerImage? Image { get { return this.ImageOption; } set { this.ImageOption = new(value); } }

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
        /// Used to track the state of Options
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<List<DtoContainerImage>?> OptionsOption { get; private set; }

        /// <summary>
        /// Gets or Sets Options
        /// </summary>
        [JsonPropertyName("options")]
        public List<DtoContainerImage>? Options { get { return this.OptionsOption; } set { this.OptionsOption = new(value); } }

        /// <summary>
        /// Used to track the state of Package
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> PackageOption { get; private set; }

        /// <summary>
        /// Gets or Sets Package
        /// </summary>
        [JsonPropertyName("package")]
        public string? Package { get { return this.PackageOption; } set { this.PackageOption = new(value); } }

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
        /// Used to track the state of Slug
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> SlugOption { get; private set; }

        /// <summary>
        /// Gets or Sets Slug
        /// </summary>
        [JsonPropertyName("slug")]
        public string? Slug { get { return this.SlugOption; } set { this.SlugOption = new(value); } }

        /// <summary>
        /// Used to track the state of Tag
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> TagOption { get; private set; }

        /// <summary>
        /// Gets or Sets Tag
        /// </summary>
        [JsonPropertyName("tag")]
        public string? Tag { get { return this.TagOption; } set { this.TagOption = new(value); } }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DtoContainerTagDetail {\n");
            sb.Append("  Address: ").Append(Address).Append("\n");
            sb.Append("  Annotations: ").Append(Annotations).Append("\n");
            sb.Append("  Image: ").Append(Image).Append("\n");
            sb.Append("  LastPusher: ").Append(LastPusher).Append("\n");
            sb.Append("  Options: ").Append(Options).Append("\n");
            sb.Append("  Package: ").Append(Package).Append("\n");
            sb.Append("  PullCount: ").Append(PullCount).Append("\n");
            sb.Append("  RecentPullCount: ").Append(RecentPullCount).Append("\n");
            sb.Append("  Slug: ").Append(Slug).Append("\n");
            sb.Append("  Tag: ").Append(Tag).Append("\n");
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
    /// A Json converter for type <see cref="DtoContainerTagDetail" />
    /// </summary>
    public class DtoContainerTagDetailJsonConverter : JsonConverter<DtoContainerTagDetail>
    {
        /// <summary>
        /// Deserializes json to <see cref="DtoContainerTagDetail" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override DtoContainerTagDetail Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<string?> address = default;
            Option<DtoContainerAnnotation?> annotations = default;
            Option<DtoContainerImage?> image = default;
            Option<DtoLastPusher?> lastPusher = default;
            Option<List<DtoContainerImage>?> options = default;
            Option<string?> package = default;
            Option<int?> pullCount = default;
            Option<int?> recentPullCount = default;
            Option<string?> slug = default;
            Option<string?> tag = default;

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
                        case "annotations":
                            annotations = new Option<DtoContainerAnnotation?>(JsonSerializer.Deserialize<DtoContainerAnnotation>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        case "image":
                            image = new Option<DtoContainerImage?>(JsonSerializer.Deserialize<DtoContainerImage>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        case "last_pusher":
                            lastPusher = new Option<DtoLastPusher?>(JsonSerializer.Deserialize<DtoLastPusher>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        case "options":
                            options = new Option<List<DtoContainerImage>?>(JsonSerializer.Deserialize<List<DtoContainerImage>>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        case "package":
                            package = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "pull_count":
                            pullCount = new Option<int?>(utf8JsonReader.TokenType == JsonTokenType.Null ? (int?)null : utf8JsonReader.GetInt32());
                            break;
                        case "recent_pull_count":
                            recentPullCount = new Option<int?>(utf8JsonReader.TokenType == JsonTokenType.Null ? (int?)null : utf8JsonReader.GetInt32());
                            break;
                        case "slug":
                            slug = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "tag":
                            tag = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        default:
                            break;
                    }
                }
            }

            if (address.IsSet && address.Value == null)
                throw new ArgumentNullException(nameof(address), "Property is not nullable for class DtoContainerTagDetail.");

            if (annotations.IsSet && annotations.Value == null)
                throw new ArgumentNullException(nameof(annotations), "Property is not nullable for class DtoContainerTagDetail.");

            if (image.IsSet && image.Value == null)
                throw new ArgumentNullException(nameof(image), "Property is not nullable for class DtoContainerTagDetail.");

            if (lastPusher.IsSet && lastPusher.Value == null)
                throw new ArgumentNullException(nameof(lastPusher), "Property is not nullable for class DtoContainerTagDetail.");

            if (options.IsSet && options.Value == null)
                throw new ArgumentNullException(nameof(options), "Property is not nullable for class DtoContainerTagDetail.");

            if (package.IsSet && package.Value == null)
                throw new ArgumentNullException(nameof(package), "Property is not nullable for class DtoContainerTagDetail.");

            if (pullCount.IsSet && pullCount.Value == null)
                throw new ArgumentNullException(nameof(pullCount), "Property is not nullable for class DtoContainerTagDetail.");

            if (recentPullCount.IsSet && recentPullCount.Value == null)
                throw new ArgumentNullException(nameof(recentPullCount), "Property is not nullable for class DtoContainerTagDetail.");

            if (slug.IsSet && slug.Value == null)
                throw new ArgumentNullException(nameof(slug), "Property is not nullable for class DtoContainerTagDetail.");

            if (tag.IsSet && tag.Value == null)
                throw new ArgumentNullException(nameof(tag), "Property is not nullable for class DtoContainerTagDetail.");

            return new DtoContainerTagDetail(address, annotations, image, lastPusher, options, package, pullCount, recentPullCount, slug, tag);
        }

        /// <summary>
        /// Serializes a <see cref="DtoContainerTagDetail" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="dtoContainerTagDetail"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, DtoContainerTagDetail dtoContainerTagDetail, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, dtoContainerTagDetail, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="DtoContainerTagDetail" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="dtoContainerTagDetail"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, DtoContainerTagDetail dtoContainerTagDetail, JsonSerializerOptions jsonSerializerOptions)
        {
            if (dtoContainerTagDetail.AddressOption.IsSet && dtoContainerTagDetail.Address == null)
                throw new ArgumentNullException(nameof(dtoContainerTagDetail.Address), "Property is required for class DtoContainerTagDetail.");

            if (dtoContainerTagDetail.AnnotationsOption.IsSet && dtoContainerTagDetail.Annotations == null)
                throw new ArgumentNullException(nameof(dtoContainerTagDetail.Annotations), "Property is required for class DtoContainerTagDetail.");

            if (dtoContainerTagDetail.ImageOption.IsSet && dtoContainerTagDetail.Image == null)
                throw new ArgumentNullException(nameof(dtoContainerTagDetail.Image), "Property is required for class DtoContainerTagDetail.");

            if (dtoContainerTagDetail.LastPusherOption.IsSet && dtoContainerTagDetail.LastPusher == null)
                throw new ArgumentNullException(nameof(dtoContainerTagDetail.LastPusher), "Property is required for class DtoContainerTagDetail.");

            if (dtoContainerTagDetail.OptionsOption.IsSet && dtoContainerTagDetail.Options == null)
                throw new ArgumentNullException(nameof(dtoContainerTagDetail.Options), "Property is required for class DtoContainerTagDetail.");

            if (dtoContainerTagDetail.PackageOption.IsSet && dtoContainerTagDetail.Package == null)
                throw new ArgumentNullException(nameof(dtoContainerTagDetail.Package), "Property is required for class DtoContainerTagDetail.");

            if (dtoContainerTagDetail.SlugOption.IsSet && dtoContainerTagDetail.Slug == null)
                throw new ArgumentNullException(nameof(dtoContainerTagDetail.Slug), "Property is required for class DtoContainerTagDetail.");

            if (dtoContainerTagDetail.TagOption.IsSet && dtoContainerTagDetail.Tag == null)
                throw new ArgumentNullException(nameof(dtoContainerTagDetail.Tag), "Property is required for class DtoContainerTagDetail.");

            if (dtoContainerTagDetail.AddressOption.IsSet)
                writer.WriteString("address", dtoContainerTagDetail.Address);

            if (dtoContainerTagDetail.AnnotationsOption.IsSet)
            {
                writer.WritePropertyName("annotations");
                JsonSerializer.Serialize(writer, dtoContainerTagDetail.Annotations, jsonSerializerOptions);
            }
            if (dtoContainerTagDetail.ImageOption.IsSet)
            {
                writer.WritePropertyName("image");
                JsonSerializer.Serialize(writer, dtoContainerTagDetail.Image, jsonSerializerOptions);
            }
            if (dtoContainerTagDetail.LastPusherOption.IsSet)
            {
                writer.WritePropertyName("last_pusher");
                JsonSerializer.Serialize(writer, dtoContainerTagDetail.LastPusher, jsonSerializerOptions);
            }
            if (dtoContainerTagDetail.OptionsOption.IsSet)
            {
                writer.WritePropertyName("options");
                JsonSerializer.Serialize(writer, dtoContainerTagDetail.Options, jsonSerializerOptions);
            }
            if (dtoContainerTagDetail.PackageOption.IsSet)
                writer.WriteString("package", dtoContainerTagDetail.Package);

            if (dtoContainerTagDetail.PullCountOption.IsSet)
                writer.WriteNumber("pull_count", dtoContainerTagDetail.PullCountOption.Value!.Value);

            if (dtoContainerTagDetail.RecentPullCountOption.IsSet)
                writer.WriteNumber("recent_pull_count", dtoContainerTagDetail.RecentPullCountOption.Value!.Value);

            if (dtoContainerTagDetail.SlugOption.IsSet)
                writer.WriteString("slug", dtoContainerTagDetail.Slug);

            if (dtoContainerTagDetail.TagOption.IsSet)
                writer.WriteString("tag", dtoContainerTagDetail.Tag);
        }
    }
}
