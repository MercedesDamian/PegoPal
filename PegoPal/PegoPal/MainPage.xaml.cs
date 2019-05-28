using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace PegoPal
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            this.SignInBtn();

        }


        //Button Navigation

         private void SignInBtn()
        {
            if (Classes.IsAuth > 0)
            {
                ButtonLogin.Visibility = Visibility.Collapsed;
                ButtonSignoff.Visibility = Visibility.Visible;
            }
            else
            {
                ButtonSignoff.Visibility = Visibility.Collapsed;
                ButtonLogin.Visibility = Visibility.Visible;
            }

        }


        private void ButtonLogin_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(UserAuth));
        }

        async private void ButtonSignoff_Click(object sender, RoutedEventArgs e)
        {
            Classes.IsAuth = (0);

            var dialog = new MessageDialog("You have logged off. ");
            await dialog.ShowAsync();
            SignInBtn();
        }

        private void Creatures_Tapped(object sender, TappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(CreatureList));
        }

        private void StatCalcTile_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(StatCalc));
        }

        private void RecipesTile_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MainPage));
        }

        private void CommandsTile_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MainPage));
        }
    }
}
