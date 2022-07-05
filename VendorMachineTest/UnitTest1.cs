using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using VendorMachine;

namespace VendorMachineTest
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void TestMethod1()
		{
			var FoodMachine = new FoodMachine();
			FoodMachine.DepositCoin(Convert.ToDouble(Console.ReadLine()));

			FoodMachine.DisplayFoodSelection();
		}
	}
}
