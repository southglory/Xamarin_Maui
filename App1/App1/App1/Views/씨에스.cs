using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace App1.Views
{
    public class 씨에스 : ContentPage
    {
        public 씨에스()
        {
            Content = new StackLayout
            {
                Children = {
                    new Label { Text = "이게 자마린인가?씨에스로만 만들면 바로 업뎃이 안되는군.", FontSize=30, TextColor=Color.DarkRed }
                }
            };
        }
    }
}