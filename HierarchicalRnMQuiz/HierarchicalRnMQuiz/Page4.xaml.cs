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
    public partial class Page4 : ContentPage
    {
        public Page4()
        {
            InitializeComponent();
        }
        async void GoToNextPage(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page5());
        }
        async void GoToPreviousPage(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
        async void GoToMainPage(object sender, EventArgs e)
        {
            await Navigation.PopToRootAsync();
        }
        void OnCheckBoxCheckedChanged1(object sender, CheckedChangedEventArgs e)
        {
            Console.WriteLine("1");
        }
        void OnCheckBoxCheckedChanged2(object sender, CheckedChangedEventArgs e)
        {
            Console.WriteLine("2");
        }
        void OnCheckBoxCheckedChanged3(object sender, CheckedChangedEventArgs e)
        {
            Console.WriteLine("3");
        }
        void OnCheckBoxCheckedChanged4(object sender, CheckedChangedEventArgs e)
        {
            Console.WriteLine("4");
        }
        void OnCheckBoxCheckedChanged5(object sender, CheckedChangedEventArgs e)
        {
            Console.WriteLine("5");
        }
    }
}