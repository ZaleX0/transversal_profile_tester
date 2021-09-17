using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace koleiny
{
    struct RutInformationDSN
    {
        public RutInformationDSN(RutMeasurment[] left, RutMeasurment[] right)
        {
            LeftRuts = left;
            RightRuts = right;
        }

        public RutMeasurment[] LeftRuts { get; set; }
        public RutMeasurment[] RightRuts { get; set; }
    }
}
