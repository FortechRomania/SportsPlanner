using Android.Widget;
using GalaSoft.MvvmLight.Views;

namespace SportsPlanner.Droid
{
    public partial class MainActivity : ActivityBase
    {
        private TextView _pageTitle;

        public TextView PageTitle
        {
            get
            {
                return _pageTitle
                    ?? (_pageTitle = FindViewById<TextView>(Resource.Id.pageTitle));
            }
        }

        private Button _getEventsBtn;

        public Button GetEventsBtn
        {
            get
            {
                return _getEventsBtn
                    ?? (_getEventsBtn = FindViewById<Button>(Resource.Id.btn_getEvents));
            }
        }
    }
}