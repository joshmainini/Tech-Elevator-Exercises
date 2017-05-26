using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PostageCalculator.Classes;

namespace PostageCalculator
{
   public class Program
    {
        static void Main(string[] args)
        {
			List<IDeliveryDriver> myDrivers = new List<IDeliveryDriver>();
			myDrivers.Add(new FirstClass());
			myDrivers.Add(new SecondClass());
			myDrivers.Add(new ThirdClass());
			myDrivers.Add(new FexEd());
			myDrivers.Add(new FourDayGround());
			myDrivers.Add(new TwoDayGround());
			myDrivers.Add(new NextDay());

			Console.WriteLine("Please enter the weight of the package?");
			double packageWeight = double.Parse(Console.ReadLine());
			Console.WriteLine("(P)ounds or (O)unces?");
			string weightDescription = Console.ReadLine();
			if (weightDescription == "P")
			{
				packageWeight *= 16;
			}
			Console.WriteLine("What distance will it be traveling to?");
			int distanceTraveled = int.Parse(Console.ReadLine());
			Console.WriteLine();
			Console.WriteLine();
			Console.WriteLine("{0,-40} ${1,-40}", "Delivery Method", "$ cost");
			Console.WriteLine("-------------------------------------------------");



			foreach (IDeliveryDriver driver in myDrivers)
			{
				double totalCost = driver.CalculateRate(distanceTraveled, packageWeight);
				string stringDrivers = driver.ToString();
				Console.WriteLine("{0,-40} ${1,-40:0.00}", stringDrivers,totalCost);
			}
        }
    }
}



