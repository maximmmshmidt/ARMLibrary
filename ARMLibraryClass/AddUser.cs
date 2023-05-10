using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ARMLibraryClass
{
    public class AddUser
    {
        static Regex reg;
        static Match match;
        public static bool Reg_Password(string text)
        {
            reg = new Regex(@"((?=.*\d)(?=.*[a-z])(?=.*[A-Z]).{8,15})");
            match = reg.Match(text);
            if (match.Success)
            {
                return true;
            }
            else { return false; }
        }
        public static bool Reg_FIO(string text)
        {
            reg = new Regex(@"^[A-ЯЁ][а-яё]{2,}");
            match = reg.Match(text);
            if (match.Success)
            {
                return true;
            }
            else { return false; }
        }   
        public static bool DateBirth(string text)
        {
            string dat = "";
            string inti = "";
            string dateToday = Convert.ToString(DateTime.Today);
            dateToday.Replace(".", "");
            text.Replace(".","");
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == ' ')
                {
                    break;
                }
                else
                {
                    inti += dateToday[i].ToString();
                    dat += text[i].ToString();
                }
            }
            if (Convert.ToInt32(inti) -5 <= Convert.ToInt32(text))
            {
                return false;
            }
            else
            {
                return true; 
            }
        }
        
    }
}
