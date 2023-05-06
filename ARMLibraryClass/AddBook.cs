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
    }
}
