using NetTopologySuite.Geometries;
using NetTopologySuite.IO.Converters;
using Newtonsoft.Json;

namespace GeometryToGeoJson
{
    public class GeoDto
    {
        public string Name { get; set; }
        [JsonConverter(typeof(GeometryConverter))]
        public Geometry Geometry { get; set; }
    }
}
