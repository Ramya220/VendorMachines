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
			bool status, coinstatus;
			while (!FoodMachine.checkTotal())
			{
				coinstatus=FoodMachine.DepositCoin(0.5);
				if (!coinstatus)
					break;
			}

			FoodMachine.DisplayFoodSelection();
			status = FoodMachine.MakeFoodSelection('C');
		}

		[TestMethod]
		public void TestMethod2()
		{
			var FoodMachine = new FoodMachine();
			bool status, coinstatus;
			while (!FoodMachine.checkTotal())
			{
				coinstatus=FoodMachine.DepositCoin(0.25);
				if (!coinstatus)
					break;
			}

			FoodMachine.DisplayFoodSelection();
			status = FoodMachine.MakeFoodSelection('C');
			
		}
		[TestMethod]
		public void TestMethod3()
		{
			var FoodMachine = new FoodMachine();
			bool status, coinstatus;
			while (!FoodMachine.checkTotal())
			{
				coinstatus=FoodMachine.DepositCoin(0.25);
				if (!coinstatus)
					break;
			}

			FoodMachine.DisplayFoodSelection();
			status = FoodMachine.MakeFoodSelection('A');
		}
		[TestMethod]
		public void TestMethod4()
		{
			var FoodMachine = new FoodMachine();
			bool status, coinstatus;
			while (!FoodMachine.checkTotal())
			{
				coinstatus=FoodMachine.DepositCoin(0.025);
				if (!coinstatus)
					break;
			}

			FoodMachine.DisplayFoodSelection();
			status = FoodMachine.MakeFoodSelection('H');
		}
		[TestMethod]
		public void TestMethod5()
		{
			var FoodMachine = new FoodMachine();
			bool status, coinstatus;
			while (!FoodMachine.checkTotal())
			{
				coinstatus=FoodMachine.DepositCoin(0.25);
				if (!coinstatus)
					break;
			}

			FoodMachine.DisplayFoodSelection();
			status = FoodMachine.MakeFoodSelection('D');
		}
		[TestMethod]
		public void TestMethod6()
		{
			var FoodMachine = new FoodMachine();
			bool status, coinstatus;
			while (!FoodMachine.checkTotal())
			{
				coinstatus=FoodMachine.DepositCoin(0.05);
				if (!coinstatus)
					break;
			}

			FoodMachine.DisplayFoodSelection();
			status = FoodMachine.MakeFoodSelection('C');
		}
		[TestMethod]
		public void TestMethod7()
		{
			var FoodMachine = new FoodMachine();
			bool status, coinstatus;
			while (!FoodMachine.checkTotal())
			{
				coinstatus=FoodMachine.DepositCoin(0.05);
				if (!coinstatus)
					break;
			}

			FoodMachine.DisplayFoodSelection();
			status = FoodMachine.MakeFoodSelection('H');
		}
		[TestMethod]
		public void TestMethod8()
		{
			var FoodMachine = new FoodMachine();
			bool status, coinstatus;
			while (!FoodMachine.checkTotal())
			{
				coinstatus=FoodMachine.DepositCoin(0.05);
				if (!coinstatus)
					break;
			}

			FoodMachine.DisplayFoodSelection();
			status = FoodMachine.MakeFoodSelection('A');
		}
		[TestMethod]
		public void TestMethod9()
		{
			var FoodMachine = new FoodMachine();
			bool status, coinstatus;
			while (!FoodMachine.checkTotal())
			{
				coinstatus = FoodMachine.DepositCoin(0.25);
				if (!coinstatus)
					break;
			}

			FoodMachine.DisplayFoodSelection();
			status = FoodMachine.MakeFoodSelection('H');
		}
	}
}
