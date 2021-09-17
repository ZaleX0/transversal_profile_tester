using GeoJSON.Net;
using GeoJSON.Net.Geometry;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace koleiny
{
    class RutMeasurmentJSON
    {
        public LineString ProfileData { get; set; }
        public LineString StraightEdge { get; set; }
        public LineString MidLine { get; set; }
        public MultiPoint StraightEdgePoints { get; set; }
        public MultiPoint MidLinePoints { get; set; }
    }
}
