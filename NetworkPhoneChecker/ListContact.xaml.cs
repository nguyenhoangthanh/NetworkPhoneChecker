using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using Microsoft.Phone.UserData;
using System.Windows.Media.Imaging;
using System.Windows.Media;

namespace PhoneApp1
{
    public partial class ListContact : PhoneApplicationPage
    {
        public ListContact()
        {
            InitializeComponent();
            GetAllContact();
        }
        private void GetAllContact()
        {
            Contacts cons = new Contacts();
            cons.SearchCompleted += new EventHandler<ContactsSearchEventArgs>(Contacts_SearchCompleted);
            cons.SearchAsync(String.Empty, FilterKind.None, "Contacts Test #1");
        }

        void Contacts_SearchCompleted(object sender, ContactsSearchEventArgs e)
        {
            List<ContactCustom> List = new List<ContactCustom>();
            foreach (Contact con in e.Results)
            {
                foreach (ContactPhoneNumber cpn in con.PhoneNumbers)
                {
                    ContactCustom cc = new ContactCustom();
                    cc.name = con.DisplayName.ToString();
                    cc.phone = cpn.ToString();
                    cc.type = FunctionHelper.CheckNetworkPhoneNumber(cpn.ToString(), 0);
                    cc.urlimgtype = FunctionHelper.CheckNetworkPhoneNumber(cpn.ToString(), 1);
                    List.Add(cc);
                }
            }

            Contact.ItemsSource = List;

            // Create the Grid
            //Grid myGrid = new Grid();
            //myGrid.Height = 100;
            //myGrid.Margin = new Thickness(12, 0, 0, 0);
            //myGrid.VerticalAlignment = VerticalAlignment.Top;

            // Define the Columns
            //ColumnDefinition colDef1 = new ColumnDefinition();
            //colDef1.Width = new GridLength(80, GridUnitType.Pixel);
            //myGrid.ColumnDefinitions.Add(colDef1);
            //ColumnDefinition colDef2 = new ColumnDefinition();
            //colDef2.Width = new GridLength(1, GridUnitType.Star);
            //myGrid.ColumnDefinitions.Add(colDef2);
            //ColumnDefinition colDef3 = new ColumnDefinition();
            //colDef3.Width = new GridLength(1, GridUnitType.Star);
            //myGrid.ColumnDefinitions.Add(colDef3);

            //foreach (Contact con in e.Results)
            //{
            //    foreach (ContactPhoneNumber cpn in con.PhoneNumbers)
            //    {
            //        TextBlock tb = new TextBlock();
            //        tb.Text = con.DisplayName.ToString();
            //        tb.FontSize = 24;
            //        tb.TextWrapping = TextWrapping.Wrap;
            //        tb.VerticalAlignment = VerticalAlignment.Top;
            //        Grid.SetColumn(tb, 1);
            //        Grid.SetColumnSpan(tb, 2);
            //        myGrid.Children.Add(tb);

            //        tb = new TextBlock();
            //        tb.Text = cpn.ToString();
            //        tb.TextWrapping = TextWrapping.Wrap;
            //        tb.VerticalAlignment = VerticalAlignment.Top;
            //        tb.Margin = new Thickness(0, 30, 0, 0);
            //        Grid.SetColumn(tb, 1);
            //        Grid.SetColumnSpan(tb, 2);
            //        myGrid.Children.Add(tb);

            //        tb = new TextBlock();
            //        tb.Text = FunctionHelper.CheckNetworkPhoneNumber(cpn.ToString(), 0);
            //        tb.TextWrapping = TextWrapping.Wrap;
            //        tb.Foreground = new SolidColorBrush(Colors.Yellow);
            //        tb.TextAlignment = TextAlignment.Right;
            //        tb.VerticalAlignment = VerticalAlignment.Top;
            //        tb.Margin = new Thickness(0, 30, 10, 0);
            //        Grid.SetColumn(tb, 2);
            //        myGrid.Children.Add(tb);

            //        Image tg = new Image();
            //        BitmapImage bm =new BitmapImage(new Uri(FunctionHelper.CheckNetworkPhoneNumber(cpn.ToString(), 1), UriKind.RelativeOrAbsolute));
            //        tg.Source = bm;
            //        tg.Height = 50;
            //        tg.VerticalAlignment = VerticalAlignment.Top;
            //        tg.Margin = new Thickness(0, 0, 10, 10);
            //        Grid.SetColumn(tg, 0);
            //        myGrid.Children.Add(tg);
            //    }
            //}
            //GridContact.Children.Add(myGrid);
        }

        public class ContactCustom
        {
            public string name { get; set; }
            public string phone { get; set; }
            public string type { get; set; }
            public string urlimgtype { get; set; }
        }
    }
}