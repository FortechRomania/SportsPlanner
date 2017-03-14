using System;
using System.Net.Http;
using SportsPlanner.Entities;
using SportsPlanner.Gateways;

using Android.App;
using Android.Widget;
using Android.OS;

namespace SportsPlanner.Droid
{
	[Activity(Label = "SportsPlanner.Droid", MainLauncher = true, Icon = "@drawable/icon")]
	public class MainActivity : Activity
	{
		private IEventsGateway _eventsGateway;

		protected override void OnCreate(Bundle bundle)
		{
			base.OnCreate(bundle);
			_eventsGateway = new EventsApiGateway();

			// Set our view from the "main" layout resource
			SetContentView(Resource.Layout.Main);

			// Get our button from the layout resource,
			// and attach an event to it
			Button button = FindViewById<Button>(Resource.Id.myButton);

			button.Click += async delegate
			{
				var searchEventsResult = await _eventsGateway.GetEventsAsync();
				DisplaySearchEventsResult(searchEventsResult);
			};
		}

		private void DisplaySearchEventsResult(SearchEventsResult searchEventsResult)
		{
			new AlertDialog.Builder(this).SetTitle("Search Events Result")
						   .SetMessage(String.Format("Did receive the {0} events", searchEventsResult.Details.Total))
						   .SetNegativeButton(Resource.String.dismiss_button, (sender, e) => { })
						   .Show();
		}
	}
}
