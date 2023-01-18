using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace App1.Views
{
    public class Ch_6_FlyoutPage2: FlyoutPage
    {
        public Ch_6_FlyoutPage2()
        {
            Flyout = new 씨에스() { Title = "플라이아웃페이지"};
            Detail = new NavigationPage(new Toolbar());
        }
    }
}
