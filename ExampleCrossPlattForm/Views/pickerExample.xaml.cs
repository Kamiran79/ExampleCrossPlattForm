using System;
using System.Collections.Generic;
using System.Linq;
using ExampleCrossPlattForm.DataModel;
using ExampleCrossPlattForm.Model;
using Xamarin.Forms;

namespace ExampleCrossPlattForm.Views
{
    public partial class pickerExample : ContentPage
    {
        FruitData fruitdata = new FruitData();
        public pickerExample()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            fruitpicker.ItemsSource = fruitdata.GetFruits().ToList();
            
        }

        void fruitpicker_SelectedIndexChanged(System.Object sender, System.EventArgs e)
        {
            var current = (Fruit)fruitpicker.ItemsSource[fruitpicker.SelectedIndex];
            labelName.Text = current.Name.ToString();
            imgurl.Source = current.ImageUrl;
            lblDescription.Text = current.Description.ToString();
        }
        //void Contactus_SelectedIndexChanged(System.Object sender, System.EventArgs e)
        //{
        //    var selected = contactus.Items[contactus.SelectedIndex];
        //    DisplayAlert("Selected Item", selected, "OK");
        //}/
    }
}
