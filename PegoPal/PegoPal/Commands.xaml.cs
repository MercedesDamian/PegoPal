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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace PegoPal
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Commands : Page
    {
        public Commands()
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

        //Nav view
        private void NavView_Loaded(object sender, RoutedEventArgs e)
        {
            // you can also add items in code behind
            NavView.MenuItems.Add(new NavigationViewItemSeparator());


            // set the initial SelectedItem 
            foreach (NavigationViewItemBase item in NavView.MenuItems)
            {
                if (item is NavigationViewItem && item.Tag.ToString() == "apps")
                {
                    NavView.SelectedItem = item;
                    break;
                }
            }
        }

        private void NavView_ItemInvoked(NavigationView sender, NavigationViewItemInvokedEventArgs args)
        {
            if (args.IsSettingsInvoked)
            {
                this.Frame.Navigate(typeof(MainPage));
            }
            else
            {
                switch (args.InvokedItem)
                {
                    case "home":
                        this.Frame.Navigate(typeof(MainPage));
                        break;

                    case "creatures":
                        this.Frame.Navigate(typeof(CreatureList));
                        break;

                    case "calculator":
                        this.Frame.Navigate(typeof(StatCalc));
                        break;

                    case "commands":
                        this.Frame.Navigate(typeof(Commands));
                        break;

                    case "recipes":
                        this.Frame.Navigate(typeof(Recipes));
                        break;
                }
            }
        }

        private void NavView_SelectionChanged(NavigationView sender, NavigationViewSelectionChangedEventArgs args)
        {
            if (args.IsSettingsSelected)
            {
                this.Frame.Navigate(typeof(MainPage));
            }
            else
            {

                NavigationViewItem item = args.SelectedItem as NavigationViewItem;

                switch (item.Tag)
                {
                    case "home":
                        this.Frame.Navigate(typeof(MainPage));
                        break;

                    case "creatures":
                        this.Frame.Navigate(typeof(CreatureList));
                        break;

                    case "calculator":
                        this.Frame.Navigate(typeof(StatCalc));
                        break;

                    case "commands":
                        this.Frame.Navigate(typeof(Commands));
                        break;

                    case "recipes":
                        this.Frame.Navigate(typeof(Recipes));
                        break;
                }
            }
        }

        //Combobox items - Commands
        private void CI_MHatchet_Tapped(object sender, TappedRoutedEventArgs e)
        {
            txtboxCommand.Text = "admincheat GFI WeaponMetalHatchet 1 1 0";
        }

        private void MPick_Tapped(object sender, TappedRoutedEventArgs e)
        {
            txtboxCommand.Text = "admincheat GFI WeaponMetalPick 1 1 0";
        }

        private void SHatchet_Tapped(object sender, TappedRoutedEventArgs e)
        {
            txtboxCommand.Text = "admincheat GFI WeaponStoneHatchet 1 1 0";
        }

        private void SPick_Tapped(object sender, TappedRoutedEventArgs e)
        {
            txtboxCommand.Text = "admincheat GFI WeaponStonePick 1 1 0";
        }

        //end of code
    }
}
