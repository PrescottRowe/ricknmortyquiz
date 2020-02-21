using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace HierarchicalRnMQuiz
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        async void GoToPage1(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page1());
        }
        async void GoToPage2(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page2(0));
        }
        async void GoToPage3(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page3(0));
        }
        async void GoToPage4(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page4(0));
        }
        async void GoToPage5(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page5(0));      
        }
        protected override void OnAppearing()
        {
            MainLabel.Text = "What Rick and Morty Character are you? Also don't sue me, that would make you a Jerry.";
        }
    }
}
