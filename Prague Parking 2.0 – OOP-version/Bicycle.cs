using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prague_Parking_2._0___OOP_version
{
    public class Bicycle : Vehicle
    {
        public override string Type => "Bicycle";

        public Bicycle(string regNumber) : base(regNumber) { }
    }

}
