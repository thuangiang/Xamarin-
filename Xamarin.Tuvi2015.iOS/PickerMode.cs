using System;
using System.Collections.Generic;
using System.Text;
using MonoTouch.UIKit;

namespace Xamarin.Tuvi2015.iOS
{
    public class PickerModel : UIPickerViewModel
    {
        public IList<Object> values;

        public event EventHandler<PickerChangedEventArgs> PickerChanged;

        public PickerModel(IList<Object> values)
        {
            this.values = values;
        }

        public override int GetComponentCount(UIPickerView picker)
        {
            return 1;
        }

        public override int GetRowsInComponent(UIPickerView picker, int component)
        {
            return values.Count;
        }

        public override string GetTitle(UIPickerView picker, int row, int component)
        {
            return values[row].ToString();
        }

        public override float GetRowHeight(UIPickerView picker, int component)
        {
            return 40f;
        }

        public override void Selected(UIPickerView picker, int row, int component)
        {
            if (this.PickerChanged != null)
            {
                this.PickerChanged(this, new PickerChangedEventArgs { SelectedValue = values[row] });
            }
        }
    }

    public class PickerChangedEventArgs : EventArgs
    {
        public object SelectedValue { get; set; }
    }
}
