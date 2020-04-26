using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace ExampleCrossPlattForm.Views
{
    public partial class ControlExample : ContentPage
    {
        public ControlExample()
        {
            InitializeComponent();
        }

        void Entry_TextChanged(System.Object sender, Xamarin.Forms.TextChangedEventArgs e)
        {
            // Text Changed event will fire the movement you enter each and every character
            lblpwd.Text = e.NewTextValue.ToString();
        }

        void etryname_Completed(System.Object sender, System.EventArgs e)
        {
            // Text Completed Event fires after press enter, It mean after entered omplete Value in the Entry
            lblname.Text = e.ToString();
        }
    }
}
