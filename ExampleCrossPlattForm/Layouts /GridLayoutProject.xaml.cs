using System;
using System.Collections.Generic;
using System.Diagnostics;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;


/*
 * ******************************************************
 * ****{ CITC-2376-MOBILE APPLICATION DEVELOPMENT }******
 * **    This program by student: KAMIRAN IBRAHIM   **   
 * **             STUDENT A# A00417993              **   
 * **             SPRING 2020 SEMESTER              **   
 * ******************************************************
 * *************** Grid Layout Project  *****************
 * ******************************************************
 */


namespace ExampleCrossPlattForm.Layouts
{
    public partial class GridLayoutProject : ContentPage
    {
        public GridLayoutProject()
        {
            InitializeComponent();
            phoneNumber.Text = "";
        }

        void btnNum1_Clicked(System.Object sender, System.EventArgs e)
        {
            var n1 = btnNum1.Text;
            phoneNumber.Text += n1;
        }

        void btnNum2_Clicked(System.Object sender, System.EventArgs e)
        {
            var n2 = btnNum2.Text;
            phoneNumber.Text += n2;
        }

        void btnNum3_Clicked(System.Object sender, System.EventArgs e)
        {
            var n3 = btnNum3.Text;
            phoneNumber.Text += n3;
        }

        void btnNum4_Clicked(System.Object sender, System.EventArgs e)
        {
            var n4 = btnNum4.Text;
            phoneNumber.Text += n4;

        }

        void btnNum5_Clicked(System.Object sender, System.EventArgs e)
        {
            var n5 = btnNum5.Text;
            phoneNumber.Text += n5;

        }

        void btnNum6_Clicked(System.Object sender, System.EventArgs e)
        {
            var n6 = btnNum6.Text;
            phoneNumber.Text += n6;

        }

        void btnNum7_Clicked(System.Object sender, System.EventArgs e)
        {
            var n7 = btnNum7.Text;
            phoneNumber.Text += n7;

        }

        void btnNum8_Clicked(System.Object sender, System.EventArgs e)
        {
            var n8 = btnNum8.Text;
            phoneNumber.Text += n8;

        }

        void btnNum9_Clicked(System.Object sender, System.EventArgs e)
        {
            var n9 = btnNum9.Text;
            phoneNumber.Text += n9;

        }

        void btnNum0_Clicked(System.Object sender, System.EventArgs e)
        {
            var n0 = btnNum0.Text;
            phoneNumber.Text += n0;

        }

        async void btnDail_Clicked(System.Object sender, System.EventArgs e)
        {

            await DisplayAlert("Dailing", phoneNumber.Text, "End");

            phoneNumber.Text = "";


            // you can use this below to add choices to pop up windows or like display alert....  but need to add the async
            /*
            string action = await DisplayActionSheet("Do you want Keep the dailed Number after Dailing?", "Cancel", null, "Keep the Dailed Number", "Clear the Dailed Number");

            if (action == "Keep the Dailed Number")
            {
                //phoneNumber.Text = "Email CHoose!";
            }
            else
                if(action == "Clear the Dailed Number")
            {

            }
            */

            // you can use this to have OK, or Cancel on DisplayAlert.
            /*
            Debug.WriteLine("Action: " + action);


            var result = await DisplayAlert("Success", "Form Saved", "Ok", "Cancel"); // since we are using async, we should specify the DisplayAlert as awaiting.
            if (result == true) // if it's equal to Ok
            {
                Navigation.PopAsync(new YourHomePage());
            }
            else // if it's equal to Cancel
            {
                return; // just return to the page and do nothing.
            }
            */




        }
    }
}
