using System;
using System.Net.Http;
using SportsPlanner.Entities;
using SportsPlanner.Gateways;


using UIKit;

namespace SportsPlanner.iOS
{
	public partial class ViewController : UIViewController
	{
		private IEventsGateway _eventsGateway;

		public ViewController(IntPtr handle) : base(handle)
		{
			_eventsGateway = new EventsApiGateway();
		}

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();
			// Perform any additional setup after loading the view, typically from a nib.
			Button.TouchUpInside += async delegate
			{
				UIApplication.SharedApplication.NetworkActivityIndicatorVisible = true;

				var searchEventsResult = await _eventsGateway.GetEventsAsync();
				DisplaySearchEventsResult(searchEventsResult);

				UIApplication.SharedApplication.NetworkActivityIndicatorVisible = false;
			};
		}

		private void DisplaySearchEventsResult(SearchEventsResult searchEventsResult)
		{
			var alertController = new UIAlertController();
			alertController.Title = "Search Events Result";
			alertController.Message = String.Format("Did receive the {0} events", searchEventsResult.Details.Total);

			var dismissAction = UIAlertAction.Create("Dismiss", UIAlertActionStyle.Cancel, null);
			alertController.AddAction(dismissAction);

			PresentViewController(alertController, true, null);
		}
	}
}

