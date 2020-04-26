using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;


/*
 * ******************************************************
 * ****{ CITC-2376-MOBILE APPLICATION DEVELOPMENT }******
 * **    This program by student: KAMIRAN IBRAHIM   **   
 * **             STUDENT A# A00417993              **   
 * **             SPRING 2020 SEMESTER              **   
 * ******************************************************
 * ***********  Button Calculator Project  **************
 * ******************************************************
 */


namespace App1.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ExampleCalculator : ContentPage
	{
		public ExampleCalculator ()
		{
			InitializeComponent ();
		}

        private void btnAdd_Clicked(object sender, EventArgs e)
        {
            
            string strResult = "";

            double nn1, nn2;

            double result = 0;

            try
            {
                nn1 = Double.Parse(number1.Text);
                nn2 = Double.Parse(number2.Text);

                result = nn1 + nn2;

                strResult = result.ToString();

                DisplayAlert("Result", strResult, "OK");
            }
            catch (Exception)
            {

                DisplayAlert("Error", "Wrong entry please try enter a number.","OK");
                number1.Text = "";
                number2.Text = "";
                number1.Focus();
            }

        }

        private void btnSub_Clicked(object sender, EventArgs e)
        {
            string strResult = "";

            double nn1, nn2;

            double result = 0;

            try
            {
                nn1 = Double.Parse(number1.Text);
                nn2 = Double.Parse(number2.Text);

                result = nn1 - nn2;

                strResult = result.ToString();

                DisplayAlert("Result", strResult, "OK");
            }
            catch (Exception)
            {

                DisplayAlert("Error", "Wrong entry please try enter a number.", "OK");
                number1.Text = "";
                number2.Text = "";
                number1.Focus();
            }

        }

        private void btnMult_Clicked(object sender, EventArgs e)
        {

            string strResult = "";

            double nn1, nn2;

            double result = 0;

            try
            {
                nn1 = Double.Parse(number1.Text);
                nn2 = Double.Parse(number2.Text);

                result = nn1 * nn2;

                strResult = result.ToString();

                DisplayAlert("Result", strResult, "OK");
            }
            catch (Exception)
            {

                DisplayAlert("Error", "Wrong entry please try enter a number.", "OK");
                number1.Text = "";
                number2.Text = "";
                number1.Focus();
            }

        }

        private void btnDiv_Clicked(object sender, EventArgs e)
        {
            string strResult = "";

            double nn1, nn2;

            double result = 0;

            try
            {
                nn1 = Double.Parse(number1.Text);
                nn2 = Double.Parse(number2.Text);

                result = nn1 / nn2;

                strResult = result.ToString();

                DisplayAlert("Result", strResult, "OK");
            }
            catch (Exception)
            {

                DisplayAlert("Error", "Wrong entry please try enter a number.", "OK");
                number1.Text = "";
                number2.Text = "";
                number1.Focus();
            }

        }
    }
}