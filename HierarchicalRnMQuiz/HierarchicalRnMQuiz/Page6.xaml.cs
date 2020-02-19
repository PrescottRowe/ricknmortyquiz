using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HierarchicalRnMQuiz
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page6 : ContentPage
    {
        public Page6()
        {
            InitializeComponent();         
        }
        async void GoToMainPage(object sender, EventArgs e)
        {
            await Navigation.PopToRootAsync();
        }
    }
}