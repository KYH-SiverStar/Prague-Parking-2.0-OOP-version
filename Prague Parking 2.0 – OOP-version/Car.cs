using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prague_Parking_2._0___OOP_version
{
    internal class Car : Vehicle
    {
        // genskap som returnerar typen av fordon
        public override string Type
        {
        get { return "Car";}
        // anropar basklassens konstruktor och
        // skickar registreringsnumret till basklassen Vehicle
        public Car(string regNumber) : base(regNumber) { }

    }
}
