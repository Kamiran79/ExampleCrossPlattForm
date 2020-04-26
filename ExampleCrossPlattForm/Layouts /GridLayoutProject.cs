using System;

using Xamarin.Forms;

namespace ExampleCrossPlattForm.Layouts
{
    public class GridLayoutProject : ContentPage
    {
        public GridLayoutProject()
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

