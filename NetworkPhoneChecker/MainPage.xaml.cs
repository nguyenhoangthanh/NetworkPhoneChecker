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


namespace NetworkPhoneChecker
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
                if (length < 2)
                {
                    ResultTypeNetwork.Text = "Không nhận dạng được thuê bao";
                    imgPhoneNetwork.Source = new BitmapImage(new Uri(@"Assets/image/LogoNotfound.jpg", UriKind.RelativeOrAbsolute));
                    return;
                }
                if (CheckTwoNumber(phonenumber.Substring(0, 2)) == false)
                    if (CheckThreeNumber(phonenumber.Substring(0, 3)) == false)
                        CheckFourNumber(phonenumber.Substring(0, 4));
            }
            catch
            {
                ResultTypeNetwork.Text = "Không nhận dạng được thuê bao";
                imgPhoneNetwork.Source = new BitmapImage(new Uri(@"Assets/image/LogoNotfound.jpg", UriKind.RelativeOrAbsolute));
            }
        }

        public bool CheckTwoNumber(string phonenumber)
        {
            bool flag = true;
            switch (phonenumber)
            {
                // số điện thoại bàn cũ
                case "04":
                    ResultTypeNetwork.Text = "Mã vùng/thuê bao thành phố Hà Nội";
                    imgPhoneNetwork.Source = new BitmapImage(new Uri(@"Assets/image/logotinh/Hanoi.png", UriKind.RelativeOrAbsolute));
                    break;
                case "08":
                    ResultTypeNetwork.Text = "Mã vùng/thuê bao thành phố Hồ Chí Minh";
                    imgPhoneNetwork.Source = new BitmapImage(new Uri(@"Assets/image/logotinh/Hochiminh.png", UriKind.RelativeOrAbsolute));
                    break;
                default:
                    ResultTypeNetwork.Text = "Không nhận dạng được thuê bao";
                    imgPhoneNetwork.Source = new BitmapImage(new Uri(@"Assets/image/LogoNotfound.jpg", UriKind.RelativeOrAbsolute));
                    flag = false;
                    break;
            }
            return flag;
        }

        public bool CheckThreeNumber(string phonenumber)
        {
            bool flag = true;
            switch (phonenumber)
            {
                // số điện thoại bàn mới
                case "024":
                    ResultTypeNetwork.Text = "Mã vùng/thuê bao thành phố Hà Nội";
                    imgPhoneNetwork.Source = new BitmapImage(new Uri(@"Assets/image/logotinh/Hanoi.png", UriKind.RelativeOrAbsolute));
                    break;
                case "028":
                    ResultTypeNetwork.Text = "Mã vùng/thuê bao thành phố Hồ Chí Minh";
                    imgPhoneNetwork.Source = new BitmapImage(new Uri(@"Assets/image/logotinh/Hochiminh.png", UriKind.RelativeOrAbsolute));
                    break;
                // số điện thoại bàn cũ
                case "020":
                    ResultTypeNetwork.Text = "Mã vùng/thuê bao tỉnh Lào Cai";
                    imgPhoneNetwork.Source = new BitmapImage(new Uri(@"Assets/image/logotinh/Laocai.png", UriKind.RelativeOrAbsolute));
                    break;
                case "022":
                    ResultTypeNetwork.Text = "Mã vùng/thuê bao tỉnh Sơn La";
                    imgPhoneNetwork.Source = new BitmapImage(new Uri(@"Assets/image/logotinh/Sonla.png", UriKind.RelativeOrAbsolute));
                    break;
                case "025":
                    ResultTypeNetwork.Text = "Mã vùng/thuê bao tỉnh Lạng Sơn";
                    imgPhoneNetwork.Source = new BitmapImage(new Uri(@"Assets/image/logotinh/Langson.png", UriKind.RelativeOrAbsolute));
                    break;
                case "026":
                    ResultTypeNetwork.Text = "Mã vùng/thuê bao tỉnh Cao Bằng";
                    imgPhoneNetwork.Source = new BitmapImage(new Uri(@"Assets/image/logotinh/Caobang.png", UriKind.RelativeOrAbsolute));
                    break;
                case "027":
                    ResultTypeNetwork.Text = "Mã vùng/thuê bao tỉnh Tuyên Quang";
                    imgPhoneNetwork.Source = new BitmapImage(new Uri(@"Assets/image/logotinh/Tuyenquang.png", UriKind.RelativeOrAbsolute));
                    break;
                case "029":
                    ResultTypeNetwork.Text = "Mã vùng/thuê bao tỉnh Yên Bái";
                    imgPhoneNetwork.Source = new BitmapImage(new Uri(@"Assets/image/logotinh/Yenbai.png", UriKind.RelativeOrAbsolute));
                    break;
                case "030":
                    ResultTypeNetwork.Text = "Mã vùng/thuê bao tỉnh Ninh Bình";
                    imgPhoneNetwork.Source = new BitmapImage(new Uri(@"Assets/image/logotinh/Ninhbinh.png", UriKind.RelativeOrAbsolute));
                    break;
                case "031":
                    ResultTypeNetwork.Text = "Mã vùng/thuê bao Thành Phố Hải Phòng";
                    imgPhoneNetwork.Source = new BitmapImage(new Uri(@"Assets/image/logotinh/Haiphong.png", UriKind.RelativeOrAbsolute));
                    break;
                case "033":
                    ResultTypeNetwork.Text = "Mã vùng/thuê bao tỉnh Quảng Ninh";
                    imgPhoneNetwork.Source = new BitmapImage(new Uri(@"Assets/image/logotinh/Quangninh.png", UriKind.RelativeOrAbsolute));
                    break;
                case "036":
                    ResultTypeNetwork.Text = "Mã vùng/thuê bao tỉnh Thái Bình";
                    imgPhoneNetwork.Source = new BitmapImage(new Uri(@"Assets/image/logotinh/Thaibinh.png", UriKind.RelativeOrAbsolute));
                    break;
                case "037":
                    ResultTypeNetwork.Text = "Mã vùng/thuê bao tỉnh Thanh Hóa";
                    imgPhoneNetwork.Source = new BitmapImage(new Uri(@"Assets/image/logotinh/Thanhhoa.png", UriKind.RelativeOrAbsolute));
                    break;
                case "038":
                    ResultTypeNetwork.Text = "Mã vùng/thuê bao tỉnh Nghệ An";
                    imgPhoneNetwork.Source = new BitmapImage(new Uri(@"Assets/image/logotinh/Nghean.png", UriKind.RelativeOrAbsolute));
                    break;
                case "039":
                    ResultTypeNetwork.Text = "Mã vùng/thuê bao tỉnh Hà Tĩnh";
                    imgPhoneNetwork.Source = new BitmapImage(new Uri(@"Assets/image/logotinh/Hatinh.png", UriKind.RelativeOrAbsolute));
                    break;
                case "052":
                    ResultTypeNetwork.Text = "Mã vùng/thuê bao tỉnh Quảng Bình";
                    imgPhoneNetwork.Source = new BitmapImage(new Uri(@"Assets/image/logotinh/Quangbinh.png", UriKind.RelativeOrAbsolute));
                    break;
                case "053":
                    ResultTypeNetwork.Text = "Mã vùng/thuê bao tỉnh Quảng Trị";
                    imgPhoneNetwork.Source = new BitmapImage(new Uri(@"Assets/image/logotinh/Quangtri.png", UriKind.RelativeOrAbsolute));
                    break;
                case "054":
                    ResultTypeNetwork.Text = "Mã vùng/thuê bao tỉnh Thừa Thiên Huế";
                    imgPhoneNetwork.Source = new BitmapImage(new Uri(@"Assets/image/logotinh/Thuathienhue.png", UriKind.RelativeOrAbsolute));
                    break;
                case "055":
                    ResultTypeNetwork.Text = "Mã vùng/thuê bao tỉnh Quảng Ngãi";
                    imgPhoneNetwork.Source = new BitmapImage(new Uri(@"Assets/image/logotinh/Quangngai.png", UriKind.RelativeOrAbsolute));
                    break;
                case "056":
                    ResultTypeNetwork.Text = "Mã vùng/thuê bao tỉnh Bình Định";
                    imgPhoneNetwork.Source = new BitmapImage(new Uri(@"Assets/image/logotinh/Binhdinh.png", UriKind.RelativeOrAbsolute));
                    break;
                case "057":
                    ResultTypeNetwork.Text = "Mã vùng/thuê bao tỉnh Phú Yên";
                    imgPhoneNetwork.Source = new BitmapImage(new Uri(@"Assets/image/logotinh/Phuyen.png", UriKind.RelativeOrAbsolute));
                    break;
                case "058":
                    ResultTypeNetwork.Text = "Mã vùng/thuê bao tỉnh Khánh Hòa";
                    imgPhoneNetwork.Source = new BitmapImage(new Uri(@"Assets/image/logotinh/Khanhhoa.png", UriKind.RelativeOrAbsolute));
                    break;
                case "059":
                    ResultTypeNetwork.Text = "Mã vùng/thuê bao tỉnh Gia Lai";
                    imgPhoneNetwork.Source = new BitmapImage(new Uri(@"Assets/image/logotinh/Gialai.png", UriKind.RelativeOrAbsolute));
                    break;
                case "060":
                    ResultTypeNetwork.Text = "Mã vùng/thuê bao tỉnh Kon Tum";
                    imgPhoneNetwork.Source = new BitmapImage(new Uri(@"Assets/image/logotinh/Kontum.png", UriKind.RelativeOrAbsolute));
                    break;
                case "061":
                    ResultTypeNetwork.Text = "Mã vùng/thuê bao tỉnh Đồng Nai";
                    imgPhoneNetwork.Source = new BitmapImage(new Uri(@"Assets/image/logotinh/Dongnai.png", UriKind.RelativeOrAbsolute));
                    break;
                case "062":
                    ResultTypeNetwork.Text = "Mã vùng/thuê bao tỉnh Bình Thuận";
                    imgPhoneNetwork.Source = new BitmapImage(new Uri(@"Assets/image/logotinh/Binhthuan.png", UriKind.RelativeOrAbsolute));
                    break;
                case "063":
                    ResultTypeNetwork.Text = "Mã vùng/thuê bao tỉnh Lâm Đồng";
                    imgPhoneNetwork.Source = new BitmapImage(new Uri(@"Assets/image/logotinh/Lamdong.png", UriKind.RelativeOrAbsolute));
                    break;
                case "064":
                    ResultTypeNetwork.Text = "Mã vùng/thuê bao Thành Phố Vũng Tàu";
                    imgPhoneNetwork.Source = new BitmapImage(new Uri(@"Assets/image/logotinh/Vungtau.png", UriKind.RelativeOrAbsolute));
                    break;
                case "066":
                    ResultTypeNetwork.Text = "Mã vùng/thuê bao tỉnh Tây Ninh";
                    imgPhoneNetwork.Source = new BitmapImage(new Uri(@"Assets/image/logotinh/Tayninh.png", UriKind.RelativeOrAbsolute));
                    break;
                case "067":
                    ResultTypeNetwork.Text = "Mã vùng/thuê bao tỉnh Đồng Tháp";
                    imgPhoneNetwork.Source = new BitmapImage(new Uri(@"Assets/image/logotinh/Dongthap.png", UriKind.RelativeOrAbsolute));
                    break;
                case "068":
                    ResultTypeNetwork.Text = "Mã vùng/thuê bao tỉnh Ninh Thuận";
                    imgPhoneNetwork.Source = new BitmapImage(new Uri(@"Assets/image/logotinh/Ninhthuan.png", UriKind.RelativeOrAbsolute));
                    break;
                case "070":
                    ResultTypeNetwork.Text = "Mã vùng/thuê bao tỉnh Vĩnh Long";
                    imgPhoneNetwork.Source = new BitmapImage(new Uri(@"Assets/image/logotinh/Vinhlong.png", UriKind.RelativeOrAbsolute));
                    break;
                case "071":
                    ResultTypeNetwork.Text = "Mã vùng/thuê bao tỉnh Bình Phước";
                    imgPhoneNetwork.Source = new BitmapImage(new Uri(@"Assets/image/logotinh/Binhphuoc.png", UriKind.RelativeOrAbsolute));
                    break;
                case "072":
                    ResultTypeNetwork.Text = "Mã vùng/thuê bao tỉnh Long An";
                    imgPhoneNetwork.Source = new BitmapImage(new Uri(@"Assets/image/logotinh/Longan.png", UriKind.RelativeOrAbsolute));
                    break;
                case "073":
                    ResultTypeNetwork.Text = "Mã vùng/thuê bao tỉnh Tiền Giang";
                    imgPhoneNetwork.Source = new BitmapImage(new Uri(@"Assets/image/logotinh/Tiengiang.png", UriKind.RelativeOrAbsolute));
                    break;
                case "074":
                    ResultTypeNetwork.Text = "Mã vùng/thuê bao tỉnh Trà Vinh";
                    imgPhoneNetwork.Source = new BitmapImage(new Uri(@"Assets/image/logotinh/Travinh.png", UriKind.RelativeOrAbsolute));
                    break;
                case "075":
                    ResultTypeNetwork.Text = "Mã vùng/thuê bao tỉnh Bến Tre";
                    imgPhoneNetwork.Source = new BitmapImage(new Uri(@"Assets/image/logotinh/Bentre.png", UriKind.RelativeOrAbsolute));
                    break;
                case "076":
                    ResultTypeNetwork.Text = "Mã vùng/thuê bao tỉnh An Giang";
                    imgPhoneNetwork.Source = new BitmapImage(new Uri(@"Assets/image/logotinh/Angiang.png", UriKind.RelativeOrAbsolute));
                    break;
                case "077":
                    ResultTypeNetwork.Text = "Mã vùng/thuê bao tỉnh Kiên Giang";
                    imgPhoneNetwork.Source = new BitmapImage(new Uri(@"Assets/image/logotinh/Kiengiang.png", UriKind.RelativeOrAbsolute));
                    break;
                case "079":
                    ResultTypeNetwork.Text = "Mã vùng/thuê bao tỉnh Sóc Trăng";
                    imgPhoneNetwork.Source = new BitmapImage(new Uri(@"Assets/image/logotinh/Soctrang.png", UriKind.RelativeOrAbsolute));
                    break;
                // SĐT di động
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
                // số điện thoại bàn mới
                case "0203":
                    ResultTypeNetwork.Text = "Mã vùng/thuê bao tỉnh Quảng Ninh";
                    imgPhoneNetwork.Source = new BitmapImage(new Uri(@"Assets/image/logotinh/Quangninh.png", UriKind.RelativeOrAbsolute));
                    break;
                case "0204":
                    ResultTypeNetwork.Text = "Mã vùng/thuê bao tỉnh Bắc Giang";
                    imgPhoneNetwork.Source = new BitmapImage(new Uri(@"Assets/image/logotinh/Bacgiang.png", UriKind.RelativeOrAbsolute));
                    break;
                case "0205":
                    ResultTypeNetwork.Text = "Mã vùng/thuê bao tỉnh Lạng Sơn";
                    imgPhoneNetwork.Source = new BitmapImage(new Uri(@"Assets/image/logotinh/Langson.png", UriKind.RelativeOrAbsolute));
                    break;
                case "0206":
                    ResultTypeNetwork.Text = "Mã vùng/thuê bao tỉnh Cao Bằng";
                    imgPhoneNetwork.Source = new BitmapImage(new Uri(@"Assets/image/logotinh/Caobang.png", UriKind.RelativeOrAbsolute));
                    break;
                case "0207":
                    ResultTypeNetwork.Text = "Mã vùng/thuê bao tỉnh Tuyên Quang";
                    imgPhoneNetwork.Source = new BitmapImage(new Uri(@"Assets/image/logotinh/Tuyenquang.png", UriKind.RelativeOrAbsolute));
                    break;
                case "0208":
                    ResultTypeNetwork.Text = "Mã vùng/thuê bao tỉnh Thái Nguyên";
                    imgPhoneNetwork.Source = new BitmapImage(new Uri(@"Assets/image/logotinh/Thainguyen.png", UriKind.RelativeOrAbsolute));
                    break;
                case "0209":
                    ResultTypeNetwork.Text = "Mã vùng/thuê bao tỉnh Bắc Kạn";
                    imgPhoneNetwork.Source = new BitmapImage(new Uri(@"Assets/image/logotinh/Backan.png", UriKind.RelativeOrAbsolute));
                    break;
                case "0210":
                    ResultTypeNetwork.Text = "Mã vùng/thuê bao tỉnh Phú Thọ";
                    imgPhoneNetwork.Source = new BitmapImage(new Uri(@"Assets/image/logotinh/Phutho.png", UriKind.RelativeOrAbsolute));
                    break;
                case "0211":
                    ResultTypeNetwork.Text = "Mã vùng/thuê bao tỉnh Vĩnh Phúc";
                    imgPhoneNetwork.Source = new BitmapImage(new Uri(@"Assets/image/logotinh/Vinhphuc.png", UriKind.RelativeOrAbsolute));
                    break;
                case "0212":
                    ResultTypeNetwork.Text = "Mã vùng/thuê bao tỉnh Sơn La";
                    imgPhoneNetwork.Source = new BitmapImage(new Uri(@"Assets/image/logotinh/Sonla.png", UriKind.RelativeOrAbsolute));
                    break;
                case "0213":
                    ResultTypeNetwork.Text = "Mã vùng/thuê bao tỉnh Lai Châu";
                    imgPhoneNetwork.Source = new BitmapImage(new Uri(@"Assets/image/logotinh/Laichau.png", UriKind.RelativeOrAbsolute));
                    break;
                case "0214":
                    ResultTypeNetwork.Text = "Mã vùng/thuê bao tỉnh Lào Cai";
                    imgPhoneNetwork.Source = new BitmapImage(new Uri(@"Assets/image/logotinh/Laocai.png", UriKind.RelativeOrAbsolute));
                    break;
                case "0215":
                    ResultTypeNetwork.Text = "Mã vùng/thuê bao tỉnh Điện Biên";
                    imgPhoneNetwork.Source = new BitmapImage(new Uri(@"Assets/image/logotinh/Dienbien.png", UriKind.RelativeOrAbsolute));
                    break;
                case "0216":
                    ResultTypeNetwork.Text = "Mã vùng/thuê bao tỉnh Yên Bái";
                    imgPhoneNetwork.Source = new BitmapImage(new Uri(@"Assets/image/logotinh/Yenbai.png", UriKind.RelativeOrAbsolute));
                    break;
                case "0218":
                    ResultTypeNetwork.Text = "Mã vùng/thuê bao tỉnh Hòa Bình";
                    imgPhoneNetwork.Source = new BitmapImage(new Uri(@"Assets/image/logotinh/Hoabinh.png", UriKind.RelativeOrAbsolute));
                    break;
                case "0219":
                    ResultTypeNetwork.Text = "Mã vùng/thuê bao tỉnh Hà Giang";
                    imgPhoneNetwork.Source = new BitmapImage(new Uri(@"Assets/image/logotinh/Hagiang.png", UriKind.RelativeOrAbsolute));
                    break;
                case "0220":
                    ResultTypeNetwork.Text = "Mã vùng/thuê bao tỉnh Hải Dương";
                    imgPhoneNetwork.Source = new BitmapImage(new Uri(@"Assets/image/logotinh/Haiduong.png", UriKind.RelativeOrAbsolute));
                    break;
                case "0221":
                    ResultTypeNetwork.Text = "Mã vùng/thuê bao tỉnh Hưng Yên";
                    imgPhoneNetwork.Source = new BitmapImage(new Uri(@"Assets/image/logotinh/Hungyen.png", UriKind.RelativeOrAbsolute));
                    break;
                case "0222":
                    ResultTypeNetwork.Text = "Mã vùng/thuê bao tỉnh Bắc Ninh";
                    imgPhoneNetwork.Source = new BitmapImage(new Uri(@"Assets/image/logotinh/Bacninh.png", UriKind.RelativeOrAbsolute));
                    break;
                case "0225":
                    ResultTypeNetwork.Text = "Mã vùng/thuê bao thành phố Hải Phòng";
                    imgPhoneNetwork.Source = new BitmapImage(new Uri(@"Assets/image/logotinh/Haiphong.png", UriKind.RelativeOrAbsolute));
                    break;
                case "0226":
                    ResultTypeNetwork.Text = "Mã vùng/thuê bao tỉnh Hà Nam";
                    imgPhoneNetwork.Source = new BitmapImage(new Uri(@"Assets/image/logotinh/Hanam.png", UriKind.RelativeOrAbsolute));
                    break;
                case "0227":
                    ResultTypeNetwork.Text = "Mã vùng/thuê bao tỉnh Thái Bình";
                    imgPhoneNetwork.Source = new BitmapImage(new Uri(@"Assets/image/logotinh/Thaibinh.png", UriKind.RelativeOrAbsolute));
                    break;
                case "0228":
                    ResultTypeNetwork.Text = "Mã vùng/thuê bao tỉnh Nam Định";
                    imgPhoneNetwork.Source = new BitmapImage(new Uri(@"Assets/image/logotinh/Namdinh.png", UriKind.RelativeOrAbsolute));
                    break;
                case "0229":
                    ResultTypeNetwork.Text = "Mã vùng/thuê bao tỉnh Ninh Bình";
                    imgPhoneNetwork.Source = new BitmapImage(new Uri(@"Assets/image/logotinh/Ninhbinh.png", UriKind.RelativeOrAbsolute));
                    break;
                case "0232":
                    ResultTypeNetwork.Text = "Mã vùng/thuê bao tỉnh Quảng Bình";
                    imgPhoneNetwork.Source = new BitmapImage(new Uri(@"Assets/image/logotinh/Quangbinh.png", UriKind.RelativeOrAbsolute));
                    break;
                case "0233":
                    ResultTypeNetwork.Text = "Mã vùng/thuê bao tỉnh Quảng Trị";
                    imgPhoneNetwork.Source = new BitmapImage(new Uri(@"Assets/image/logotinh/Quangtri.png", UriKind.RelativeOrAbsolute));
                    break;
                case "0234":
                    ResultTypeNetwork.Text = "Mã vùng/thuê bao tỉnh Thừa Thiên Huế";
                    imgPhoneNetwork.Source = new BitmapImage(new Uri(@"Assets/image/logotinh/Thuathienhue.png", UriKind.RelativeOrAbsolute));
                    break;
                case "0235":
                    ResultTypeNetwork.Text = "Mã vùng/thuê bao tỉnh Quảng Nam";
                    imgPhoneNetwork.Source = new BitmapImage(new Uri(@"Assets/image/logotinh/Quangnam.png", UriKind.RelativeOrAbsolute));
                    break;
                case "0236":
                    ResultTypeNetwork.Text = "Mã vùng/thuê bao thành phố Đà Nẵng";
                    imgPhoneNetwork.Source = new BitmapImage(new Uri(@"Assets/image/logotinh/Danang.png", UriKind.RelativeOrAbsolute));
                    break;
                case "0237":
                    ResultTypeNetwork.Text = "Mã vùng/thuê bao tỉnh Thanh Hóa";
                    imgPhoneNetwork.Source = new BitmapImage(new Uri(@"Assets/image/logotinh/Thanhhoa.png", UriKind.RelativeOrAbsolute));
                    break;
                case "0238":
                    ResultTypeNetwork.Text = "Mã vùng/thuê bao tỉnh Nghệ An";
                    imgPhoneNetwork.Source = new BitmapImage(new Uri(@"Assets/image/logotinh/Nghean.png", UriKind.RelativeOrAbsolute));
                    break;
                case "0239":
                    ResultTypeNetwork.Text = "Mã vùng/thuê bao tỉnh Hà Tĩnh";
                    imgPhoneNetwork.Source = new BitmapImage(new Uri(@"Assets/image/logotinh/Hatinh.png", UriKind.RelativeOrAbsolute));
                    break;
                case "0251":
                    ResultTypeNetwork.Text = "Mã vùng/thuê bao tỉnh Đồng Nai";
                    imgPhoneNetwork.Source = new BitmapImage(new Uri(@"Assets/image/logotinh/Dongnai.png", UriKind.RelativeOrAbsolute));
                    break;
                case "0252":
                    ResultTypeNetwork.Text = "Mã vùng/thuê bao tỉnh Bình Thuận";
                    imgPhoneNetwork.Source = new BitmapImage(new Uri(@"Assets/image/logotinh/Binhthuan.png", UriKind.RelativeOrAbsolute));
                    break;
                case "0254":
                    ResultTypeNetwork.Text = "Mã vùng/thuê bao tỉnh Bà Rịa Vũng Tàu";
                    imgPhoneNetwork.Source = new BitmapImage(new Uri(@"Assets/image/logotinh/Vungtau.png", UriKind.RelativeOrAbsolute));
                    break;
                case "0255":
                    ResultTypeNetwork.Text = "Mã vùng/thuê bao tỉnh Quảng Ngãi";
                    imgPhoneNetwork.Source = new BitmapImage(new Uri(@"Assets/image/logotinh/Quangngai.png", UriKind.RelativeOrAbsolute));
                    break;
                case "0256":
                    ResultTypeNetwork.Text = "Mã vùng/thuê bao tỉnh Bình Định";
                    imgPhoneNetwork.Source = new BitmapImage(new Uri(@"Assets/image/logotinh/Binhdinh.png", UriKind.RelativeOrAbsolute));
                    break;
                case "0257":
                    ResultTypeNetwork.Text = "Mã vùng/thuê bao tỉnh Phú Yên";
                    imgPhoneNetwork.Source = new BitmapImage(new Uri(@"Assets/image/logotinh/Phuyen.png", UriKind.RelativeOrAbsolute));
                    break;
                case "0258":
                    ResultTypeNetwork.Text = "Mã vùng/thuê bao tỉnh Khánh Hòa";
                    imgPhoneNetwork.Source = new BitmapImage(new Uri(@"Assets/image/logotinh/Khanhhoa.png", UriKind.RelativeOrAbsolute));
                    break;
                case "0259 ":
                    ResultTypeNetwork.Text = "Mã vùng/thuê bao tỉnh Ninh Thuận";
                    imgPhoneNetwork.Source = new BitmapImage(new Uri(@"Assets/image/logotinh/Ninhthuan.png", UriKind.RelativeOrAbsolute));
                    break;
                case "0260":
                    ResultTypeNetwork.Text = "Mã vùng/thuê bao tỉnh Kon Tum";
                    imgPhoneNetwork.Source = new BitmapImage(new Uri(@"Assets/image/logotinh/Kontum.png", UriKind.RelativeOrAbsolute));
                    break;
                case "0261":
                    ResultTypeNetwork.Text = "Mã vùng/thuê bao tỉnh Đăk Nông";
                    imgPhoneNetwork.Source = new BitmapImage(new Uri(@"Assets/image/logotinh/Daknong.png", UriKind.RelativeOrAbsolute));
                    break;
                case "0262":
                    ResultTypeNetwork.Text = "Mã vùng/thuê bao tỉnh Đăk Lăk";
                    imgPhoneNetwork.Source = new BitmapImage(new Uri(@"Assets/image/logotinh/Daklak.png", UriKind.RelativeOrAbsolute));
                    break;
                case "0263":
                    ResultTypeNetwork.Text = "Mã vùng/thuê bao tỉnh Lâm Đồng";
                    imgPhoneNetwork.Source = new BitmapImage(new Uri(@"Assets/image/logotinh/Lamdong.png", UriKind.RelativeOrAbsolute));
                    break;
                case "0269":
                    ResultTypeNetwork.Text = "Mã vùng/thuê bao tỉnh Gia Lai";
                    imgPhoneNetwork.Source = new BitmapImage(new Uri(@"Assets/image/logotinh/Gialai.png", UriKind.RelativeOrAbsolute));
                    break;
                case "0270":
                    ResultTypeNetwork.Text = "Mã vùng/thuê bao tỉnh Vĩnh Long";
                    imgPhoneNetwork.Source = new BitmapImage(new Uri(@"Assets/image/logotinh/Vinhlong.png", UriKind.RelativeOrAbsolute));
                    break;
                case "0271":
                    ResultTypeNetwork.Text = "Mã vùng/thuê bao tỉnh Bình Phước";
                    imgPhoneNetwork.Source = new BitmapImage(new Uri(@"Assets/image/logotinh/Binhphuoc.png", UriKind.RelativeOrAbsolute));
                    break;
                case "0272":
                    ResultTypeNetwork.Text = "Mã vùng/thuê bao tỉnh Long An";
                    imgPhoneNetwork.Source = new BitmapImage(new Uri(@"Assets/image/logotinh/Longan.png", UriKind.RelativeOrAbsolute));
                    break;
                case "0273":
                    ResultTypeNetwork.Text = "Mã vùng/thuê bao tỉnh Tiền Giang";
                    imgPhoneNetwork.Source = new BitmapImage(new Uri(@"Assets/image/logotinh/Tiengiang.png", UriKind.RelativeOrAbsolute));
                    break;
                case "0274":
                    ResultTypeNetwork.Text = "Mã vùng/thuê bao tỉnh Bình Dương";
                    imgPhoneNetwork.Source = new BitmapImage(new Uri(@"Assets/image/logotinh/Binhduong.png", UriKind.RelativeOrAbsolute));
                    break;
                case "0275":
                    ResultTypeNetwork.Text = "Mã vùng/thuê bao tỉnh Bến Tre";
                    imgPhoneNetwork.Source = new BitmapImage(new Uri(@"Assets/image/logotinh/Bentre.png", UriKind.RelativeOrAbsolute));
                    break;
                case "0276":
                    ResultTypeNetwork.Text = "Mã vùng/thuê bao tỉnh Tây Ninh";
                    imgPhoneNetwork.Source = new BitmapImage(new Uri(@"Assets/image/logotinh/Tayninh.png", UriKind.RelativeOrAbsolute));
                    break;
                case "0277":
                    ResultTypeNetwork.Text = "Mã vùng/thuê bao tỉnh Đồng Tháp";
                    imgPhoneNetwork.Source = new BitmapImage(new Uri(@"Assets/image/logotinh/Dongthap.png", UriKind.RelativeOrAbsolute));
                    break;
                case "0290":
                    ResultTypeNetwork.Text = "Mã vùng/thuê bao tỉnh Cà Mau";
                    imgPhoneNetwork.Source = new BitmapImage(new Uri(@"Assets/image/logotinh/Camau.png", UriKind.RelativeOrAbsolute));
                    break;
                case "0291":
                    ResultTypeNetwork.Text = "Mã vùng/thuê bao tỉnh Bạc Liêu";
                    imgPhoneNetwork.Source = new BitmapImage(new Uri(@"Assets/image/logotinh/Baclieu.png", UriKind.RelativeOrAbsolute));
                    break;
                case "0292":
                    ResultTypeNetwork.Text = "Mã vùng/thuê bao tỉnh thành phố Cần Thơ";
                    imgPhoneNetwork.Source = new BitmapImage(new Uri(@"Assets/image/logotinh/Cantho.png", UriKind.RelativeOrAbsolute));
                    break;
                case "0293":
                    ResultTypeNetwork.Text = "Mã vùng/thuê bao tỉnh Hậu Giang";
                    imgPhoneNetwork.Source = new BitmapImage(new Uri(@"Assets/image/logotinh/Haugiang.png", UriKind.RelativeOrAbsolute));
                    break;
                case "0294":
                    ResultTypeNetwork.Text = "Mã vùng/thuê bao tỉnh Trà Vinh";
                    imgPhoneNetwork.Source = new BitmapImage(new Uri(@"Assets/image/logotinh/Travinh.png", UriKind.RelativeOrAbsolute));
                    break;
                case "0296":
                    ResultTypeNetwork.Text = "Mã vùng/thuê bao tỉnh An Giang";
                    imgPhoneNetwork.Source = new BitmapImage(new Uri(@"Assets/image/logotinh/Angiang.png", UriKind.RelativeOrAbsolute));
                    break;
                case "0297":
                    ResultTypeNetwork.Text = "Mã vùng/thuê bao tỉnh Kiên Giang";
                    imgPhoneNetwork.Source = new BitmapImage(new Uri(@"Assets/image/logotinh/Kiengiang.png", UriKind.RelativeOrAbsolute));
                    break;
                case "0299":
                    ResultTypeNetwork.Text = "Mã vùng/thuê bao tỉnh Sóc Trăng";
                    imgPhoneNetwork.Source = new BitmapImage(new Uri(@"Assets/image/logotinh/Soctrang.png", UriKind.RelativeOrAbsolute));
                    break;
<<<<<<< HEAD
					/*case "0210":
                        ResultTypeNetwork.Text = "Mã vùng/thuê bao tỉnh ";
                        imgPhoneNetwork.Source = new BitmapImage(new Uri(@"Assets/image/logotinh/Phutho.png", UriKind.RelativeOrAbsolute));
                    break;
                    case "0211":
                        ResultTypeNetwork.Text = "Mã vùng/thuê bao tỉnh ";
                        imgPhoneNetwork.Source = new BitmapImage(new Uri(@"Assets/image/logotinh/Vinhphuc.png", UriKind.RelativeOrAbsolute));
                    break;
                    case "0218":
                    ResultTypeNetwork.Text = "Mã vùng/thuê bao tỉnh Hòa Bình ";
                        imgPhoneNetwork.Source = new BitmapImage(new Uri(@"Assets/image/logotinh/Hoabinh.png", UriKind.RelativeOrAbsolute));
                    break;
                    case "0219":
                        ResultTypeNetwork.Text = "Mã vùng/thuê bao tỉnh Hà Giang ";
                        imgPhoneNetwork.Source = new BitmapImage(new Uri(@"Assets/image/logotinh/Hagiang.png", UriKind.RelativeOrAbsolute));
                    break;*/
=======
				// số điện thoại bàn cũ
					case "0210":
                        ResultTypeNetwork.Text = "Mã vùng/thuê bao tỉnh ";
                        imgPhoneNetwork.Source = new BitmapImage(new Uri(@"Assets/image/logotinh/Phutho.png", UriKind.RelativeOrAbsolute));
                    break;
                    //case "0211":
                    //    ResultTypeNetwork.Text = "Mã vùng/thuê bao tỉnh ";
                    //    imgPhoneNetwork.Source = new BitmapImage(new Uri(@"Assets/image/logotinh/Vinhphuc.png", UriKind.RelativeOrAbsolute));
                    //break;
                    //case "0218":
                    //    ResultTypeNetwork.Text = "Mã vùng/thuê bao tỉnh ";
                    //    imgPhoneNetwork.Source = new BitmapImage(new Uri(@"Assets/image/logotinh/Hoabinh.png", UriKind.RelativeOrAbsolute));
                    //break;
                    //case "0219":
                    //    ResultTypeNetwork.Text = "Mã vùng/thuê bao tỉnh ";
                    //    imgPhoneNetwork.Source = new BitmapImage(new Uri(@"Assets/image/logotinh/Hagiang.png", UriKind.RelativeOrAbsolute));
                    //break;
>>>>>>> origin/master
					case "0230":
                        ResultTypeNetwork.Text = "Mã vùng/thuê bao tỉnh Điện Biên";
                        imgPhoneNetwork.Source = new BitmapImage(new Uri(@"Assets/image/logotinh/Dienbien.png", UriKind.RelativeOrAbsolute));
                    break;
                    case "0231":
                        ResultTypeNetwork.Text = "Mã vùng/thuê bao tỉnh Lai Châu";
                        imgPhoneNetwork.Source = new BitmapImage(new Uri(@"Assets/image/logotinh/Laichau.png", UriKind.RelativeOrAbsolute));
                    break;
					case "0240":
                        ResultTypeNetwork.Text = "Mã vùng/thuê bao tỉnh Bắc Giang";
                        imgPhoneNetwork.Source = new BitmapImage(new Uri(@"Assets/image/logotinh/Bacgiang.png", UriKind.RelativeOrAbsolute));
                    break;
                    case "0241":
                        ResultTypeNetwork.Text = "Mã vùng/thuê bao tỉnh Bắc Ninh ";
                        imgPhoneNetwork.Source = new BitmapImage(new Uri(@"Assets/image/logotinh/Bacninh.png", UriKind.RelativeOrAbsolute));
                    break;
					case "0280":
                        ResultTypeNetwork.Text = "Mã vùng/thuê bao tỉnh Thái Nguyên ";
                        imgPhoneNetwork.Source = new BitmapImage(new Uri(@"Assets/image/logotinh/Thainguyen.png", UriKind.RelativeOrAbsolute));
                    break;
                    case "0281":
                        ResultTypeNetwork.Text = "Mã vùng/thuê bao tỉnh Bắc Cạn ";
                        imgPhoneNetwork.Source = new BitmapImage(new Uri(@"Assets/image/logotinh/Backan.png", UriKind.RelativeOrAbsolute));
                    break;
					case "0320":
                        ResultTypeNetwork.Text = "Mã vùng/thuê bao tỉnh Hải Dương";
                        imgPhoneNetwork.Source = new BitmapImage(new Uri(@"Assets/image/logotinh/Haiduong.png", UriKind.RelativeOrAbsolute));
                    break;
                    case "0321":
                        ResultTypeNetwork.Text = "Mã vùng/thuê bao tỉnh Hưng Yên ";
                        imgPhoneNetwork.Source = new BitmapImage(new Uri(@"Assets/image/logotinh/Hungyen.png", UriKind.RelativeOrAbsolute));
                    break;
					case "0350":
                        ResultTypeNetwork.Text = "Mã vùng/thuê bao tỉnh Nam Định ";
                        imgPhoneNetwork.Source = new BitmapImage(new Uri(@"Assets/image/logotinh/Namdinh.png", UriKind.RelativeOrAbsolute));
                    break;
                    case "0351":
                        ResultTypeNetwork.Text = "Mã vùng/thuê bao tỉnh Hà Nam ";
                        imgPhoneNetwork.Source = new BitmapImage(new Uri(@"Assets/image/logotinh/Hanam.png", UriKind.RelativeOrAbsolute));
                    break;
					case "0500":
                    ResultTypeNetwork.Text = "Mã vùng/thuê bao tỉnh Đắk Lắk ";
                        imgPhoneNetwork.Source = new BitmapImage(new Uri(@"Assets/image/logotinh/Daklak.png", UriKind.RelativeOrAbsolute));
                    break;
                    case "0501":
                    ResultTypeNetwork.Text = "Mã vùng/thuê bao tỉnh Đắk Nông ";
                        imgPhoneNetwork.Source = new BitmapImage(new Uri(@"Assets/image/logotinh/Daknong.png", UriKind.RelativeOrAbsolute));
                    break;
					case "0510":
                        ResultTypeNetwork.Text = "Mã vùng/thuê bao tỉnh Quảng Nam ";
                        imgPhoneNetwork.Source = new BitmapImage(new Uri(@"Assets/image/logotinh/Quangnam.png", UriKind.RelativeOrAbsolute));
                    break;
                    case "0511":
                        ResultTypeNetwork.Text = "Mã vùng/thuê bao tỉnh Đà Nẵng ";
                        imgPhoneNetwork.Source = new BitmapImage(new Uri(@"Assets/image/logotinh/Danang.png", UriKind.RelativeOrAbsolute));
                    break;
					case "0650":
                        ResultTypeNetwork.Text = "Mã vùng/thuê bao tỉnh Bình Dương";
                        imgPhoneNetwork.Source = new BitmapImage(new Uri(@"Assets/image/logotinh/Binhduong.png", UriKind.RelativeOrAbsolute));
                    break;
                    case "0651":
                        ResultTypeNetwork.Text = "Mã vùng/thuê bao tỉnh Bình Phước";
                        imgPhoneNetwork.Source = new BitmapImage(new Uri(@"Assets/image/logotinh/Binhphuoc.png", UriKind.RelativeOrAbsolute));
                    break;
					case "0710":
                        ResultTypeNetwork.Text = "Mã vùng/thuê bao tỉnh Cần Thơ ";
                        imgPhoneNetwork.Source = new BitmapImage(new Uri(@"Assets/image/logotinh/Cantho.png", UriKind.RelativeOrAbsolute));
                    break;
                    case "0711":
                        ResultTypeNetwork.Text = "Mã vùng/thuê bao tỉnh Hậu Giang";
                        imgPhoneNetwork.Source = new BitmapImage(new Uri(@"Assets/image/logotinh/Haugiang.png", UriKind.RelativeOrAbsolute));
                    break;
					case "0780":
                        ResultTypeNetwork.Text = "Mã vùng/thuê bao tỉnh Cà Mau ";
                        imgPhoneNetwork.Source = new BitmapImage(new Uri(@"Assets/image/logotinh/Camau.png", UriKind.RelativeOrAbsolute));
                    break;
                    case "0781":
                        ResultTypeNetwork.Text = "Mã vùng/thuê bao tỉnh Bạc Liêu";
                        imgPhoneNetwork.Source = new BitmapImage(new Uri(@"Assets/image/logotinh/Baclieu.png", UriKind.RelativeOrAbsolute));
                    break;
                // số điện thoại di động
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
            NavigationService.Navigate(new Uri("/ListContact.xaml?parameter=all", UriKind.Relative));
        }
        private void ListNetwork_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/ListNetwork.xaml", UriKind.Relative));
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
