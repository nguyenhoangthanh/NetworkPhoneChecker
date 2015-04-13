using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using NetworkPhoneChecker.Resources;
using System.Windows.Media.Imaging;
using Microsoft.Phone.Tasks;
using Windows.Phone.PersonalInformation;
using Microsoft.Phone.UserData;


namespace PhoneApp1
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();
            //BuildLocalizedApplicationBar();            
        }

        private void txtPhoneNumber_TextChanged(object sender, TextChangedEventArgs e)
        {
            string phonenumber = txtPhoneNumber.Text;
            CheckPhoneNumber(phonenumber);
        }

        private void CheckPhoneNumber(string phonenumber)
        {
            try
            {
                int length = phonenumber.Length;
                if (length < 3)
                {
                    ResultTypeNetwork.Text = "Không nhận dạng được thuê bao";
                    imgPhoneNetwork.Source = new BitmapImage(new Uri(@"Assets/image/LogoNotfound.jpg", UriKind.RelativeOrAbsolute));
                    return;
                }
                if (CheckThreeNumber(phonenumber.Substring(0, 3)) == false)
                    CheckFourNumber(phonenumber.Substring(0, 4));
            }
            catch
            {
                ResultTypeNetwork.Text = "Không nhận dạng được thuê bao";
                imgPhoneNetwork.Source = new BitmapImage(new Uri(@"Assets/image/LogoNotfound.jpg", UriKind.RelativeOrAbsolute));
            }
        }

        public bool CheckThreeNumber(string phonenumber)
        {
            bool flag = true;
            switch (phonenumber)
            {
                case "090":
                case "093":
                    ResultTypeNetwork.Text = "Đã nhận diện được thuê bao";
                    imgPhoneNetwork.Source = new BitmapImage(new Uri(@"Assets/image/LogoMobifone.jpg", UriKind.RelativeOrAbsolute));
                    break;
                case "091":
                case "094":
                    ResultTypeNetwork.Text = "Đã nhận diện được thuê bao";
                    imgPhoneNetwork.Source = new BitmapImage(new Uri(@"Assets/image/LogoVinaphone.jpg", UriKind.RelativeOrAbsolute));
                    break;
                case "092":
                case "018":
                    ResultTypeNetwork.Text = "Đã nhận diện được thuê bao";
                    imgPhoneNetwork.Source = new BitmapImage(new Uri(@"Assets/image/LogoVietnammobile.jpg", UriKind.RelativeOrAbsolute));
                    break;
                case "095":
                    ResultTypeNetwork.Text = "Đã nhận diện được thuê bao";
                    imgPhoneNetwork.Source = new BitmapImage(new Uri(@"Assets/image/LogoSfone.jpg", UriKind.RelativeOrAbsolute));
                    break;
                case "096":
                case "097":
                case "098":
                case "016":
                    ResultTypeNetwork.Text = "Đã nhận diện được thuê bao";
                    imgPhoneNetwork.Source = new BitmapImage(new Uri(@"Assets/image/LogoViettel.jpg", UriKind.RelativeOrAbsolute));
                    break;
                case "099":
                case "019":
                    ResultTypeNetwork.Text = "Đã nhận diện được thuê bao";
                    imgPhoneNetwork.Source = new BitmapImage(new Uri(@"Assets/image/LogoGmobile.jpg", UriKind.RelativeOrAbsolute));
                    break;
                default:
                    ResultTypeNetwork.Text = "Không nhận dạng được thuê bao";
                    imgPhoneNetwork.Source = new BitmapImage(new Uri(@"Assets/image/LogoNotfound.jpg", UriKind.RelativeOrAbsolute));
                    flag = false;
                    break;
            }
            return flag;
        }

        public bool CheckFourNumber(string phonenumber)
        {
            bool flag = true;
            switch (phonenumber)
            {
                case "0120":
                case "0122":
                case "0126":
                case "0128":
                    ResultTypeNetwork.Text = "Đã nhận diện được thuê bao";
                    imgPhoneNetwork.Source = new BitmapImage(new Uri(@"Assets/image/LogoMobifone.jpg", UriKind.RelativeOrAbsolute));
                    break;
                case "0123":
                case "0124":
                case "0125":
                case "0127":
                case "0129":
                    ResultTypeNetwork.Text = "Đã nhận diện được thuê bao";
                    imgPhoneNetwork.Source = new BitmapImage(new Uri(@"Assets/image/LogoVinaphone.jpg", UriKind.RelativeOrAbsolute));
                    break;
                case "0161":
                case "0162":
                case "0163":
                case "0164":
                case "0165":
                case "0166":
                case "0167":
                case "0168":
                case "0169":
                    ResultTypeNetwork.Text = "Đã nhận diện được thuê bao";
                    imgPhoneNetwork.Source = new BitmapImage(new Uri(@"Assets/image/LogoViettel.jpg", UriKind.RelativeOrAbsolute));
                    break;
                case "0188":
                    ResultTypeNetwork.Text = "Đã nhận diện được thuê bao";
                    imgPhoneNetwork.Source = new BitmapImage(new Uri(@"Assets/image/LogoVietnammobile.jpg", UriKind.RelativeOrAbsolute));
                    break;
                case "0199":
                    ResultTypeNetwork.Text = "Đã nhận diện được thuê bao";
                    imgPhoneNetwork.Source = new BitmapImage(new Uri(@"Assets/image/LogoGmobile.jpg", UriKind.RelativeOrAbsolute));
                    break;
                default:
                    ResultTypeNetwork.Text = "Không nhận dạng được thuê bao";
                    imgPhoneNetwork.Source = new BitmapImage(new Uri(@"Assets/image/LogoNotfound.jpg", UriKind.RelativeOrAbsolute));
                    flag = false;
                    break;
            }
            return flag;
        }

        private void btnContact_Click(object sender, RoutedEventArgs e)
        {
            PhoneNumberChooserTask phoneNumberChooserTask;
            phoneNumberChooserTask = new PhoneNumberChooserTask();
            phoneNumberChooserTask.Completed += new EventHandler<PhoneNumberResult>(phoneNumberChooserTask_Completed);
            phoneNumberChooserTask.Show();
        }
        void phoneNumberChooserTask_Completed(object sender, PhoneNumberResult e)
        {
            if (e.TaskResult == TaskResult.OK)
            {
                txtPhoneNumber.Text = e.PhoneNumber;
            }
        }

        private void ListContact_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/ListContact.xaml", UriKind.Relative));
        }

        // Sample code for building a localized ApplicationBar
        private void BuildLocalizedApplicationBar()
        {
            // Set the page's ApplicationBar to a new instance of ApplicationBar.
            ApplicationBar = new ApplicationBar();

            // Create a new button and set the text value to the localized string from AppResources.
            ApplicationBarIconButton appBarButton = new ApplicationBarIconButton(new Uri("/Assets/AppBar/appbar.add.rest.png", UriKind.Relative));
            appBarButton.Text = AppResources.AppBarButtonText;
            ApplicationBar.Buttons.Add(appBarButton);

            // Create a new menu item with the localized string from AppResources.
            ApplicationBarMenuItem appBarMenuItem = new ApplicationBarMenuItem(AppResources.AppBarMenuItemText);
            ApplicationBar.MenuItems.Add(appBarMenuItem);
        }
    }
}