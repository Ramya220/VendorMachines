using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendorMachine
{
	public class  FoodMachine
	{
		const double MIN_COST_OF_FOOD = 0.50;
		public double RunningTotal { get; set; }
		public double BalanceAmount { get; set; }
		public double selectioncost =0 ;
		public FoodMachine()
		{
			RunningTotal = 0;
			BalanceAmount = 0;
		}
		
		public bool DepositCoin(double coin)
		{
			//the only valid coins are nickels,dimens,quaters
			bool isvalid = true;
			switch (coin)
			{
				case (0.05):
					RunningTotal += 0.05 ;
					Console.WriteLine("Inserted NIKELS coin");
					break;
				case (0.1):
					RunningTotal += 0.1;
					Console.WriteLine("Inserted DIMES coin");
					break;
				case (0.25):
					RunningTotal += 0.25;
					Console.WriteLine("Inserted QUARTERS coin");
					break;
				default:
					Console.WriteLine("Invalid Entry");
					isvalid = false;
					break;


			}
			return isvalid;
		}
		public  bool checkTotal()
		{
			if (RunningTotal >= MIN_COST_OF_FOOD)
				return true;
			else
				return false;
		}
		
		public void DisplayFoodSelection()
		{
			Console.WriteLine("************************");
			Console.WriteLine("*   C- Cola           *");
			Console.WriteLine("*   H- Chips          *");
			Console.WriteLine("*   A- Candy          *");
			Console.WriteLine("************************");
			Console.WriteLine();
			Console.WriteLine("Please make your selection");
			

		}
		public bool MakeFoodSelection(char selection)
		{
			bool selectionok = false;
			
			
			while (!selectionok)
			{
				switch (selection)
				{
					case 'C':
						Console.WriteLine("Thank you for Choosong Cola");
						selectioncost += 1.00;
						ReturnChange(selectioncost);
						selectionok = true;
						break;
					case 'H':
						Console.WriteLine("Thank you for Choosong Chips");
						selectioncost += 0.50;
						ReturnChange(selectioncost);
						selectionok = true;
						break;
					case 'A':
						Console.WriteLine("Thank you for Choosong Candy");
						selectioncost += 0.65;
						ReturnChange(selectioncost);
						selectionok = true;
						break;
					default:
						Console.WriteLine("Invalid Selection. Please retry");
						selectionok = false;
						break;

				}
				if (!selectionok)
					break;
			}
			return selectionok;
		}
		private void ReturnChange( double selectioncost)
		{
			if (selectioncost > RunningTotal)
			{
				Console.WriteLine("You selected Item is higher than the inserted Coin of {0:C}", selectioncost - RunningTotal);
				selectioncost = 0;
			}
			else
			{
				Console.WriteLine(" Thank you for Shopping ! Your change is {0:C}", RunningTotal - selectioncost);
				RunningTotal = RunningTotal - selectioncost;
			}
		}
		
	}
}
	