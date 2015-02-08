using System.Collections.Generic;
using Android.App;
using Android.Views;
using Android.Widget;
using WcfServiceHost.Model;
using Xamarin.Tuvi2015.Droid;


namespace Xamarin.Tuvi2015.Droid.Adapters
{
    internal class MobileInformationAdapter : BaseAdapter<MobileInformation>
    {
        private readonly List<MobileInformation> MobileInformation;
        private readonly Activity context;

        public MobileInformationAdapter(Activity context, IEnumerable<MobileInformation> MobileInformation)
        {
            this.context = context;
            this.MobileInformation = new List<MobileInformation>(MobileInformation);
        }

        public override MobileInformation this[int position]
        {
            get { return MobileInformation[position]; }
        }

        public override int Count
        {
            get { return MobileInformation.Count; }
        }

        public override long GetItemId(int position)
        {
            return position;
        }

        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            View view = convertView ?? context.LayoutInflater.Inflate(Resource.Layout.MonkeyInformation, null);

            var familyName = view.FindViewById<TextView>(Resource.Id.familyNameText);
            var subfamily = view.FindViewById<TextView>(Resource.Id.subfamilyNameText);
            var commonName = view.FindViewById<TextView>(Resource.Id.commonNameText);
            var scientificNameText = view.FindViewById<TextView>(Resource.Id.scientificNameText);

            MobileInformation monkeyOfInterest = MobileInformation[position];

            familyName.Text = monkeyOfInterest.Family;
            subfamily.Text = monkeyOfInterest.Subfamily;
            commonName.Text = monkeyOfInterest.CommonName;
            scientificNameText.Text = monkeyOfInterest.ScientificName;

            return view;
        }

        public void RefreshData(IEnumerable<MobileInformation> updatedMonkeyInfo)
        {
            MobileInformation.Clear();
            MobileInformation.AddRange(updatedMonkeyInfo);

            context.RunOnUiThread(() => NotifyDataSetChanged());
        }
    }
}