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
	public partial class CtrlEx : ContentPage
	{
		public CtrlEx ()
		{
			InitializeComponent ();
		}

        async private void BtnClickMe_Clicked(object sender, EventArgs e)
        {
            //DisplayAlert("Click Event", "Button Clicked", "OK");
            await lblHello.RelRotateTo(180, 500);

        }
    }
}