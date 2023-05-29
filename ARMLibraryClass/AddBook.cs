using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ARMLibraryClass
{
    public class AddBook
    {
        static Regex reg;
        static Match match;

        public static bool Reg_NameBook(string text)
        {
            reg = new Regex(@"^[A-ЯЁ][а-яё].{2,}");
            match = reg.Match(text);
            if (match.Success)
            {
                return true;
            }
            else { return false; }
        }
        public static bool Reg_PlacePublication(string text)
        {
            reg = new Regex(@"г\s[^\d][^\s-\s][^,]*");
            match = reg.Match(text);
            if (match.Success)
            {
                return true;
            }
            else { return false; }
        }
        public static bool Reg_PublishingHouse(string text)
        {
            reg = new Regex(@"^[A-ЯЁ]{1}[а-яё]{3,}");
            match = reg.Match(text);
            if (match.Success)
            {
                return true;
            }
            else { return false; }
        }
        public static bool Gg_IBN(string text)
        {
            int kr = 0;
            if (text.Length == 10)
            {
                reg = new Regex(@"^[1-9 0]");
                match = reg.Match(text);
                if (match.Success)
                {
                    for (int i = 0; i <= 10; i++)
                    {
                        kr += Convert.ToInt32(text[i]) * i;
                    }
                    if (kr / 11 == 0)
                    {
                        return true;
                    }
                    else return false;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
        public static bool Reg_BBK(string text)
        {
            reg = new Regex(@"[1-9][0-9]\.?[0-9]{0,3}");
            match = reg.Match(text);
            if (match.Success)
            {
                return true;
            }
            else { return false; }
        }
        public static bool Reg_Number(string text)
        {
            reg = new Regex(@"^[0-9]{3,}");
            match = reg.Match(text);
            if (match.Success)
            {
                return true;
            }
            else { return false; }
        }
    }
}
