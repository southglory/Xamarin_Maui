using App1.Services;
using App1.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            //MainPage = new AppShell();
            //MainPage = new Page1();
            //MainPage = new 씨에스();
            //MainPage = new NavigationPage (new Toolbar());
            //MainPage = new Ch_4_TabbedPage1();
            //TabbedPage tabbed = new TabbedPage();
            //tabbed.Children.Add(new Page1() { Title = "페이지1" });
            //tabbed.Children.Add(new 씨에스() { Title = "페이지2"});
            //tabbed.Children.Add(new Toolbar() { Title = "페이지3"});
            //MainPage = tabbed;
            //MainPage = new Ch_5_CarouselPage1();
            //MainPage = new Ch_6_FlyoutPage1();
            //MainPage = new Ch_6_FlyoutPage2();
            //MainPage = new NavigationPage( new Ch_7_NavigationPage1());
            TabbedPage tabbed = new TabbedPage();
            tabbed.Children.Add(new ElementsPage1() { Title = "Xaml" });
            tabbed.Children.Add(new ElementsPage2() { Title = "CS" });
            MainPage= tabbed;
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
