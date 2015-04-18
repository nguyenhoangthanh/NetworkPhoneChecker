using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;

namespace NetworkPhoneChecker
{
    public partial class ListNetwork : PhoneApplicationPage
    {
        public ListNetwork()
        {
            InitializeComponent();
        }

        private void Mobifone_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            NavigationService.Navigate(new Uri("/ListContact.xaml?parameter=Mobifone", UriKind.Relative));
        }
        private void Viettel_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            NavigationService.Navigate(new Uri("/ListContact.xaml?parameter=Viettel", UriKind.Relative));
        }
        private void Vinaphone_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            NavigationService.Navigate(new Uri("/ListContact.xaml?parameter=Vinaphone", UriKind.Relative));
        }
        private void Vietnammobile_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            NavigationService.Navigate(new Uri("/ListContact.xaml?parameter=Vietnammobile", UriKind.Relative));
        }
        private void Gmobile_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            NavigationService.Navigate(new Uri("/ListContact.xaml?parameter=Gmobile", UriKind.Relative));
        }
        private void Sfone_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            NavigationService.Navigate(new Uri("/ListContact.xaml?parameter=Sfone", UriKind.Relative));
        }
        private void Dienthoaiban_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            NavigationService.Navigate(new Uri("/ListContact.xaml?parameter=Dienthoaiban", UriKind.Relative));
        }
    }
}