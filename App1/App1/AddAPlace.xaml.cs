using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App1
{
    public partial class AddAPlace : ContentPage
    {
        public AddAPlace()
        {
            InitializeComponent();
            private async void ToAddAPlace(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AddAPlace());
        }
    }
}
