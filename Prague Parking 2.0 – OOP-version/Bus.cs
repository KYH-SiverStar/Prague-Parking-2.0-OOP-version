using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prague_Parking_2._0___OOP_version
{
    internal class Bus : Vehicle
    {
        public override string Type {
        get { return "Bus";}

        public Bus(string regNumber) : base(regNumber) { }
    }
}
