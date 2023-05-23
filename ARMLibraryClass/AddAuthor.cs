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
            reg = new Regex(@"^[A-ЯЁ][а-яё].{3,}");
            match = reg.Match(text);
            if (match.Success)
            {
                reg = new Regex(@"[\!@#$%^&*()\\//№;%:?*\-=+_'0-9.,;:~`]");
                match = reg.Match(text);
                if (!match.Success)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else { return false; }
        }
    }
}
