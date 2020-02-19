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
        int Character, temp = 0;
        CheckBox lastChecked;
        public Page4(int Character)
        {
            InitializeComponent();
            this.Character = Character;
        }
        async void GoToNextPage(object sender, EventArgs e)
        {
            Character += temp;
            await Navigation.PushAsync(new Page5(this.Character));
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
            CheckBox activeCheckBox = sender as CheckBox;
            if (activeCheckBox != lastChecked && lastChecked != null) lastChecked.IsChecked = false;
            lastChecked = activeCheckBox.IsChecked ? activeCheckBox : null;
            temp = 1;
        }
        void OnCheckBoxCheckedChanged2(object sender, CheckedChangedEventArgs e)
        {
            CheckBox activeCheckBox = sender as CheckBox;
            if (activeCheckBox != lastChecked && lastChecked != null) lastChecked.IsChecked = false;
            lastChecked = activeCheckBox.IsChecked ? activeCheckBox : null;
            temp = 2;
        }
        void OnCheckBoxCheckedChanged3(object sender, CheckedChangedEventArgs e)
        {
            CheckBox activeCheckBox = sender as CheckBox;
            if (activeCheckBox != lastChecked && lastChecked != null) lastChecked.IsChecked = false;
            lastChecked = activeCheckBox.IsChecked ? activeCheckBox : null;
            temp = 3;
        }
        void OnCheckBoxCheckedChanged4(object sender, CheckedChangedEventArgs e)
        {
            CheckBox activeCheckBox = sender as CheckBox;
            if (activeCheckBox != lastChecked && lastChecked != null) lastChecked.IsChecked = false;
            lastChecked = activeCheckBox.IsChecked ? activeCheckBox : null;
            temp = 4;
        }
        void OnCheckBoxCheckedChanged5(object sender, CheckedChangedEventArgs e)
        {
            CheckBox activeCheckBox = sender as CheckBox;
            if (activeCheckBox != lastChecked && lastChecked != null) lastChecked.IsChecked = false;
            lastChecked = activeCheckBox.IsChecked ? activeCheckBox : null;
            temp = 5;
        }
        protected override void OnAppearing()
        {
            MainLabel.Text = "What is the best McNugget sauce?";
        }
        protected override void OnDisappearing()
        {
            cb1.IsChecked = cb2.IsChecked = cb3.IsChecked = cb4.IsChecked = cb5.IsChecked = false; //This prevents integer overflow. Otherwise repeated page traversals with previously checkedboxes would continue adding when going forward.   
        }
    }
}