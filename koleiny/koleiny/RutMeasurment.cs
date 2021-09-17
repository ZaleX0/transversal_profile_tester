using GeoJSON.Net.Geometry;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace koleiny
{
    struct RutMeasurment
    {
        public string LaneSide { get; set; }
        public int Position { get; set; }
        public double Width { get; set; }
        public double Depth { get; set; }
        public double[] RutProfileDataX { get; set; }
        public double[] RutProfileDataZ { get; set; }
        public double StraightEdgeX1 { get; set; }
        public double StraightEdgeY1 { get; set; }
        public double StraightEdgeX2 { get; set; }
        public double StraightEdgeY2 { get; set; }
        public double MidLineX1 { get; set; }
        public double MidLineY1 { get; set; }
        public double MidLineX2 { get; set; }
        public double MidLineY2 { get; set; }



        public string GetGeoJson(double scalarX = 1, double scalarY = 1)
        {
            return JsonConvert.SerializeObject(new RutMeasurmentJSON()
            {
                ProfileData = GetRutProfileDataLineString(scalarX, scalarY),
                StraightEdge = GetStraightEdgeLineString(scalarX, scalarY),
                MidLine = GetMidLineLineString(scalarX, scalarY),
                StraightEdgePoints = GetStraightEdgeMultiPoint(scalarX, scalarY),
                MidLinePoints = GetMidLineMultiPoint(scalarX, scalarY)
            });
        }


        public LineString GetRutProfileDataLineString(double scalarX, double scalarY)
        {
            List<Position> positions = new List<Position>();
            for (int i = 0; i < RutProfileDataX.Length; i++)
                positions.Add(new Position(RutProfileDataZ[i] * scalarY, RutProfileDataX[i] * scalarX));
            return new LineString(positions);
        }
        public LineString GetStraightEdgeLineString(double scalarX, double scalarY)
        {
            List<Position> positions = new List<Position>();
            positions.Add(new Position(StraightEdgeY1 * scalarY, StraightEdgeX1 * scalarX));
            positions.Add(new Position(StraightEdgeY2 * scalarY, StraightEdgeX2 * scalarX));
            return new LineString(positions);
        }
        public LineString GetMidLineLineString(double scalarX, double scalarY)
        {
            List<Position> positions = new List<Position>();
            positions.Add(new Position(MidLineY1 * scalarY, MidLineX1 * scalarX));
            positions.Add(new Position(MidLineY2 * scalarY, MidLineX2 * scalarX));
            return new LineString(positions);
        }
        public MultiPoint GetStraightEdgeMultiPoint(double scalarX, double scalarY)
        {
            List<Point> points = new List<Point>();
            points.Add(new Point(new Position(StraightEdgeY1 * scalarY, StraightEdgeX1 * scalarX)));
            points.Add(new Point(new Position(StraightEdgeY2 * scalarY, StraightEdgeX2 * scalarX)));
            return new MultiPoint(points);
        }
        public MultiPoint GetMidLineMultiPoint(double scalarX, double scalarY)
        {
            List<Point> points = new List<Point>();
            points.Add(new Point(new Position(MidLineY1 * scalarY, MidLineX1 * scalarX)));
            points.Add(new Point(new Position(MidLineY2 * scalarY, MidLineX2 * scalarX)));
            return new MultiPoint(points);
        }
    }
}
