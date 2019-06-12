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
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace PegoPal
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Recipes : Page
    {
        public Recipes()
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

        //Combobox items
        private void SimpleKibble_Tapped(object sender, TappedRoutedEventArgs e)
        {

            //images & textboxes 
            BitmapImage EggImageSource = new BitmapImage
            {
                // Call BaseUri on the root Page element and combine it with a relative path
                // to consruct an absolute URI.
                UriSource = new Uri(this.BaseUri, "https://www.dododex.com/media/item/Dodo_Egg.png")
            };
            EggImage.Source = EggImageSource;
            EggType.Text = "x1 Small Egg";

            BitmapImage MeatImageSource = new BitmapImage
            {
                // Call BaseUri on the root Page element and combine it with a relative path
                // to consruct an absolute URI.
                UriSource = new Uri(this.BaseUri, "https://www.dododex.com/media/item/Cooked_Fish_Meat.png")
            };
            MeatImage.Source = MeatImageSource;
            MeatType.Text = "x1 Cooked Fish Meat";

            BitmapImage VegImageSource = new BitmapImage
            {
                // Call BaseUri on the root Page element and combine it with a relative path
                // to consruct an absolute URI.
                UriSource = new Uri(this.BaseUri, "https://www.dododex.com/media/item/Rockarrot.png")
            };
            VegImage.Source = VegImageSource;
            VegType.Text = "x2 Rockarrot";

            BitmapImage BerryImageSource = new BitmapImage
            {
                // Call BaseUri on the root Page element and combine it with a relative path
                // to consruct an absolute URI.
                UriSource = new Uri(this.BaseUri, "https://www.dododex.com/media/item/Mejoberry.png")
            };
            BerryImage.Source = BerryImageSource;
            BerryType.Text = "x5 Mejoberries";

            BitmapImage FiberImageSource = new BitmapImage
            {
                // Call BaseUri on the root Page element and combine it with a relative path
                // to consruct an absolute URI.
                UriSource = new Uri(this.BaseUri, "https://www.dododex.com/media/item/Fiber.png")
            };
            FiberImage.Source = FiberImageSource;
            FiberType.Text = "x5 Fiber";

            BitmapImage WaterImageSource = new BitmapImage
            {
                // Call BaseUri on the root Page element and combine it with a relative path
                // to consruct an absolute URI.
                UriSource = new Uri(this.BaseUri, "https://www.dododex.com/media/item/Waterskin.png")
            };
            WaterImage.Source = WaterImageSource;
            WaterType.Text = "Waterskin";

        }

        private void RegularKibble_Tapped(object sender, TappedRoutedEventArgs e)
        {
            //images & textboxes 
            BitmapImage EggImageSource = new BitmapImage
            {
                // Call BaseUri on the root Page element and combine it with a relative path
                // to consruct an absolute URI.
                UriSource = new Uri(this.BaseUri, "https://www.dododex.com/media/item/Dodo_Egg.png")
            };
            EggImage.Source = EggImageSource;
            EggType.Text = "x1 Medium Egg";

            BitmapImage MeatImageSource = new BitmapImage
            {
                // Call BaseUri on the root Page element and combine it with a relative path
                // to consruct an absolute URI.
                UriSource = new Uri(this.BaseUri, "https://www.dododex.com/media/item/Cooked_Meat_Jerky.png")
            };
            MeatImage.Source = MeatImageSource;
            MeatType.Text = "x1 Cooked Meat Jerky";

            BitmapImage VegImageSource = new BitmapImage
            {
                // Call BaseUri on the root Page element and combine it with a relative path
                // to consruct an absolute URI.
                UriSource = new Uri(this.BaseUri, "https://www.dododex.com/media/item/Longrass.png")
            };
            VegImage.Source = VegImageSource;
            VegType.Text = "x2 Longrass";

            BitmapImage BerryImageSource = new BitmapImage
            {
                // Call BaseUri on the root Page element and combine it with a relative path
                // to consruct an absolute URI.
                UriSource = new Uri(this.BaseUri, "https://www.dododex.com/media/item/Savoroot.png")
            };
            BerryImage.Source = BerryImageSource;
            BerryType.Text = "x2 Savoroot";

            BitmapImage FiberImageSource = new BitmapImage
            {
                // Call BaseUri on the root Page element and combine it with a relative path
                // to consruct an absolute URI.
                UriSource = new Uri(this.BaseUri, "https://www.dododex.com/media/item/Fiber.png")
            };
            FiberImage.Source = FiberImageSource;
            FiberType.Text = "x5 Fiber";

            BitmapImage WaterImageSource = new BitmapImage
            {
                // Call BaseUri on the root Page element and combine it with a relative path
                // to consruct an absolute URI.
                UriSource = new Uri(this.BaseUri, "https://www.dododex.com/media/item/Waterskin.png")
            };
            WaterImage.Source = WaterImageSource;
            WaterType.Text = "Waterskin";
        }

        private void SuperiorKibble_Tapped(object sender, TappedRoutedEventArgs e)
        {
            //images & textboxes 
            BitmapImage EggImageSource = new BitmapImage
            {
                // Call BaseUri on the root Page element and combine it with a relative path
                // to consruct an absolute URI.
                UriSource = new Uri(this.BaseUri, "https://www.dododex.com/media/item/Dodo_Egg.png")
            };
            EggImage.Source = EggImageSource;
            EggType.Text = "x1 Large Egg";

            BitmapImage MeatImageSource = new BitmapImage
            {
                // Call BaseUri on the root Page element and combine it with a relative path
                // to consruct an absolute URI.
                UriSource = new Uri(this.BaseUri, "https://www.dododex.com/media/item/Prime_Meat_Jerky.png")
            };
            MeatImage.Source = MeatImageSource;
            MeatType.Text = "x1 Prime Meat Jerky";

            BitmapImage VegImageSource = new BitmapImage
            {
                // Call BaseUri on the root Page element and combine it with a relative path
                // to consruct an absolute URI.
                UriSource = new Uri(this.BaseUri, "https://www.dododex.com/media/item/Citronal.png")
            };
            VegImage.Source = VegImageSource;
            VegType.Text = "x2 Citronal";

            BitmapImage BerryImageSource = new BitmapImage
            {
                // Call BaseUri on the root Page element and combine it with a relative path
                // to consruct an absolute URI.
                UriSource = new Uri(this.BaseUri, "https://www.dododex.com/media/item/Sap.png")
            };
            BerryImage.Source = BerryImageSource;
            BerryType.Text = "x1 Sap";

            BitmapImage FiberImageSource = new BitmapImage
            {
                // Call BaseUri on the root Page element and combine it with a relative path
                // to consruct an absolute URI.
                UriSource = new Uri(this.BaseUri, "https://www.dododex.com/media/item/Fiber.png")
            };
            FiberImage.Source = FiberImageSource;
            FiberType.Text = "x5 Fiber";

            BitmapImage WaterImageSource = new BitmapImage
            {
                // Call BaseUri on the root Page element and combine it with a relative path
                // to consruct an absolute URI.
                UriSource = new Uri(this.BaseUri, "https://www.dododex.com/media/item/Rare_Mushroom.png")
            };
            WaterImage.Source = WaterImageSource;
            WaterType.Text = "x2 Rare Mushroom";
        }

        private void ExceptionalKibble_Tapped(object sender, TappedRoutedEventArgs e)
        {
            //images & textboxes 
            BitmapImage EggImageSource = new BitmapImage
            {
                // Call BaseUri on the root Page element and combine it with a relative path
                // to consruct an absolute URI.
                UriSource = new Uri(this.BaseUri, "https://www.dododex.com/media/item/Dodo_Egg.png")
            };
            EggImage.Source = EggImageSource;
            EggType.Text = "x1 Extra Large Egg";

            BitmapImage MeatImageSource = new BitmapImage
            {
                // Call BaseUri on the root Page element and combine it with a relative path
                // to consruct an absolute URI.
                UriSource = new Uri(this.BaseUri, "https://www.dododex.com/media/item/Focal_Chili.png")
            };
            MeatImage.Source = MeatImageSource;
            MeatType.Text = "x1 Focal Chili";

            BitmapImage VegImageSource = new BitmapImage
            {
                // Call BaseUri on the root Page element and combine it with a relative path
                // to consruct an absolute URI.
                UriSource = new Uri(this.BaseUri, "https://www.dododex.com/media/item/Rare_Flower.png")
            };
            VegImage.Source = VegImageSource;
            VegType.Text = "x1 Rare Flower";

            BitmapImage BerryImageSource = new BitmapImage
            {
                // Call BaseUri on the root Page element and combine it with a relative path
                // to consruct an absolute URI.
                UriSource = new Uri(this.BaseUri, "https://www.dododex.com/media/item/Mejoberry.png")
            };
            BerryImage.Source = BerryImageSource;
            BerryType.Text = "x10 Mejoberries";

            BitmapImage FiberImageSource = new BitmapImage
            {
                // Call BaseUri on the root Page element and combine it with a relative path
                // to consruct an absolute URI.
                UriSource = new Uri(this.BaseUri, "https://www.dododex.com/media/item/Fiber.png")
            };
            FiberImage.Source = FiberImageSource;
            FiberType.Text = "x5 Fiber";

            BitmapImage WaterImageSource = new BitmapImage
            {
                // Call BaseUri on the root Page element and combine it with a relative path
                // to consruct an absolute URI.
                UriSource = new Uri(this.BaseUri, "https://www.dododex.com/media/item/Waterskin.png")
            };
            WaterImage.Source = WaterImageSource;
            WaterType.Text = "Waterskin";
        }

        private void ExtraordinaryKibble_Tapped(object sender, TappedRoutedEventArgs e)
        {
            //images & textboxes 
            BitmapImage EggImageSource = new BitmapImage
            {
                // Call BaseUri on the root Page element and combine it with a relative path
                // to consruct an absolute URI.
                UriSource = new Uri(this.BaseUri, "https://www.dododex.com/media/item/Dodo_Egg.png")
            };
            EggImage.Source = EggImageSource;
            EggType.Text = "x1 Special Egg";

            BitmapImage MeatImageSource = new BitmapImage
            {
                // Call BaseUri on the root Page element and combine it with a relative path
                // to consruct an absolute URI.
                UriSource = new Uri(this.BaseUri, "https://www.dododex.com/media/item/Giant_Bee_Honey.png")
            };
            MeatImage.Source = MeatImageSource;
            MeatType.Text = "x1 Giant Bee Honey";

            BitmapImage VegImageSource = new BitmapImage
            {
                // Call BaseUri on the root Page element and combine it with a relative path
                // to consruct an absolute URI.
                UriSource = new Uri(this.BaseUri, "https://www.dododex.com/media/item/Lazarus_Chowder.png")
            };
            VegImage.Source = VegImageSource;
            VegType.Text = "x1 Lazarus Chowder";

            BitmapImage BerryImageSource = new BitmapImage
            {
                // Call BaseUri on the root Page element and combine it with a relative path
                // to consruct an absolute URI.
                UriSource = new Uri(this.BaseUri, "https://www.dododex.com/media/item/Mejoberry.png")
            };
            BerryImage.Source = BerryImageSource;
            BerryType.Text = "x10 Mejoberries";

            BitmapImage FiberImageSource = new BitmapImage
            {
                // Call BaseUri on the root Page element and combine it with a relative path
                // to consruct an absolute URI.
                UriSource = new Uri(this.BaseUri, "https://www.dododex.com/media/item/Fiber.png")
            };
            FiberImage.Source = FiberImageSource;
            FiberType.Text = "x5 Fiber";

            BitmapImage WaterImageSource = new BitmapImage
            {
                // Call BaseUri on the root Page element and combine it with a relative path
                // to consruct an absolute URI.
                UriSource = new Uri(this.BaseUri, "https://www.dododex.com/media/item/Waterskin.png")
            };
            WaterImage.Source = WaterImageSource;
            WaterType.Text = "Waterskin";
        }
        //end of code
    }
}
