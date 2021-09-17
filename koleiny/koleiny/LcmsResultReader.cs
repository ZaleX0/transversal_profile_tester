using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace koleiny
{
    class LcmsResultReader
    {
        public static RutMeasurment[] GetRutMeasurments(string xmlPath)
        {
            XmlReader r = XmlReader.Create(xmlPath);
            RutMeasurment[] measurments = new RutMeasurment[20];
            r.ReadToFollowing("RutInformationDSN");

            for (int i = 0; i < 20; i++)
            {
                #region Reading Xml...
                r.ReadToFollowing("LaneSide");
                measurments[i].LaneSide = r.ReadElementContentAsString();

                r.ReadToFollowing("Position");
                measurments[i].Position = r.ReadElementContentAsInt();

                r.ReadToFollowing("Width");
                measurments[i].Width = r.ReadElementContentAsDouble();

                r.ReadToFollowing("Depth");
                measurments[i].Depth = r.ReadElementContentAsDouble();

                // RutProfileData
                r.ReadToFollowing("RutProfileDataX");
                string[] stringX = r.ReadElementContentAsString().Split(' ');
                r.ReadToFollowing("RutProfileDataZ");
                string[] stringZ = r.ReadElementContentAsString().Split(' ');

                double[] x = new double[stringX.Length];
                double[] z = new double[stringZ.Length];
                for (int j = 0; j < stringX.Length; j++)
                {
                    if (!double.TryParse(stringX[j], out x[j]))
                        x[j] = double.Parse(stringX[j].Replace('.', ','));

                    if (!double.TryParse(stringZ[j], out z[j]))
                        z[j] = double.Parse(stringZ[j].Replace('.', ','));
                }
                measurments[i].RutProfileDataX = x;
                measurments[i].RutProfileDataZ = z;

                // StraightEdgeCoords
                r.ReadToFollowing("StraightEdgeCoords");
                if (!r.IsEmptyElement)
                {
                    r.ReadToFollowing("X");
                    measurments[i].StraightEdgeX1 = r.ReadElementContentAsDouble();
                    r.ReadToFollowing("Y");
                    measurments[i].StraightEdgeY1 = r.ReadElementContentAsDouble();

                    r.ReadToFollowing("X");
                    measurments[i].StraightEdgeX2 = r.ReadElementContentAsDouble();
                    r.ReadToFollowing("Y");
                    measurments[i].StraightEdgeY2 = r.ReadElementContentAsDouble();
                }

                // MidLineCoords
                r.ReadToFollowing("MidLineCoords");
                if (!r.IsEmptyElement)
                {
                    r.ReadToFollowing("X");
                    measurments[i].MidLineX1 = r.ReadElementContentAsDouble();
                    r.ReadToFollowing("Y");
                    measurments[i].MidLineY1 = r.ReadElementContentAsDouble();

                    r.ReadToFollowing("X");
                    measurments[i].MidLineX2 = r.ReadElementContentAsDouble();
                    r.ReadToFollowing("Y");
                    measurments[i].MidLineY2 = r.ReadElementContentAsDouble();
                }
                #endregion
            }
            return measurments;
        }
    }
}
