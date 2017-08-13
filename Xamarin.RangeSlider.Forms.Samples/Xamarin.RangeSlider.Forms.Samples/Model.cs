using System.ComponentModel;

namespace Xamarin.RangeSlider.Forms.Samples
{
    public class Model: INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public float MinValue { get; set; } = 2;
        public float MaxValue { get; set; } = 78;
        public float LowerValue { get; set; } = 7;
        public float UpperValue { get; set; } = 55;
    }
}