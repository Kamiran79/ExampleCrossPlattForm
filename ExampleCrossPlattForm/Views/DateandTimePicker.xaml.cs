using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace ExampleCrossPlattForm.Views
{
    public partial class DateandTimePicker : ContentPage
    {
        public DateandTimePicker()
        {
            InitializeComponent();
        }

        void enddate_DateSelected(System.Object sender, Xamarin.Forms.DateChangedEventArgs e)
        {
            //TimeSpan timeSpan = enddate.Date - startdate.Date;
            //DisplayAlert("Days", timeSpan.Days.ToString(), "OK");
            calculate();
        }

        void Button_Clicked(System.Object sender, System.EventArgs e)
        {
        }

        void btndays_Clicked(System.Object sender, System.EventArgs e)
        {
        }

        void btndays_Clicked_1(System.Object sender, System.EventArgs e)
        {
        }

        void btndays_Clicked_2(System.Object sender, System.EventArgs e)
        {
            calculate();
        }

        void calculate()
        {
            TimeSpan extra = (swi.IsToggled) ? TimeSpan.FromDays(1):TimeSpan.Zero;
            TimeSpan timeSpan = enddate.Date - startdate.Date + extra;
            resultlbl.Text = String.Format("{0} day{1} gap between dates",
                timeSpan.Days, timeSpan.Days==1?" ": "s");
            
            
            //DisplayAlert("Days", timeSpan.Days.ToString(), "OK");
            
        }

        void swi_Toggled(System.Object sender, Xamarin.Forms.ToggledEventArgs e)
        {
            calculate();

        }
    }
}
