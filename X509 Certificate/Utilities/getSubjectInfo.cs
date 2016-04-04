using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Utilities
{
    class getSubjectInfo
    {
        private static string str_In, E, CN, OU, O, L, S, C;

        public getSubjectInfo()
        {
            str_In = "";
            E = "";
            CN = "";
            OU = "";
            O = "";
            L = "";
            S = "";
            C = "";
        }

        private static void gan(string xau, string xau2)
        {
            if ((xau == "E") || (xau == " E")) E = string.Copy(xau2);
            if ((xau == "CN") || (xau == " CN")) CN = string.Copy(xau2);
            if ((xau == "OU") || (xau == " OU")) OU = string.Copy(xau2);
            if ((xau == "O") || (xau == " O")) O = string.Copy(xau2);
            if ((xau == "L") || (xau == " L")) L = string.Copy(xau2);
            if ((xau == "S") || (xau == " S")) S = string.Copy(xau2);
            if ((xau == "C") || (xau == " C")) C = string.Copy(xau2);
        }

        private static void xuly(string s)
        {
            string xau, xau2;
            int i, j;
            i = 0;
            while (i <= s.Length - 1)
            {
                j = i;
                xau = "";
                while ((j <= s.Length - 1) && (s[j] != '='))
                {
                    xau = xau + s[j];
                    j++;
                }
                j++;
                xau2 = "";
                while ((j <= s.Length - 1) && (s[j] != ','))
                {
                    xau2 = xau2 + s[j];
                    j++;
                }
                gan(xau, xau2);
                i = j + 1;
            }
        }
              
        public void set_Subject(string subjectInfo)
        {
            str_In= string.Copy(subjectInfo);
        }

        public string get_E()
        {
            xuly(str_In);
            return string.Copy(E);
        }

        public string get_CN()
        {
            xuly(str_In);
            return string.Copy(CN);
        }

        public string get_OU()
        {
            xuly(str_In);
            return string.Copy(OU);
        }

        public string get_O()
        {
            xuly(str_In);
            return string.Copy(O);
        }

        public string get_L()
        {
            xuly(str_In);
            return string.Copy(L);
        }

        public string get_ST()
        {
            xuly(str_In);
            return string.Copy(S);
        }

        public string get_C()
        {
            xuly(str_In);
            return string.Copy(C);
        }

    }
}
