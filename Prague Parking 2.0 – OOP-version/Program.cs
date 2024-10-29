public class ParkingSpot
{ public Vehicle Vehicle { get; set; }
    public ParkingSpot(Vehicle vehicle) 
    { Vehicle = vehicle; }
}

public class ParkingGarage
{
    private List<ParkingSpot> parkingSpots;
    public ParkingGarage(int numSpots)
    {
        parkingSpots = new List<ParkingSpot>(numSpots);
        for (int i = 0; i < numSpots; i++)
        { parkingSpots.Add(null); }
    }
}
﻿
