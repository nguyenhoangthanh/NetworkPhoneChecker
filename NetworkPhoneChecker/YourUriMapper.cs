using System;
using System.Collections.Generic;
using System.IO.IsolatedStorage;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Navigation;

namespace NetworkPhoneChecker
{
    public class YourUriMapper : UriMapperBase
    {
        public override Uri MapUri(Uri uri)
        {
            //if (uri.OriginalString == "/MainPage.xaml")
            //{
            //    var settings = IsolatedStorageSettings.ApplicationSettings;

            //    if (!settings.Contains("WasLaunched"))
            //    {
            //        uri = new Uri("/Animation.xaml", UriKind.Relative);
            //    }
            //    else
            //    {
            //        uri = new Uri("/MainPage.xaml", UriKind.Relative);
            //    }
            //}
            //return uri;
            return new Uri("/Animation.xaml", UriKind.Relative);
        }
    }

}
