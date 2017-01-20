using System;
using MvvmCross.Core.ViewModels;

namespace Calculator_MVVMCross
{
	public class CalculatorViewModel:MvxViewModel 
	{
		ICalculatorService _calculator;

		public CalculatorViewModel(ICalculatorService calculator)
		{
			_calculator = calculator;
		}

		public override void Start()
		{
			FirstNumber = 0;
			SecondNumber = 0;
			recalculate();
			base.Start();
		}

		double _firstNumber;
		public double FirstNumber
		{
			get { return _firstNumber; }
			set { _firstNumber = value; RaisePropertyChanged(() => FirstNumber); recalculate();}
		}

		double _secondNumber;
		public double SecondNumber
		{
			get { return _secondNumber; }
			set { _secondNumber = value; RaisePropertyChanged(() => SecondNumber);recalculate(); }
		}

		double _result;
		public double Result
		{
			get { return _result; }
			set { _result = value; RaisePropertyChanged(() => Result);}
		}

		public void recalculate()
		{
		    Result = FirstNumber + SecondNumber;
		}
	}
}
