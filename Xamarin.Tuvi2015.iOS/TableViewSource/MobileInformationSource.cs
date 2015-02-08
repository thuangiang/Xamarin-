using System.Collections.Generic;
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using WcfServiceHost.Model;

namespace Xamarin.Tuvi2015.iOS.TableViewSource
{
    internal class MobileInformationSource : UITableViewSource
    {
        private readonly NSString MobileCellIdentifier = new NSString("MobileCell");

        private readonly List<MobileInformation> MobileInformation;

        public MobileInformationSource(IEnumerable<MobileInformation> MobileInformation)
        {
            this.MobileInformation = new List<MobileInformation>(MobileInformation);
        }

        public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
        {
            UITableViewCell cell =
                tableView.DequeueReusableCell(MobileCellIdentifier)
                ?? new UITableViewCell(UITableViewCellStyle.Subtitle, MobileCellIdentifier);

            MobileInformation MobileOfInterest = MobileInformation[indexPath.Row];

            cell.TextLabel.Text = MobileOfInterest.CommonName;
            cell.DetailTextLabel.Text = MobileOfInterest.ScientificName;
            return cell;
        }

        public override int RowsInSection(UITableView tableview, int section)
        {
            return MobileInformation.Count;
        }

        public void RefreshData(UITableView tableview, IEnumerable<MobileInformation> updatedMobileInfo)
        {
            MobileInformation.Clear();
            MobileInformation.AddRange(updatedMobileInfo);

            BeginInvokeOnMainThread(() => tableview.ReloadData());
        }
    }
}