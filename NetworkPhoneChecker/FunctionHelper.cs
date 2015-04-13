using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneApp1
{
    public class FunctionHelper
    {
        public static string CheckNetworkPhoneNumber(string phonenumber, int type)
        {
            int length = phonenumber.Length;
            if (length < 3)
            {
                return type == 0 ? "Unknow" : "Assets/image/LogoNotfound.jpg";
            }
            else if (length < 4)
            {
                switch (phonenumber)
                {
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
                string threefirstphonenumber = phonenumber.Substring(0, 3);
                string fourfirstphonenumber = phonenumber.Substring(0, 4);
                switch (threefirstphonenumber)
                {
                    case "016":
                        return type == 0 ? "Viettel" : "Assets/image/LogoViettel.jpg";
                }
                switch (fourfirstphonenumber)
                {
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
            }
            return type == 0 ? "Unknow" : "Assets/image/LogoNotfound.jpg";
        }
    }
}
