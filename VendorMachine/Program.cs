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
			bool status,coinstatus;
			while (!FoodMachine.checkTotal())
			{
				Console.WriteLine("Please Enter Coin or a dollar amount (0.05,0.1,0.25)");

				coinstatus = FoodMachine.DepositCoin(Convert.ToDouble(Console.ReadLine()));
				if (!coinstatus)
					break;

			}
			while(FoodMachine.checkTotal())
			{
				FoodMachine.DisplayFoodSelection();
				status = FoodMachine.MakeFoodSelection(Convert.ToChar(Console.ReadLine().ToUpper()));
				if (!status)
					break;

			}
			Console.ReadLine();
		}
	}
}
