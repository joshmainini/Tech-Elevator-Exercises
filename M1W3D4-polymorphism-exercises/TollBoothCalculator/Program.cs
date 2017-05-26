using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TollBoothCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
			int distanceTraveled;
			int sum = 0;
			decimal totalToll = 0;

			List<IVehicle> vehicles = new List<IVehicle>();
			vehicles.Add(new Truck(8));
			vehicles.Add(new Car(false));
			vehicles.Add(new Tank());
			vehicles.Add(new Car(true));

			Random rnd = new Random();
			Console.WriteLine("{0,-20} {1,-20} {2,-20}", "Vehicle", "Distance Traveled", "Toll $");
			Console.WriteLine();
			foreach (IVehicle vehicle in vehicles)
			{
				distanceTraveled = rnd.Next(10, 241);
				sum = (sum + distanceTraveled);
				string stringVehicle = vehicle.ToString();
				double tollCost = vehicle.CalculateToll(distanceTraveled);
				totalToll += (decimal)tollCost;
				Console.WriteLine("{0,-20} {1,-20} ${2,-20:0.00}", stringVehicle, distanceTraveled, tollCost);

			}
			double totalMiles = (double)sum / 100;
			Console.WriteLine();
			Console.WriteLine();
			Console.WriteLine("Total Miles Traveled: {0}", totalMiles);
			Console.WriteLine("Total Tollbooth Revenue: ${0:0.00}", totalToll);

		}
    }
}
