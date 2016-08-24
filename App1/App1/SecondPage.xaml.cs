using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App1
{
    public partial class SecondPage : ContentPage
    {
        public SecondPage()
        {
            InitializeComponent();
        }

        private async void ToAddAPlacw(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AddAPlace());
        }
    }
}
