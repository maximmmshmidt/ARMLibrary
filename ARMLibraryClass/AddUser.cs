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
        // проверка логина
        public static bool Reg_Login(string text)
        {
            reg = new Regex(@"^[a-zA-Z]{1}[a-zA-Z1-9]{1,9}$");
            match = reg.Match(text);
            if (match.Success)
            {
                return true;
            }
            else { return false; }
        }
        // проверка пороля
        public static bool Reg_Password(string text)
        {
            reg = new Regex(@"((?=.*\d)(?=.*[a-z])(?=.*[A-Z]).{8,15}$)");
            match = reg.Match(text);
            if (match.Success)
            {
                return true;
            }
            else { return false; }
        }
        //проверка на фамилию имя отчество
        public static bool Reg_FIO(string text)
        {
            reg = new Regex(@"(^[A-ЯЁ][а-яё].{2,15}$){3}");
            match = reg.Match(text);
            if (match.Success)
            {
                return true;
            }
            else { return false; }
        }
        // проверка на адрес
        public static bool Reg_Adres(string text)
        {
            reg = new Regex(@"г\s[^\d][^\s-\s][^,]*");
            match = reg.Match(text);
            if (match.Success)
            {
                return true;
            }
            else { return false; }
        }   
    // ПРОВЕРКА НА ВОЗРАСТ
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
        /* номер телефона:
                Все допустимые:

                1 800 5551212

                800 555 1212

                8005551212

                18005551212

                +1800 555 1212 расширение 65432

                800 5551212 ext3333

                Недопустимые # ы

                234-911-5678

                314-159-2653

                123-234-5678
        */
        public static bool NumberPhone(string text)
        {
            if (text.Length <= 18 && text.Length >= 5)
            {
                reg = new Regex(@"(?:(?:\+?1\s*(?:[.-]\s*)?)?(?:(\s*([2-9]1[02-9]|[2-9][02-8]1|[2-9][02-8][02-9]‌​)\s*)|([2-9]1[02-9]|[2-9][02-8]1|[2-9][02-8][02-9]))\s*(?:[.-]\s*)?)([2-9]1[02-9]‌​|[2-9][02-9]1|[2-9][02-9]{2})\s*(?:[.-]\s*)?([0-9]{4})\s*(?:\s*(?:#|x\.?|ext\.?|extension)\s*(\d+)\s*)?$");
                match = reg.Match(text);
                if (match.Success)
                {
                    return true;
                }
                else { return false; }
            }
            return true;
        }
    }
}
