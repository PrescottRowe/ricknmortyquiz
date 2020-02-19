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
        int Character;
        public Page6(int Character)
        {
            InitializeComponent();
            this.Character = Character;
            Console.WriteLine(this.Character);
        }
        async void GoToMainPage(object sender, EventArgs e)
        {
            await Navigation.PopToRootAsync();
        }
        protected override void OnAppearing()
        {
            switch (Character)
            {

                case int n when (n <= 5): // statement sequence
                    MainLabel.Text = "Where's the wine?";
                    CharacterImage.BackgroundImageSource = "beth";
                    break;

                case int n when (5 < n && n <= 10): // statement sequence
                    MainLabel.Text = "Hey, Im Squanchen here.";
                    CharacterImage.BackgroundImageSource = "squanch";
                    break;

                case int n when (10 < n && n <= 14): // statement sequence
                    MainLabel.Text = "Hi, do you want to help me develop my app.";
                    CharacterImage.BackgroundImageSource = "develop";
                    break;

                case int n when (14 < n && n <= 16): // statement sequence
                    MainLabel.Text = "I am Bird Person, my people have been here long before cartoons.";
                    CharacterImage.BackgroundImageSource = "birdperson";
                    break;

                case int n when (16 < n && n <= 19): // statement sequence
                    MainLabel.Text = "Your life has a single purpose. Pass the butter.";
                    CharacterImage.BackgroundImageSource = "butterbot2";
                    break;

                case int n when (19 < n && n <= 23): // statement sequence
                    MainLabel.Text = "You must be King Flippy Nips, and he says this app is a planet!!";
                    CharacterImage.BackgroundImageSource = "flippynips";
                    break;

                case int n when (23 < n && n <= 25): // statement sequence
                    MainLabel.Text = "Ahh yyyeah you are the realest Morty, Morty.";
                    CharacterImage.BackgroundImageSource = "morty";
                    break;

                case int n when (25 < n && n  <100): // statement sequence
                    MainLabel.Text = "Only a Rick would test the IntegerOverflow.";
                    CharacterImage.BackgroundImageSource = "rick";
                    break;

                default:    // default statement sequence
                    MainLabel.Text = "WTF SUMMER, Stop breaking my APP!";
                    CharacterImage.BackgroundImageSource = "summer";
                    break;
            }
            
        }
    }
}