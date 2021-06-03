using System;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

using WeightAndSee2.Services;
using WeightAndSee2.Models;

namespace WeightAndSee2.ViewModels
{
    public class AboutViewModel : BaseViewModel
    {
        public AboutViewModel()
        {
            Title = "About";
            OpenWebCommand = new Command(async () => await Browser.OpenAsync("https://aka.ms/xamarin-quickstart"));
            
            var AllUsers = UserDataStore.GetItemsAsync().Result;
            System.Diagnostics.Debug.Assert(AllUsers != null);
            System.Diagnostics.Debug.Assert(AllUsers.Count == 1);

            var AllProfiles = ProfileDataStore.GetItemsAsync().Result;
            System.Diagnostics.Debug.Assert(AllProfiles != null);
            System.Diagnostics.Debug.Assert(AllProfiles.Count == 1);

            var AllDataPoints = DataPointStore.GetItemsAsync().Result;
            System.Diagnostics.Debug.Assert(AllDataPoints != null);
            System.Diagnostics.Debug.Assert(AllDataPoints.Count == 1);

            SQLiteUserDataPointStore UserDataPointStore = (SQLiteUserDataPointStore) DataPointStore;
            var RelevantDataPoints = UserDataPointStore.GetDataPoints(AllUsers[0]);
        }

        public ICommand OpenWebCommand { get; }
    }
}