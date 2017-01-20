using System;
namespace Calculator_MVVMCross
{
	public class CalculatorService:ICalculatorService
	{


		public double Add(int firstNumber, int secondNumber)
		{
			return firstNumber + secondNumber;
		}

	
	}
}
