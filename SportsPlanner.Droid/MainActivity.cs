using Android.App;
using Android.Widget;
using Android.OS;
using SportsPlanner.ViewModels;
using System.Collections.Generic;
using GalaSoft.MvvmLight.Helpers;
using GalaSoft.MvvmLight.Views;

namespace SportsPlanner.Droid
{
    [Activity(Label = "SportsPlanner.Droid", MainLauncher = true, Icon = "@drawable/icon")]
	public partial class MainActivity : ActivityBase
	{
        // Keep track of bindings to avoid premature garbage collection
        private readonly List<Binding> bindings = new List<Binding>();

        // Gets a reference to the MainViewModel from the ViewModelLocator.
        private MainViewModel ViewModel
        {
            get
            {
                return App.Locator.MainViewModel;
            }
        }

		protected override void OnCreate(Bundle bundle)
		{
			base.OnCreate(bundle);

			// Set our view from the "main" layout resource
			SetContentView(Resource.Layout.Main);

            GetEventsBtn.SetCommand(nameof(Android.Views.View.Click), ViewModel.GetEventsCommand);

            bindings.Add(
                this.SetBinding(
                    () => ViewModel.PageTitle,
                    () => PageTitle.Text));
        }
	}
}
