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
    public partial class Animation : PhoneApplicationPage
    {
        public Animation()
        {
            InitializeComponent();
            Loaded+=Animation_Loaded; 
        }

        private void Animation_Loaded(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/MainPage.xaml", UriKind.Relative));
        }
    }
}