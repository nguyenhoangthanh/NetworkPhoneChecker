using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetworkPhoneChecker
{
    public class FunctionHelper
    {
        public static string CheckNetworkPhoneNumber(string phonenumber, int type)
        {
            int length = phonenumber.Length;
            if (length < 2)
            {
                return type == 0 ? "Unknow" : "Assets/image/LogoNotfound.jpg";
            }
            else if (length < 3)
            {
                switch (phonenumber)
                {
                    // số điện thoại bàn cũ
                    case "04":
                        return type == 0 ? "Dienthoaiban" : "Assets/image/logotinh/Hanoi.png";
                    case "08":
                        return type == 0 ? "Dienthoaiban" : "Assets/image/logotinh/Hochiminh.png";
                }
            }
            else if (length < 4)
            {
                switch (phonenumber)
                {
                    // số điện thoại bàn mới
                    case "024":
                        return type == 0 ? "Dienthoaiban" : "Assets/image/logotinh/Hanoi.png";
                    case "028":
                        return type == 0 ? "Dienthoaiban" : "Assets/image/logotinh/Hochiminh.png";
                    // số điện thoại bàn cũ
                    case "020":
                        return type == 0 ? "Dienthoaiban" : "Assets/image/logotinh/Laocai.png";
                    case "022":
                        return type == 0 ? "Dienthoaiban" : "Assets/image/logotinh/Sonla.png";
                    case "025":
                        return type == 0 ? "Dienthoaiban" : "Assets/image/logotinh/Langson.png";
                    case "026":
                        return type == 0 ? "Dienthoaiban" : "Assets/image/logotinh/Caobang.png";
                    case "027":
                        return type == 0 ? "Dienthoaiban" : "Assets/image/logotinh/Tuyenquang.png";
                    case "029":
                        return type == 0 ? "Dienthoaiban" : "Assets/image/logotinh/Yenbai.png";
                    case "030":
                        return type == 0 ? "Dienthoaiban" : "Assets/image/logotinh/Ninhbinh.png";
                    case "031":
                        return type == 0 ? "Dienthoaiban" : "Assets/image/logotinh/Haiphong.png";
                    case "033":
                        return type == 0 ? "Dienthoaiban" : "Assets/image/logotinh/Quangninh.png";
                    case "036":
                        return type == 0 ? "Dienthoaiban" : "Assets/image/logotinh/Thaibinh.png";
                    case "037":
                        return type == 0 ? "Dienthoaiban" : "Assets/image/logotinh/Thanhhoa.png";
                    case "038":
                        return type == 0 ? "Dienthoaiban" : "Assets/image/logotinh/Nghean.png";
                    case "039":
                        return type == 0 ? "Dienthoaiban" : "Assets/image/logotinh/Hatinh.png";
                    case "052":
                        return type == 0 ? "Dienthoaiban" : "Assets/image/logotinh/Quangbinh.png";
                    case "053":
                        return type == 0 ? "Dienthoaiban" : "Assets/image/logotinh/Quangtri.png";
                    case "054":
                        return type == 0 ? "Dienthoaiban" : "Assets/image/logotinh/Thuathienhue.png";
                    case "055":
                        return type == 0 ? "Dienthoaiban" : "Assets/image/logotinh/Quangngai.png";
                    case "056":
                        return type == 0 ? "Dienthoaiban" : "Assets/image/logotinh/Binhdinh.png";
                    case "057":
                        return type == 0 ? "Dienthoaiban" : "Assets/image/logotinh/Phuyen.png";
                    case "058":
                        return type == 0 ? "Dienthoaiban" : "Assets/image/logotinh/Khanhhoa.png";
                    case "059":
                        return type == 0 ? "Dienthoaiban" : "Assets/image/logotinh/Gialai.png";
                    case "060":
                        return type == 0 ? "Dienthoaiban" : "Assets/image/logotinh/Kontum.png";
                    case "061":
                        return type == 0 ? "Dienthoaiban" : "Assets/image/logotinh/Dongnai.png";
                    case "062":
                        return type == 0 ? "Dienthoaiban" : "Assets/image/logotinh/Binhthuan.png";
                    case "063":
                        return type == 0 ? "Dienthoaiban" : "Assets/image/logotinh/Lamdong.png";
                    case "064":
                        return type == 0 ? "Dienthoaiban" : "Assets/image/logotinh/Vungtau.png";
                    case "066":
                        return type == 0 ? "Dienthoaiban" : "Assets/image/logotinh/Tayninh.png";
                    case "067":
                        return type == 0 ? "Dienthoaiban" : "Assets/image/logotinh/Dongthap.png";
                    case "068":
                        return type == 0 ? "Dienthoaiban" : "Assets/image/logotinh/Ninhthuan.png";
                    case "070":
                        return type == 0 ? "Dienthoaiban" : "Assets/image/logotinh/Vinhlong.png";
                    case "071":
                        return type == 0 ? "Dienthoaiban" : "Assets/image/logotinh/Binhphuoc.png";
                    case "072":
                        return type == 0 ? "Dienthoaiban" : "Assets/image/logotinh/Longan.png";
                    case "073":
                        return type == 0 ? "Dienthoaiban" : "Assets/image/logotinh/Tiengiang.png";
                    case "074":
                        return type == 0 ? "Dienthoaiban" : "Assets/image/logotinh/Travinh.png";
                    case "075":
                        return type == 0 ? "Dienthoaiban" : "Assets/image/logotinh/Bentre.png";
                    case "076":
                        return type == 0 ? "Dienthoaiban" : "Assets/image/logotinh/Angiang.png";
                    case "077":
                        return type == 0 ? "Dienthoaiban" : "Assets/image/logotinh/Kiengiang.png";
                    case "079":
                        return type == 0 ? "Dienthoaiban" : "Assets/image/logotinh/Soctrang.png";
                    // SĐT di động
                    case "090":
                    case "093":
                        return type == 0 ? "Mobifone" : "Assets/image/LogoMobifone.jpg";
                    case "091":
                    case "094":
                        return type == 0 ? "Vinaphone" : "Assets/image/LogoVinaphone.jpg";
                    case "092":
                    case "018":
                        return type == 0 ? "Vietnammobile" : "Assets/image/LogoVietnammobile.jpg";
                    case "095":
                        return type == 0 ? "Sfone" : "Assets/image/LogoSfone.jpg";
                    case "096":
                    case "097":
                    case "098":
                    case "016":
                        return type == 0 ? "Viettel" : "Assets/image/LogoViettel.jpg";
                    case "099":
                    case "019":
                        return type == 0 ? "Gmobile" : "Assets/image/LogoGmobile.jpg";
                }
            }
            else
            {
                string twofirstphonenumber = phonenumber.Substring(0, 2);
                string threefirstphonenumber = phonenumber.Substring(0, 3);
                string fourfirstphonenumber = phonenumber.Substring(0, 4);
                switch (fourfirstphonenumber)
                {
                    //số điện thoại bàn
                    case "0236":
                        return type == 0 ? "Dienthoaiban" : "Assets/image/logotinh/Danang.png";
                    case "0203":  
                        return type == 0 ? "Dienthoaiban" : "Assets/image/logotinh/Quangninh.png";
                    case "0204":
                        return type == 0 ? "Dienthoaiban" : "Assets/image/logotinh/Bacgiang.png";
                    case "0205":
                        return type == 0 ? "Dienthoaiban" : "Assets/image/logotinh/Langson.png";
                    case "0206":
                        return type == 0 ? "Dienthoaiban" : "Assets/image/logotinh/Caobang.png";
                    case "0207":
                        return type == 0 ? "Dienthoaiban" : "Assets/image/image/logotinh/Tuyenquang.png";
                    case "0208":
                        return type == 0 ? "Dienthoaiban" : "Assets/image/logotinh/Thainguyen.png";
                    case "0209":
                        return type == 0 ? "Dienthoaiban" : "Assets/image/logotinh/Backan.png";
                    case "0210":
                        return type == 0 ? "Dienthoaiban" : "Assets/image/logotinh/Phutho.png";
                    case "0211":
                        return type == 0 ? "Dienthoaiban" : "Assets/image/logotinh/Vinhphuc.png";
                    case "0212":
                        return type == 0 ? "Dienthoaiban" : "Assets/image/logotinh/Sonla.png";
                    case "0213":
                        return type == 0 ? "Dienthoaiban" : "Assets/image/logotinh/Laichau.png";
                    case "0214":
                        return type == 0 ? "Dienthoaiban" : "Assets/image/logotinh/Laocai.png";
                    case "0215":
                        return type == 0 ? "Dienthoaiban" : "Assets/image/logotinh/Dienbien.png";
                    case "0216":
                        return type == 0 ? "Dienthoaiban" : "Assets/image/logotinh/Yenbai.png";
                    case "0218":
                        return type == 0 ? "Dienthoaiban" : "Assets/image/logotinh/Hoabinh.png";
                    case "0219":
                        return type == 0 ? "Dienthoaiban" : "Assets/image/logotinh/Hagiang.png";
                    case "0220":
                        return type == 0 ? "Dienthoaiban" : "Assets/image/logotinh/Haiduong.png";
                    case "0221":
                        return type == 0 ? "Dienthoaiban" : "Assets/image/logotinh/Hungyen.png";
                    case "0222":
                        return type == 0 ? "Dienthoaiban" : "Assets/image/logotinh/Bacninh.png";
                    case "0225":
                        return type == 0 ? "Dienthoaiban" : "Assets/image/logotinh/Haiphong.png";
                    case "0226":
                        return type == 0 ? "Dienthoaiban" : "Assets/image/logotinh/Hanam.png";
                    case "0227":
                        return type == 0 ? "Dienthoaiban" : "Assets/image/logotinh/Thaibinh.png";
                    case "0228":
                        return type == 0 ? "Dienthoaiban" : "Assets/image/logotinh/Namdinh.png";
                    case "0229":
                        return type == 0 ? "Dienthoaiban" : "Assets/image/logotinh/Ninhbinh.png";
                    case "0232":
                        return type == 0 ? "Dienthoaiban" : "Assets/image/logotinh/Quangbinh.png";
                    case "0233":
                        return type == 0 ? "Dienthoaiban" : "Assets/image/logotinh/Quangtri.png";
                    case "0234":
                        return type == 0 ? "Dienthoaiban" : "Assets/image/logotinh/Thuathienhue.png";
                    case "0235":
                        return type == 0 ? "Dienthoaiban" : "Assets/image/logotinh/Quangnam.png";
                    case "0237":
                        return type == 0 ? "Dienthoaiban" : "Assets/image/logotinh/Thanhhoa.png";
                    case "0238":
                        return type == 0 ? "Dienthoaiban" : "Assets/image/logotinh/Nghean.png";
                    case "0239":
                        return type == 0 ? "Dienthoaiban" : "Assets/image/logotinh/Hatinh.png";
                    case "0251":
                        return type == 0 ? "Dienthoaiban" : "Assets/image/logotinh/Dongnai.png";
                    case "0252":
                        return type == 0 ? "Dienthoaiban" : "Assets/image/logotinh/Binhthuan.png";
                    case "0254":
                        return type == 0 ? "Dienthoaiban" : "Assets/image/logotinh/Vungtau.png";
                    case "0255":
                        return type == 0 ? "Dienthoaiban" : "Assets/image/logotinh/Quangngai.png";
                    case "0256":
                        return type == 0 ? "Dienthoaiban" : "Assets/image/logotinh/Binhdinh.png";
                    case "0257":
                        return type == 0 ? "Dienthoaiban" : "Assets/image/logotinh/Phuyen.png";
                    case "0258":
                        return type == 0 ? "Dienthoaiban" : "Assets/image/logotinh/Khanhhoa.png";
                    case "0259 ":
                        return type == 0 ? "Dienthoaiban" : "Assets/image/logotinh/Ninhthuan.png";
                    case "0260":
                        return type == 0 ? "Dienthoaiban" : "Assets/image/logotinh/Kontum.png";
                    case "0261":
                        return type == 0 ? "Dienthoaiban" : "Assets/image/logotinh/Daknong.png";
                    case "0262":
                        return type == 0 ? "Dienthoaiban" : "Assets/image/logotinh/Daklak.png";
                    case "0263":
                        return type == 0 ? "Dienthoaiban" : "Assets/image/logotinh/Lamdong.png";
                    case "0269":
                        return type == 0 ? "Dienthoaiban" : "Assets/image/logotinh/Gialai.png";
                    case "0270":
                        return type == 0 ? "Dienthoaiban" : "Assets/image/logotinh/Vinhlong.png";
                    case "0271":
                        return type == 0 ? "Dienthoaiban" : "Assets/image/logotinh/Binhphuoc.png";
                    case "0272":
                        return type == 0 ? "Dienthoaiban" : "Assets/image/logotinh/Longan.png";
                    case "0273":
                        return type == 0 ? "Dienthoaiban" : "Assets/image/logotinh/Tiengiang.png";
                    case "0274":
                        return type == 0 ? "Dienthoaiban" : "Assets/image/logotinh/Binhduong.png";
                    case "0275":
                        return type == 0 ? "Dienthoaiban" : "Assets/image/logotinh/Bentre.png";
                    case "0276":
                        return type == 0 ? "Dienthoaiban" : "Assets/image/logotinh/Tayninh.png";
                    case "0277":
                        return type == 0 ? "Dienthoaiban" : "Assets/image/logotinh/Dongthap.png";
                    case "0290":
                        return type == 0 ? "Dienthoaiban" : "Assets/image/logotinh/Camau.png";
                    case "0291":
                        return type == 0 ? "Dienthoaiban" : "Assets/image/logotinh/Baclieu.png";
                    case "0292":
                        return type == 0 ? "Dienthoaiban" : "Assets/image/logotinh/Cantho.png";
                    case "0293":
                        return type == 0 ? "Dienthoaiban" : "Assets/image/logotinh/Haugiang.png";
                    case "0294":
                        return type == 0 ? "Dienthoaiban" : "Assets/image/logotinh/Travinh.png";
                    case "0296":
                        return type == 0 ? "Dienthoaiban" : "Assets/image/logotinh/Angiang.png";
                    case "0297":
                        return type == 0 ? "Dienthoaiban" : "Assets/image/logotinh/Kiengiang.png";
                    case "0299":
                        return type == 0 ? "Dienthoaiban" : "Assets/image/logotinh/Soctrang.png";
                    // số điện thoại di động
                    case "0120":
                    case "0122":
                    case "0126":
                    case "0128":
                        return type == 0 ? "Mobifone" : "Assets/image/LogoMobifone.jpg";
                    case "0123":
                    case "0124":
                    case "0125":
                    case "0127":
                    case "0129":
                        return type == 0 ? "Vinaphone" : "Assets/image/LogoVinaphone.jpg";
                    case "0188":
                        return type == 0 ? "Vietnammobile" : "Assets/image/LogoVietnammobile.jpg";
                    case "0199":
                        return type == 0 ? "Gmobile" : "Assets/image/LogoGmobile.jpg";
                }
                switch (threefirstphonenumber)
                {
                    // số điện thoại viettel
                    case "016":
                        return type == 0 ? "Viettel" : "Assets/image/LogoViettel.jpg";
                }
                switch (twofirstphonenumber)
                {
                    // số điện thoại bàn cũ
                    case "04":
                        return type == 0 ? "Dienthoaiban" : "Assets/image/logotinh/Hanoi.png";
                    case "08":
                        return type == 0 ? "Dienthoaiban" : "Assets/image/logotinh/Hochiminh.png";
                }
            }
            return type == 0 ? "Unknow" : "Assets/image/LogoNotfound.jpg";
        }
    }
}
