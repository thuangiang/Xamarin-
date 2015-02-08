using System;
using System.Linq;
using Android.App;
using Android.OS;
using Android.Views;
using Android.Views.InputMethods;
using Android.Widget;
using WcfServiceHost.Model;
using Xamarin.Tuvi2015.Droid;
using Xamarin.Tuvi2015.Client;
using Xamarin.Tuvi2015.Droid.Adapters;

namespace Xamarin.Tuvi2015.Droid
{
    [Activity(Label = "Tu vi 2015", MainLauncher = true, Icon = "@drawable/Tuvi2015",
        WindowSoftInputMode = SoftInput.StateHidden)]
    public class MainActivity : Activity
    {
        private MobileServiceClient MobileServiceClient;
        private MobileInformationAdapter adapter;
        private static string Tuoi;
        private static int index_tuoi;
        private EditText familyText;
        private EditText genusText;
        private Button getRandomMobileButton;
        private TextView randomMobileLabel;
        private ImageButton searchButton;
        private ListView searchResultsList;
        private EditText subfamilyText;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            SetContentView(Resource.Layout.Main);


            InitializeHelloWorldServiceClient();

            getRandomMobileButton = FindViewById<Button>(Resource.Id.getRandomMonkeyButton);
            getRandomMobileButton.Click += getRandomMobileButton_Click;

            //randomMobileLabel = FindViewById<TextView>(Resource.Id.randomMonkeyLabel);

            //familyText = FindViewById<EditText>(Resource.Id.familyText);
            //subfamilyText = FindViewById<EditText>(Resource.Id.subfamilyText);
            //genusText = FindViewById<EditText>(Resource.Id.genusText);

            searchButton = FindViewById<ImageButton>(Resource.Id.searchButton);
            searchButton.Click += searchButton_Click;

            searchResultsList = FindViewById<ListView>(Resource.Id.searchResultsList);

            adapter = new MobileInformationAdapter(this, Enumerable.Empty<MobileInformation>());
            searchResultsList.Adapter = adapter;

            Spinner spinner = FindViewById<Spinner>(Resource.Id.spinner);

            spinner.ItemSelected += new EventHandler<AdapterView.ItemSelectedEventArgs>(spinner_ItemSelected);
            var adapter2 = ArrayAdapter.CreateFromResource(
                    this, Resource.Array.planets_array, Android.Resource.Layout.SimpleSpinnerItem);

            adapter2.SetDropDownViewResource(Android.Resource.Layout.SimpleSpinnerDropDownItem);
            spinner.Adapter = adapter2;
        }

        private void spinner_ItemSelected(object sender, AdapterView.ItemSelectedEventArgs e)
        {
            Spinner spinner = (Spinner)sender;
            index_tuoi = e.Position;
            Tuoi = (string) spinner.GetItemAtPosition(e.Position);
            //Toast.MakeText(this, Tuoi, ToastLength.Long).Show();
        }
        private void getRandomMobileButton_Click(object sender, EventArgs e)
        {
            MobileServiceClient.GetRandomMobileNameAsync();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            //var inputManager = (InputMethodManager) GetSystemService(InputMethodService);
            //inputManager.HideSoftInputFromWindow(CurrentFocus.WindowToken, HideSoftInputFlags.NotAlways);

            MobileServiceClient.GetMobileMatchAsync(
                new MobileQuery
                {
                    Family = "",
                    Subfamily = "",
                    Genus = Tuoi
                });
        }

        //TODO: Step 6 - Android - Initialize our Service
        private void InitializeHelloWorldServiceClient()
        {
            MobileServiceClient = MobileServiceClientHelper.CreateMobileServiceClient();
            MobileServiceClient.GetMobileMatchCompleted += GetMobileMatchCompleted;
            MobileServiceClient.GetRandomMobileNameCompleted += GetRandomMobileNameCompleted;
        }

        private void GetRandomMobileNameCompleted(object sender, GetRandomMobileNameCompletedEventArgs e)
        {
            string msg = string.Empty;

            if (e.Error != null)
                msg = e.Error.Message;
            else if (e.Cancelled)
                msg = "Request was canceled";
            else
                msg = e.Result;

            RunOnUiThread(() => randomMobileLabel.Text = msg);
        }

        private void GetMobileMatchCompleted(object sender, GetMobileMatchCompletedEventArgs e)
        {
            if (e.Error != null)
            {
                Toast.MakeText(this, e.Error.Message, ToastLength.Short).Show();
                return;
            }

            if (e.Cancelled)
            {
                Toast.MakeText(this, "Request was canceled", ToastLength.Short).Show();
                return;
            }

            adapter.RefreshData(e.Result);
        }
    }
}