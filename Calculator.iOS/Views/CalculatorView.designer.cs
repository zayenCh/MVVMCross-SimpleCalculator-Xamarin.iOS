// WARNING
//
// This file has been generated automatically by Xamarin Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace Calculator.iOS
{
    [Register ("CalculatorView")]
    partial class CalculatorView
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel lblResult { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField txtFirstNumber { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField txtSecondNumber { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (lblResult != null) {
                lblResult.Dispose ();
                lblResult = null;
            }

            if (txtFirstNumber != null) {
                txtFirstNumber.Dispose ();
                txtFirstNumber = null;
            }

            if (txtSecondNumber != null) {
                txtSecondNumber.Dispose ();
                txtSecondNumber = null;
            }
        }
    }
}