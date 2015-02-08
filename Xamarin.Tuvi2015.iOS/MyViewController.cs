using System;
using System.Collections.Generic;
using System.Linq;
using MonoTouch.CoreAnimation;
using MonoTouch.UIKit;
using System.Drawing;
using WcfServiceHost.Model;
using Xamarin.Tuvi2015.Client;

namespace Xamarin.Tuvi2015.iOS
{
    public class MyViewController : UIViewController
    {
        const float padding = 2.0f;
        const float controlHeight = 34.0f;

        private MobileServiceClient MobileServiceClient;

        UIButton getRandomMobileButton, searchButton;

        private UILabel randomMobileName;

        private UITextField genus;

        private UITableView results;

        private TableViewSource.MobileInformationSource MobileInformationSource;

        private readonly IList<object> tuoList = new List<object>
            {
            "Tý",
            "Sửu",
            "Dần",
            "Mão",
            "Thìn",
            "Tỵ",
            "Ngọ",
            "Mùi",
            "Thân",
            "Dậu",
            "Tuất",
            "Hợi"
            };

        PickerModel picker_model;
        UIPickerView picker;

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            InitializeHelloWorldServiceClient();

            picker = new UIPickerView();
            picker_model = new PickerModel(tuoList);
            picker.Model = picker_model;
            picker.ShowSelectionIndicator = true;


            UIToolbar toolbar = new UIToolbar();
            toolbar.BarStyle = UIBarStyle.Black;
            toolbar.Translucent = true;
            toolbar.SizeToFit();

            UIBarButtonItem doneButton = new UIBarButtonItem("Done", UIBarButtonItemStyle.Done, (s, e) =>
            {
                foreach (UIView view in this.View.Subviews)
                {
                    if (view.IsFirstResponder)
                    {
                        UITextField textview = (UITextField)view;
                        textview.Text = picker_model.values[picker.SelectedRowInComponent(0)].ToString();
                        textview.ResignFirstResponder();
                    }
                }

            });
            toolbar.SetItems(new UIBarButtonItem[] { doneButton }, true);
           

            View.Frame = UIScreen.MainScreen.Bounds;
            View.BackgroundColor = UIColor.White;
            View.AutoresizingMask = UIViewAutoresizing.FlexibleWidth | UIViewAutoresizing.FlexibleHeight;

            getRandomMobileButton = CreateFlatButton();
            getRandomMobileButton.Frame = new RectangleF(padding, 22.0f, this.View.Frame.Width - (padding * 2), controlHeight);
            
            getRandomMobileButton.SetTitle("Get Random Mobile", UIControlState.Normal);

            getRandomMobileButton.TouchUpInside += (object sender, EventArgs e) => MobileServiceClient.GetRandomMobileNameAsync();
            
            randomMobileName = new UILabel
            {
                Frame = new RectangleF(padding, getRandomMobileButton.Frame.Bottom, this.View.Frame.Width - (padding*2), controlHeight), 
                TextAlignment = UITextAlignment.Center
            };

            AddBottomBorder(randomMobileName, 2.0f);


            var searchY = randomMobileName.Frame.Bottom + (padding * 5);

            genus = new UITextField
            {
                Frame = new RectangleF(170, searchY, 78, controlHeight), 
                Placeholder = "Tuổi"
            };
            genus.InputView = picker;
            genus.InputAccessoryView = toolbar;

            AddBottomBorder(genus, 2.0f);

            searchButton = CreateFlatButton();
            searchButton.Frame = new RectangleF(250, searchY, 68, controlHeight);
            searchButton.SetTitle("Xem", UIControlState.Normal);

            searchButton.TouchUpInside += (object sender, EventArgs e) =>
            {
                DismissKeyboard();

                MobileServiceClient.GetMobileMatchAsync(
                    new MobileQuery()
                    {
                        Family =string.Empty,
                        Subfamily = string.Empty,
                        Genus = genus.Text
                    });
            };

            results = new UITableView
            {
                Frame = new RectangleF(0, searchButton.Frame.Bottom + padding, 
                                        this.View.Frame.Width, 
                                        this.View.Frame.Height - searchButton.Frame.Bottom - padding)
            };

            MobileInformationSource = new TableViewSource.MobileInformationSource(Enumerable.Empty<MobileInformation>());
            results.Source = MobileInformationSource;

            View.AddSubviews(getRandomMobileButton, randomMobileName, genus, searchButton, results);
        }

        //TODO: Step 6 - iOS - Initialize our Service
        private void InitializeHelloWorldServiceClient()
        {
            MobileServiceClient = MobileServiceClientHelper.CreateMobileServiceClient();
            MobileServiceClient.GetMobileMatchCompleted += GetMobileMatchCompleted;
            MobileServiceClient.GetRandomMobileNameCompleted += GetRandomMobileNameCompleted;
        }

      
        void GetRandomMobileNameCompleted(object sender, GetRandomMobileNameCompletedEventArgs e)
        {
            string msg;

            if (e.Error != null)
                msg = e.Error.Message;
            else if (e.Cancelled)
                msg = "Request was canceled";
            else
                msg = e.Result;

            BeginInvokeOnMainThread(() => randomMobileName.Text = msg);
        }

        void GetMobileMatchCompleted(object sender, GetMobileMatchCompletedEventArgs e)
        {
            if (e.Error != null)
            {
                var alert = new UIAlertView {Title = "Error", Message = e.Error.Message};

                alert.Show();

                return;
            }

            if (e.Cancelled)
            {
                var alert = new UIAlertView { Title = "Error", Message = "Request was canceled" };

                alert.Show();
                return;
            }

            MobileInformationSource.RefreshData(results, e.Result);
        }

        private void DismissKeyboard()
        {
            genus.ResignFirstResponder();
        }

        private void AddBottomBorder(UIView view, float borderSize)
        {
            var bottomBorder = CALayer.Create();
            bottomBorder.BorderColor = UIColor.LightGray.CGColor;
            bottomBorder.BorderWidth = borderSize;

            bottomBorder.Frame = new RectangleF(-borderSize, -borderSize, view.Frame.Width + (borderSize * 2), view.Frame.Height + borderSize);

            view.Layer.AddSublayer(bottomBorder);
        }

        private UIButton CreateFlatButton()
        {
            var button = UIButton.FromType(UIButtonType.Custom);
            button.HorizontalAlignment = UIControlContentHorizontalAlignment.Center;
            button.VerticalAlignment = UIControlContentVerticalAlignment.Center;
            button.SetTitleColor(UIColor.White, UIControlState.Normal);
            button.Layer.BackgroundColor = View.TintColor.CGColor;
            button.Layer.CornerRadius = 8.0f;

            return button;
        }
    }
}

