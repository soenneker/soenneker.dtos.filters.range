using Soenneker.Dtos.Filters.Base;
using System.Text.Json.Serialization;
using Newtonsoft.Json;
using Soenneker.Attributes.PublicOpenApiObject;

namespace Soenneker.Dtos.Filters.Range;

/// <summary>
/// A generic object for handling range filtering during querying
/// </summary>
[PublicOpenApiObject]
public sealed class RangeFilter : FilterBase
{
    /// <summary>
    /// The exclusive lower bound for the field value.
    /// </summary>
    [JsonPropertyName("greaterThan")]
    [JsonProperty("greaterThan")]
    public object? GreaterThan { get; set; }

    /// <summary>
    /// The inclusive lower bound for the field value.
    /// </summary>
    [JsonPropertyName("greaterThanOrEqual")]
    [JsonProperty("greaterThanOrEqual")]
    public object? GreaterThanOrEqual { get; set; }

    /// <summary>
    /// The exclusive upper bound for the field value.
    /// </summary>
    [JsonPropertyName("lessThan")]
    [JsonProperty("lessThan")]
    public object? LessThan { get; set; }

    /// <summary>
    /// The inclusive upper bound for the field value.
    /// </summary>
    [JsonPropertyName("lessThanOrEqual")]
    [JsonProperty("lessThanOrEqual")]
    public object? LessThanOrEqual { get; set; }
}
