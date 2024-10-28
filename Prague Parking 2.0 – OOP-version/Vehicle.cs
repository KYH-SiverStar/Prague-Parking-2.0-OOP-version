using System;
     
    // Basklass för alla fordon
    public abstract class Vehicle
    {
        public string RegNumber { get; set; }
        public DateTime ArrivalTime { get; set; }
        public abstract string Type { get; }

        public Vehicle(string regNumber)
        {
            RegNumber = regNumber;
            ArrivalTime = DateTime.Now;
        }
    }
public class ParkingSpot
{
    public Vehicle Vehicle { get; set; }

    public ParkingSpot(Vehicle vehicle)
    {
        Vehicle = vehicle;
    }
}


