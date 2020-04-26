using System;
using System.Collections.Generic;
using ExampleCrossPlattForm.Model;
using System.Collections.Generic;
using Xamarin.Forms;
using System.Linq;

namespace ExampleCrossPlattForm.Views
{
    public partial class ListViewDemo : ContentPage
    {

        // In the grouping we group based Name(Title)
        // Give shortTitle to display list on righside

        public ListViewDemo()
        {
            InitializeComponent();
            
        }

        void lview_ItemSelected(System.Object sender, Xamarin.Forms.SelectedItemChangedEventArgs e)
        {
        }

        void lview_ItemTapped(System.Object sender, Xamarin.Forms.ItemTappedEventArgs e)
        {
        }
    }
}
