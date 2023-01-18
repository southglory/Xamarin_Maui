using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace App1.Views
{
    public class ElementsPage2 : ContentPage
    {
        public ElementsPage2()
        {
            Button btn = new Button { Text = "배경색 변경", BackgroundColor = Color.BlueViolet, FontSize = 30 };
            btn.Clicked += (s, e) =>
            {
                this.BackgroundColor = Color.DarkSlateGray;
            };
            Label label = new Label 
            { 
                Text = "C# 레이블입니다.", TextColor = Color.Red, BackgroundColor = Color.Blue
                , FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)) };
            Label label2 = new Label
            {
                Text = "30 레이블입니다.",
                TextColor = Color.Red,
                BackgroundColor = Color.Blue
    ,
                FontSize = 30
            };
            Editor editor;

            if (Device.RuntimePlatform == Device.UWP)
            {
                editor = new Editor
                {
                    Placeholder = "텍스트 여러줄 입력",
                    TextColor = Color.Black,
                    HeightRequest = 300
                };
            }
            else
            {
                editor = new Editor
                {
                    Placeholder = "텍스트 여러줄 입력",
                    BackgroundColor = Color.Black,
                    TextColor = Color.White,
                    HeightRequest = 300
                };
            }
            Slider slider = new Slider { Maximum = 30, Minimum = 5,  Value = 10, MinimumTrackColor = Color.Pink, MaximumTrackColor = Color.DarkSalmon };
            slider.ValueChanged += (s, e) =>
            {
                editor.Text = e.NewValue.ToString();
            };

            Content = new StackLayout 
            { 
                Children =
                { 
                    btn, label, label2, editor, slider
                }
            };
        }
    }
}