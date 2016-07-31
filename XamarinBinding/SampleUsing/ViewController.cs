using System;

using UIKit;

namespace SampleUsing
{
	public partial class ViewController : UIViewController
	{
		protected ViewController(IntPtr handle) : base(handle)
		{
			// Note: this .ctor should not contain any initialization logic.
		}

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();

			var myClass = new XamarinBindingLibrary.MyClass();
			lblText.Text = myClass.Value;
		}
	}
}

