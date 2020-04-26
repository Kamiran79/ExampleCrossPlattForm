using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ClassEx2020.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class entryExample : ContentPage
	{
		public entryExample ()
		{
			InitializeComponent ();
		}

        private void Button_Clicked(object sender, EventArgs e)
        {
            var text = entryPassword.Text;

            DisplayAlert("Password", entryPassword.Text, "OK");
        }
    }
}