using System;
using Calculator_MVVMCross;
using MvvmCross.Binding.BindingContext;
using MvvmCross.iOS.Views;
using UIKit;

namespace Calculator.iOS
{
	public partial class CalculatorView : MvxViewController<CalculatorViewModel>
	{
		public CalculatorView() : base("CalculatorView", null)
		{
		}

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();
			// Perform any additional setup after loading the view, typically from a nib.
			this.CreateBinding(txtFirstNumber).To((CalculatorViewModel vm) => vm.FirstNumber).Apply();
			this.CreateBinding(txtSecondNumber).To((CalculatorViewModel vm) => vm.SecondNumber).Apply();
			this.CreateBinding(lblResult).To((CalculatorViewModel vm) => vm.Result).Apply();
		
			View.AddGestureRecognizer(new UITapGestureRecognizer(() =>
		{
				this.txtFirstNumber.ResignFirstResponder();
		}));

		}

		public override void DidReceiveMemoryWarning()
		{
			base.DidReceiveMemoryWarning();
			// Release any cached data, images, etc that aren't in use.
		}
	}
}

