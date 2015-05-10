using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace NetworkPhoneChecker
{
    public class FunctionHelper
    {
        public static string result = "";
        public static string CheckNetworkPhoneNumber(string phonenumber, int type)
        {
            try
            {
                phonenumber = phonenumber.Replace("+84", "0");
                Regex digitsOnly = new Regex(@"[^\d]");
                phonenumber = digitsOnly.Replace(phonenumber, "");
                int length = phonenumber.Length;
                bool status = false;
                if (length >= 4)
                {
                    status = CheckFourNumber(phonenumber.Substring(0, 4),type);
                    if (!status)
                        status = CheckThreeNumber(phonenumber.Substring(0, 3), type);
                    if (!status)
                        status = CheckTwoNumber(phonenumber.Substring(0, 2), type);
                }
                else if (length == 3 && status == false)
                {
                    status = CheckThreeNumber(phonenumber.Substring(0, 3),type);
                    if (!status)
                        status = CheckTwoNumber(phonenumber.Substring(0, 2), type);
                }
                else if (length == 2 && status == false)
                {
                    status = CheckTwoNumber(phonenumber.Substring(0, 2), type);
                }
                else if (length < 2)
                {
                    result = type == 0 ? "Unknow" : "Assets/image/LogoNotfound.jpg";
                }
            }
            catch
            {
                result = type == 0 ? "Unknow" : "Assets/image/LogoNotfound.jpg";
            }
            return result;
        }

        public static bool CheckTwoNumber(string phonenumber, int type)
        {
            bool flag = true;
            switch (phonenumber)
            {
                // số điện thoại bàn cũ
                case "04":
                    result = type == 0 ? "Dienthoaiban" : "Assets/image/logotinh/Hanoi.png";
                    break;
                case "08":
                    result = type == 0 ? "Dienthoaiban" : "Assets/image/logotinh/Hochiminh.png";
                    break;
                default:
                    flag = false;
                    result = type == 0 ? "Unknow" : "Assets/image/LogoNotfound.jpg";
                    break;
            }
            return flag;
        }

        public static bool CheckThreeNumber(string phonenumber, int type)
        {
            bool flag = true;
            switch (phonenumber)
            {
                // số điện thoại bàn cũ
                case "020":
                    result = type == 0 ? "Dienthoaiban" : "Assets/image/logotinh/Laocai.png";
                    break;
                case "022":
                    result = type == 0 ? "Dienthoaiban" : "Assets/image/logotinh/Sonla.png";
                    break;
                case "025":
                    result = type == 0 ? "Dienthoaiban" : "Assets/image/logotinh/Langson.png";
                    break;
                case "026":
                    result = type == 0 ? "Dienthoaiban" : "Assets/image/logotinh/Caobang.png";
                    break;
                case "027":
                    result = type == 0 ? "Dienthoaiban" : "Assets/image/logotinh/Tuyenquang.png";
                    break;
                case "029":
                    result = type == 0 ? "Dienthoaiban" : "Assets/image/logotinh/Yenbai.png";
                    break;
                case "030":
                    result = type == 0 ? "Dienthoaiban" : "Assets/image/logotinh/Ninhbinh.png";
                    break;
                case "031":
                    result = type == 0 ? "Dienthoaiban" : "Assets/image/logotinh/Haiphong.png";
                    break;
                case "033":
                    result = type == 0 ? "Dienthoaiban" : "Assets/image/logotinh/Quangninh.png";
                    break;
                case "036":
                    result = type == 0 ? "Dienthoaiban" : "Assets/image/logotinh/Thaibinh.png";
                    break;
                case "037":
                    result = type == 0 ? "Dienthoaiban" : "Assets/image/logotinh/Thanhhoa.png";
                    break;
                case "038":
                    result = type == 0 ? "Dienthoaiban" : "Assets/image/logotinh/Nghean.png";
                    break;
                case "039":
                    result = type == 0 ? "Dienthoaiban" : "Assets/image/logotinh/Hatinh.png";
                    break;
                case "052":
                    result = type == 0 ? "Dienthoaiban" : "Assets/image/logotinh/Quangbinh.png";
                    break;
                case "053":
                    result = type == 0 ? "Dienthoaiban" : "Assets/image/logotinh/Quangtri.png";
                    break;
                case "054":
                    result = type == 0 ? "Dienthoaiban" : "Assets/image/logotinh/Thuathienhue.png";
                    break;
                case "055":
                    result = type == 0 ? "Dienthoaiban" : "Assets/image/logotinh/Quangngai.png";
                    break;
                case "056":
                    result = type == 0 ? "Dienthoaiban" : "Assets/image/logotinh/Binhdinh.png";
                    break;
                case "057":
                    result = type == 0 ? "Dienthoaiban" : "Assets/image/logotinh/Phuyen.png";
                    break;
                case "058":
                    result = type == 0 ? "Dienthoaiban" : "Assets/image/logotinh/Khanhhoa.png";
                    break;
                case "059":
                    result = type == 0 ? "Dienthoaiban" : "Assets/image/logotinh/Gialai.png";
                    break;
                case "060":
                    result = type == 0 ? "Dienthoaiban" : "Assets/image/logotinh/Kontum.png";
                    break;
                case "061":
                    result = type == 0 ? "Dienthoaiban" : "Assets/image/logotinh/Dongnai.png";
                    break;
                case "062":
                    result = type == 0 ? "Dienthoaiban" : "Assets/image/logotinh/Binhthuan.png";
                    break;
                case "063":
                    result = type == 0 ? "Dienthoaiban" : "Assets/image/logotinh/Lamdong.png";
                    break;
                case "064":
                    result = type == 0 ? "Dienthoaiban" : "Assets/image/logotinh/Vungtau.png";
                    break;
                case "066":
                    result = type == 0 ? "Dienthoaiban" : "Assets/image/logotinh/Tayninh.png";
                    break;
                case "067":
                    result = type == 0 ? "Dienthoaiban" : "Assets/image/logotinh/Dongthap.png";
                    break;
                case "068":
                    result = type == 0 ? "Dienthoaiban" : "Assets/image/logotinh/Ninhthuan.png";
                    break;
                case "070":
                    result = type == 0 ? "Dienthoaiban" : "Assets/image/logotinh/Vinhlong.png";
                    break;
                case "071":
                    result = type == 0 ? "Dienthoaiban" : "Assets/image/logotinh/Binhphuoc.png";
                    break;
                case "072":
                    result = type == 0 ? "Dienthoaiban" : "Assets/image/logotinh/Longan.png";
                    break;
                case "073":
                    result = type == 0 ? "Dienthoaiban" : "Assets/image/logotinh/Tiengiang.png";
                    break;
                case "074":
                    result = type == 0 ? "Dienthoaiban" : "Assets/image/logotinh/Travinh.png";
                    break;
                case "075":
                    result = type == 0 ? "Dienthoaiban" : "Assets/image/logotinh/Bentre.png";
                    break;
                case "076":
                    result = type == 0 ? "Dienthoaiban" : "Assets/image/logotinh/Angiang.png";
                    break;
                case "077":
                    result = type == 0 ? "Dienthoaiban" : "Assets/image/logotinh/Kiengiang.png";
                    break;
                case "079":
                    result = type == 0 ? "Dienthoaiban" : "Assets/image/logotinh/Soctrang.png";
                    break;
                // SĐT di động
                case "090":
                case "093":
                    result = type == 0 ? "Mobifone" : "Assets/image/LogoMobifone.jpg";
                    break;
                case "091":
                case "094":
                    result = type == 0 ? "Vinaphone" : "Assets/image/LogoVinaphone.jpg";
                    break;
                case "092":
                case "018":
                    result = type == 0 ? "Vietnammobile" : "Assets/image/LogoVietnammobile.jpg";
                    break;
                case "095":
                    result = type == 0 ? "Sfone" : "Assets/image/LogoSfone.jpg";
                    break;
                case "096":
                case "097":
                case "098":
                case "016":
                    result = type == 0 ? "Viettel" : "Assets/image/LogoViettel.jpg";
                    break;
                case "099":
                case "019":
                    result = type == 0 ? "Gmobile" : "Assets/image/LogoGmobile.jpg";
                    break;
                default:
                    flag = false;
                    result = type == 0 ? "Unknow" : "Assets/image/LogoNotfound.jpg";
                    break;
            }
            return flag;
        }

        public static bool CheckFourNumber(string phonenumber, int type)
        {
            bool flag = true;
            switch (phonenumber)
            {
                // số điện thoại bàn cũ
                case "0210":
                    result = type == 0 ? "Dienthoaiban" : "Assets/image/logotinh/Phutho.png";
                    break;
                case "0211":
                    result = type == 0 ? "Dienthoaiban" : "Assets/image/logotinh/Vinhphuc.png";
                    break;
                case "0218":
                    result = type == 0 ? "Dienthoaiban" : "Assets/image/logotinh/Hoabinh.png";
                    break;
                case "0219":
                    result = type == 0 ? "Dienthoaiban" : "Assets/image/logotinh/Hagiang.png";
                    break;
                case "0230":
                    result = type == 0 ? "Dienthoaiban" : "Assets/image/logotinh/Dienbien.png";
                    break;
                case "0231":
                    result = type == 0 ? "Dienthoaiban" : "Assets/image/logotinh/Laichau.png";
                    break;
                case "0240":
                    result = type == 0 ? "Dienthoaiban" : "Assets/image/logotinh/Bacgiang.png";
                    break;
                case "0241":
                    result = type == 0 ? "Dienthoaiban" : "Assets/image/logotinh/Bacninh.png";
                    break;
                case "0280":
                    result = type == 0 ? "Dienthoaiban" : "Assets/image/logotinh/Thainguyen.png";
                    break;
                case "0281":
                    result = type == 0 ? "Dienthoaiban" : "Assets/image/logotinh/Backan.png";
                    break;
                case "0320":
                    result = type == 0 ? "Dienthoaiban" : "Assets/image/logotinh/Haiduong.png";
                    break;
                case "0321":
                    result = type == 0 ? "Dienthoaiban" : "Assets/image/logotinh/Hungyen.png";
                    break;
                case "0350":
                    result = type == 0 ? "Dienthoaiban" : "Assets/image/logotinh/Namdinh.png";
                    break;
                case "0351":
                    result = type == 0 ? "Dienthoaiban" : "Assets/image/logotinh/Hanam.png";
                    break;
                case "0500":
                    result = type == 0 ? "Dienthoaiban" : "Assets/image/logotinh/Daklak.png";
                    break;
                case "0501":
                    result = type == 0 ? "Dienthoaiban" : "Assets/image/logotinh/Daknong.png";
                    break;
                case "0510":
                    result = type == 0 ? "Dienthoaiban" : "Assets/image/logotinh/Quangnam.png";
                    break;
                case "0511":
                    result = type == 0 ? "Dienthoaiban" : "Assets/image/logotinh/Danang.png";
                    break;
                case "0650":
                    result = type == 0 ? "Dienthoaiban" : "Assets/image/logotinh/Binhduong.png";
                    break;
                case "0651":
                    result = type == 0 ? "Dienthoaiban" : "Assets/image/logotinh/Binhphuoc.png";
                    break;
                case "0710":
                    result = type == 0 ? "Dienthoaiban" : "Assets/image/logotinh/Cantho.png";
                    break;
                case "0711":
                    result = type == 0 ? "Dienthoaiban" : "Assets/image/logotinh/Haugiang.png";
                    break;
                case "0780":
                    result = type == 0 ? "Dienthoaiban" : "Assets/image/logotinh/Camau.png";
                    break;
                case "0781":
                    result = type == 0 ? "Dienthoaiban" : "Assets/image/logotinh/Baclieu.png";
                    break;
                // số điện thoại di động
                case "0120":
                case "0121":
                case "0122":
                case "0126":
                case "0128":
                    result = type == 0 ? "Mobifone" : "Assets/image/LogoMobifone.jpg";
                    break;
                case "0123":
                case "0124":
                case "0125":
                case "0127":
                case "0129":
                    result = type == 0 ? "Vinaphone" : "Assets/image/LogoVinaphone.jpg";
                    break;
                case "0188":
                    result = type == 0 ? "Vietnammobile" : "Assets/image/LogoVietnammobile.jpg";
                    break;
                case "0199":
                    result = type == 0 ? "Gmobile" : "Assets/image/LogoGmobile.jpg";
                    break;
                default:
                    flag = false;
                    result = type == 0 ? "Unknow" : "Assets/image/LogoNotfound.jpg";
                    break;
            }
            return flag;
        }
    }
}
