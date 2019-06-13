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
    public sealed partial class CreatureList : Page
    {
        public CreatureList()
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

        //Combobox Items
        private void CI_Pegomastax_Tapped(object sender, TappedRoutedEventArgs e)
        {
            Classes.Pegomastax();

            string kibble = Classes.Kibble.ToString();
            string mejoberries = Classes.Mejoberries.ToString();
            string berries = Classes.Berries.ToString();



            txtboxMQuantity.Text = mejoberries;
            txtboxKQuantity.Text = kibble;
            txtboxBQuantity.Text = berries;

            txtboxKTime.Text = Classes.KTime;
            txtboxMTime.Text = Classes.MTime;
            txtboxBTime.Text = Classes.BTime;

        }

        // multipliers
        private void Txtboxlevel_TextChanging(TextBox sender, TextBoxTextChangingEventArgs args)
        {
            int value = 1;

            value = int.Parse(txtboxlevel.Text);
            Classes.Level = value;
            Classes.Pegomastax();
        }

        private void TxtboxTMultiplier_TextChanging(TextBox sender, TextBoxTextChangingEventArgs args)
        {
            int value = 1;

            value = int.Parse(txtboxlevel.Text);
            Classes.Level = value;
            Classes.Pegomastax();
        }
        private void TxtboxCMultiplier_TextChanging(TextBox sender, TextBoxTextChangingEventArgs args)
        {
            int value = 1;

            value = int.Parse(txtboxlevel.Text);
            Classes.Level = value;
            Classes.Pegomastax();
        }

        private void CI_Giganotosaurus_Tapped(object sender, TappedRoutedEventArgs e)
        {
            Classes.Giganotosaurus();

            string kibble = Classes.Kibble.ToString();
            string mejoberries = Classes.Mejoberries.ToString();
            string berries = Classes.Berries.ToString();



            txtboxMQuantity.Text = mejoberries;
            txtboxKQuantity.Text = kibble;
            txtboxBQuantity.Text = berries;

            txtboxKTime.Text = Classes.KTime;
            txtboxMTime.Text = Classes.MTime;
            txtboxBTime.Text = Classes.BTime;
        }

        //end code
    }
}
