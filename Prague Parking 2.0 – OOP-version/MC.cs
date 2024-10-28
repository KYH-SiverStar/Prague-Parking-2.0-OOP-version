using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prague_Parking_2._0___OOP_version
{
    class MC : Vehicle
    {
        public override string Type => "MC";

        public MC(string regNumber) : base(regNumber) { }
    }
}
