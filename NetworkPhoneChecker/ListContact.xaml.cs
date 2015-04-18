using System;
using System.Text;
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
using Microsoft.Phone.Tasks;
using System.Text.RegularExpressions;

namespace NetworkPhoneChecker
{
    public partial class ListContact : PhoneApplicationPage
    {
        List<ContactCustom> List = new List<ContactCustom>();
        string NetWorkType = "";
        public ListContact()
        {
            InitializeComponent();
            GetAllContact();
        }
        protected override void OnNavigatedTo(System.Windows.Navigation.NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            NetWorkType = NavigationContext.QueryString["parameter"];
        }
        private void GetAllContact()
        {
            Contacts cons = new Contacts();
            cons.SearchCompleted += new EventHandler<ContactsSearchEventArgs>(Contacts_SearchCompleted);
            cons.SearchAsync(String.Empty, FilterKind.None, "Contacts Test #1");
        }

        void Contacts_SearchCompleted(object sender, ContactsSearchEventArgs e)
        {
            foreach (Contact con in e.Results)
            {
                foreach (ContactPhoneNumber cpn in con.PhoneNumbers)
                {
                    ContactCustom cc = new ContactCustom();
                    cc.name = con.DisplayName.ToString();
                    cc.namecus = ConvertVN(cc.name.ToLower());
                    string[] temp = cpn.ToString().Split(' ');
                    cc.phone = temp[0];
                    cc.type = FunctionHelper.CheckNetworkPhoneNumber(cpn.ToString(), 0);
                    cc.urlimgtype = FunctionHelper.CheckNetworkPhoneNumber(cpn.ToString(), 1);
                    if (NetWorkType == "all")
                        List.Add(cc);
                    else if(NetWorkType == cc.type)
                        List.Add(cc);
                }
            }
            Contact.ItemsSource = List;
        }

        public class ContactCustom
        {
            public string name { get; set; }
            public string namecus { get; set; }
            public string phone { get; set; }
            public string type { get; set; }
            public string urlimgtype { get; set; }
        }

        private void Call_Click(object sender, RoutedEventArgs e)
        {
            var btncall = sender as Button;
            if (null == btncall) { return; }
            ContactCustom cc = btncall.DataContext as ContactCustom;
            PhoneCallTask phoneCallTask = new PhoneCallTask();
            phoneCallTask.PhoneNumber = cc.phone.ToString();
            phoneCallTask.DisplayName = cc.name.ToString();
            phoneCallTask.Show();
        }

        private void txtPhoneSeachNumber_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (!txtPhoneSeachNumber.Text.Contains("Nhập số điện thoại hoặc tên"))
            {
                List<ContactCustom> l = new List<ContactCustom>();
                string textsearch = ConvertVN(txtPhoneSeachNumber.Text.ToLower());
                l = List.Where(i => i.namecus.Contains(textsearch) || i.phone.Contains(textsearch)).ToList();
                Contact.ItemsSource = l;
            }
        }

        public string ConvertVN(string chucodau)
        {
            const string FindText = "áàảãạâấầẩẫậăắằẳẵặđéèẻẽẹêếềểễệíìỉĩịóòỏõọôốồổỗộơớờởỡợúùủũụưứừửữựýỳỷỹỵÁÀẢÃẠÂẤẦẨẪẬĂẮẰẲẴẶĐÉÈẺẼẸÊẾỀỂỄỆÍÌỈĨỊÓÒỎÕỌÔỐỒỔỖỘƠỚỜỞỠỢÚÙỦŨỤƯỨỪỬỮỰÝỲỶỸỴ";
            const string ReplText = "aaaaaaaaaaaaaaaaadeeeeeeeeeeeiiiiiooooooooooooooooouuuuuuuuuuuyyyyyAAAAAAAAAAAAAAAAADEEEEEEEEEEEIIIIIOOOOOOOOOOOOOOOOOUUUUUUUUUUUYYYYY";
            int index = -1;
            char[] arrChar = FindText.ToCharArray();
            while ((index = chucodau.IndexOfAny(arrChar)) != -1)
            {
                int index2 = FindText.IndexOf(chucodau[index]);
                chucodau = chucodau.Replace(chucodau[index], ReplText[index2]);
            }
            return chucodau;
        }


        private void txtPhoneSeachNumber_LostFocus(object sender, RoutedEventArgs e)
        {
            if (txtPhoneSeachNumber.Text == "")
                txtPhoneSeachNumber.Text = "Nhập số điện thoại hoặc tên";
        }

        private void txtPhoneSeachNumber_GotFocus(object sender, RoutedEventArgs e)
        {
            txtPhoneSeachNumber.Text = "";
        }
    }
}