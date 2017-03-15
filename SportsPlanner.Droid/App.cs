using SportsPlanner.ViewModels;
using GalaSoft.MvvmLight.Threading;

namespace SportsPlanner.Droid
{
    public static class App
    {
        private static ViewModelLocator locator;

        public static ViewModelLocator Locator
        {
            get
            {
                if (locator == null)
                {
                    // Initialize the MVVM Light DispatcherHelper.
                    // This needs to be called on the UI thread.
                    DispatcherHelper.Initialize();

                    locator = new ViewModelLocator();
                }

                return locator;
            }
        }
    }
}