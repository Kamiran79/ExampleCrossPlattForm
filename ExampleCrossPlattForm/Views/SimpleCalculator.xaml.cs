using System;
using System.Collections.Generic;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ExampleCrossPlattForm.Views
{
    public partial class SimpleCalculator : ContentPage
    {
        public SimpleCalculator()
        {
            InitializeComponent();
        }

        void add_Clicked(System.Object sender, System.EventArgs e)
        {
            var n1 = number1.Text;
            var n2 = number2.Text;

            double nn1 = 0;
            double nn2 = 0;
            double result = 0;



            //string intString = "234";
            //int i = 0;

            //bool flag1 = false;



            try
            {

                nn1 = Double.Parse(n1);
                nn2 = Double.Parse(n2);

                result = nn1 + nn2;

                DisplayAlert("Add Selected:", "The result is: "+ result, "OK");
            }
            catch (Exception ex)
            {
                DisplayAlert("Error", "Wrong Format " + ex.Message, "OK");
                number1.Text = "";
                number2.Text = "";
            }

            //if (!Int32.TryParse(n1, out nn1))
            //{
             //   DisplayAlert("Error", "Please enter a number", "ok");
            //}
            //else
            //{

            //}
            //if (!Int32.TryParse(n2, out nn2))
            //{
             //   DisplayAlert("Error", "Please enter a number", "ok");
            //}

            //result = nn1 + nn2;

            

            //DisplayAlert("Your Result", Convert.ToString(result), "OK");
            //number1.Text = "";
            //number2.Text = "";
        }

        double GetResult (double x, double y)
        {
            double result = x + y;
            return result;
        }

        void sub_Clicked(System.Object sender, System.EventArgs e)
        {
        }
    }
}
