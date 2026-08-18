using Soenneker.Dtos.Filters.Base;
using System.Text.Json.Serialization;
using Newtonsoft.Json;
using Soenneker.Attributes.PublicOpenApiObject;

namespace Soenneker.Dtos.Filters.Range;

/// <summary>
/// Selects records by applying inclusive or exclusive lower and upper bounds to a named comparable field.
/// </summary>
[PublicOpenApiObject]
public sealed class RangeFilter : FilterBase
{
    /// <summary>
    /// Exclusive lower bound; matching field values must be greater than this value.
    /// </summary>
    [JsonPropertyName("greaterThan")]
    [JsonProperty("greaterThan")]
    public object? GreaterThan { get; set; }

    /// <summary>
    /// Inclusive lower bound; matching field values must be greater than or equal to this value.
    /// </summary>
    [JsonPropertyName("greaterThanOrEqual")]
    [JsonProperty("greaterThanOrEqual")]
    public object? GreaterThanOrEqual { get; set; }

    /// <summary>
    /// Exclusive upper bound; matching field values must be less than this value.
    /// </summary>
    [JsonPropertyName("lessThan")]
    [JsonProperty("lessThan")]
    public object? LessThan { get; set; }

    /// <summary>
    /// Inclusive upper bound; matching field values must be less than or equal to this value.
    /// </summary>
    [JsonPropertyName("lessThanOrEqual")]
    [JsonProperty("lessThanOrEqual")]
    public object? LessThanOrEqual { get; set; }
}
