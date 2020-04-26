using System;

using Xamarin.Forms;

namespace ExampleCrossPlattForm.Views
{
    public class ImgDemo : ContentPage
    {
        public ImgDemo()
        {
            Content = new StackLayout
            {
                Children = {
                    new Label { Text = "Hello ContentPage" }
                }
            };
        }
    }
}

