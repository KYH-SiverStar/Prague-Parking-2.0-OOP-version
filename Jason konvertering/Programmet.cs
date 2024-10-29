using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Jason_konvertering
{
    internal class Programmet
    {
    }
}






// Main program
class Program
{
    static void Main()
    {
        ParkingGarage garage = new ParkingGarage();

        bool running = true;
        while (running)
        {
            Console.WriteLine("1. Parkera fordon\n2. Flytta fordon\n3. Ta bort fordon\n4. Skriv ut parkeringsplatser\n5. Avsluta");
            Console.Write("Välj ett alternativ: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.Write("Ange fordonstyp (CAR/MC): ");
                    string type = Console.ReadLine().ToUpper();
                    Console.Write("Ange registreringsnummer: ");
                    string regNumber = Console.ReadLine();

                    Vehicle vehicle = type == "CAR" ? new Car(regNumber) : type == "MC" ? new MC(regNumber) : null;
                    if (vehicle != null)
                        garage.ParkVehicle(vehicle);
                    else
                        Console.WriteLine("Ogiltig fordonstyp.");
                    break;

                case "2":
                    Console.Write("Ange från plats: ");
                    if (int.TryParse(Console.ReadLine(), out int fromSpot))
                    {
                        Console.Write("Ange till plats: ");
                        if (int.TryParse(Console.ReadLine(), out int toSpot))
                            garage.MoveVehicle(fromSpot, toSpot);
                        else
                            Console.WriteLine("Ogiltigt platsnummer.");
                    }
                    else
                        Console.WriteLine("Ogiltigt platsnummer.");
                    break;

                case "3":
                    Console.Write("Ange registreringsnummer: ");
                    regNumber = Console.ReadLine();
                    garage.RemoveVehicle(regNumber);
                    break;

                case "4":
                    garage.PrintParkingSpots();
                    break;

                case "5":
                    running = false;
                    break;

                default:
                    Console.WriteLine("Ogiltigt alternativ.");
                    break;
            }
        }
    }
}