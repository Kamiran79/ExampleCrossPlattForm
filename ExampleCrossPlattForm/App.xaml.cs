using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using ExampleCrossPlattForm.Views;
using ExampleCrossPlattForm.Layouts;


namespace ExampleCrossPlattForm
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //MainPage = new MainPage();
            //MainPage = new MyPage();
            //MainPage = new SimpleCalculator();
            //MainPage = new ImgDemo();
            //MainPage = new StackEx();
            //MainPage = new StackExample();
            //MainPage = new GridEx();

            //MainPage = new GridLayoutProject();

            //MainPage = new Page1StackLayoutProject();

            //MainPage = new Page2StackLayoutProject();
            //MainPage = new RelativeLayoutProject();
            //MainPage = new SliderEx();
            //MainPage = new ControlExample();
            //MainPage = new LoginPage();
            MainPage = new pickerExample();
            //MainPage = new DateandTimePicker();
            //MainPage = new ImageDemo();
            //MainPage = new AbsoluteExLayout();
            //MainPage = new circleimg_ex();
            //MainPage = new WelcomePage();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
