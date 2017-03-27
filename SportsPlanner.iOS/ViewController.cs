using System;
using UIKit;
using System.Collections.Generic;
using GalaSoft.MvvmLight.Helpers;
using SportsPlanner.ViewModels;

namespace SportsPlanner.iOS
{
    public partial class ViewController : UIViewController
	{
        // Keep track of bindings to avoid premature garbage collection
        private readonly List<Binding> bindings = new List<Binding>();

        // Gets a reference to the MainViewModel from the ViewModelLocator.
        private MainViewModel ViewModel
        {
            get
            {
                return Application.Locator.MainViewModel;
            }
        }

        public ViewController(IntPtr handle) : base(handle)
		{
		}

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();

            Button.SetCommand(nameof(UIControl.TouchUpInside), ViewModel.GetEventsCommand);
        }
	}
}

