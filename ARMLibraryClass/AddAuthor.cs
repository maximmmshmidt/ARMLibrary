using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace ARMLibraryClass
{
    public class AddAuthor
    {
        static Regex reg;
        static Match match;

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
        public static bool Reg_Date(string text)
        {
            reg = new Regex(@"(\d{1,2}\/\d{1,2}\/\d{4})");
            match = reg.Match(text);
            if (match.Success)
            {
                return true;
            }
            else { return false; }
        }
    }
}
