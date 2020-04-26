using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace ExampleCrossPlattForm.Layouts
{
    public partial class AbsoluteExLayout : ContentPage
    {
        public AbsoluteExLayout()
        {
            InitializeComponent();
        }

        void btnClick_Clicked(System.Object sender, System.EventArgs e)
        {
            minibox.Color = Color.SeaGreen;
        }
    }
}
