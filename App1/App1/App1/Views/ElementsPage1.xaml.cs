using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ElementsPage1 : ContentPage
    {
        public ElementsPage1()
        {
            InitializeComponent();
        }

        private void btn1_Clicked(object sender, EventArgs e)
        {
            BackgroundColor = Color.Yellow;
        }

        private void stepper1_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            lbl1.Text = e.NewValue.ToString();
        }
    }
}