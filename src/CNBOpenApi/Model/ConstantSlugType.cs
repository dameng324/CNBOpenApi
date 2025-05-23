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
    /// Defines constant.SlugType
    /// </summary>
    public enum ConstantSlugType
    {
        /// <summary>
        /// Enum SlugTypeGroup for value: 0
        /// </summary>
        SlugTypeGroup = 0,

        /// <summary>
        /// Enum SlugTypeRepo for value: 1
        /// </summary>
        SlugTypeRepo = 1,

        /// <summary>
        /// Enum SlugTypeMission for value: 2
        /// </summary>
        SlugTypeMission = 2,

        /// <summary>
        /// Enum SlugTypeRegistry for value: 3
        /// </summary>
        SlugTypeRegistry = 3,

        /// <summary>
        /// Enum SlugTypeUnknown for value: 4
        /// </summary>
        SlugTypeUnknown = 4
    }

    /// <summary>
    /// Converts <see cref="ConstantSlugType"/> to and from the JSON value
    /// </summary>
    public static class ConstantSlugTypeValueConverter
    {
        /// <summary>
        /// Parses a given value to <see cref="ConstantSlugType"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static ConstantSlugType FromString(string value)
        {
            if (value.Equals((0).ToString()))
                return ConstantSlugType.SlugTypeGroup;

            if (value.Equals((1).ToString()))
                return ConstantSlugType.SlugTypeRepo;

            if (value.Equals((2).ToString()))
                return ConstantSlugType.SlugTypeMission;

            if (value.Equals((3).ToString()))
                return ConstantSlugType.SlugTypeRegistry;

            if (value.Equals((4).ToString()))
                return ConstantSlugType.SlugTypeUnknown;

            throw new NotImplementedException($"Could not convert value to type ConstantSlugType: '{value}'");
        }

        /// <summary>
        /// Parses a given value to <see cref="ConstantSlugType"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static ConstantSlugType? FromStringOrDefault(string value)
        {
            if (value.Equals((0).ToString()))
                return ConstantSlugType.SlugTypeGroup;

            if (value.Equals((1).ToString()))
                return ConstantSlugType.SlugTypeRepo;

            if (value.Equals((2).ToString()))
                return ConstantSlugType.SlugTypeMission;

            if (value.Equals((3).ToString()))
                return ConstantSlugType.SlugTypeRegistry;

            if (value.Equals((4).ToString()))
                return ConstantSlugType.SlugTypeUnknown;

            return null;
        }

        /// <summary>
        /// Converts the <see cref="ConstantSlugType"/> to the json value
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public static int ToJsonValue(ConstantSlugType value)
        {
            return (int) value;
        }
    }

    /// <summary>
    /// A Json converter for type <see cref="ConstantSlugType"/>
    /// </summary>
    /// <exception cref="NotImplementedException"></exception>
    public class ConstantSlugTypeJsonConverter : JsonConverter<ConstantSlugType>
    {
        /// <summary>
        /// Returns a  from the Json object
        /// </summary>
        /// <param name="reader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="options"></param>
        /// <returns></returns>
        public override ConstantSlugType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            string? rawValue = reader.GetString();

            ConstantSlugType? result = rawValue == null
                ? null
                : ConstantSlugTypeValueConverter.FromStringOrDefault(rawValue);

            if (result != null)
                return result.Value;

            throw new JsonException();
        }

        /// <summary>
        /// Writes the ConstantSlugType to the json writer
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="constantSlugType"></param>
        /// <param name="options"></param>
        public override void Write(Utf8JsonWriter writer, ConstantSlugType constantSlugType, JsonSerializerOptions options)
        {
            writer.WriteStringValue(constantSlugType.ToString());
        }
    }

    /// <summary>
    /// A Json converter for type <see cref="ConstantSlugType"/>
    /// </summary>
    public class ConstantSlugTypeNullableJsonConverter : JsonConverter<ConstantSlugType?>
    {
        /// <summary>
        /// Returns a ConstantSlugType from the Json object
        /// </summary>
        /// <param name="reader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="options"></param>
        /// <returns></returns>
        public override ConstantSlugType? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            string? rawValue = reader.GetString();

            ConstantSlugType? result = rawValue == null
                ? null
                : ConstantSlugTypeValueConverter.FromStringOrDefault(rawValue);

            if (result != null)
                return result.Value;

            throw new JsonException();
        }

        /// <summary>
        /// Writes the DateTime to the json writer
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="constantSlugType"></param>
        /// <param name="options"></param>
        public override void Write(Utf8JsonWriter writer, ConstantSlugType? constantSlugType, JsonSerializerOptions options)
        {
            writer.WriteStringValue(constantSlugType?.ToString() ?? "null");
        }
    }
}
