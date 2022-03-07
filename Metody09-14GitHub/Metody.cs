using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metody09_14GitHub
{
    class Metody
    {
        public static double Diskriminant(double a, double b, double c, out double x1, out double x2, out double d) //09
        {
            d = (b * b) - (4 * a * c);
            x1 = 0;
            x2 = 0;
            if (d < 0)
            {
                d = 0;
            }
            else if (d > 0)
            {
                x1 = (-b + Math.Sqrt(d)) / (2 * a);
                x2 = (-b - Math.Sqrt(d)) / (2 * a);
            }
            else
            {
                x1 = (-b + Math.Sqrt(d)) / (2 * a);
            }
            return d;
        }
        public static bool ObsahujeCislici(string nejakyString, out int cifSoucet, out int lichSoucet, out int sudSoucet) //10
        {
            bool obsahujeCisl = false;
            cifSoucet = 0;
            lichSoucet = 0;
            sudSoucet = 0;
            for (int i = 0; i < nejakyString.Length; ++i)
            {
                if (Char.IsNumber(nejakyString[i]))
                {
                    obsahujeCisl = true;
                    cifSoucet += Convert.ToInt32(nejakyString[i].ToString());
                    if (Convert.ToInt32(nejakyString[i].ToString()) % 2 != 0)
                    {
                        lichSoucet += Convert.ToInt32(nejakyString[i].ToString());
                    }
                    else if (Convert.ToInt32(nejakyString[i].ToString()) % 2 == 0)
                    {
                        sudSoucet += Convert.ToInt32(nejakyString[i].ToString());
                    }
                }
            }

            return obsahujeCisl;
        }

        public static int PocetSlov(string s, out string upravenyS)
        {
            string[] pole;
            char[] separators = { ' ' };
            int pocetSlov = 0;
            pole = s.Split(separators,StringSplitOptions.RemoveEmptyEntries);
            pocetSlov = pole.Length;
            int i = 0;
            while (i < s.Length)
            {
                if (s[i] > '0' && s[i] < '9')
                {
                    s = s.Remove(i, 1);
                }
                else ++i;
            }
            upravenyS = s;
            return pocetSlov;
        }
        public static int PocetSlov1(ref string s)
        {
            string[] pole;
            char[] separators = { ' ' };
            int pocetSlov = 0;
            pole = s.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            pocetSlov = pole.Length;
            int i = 0;
            while (i < s.Length)
            {
                if (s[i] > '0' && s[i] < '9')
                {
                    s = s.Remove(i, 1);
                }
                else ++i;
            }
            return pocetSlov;
        }
        public static bool ObsahujeSlovo(string s, out string nejdelsiSlovo, out string nejkratsiSlovo)
        {
            string max = "", min = "";
            int maxDelka = Int32.MinValue;
            bool obsahujeSlovo = false;
            string[] pole;
            char[] separators = { ' ' };
            pole = s.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < pole.Length; i++)
            {
                if (String.IsNullOrEmpty(s) && !obsahujeSlovo)
                {
                    obsahujeSlovo = false;
                }
                else
                {
                    obsahujeSlovo = true;
                }
            }
            for (int j = 0; j < s.Length; j++)
            {
                if (pole[j].Length > maxDelka)
                {
                    max = pole[j];
                }
                else
                {
                    min = pole[j];
                }
            }
            nejdelsiSlovo = max;
            nejkratsiSlovo = min;
            return obsahujeSlovo;
        }
    }
}
