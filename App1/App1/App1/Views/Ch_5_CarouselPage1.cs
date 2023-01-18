using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace App1.Views
{
    public class Ch_5_CarouselPage1 : CarouselPage
    {
        public Ch_5_CarouselPage1()
        {
            Children.Add(new Page1());
            Children.Add(new 씨에스());

        }
    }
}