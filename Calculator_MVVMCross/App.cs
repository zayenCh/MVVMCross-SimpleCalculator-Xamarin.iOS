using System;
using MvvmCross.Core.ViewModels;
using MvvmCross.Platform;

namespace Calculator_MVVMCross
{
	public class App:MvxApplication
	{
		public App()
		{
			Mvx.RegisterType<ICalculatorService, CalculatorService>();
			Mvx.RegisterSingleton<IMvxAppStart>(new MvxAppStart<CalculatorViewModel>());
		}
	}
}
