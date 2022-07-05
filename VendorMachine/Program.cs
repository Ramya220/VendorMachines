using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendorMachine
{
	class Program
	{
		static void Main(string[] args)
		{
			var FoodMachine = new FoodMachine();
			while (!FoodMachine.checkTotal())
			{
				Console.WriteLine("Please Enter Coin or a dollar amount (0.05,0.1,0.25)");

				FoodMachine.DepositCoin(Convert.ToDouble(Console.ReadLine()));

			}
			while(FoodMachine.checkTotal())
			{
				FoodMachine.DisplayFoodSelection();
			}
			Console.ReadLine();
		}
	}
}
