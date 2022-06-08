using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PracticalProject.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LandingPage : CarouselPage
    {
        public LandingPage()
        {
            InitializeComponent();
        }
        private async void AnimalPage(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new View.LoginPage());

        }
    }
}