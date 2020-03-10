using NetTopologySuite;
using NetTopologySuite.Geometries;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace GeometryToGeoJson
{
    class Program
    {
        static void Main(string[] args)
        {
            var geometryFactory = NtsGeometryServices.Instance.CreateGeometryFactory(srid: 4326);

            var coordinates = new List<Coordinate>();

            coordinates.Add(new Coordinate(-127.07202896, 54.82682777));
            coordinates.Add(new Coordinate(-127.05364005, 54.82893557));

            var dto = new GeoDto();
            dto.Name = "First DTO";
            dto.Geometry = geometryFactory.CreateLineString(coordinates.ToArray());

            var json = JsonConvert.SerializeObject(dto, Formatting.Indented, new JsonSerializerSettings
            {
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore
            });

            Console.WriteLine(json);
            Console.ReadKey();
        }
    }
}
