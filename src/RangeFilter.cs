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
    [JsonPropertyName("greaterThan")]
    [JsonProperty("greaterThan")]
    public object? GreaterThan { get; set; }

    [JsonPropertyName("greaterThanOrEqual")]
    [JsonProperty("greaterThanOrEqual")]
    public object? GreaterThanOrEqual { get; set; }

    [JsonPropertyName("lessThan")]
    [JsonProperty("lessThan")]
    public object? LessThan { get; set; }

    [JsonPropertyName("lessThanOrEqual")]
    [JsonProperty("lessThanOrEqual")]
    public object? LessThanOrEqual { get; set; }
}