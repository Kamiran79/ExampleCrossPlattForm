using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace ExampleCrossPlattForm.Views
{
    public partial class ImageDemo : ContentPage
    {
        public ImageDemo()
        {
            InitializeComponent();
            var imgSource = new UriImageSource
            { Uri = new Uri("http://lorempixel.com/400/200/sports/2/") };
           //imgSource.CachingEnabled = false; // if this true that will keep img for 4 hrs on the phone device.
            //imgSource.CacheValidity = TimeSpan.FromHours(4);
            img.Source = imgSource;
            
        }
    }
}
