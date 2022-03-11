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
        public static bool ObsahujeSlovo(string text, out string nejdelsiSlovo, out string nejkratsiSlovo)
        {
            bool obsahujeslovo = false;
            nejdelsiSlovo = "";
            nejkratsiSlovo = text;
            int pocetMax = 0;
            int pocetMin = text.Length;
            char[] separators = { ' ' };
            string[] poleSlov = text.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            foreach (string s in poleSlov)
            {
                if (s.Length >= 1)
                {
                    obsahujeslovo = true;
                }
                if (s.Length > pocetMax)
                {
                    pocetMax = s.Length;
                    nejdelsiSlovo = s;
                }
                if (s.Length < pocetMin)
                {
                    pocetMin = s.Length;
                    nejkratsiSlovo = s;
                }
            }
            return obsahujeslovo;
        }
        public static bool JeAlfanum(string s, out int pocetMalych, out int pocetVelkych, out int pocetJinych)
        {
            bool jealfanum = false;
            pocetMalych = 0;
            pocetVelkych = 0;
            pocetJinych = 0;

            for (int i = 0; i < s.Length; ++i)
            {
                if (Char.IsLetterOrDigit(s[i]))
                {
                    jealfanum = true;
                    if (Char.IsUpper(s[i])) ++pocetVelkych;
                    else if (Char.IsLower(s[i])) ++pocetMalych;
                }
                else
                {
                    ++pocetJinych;
                    jealfanum = false;
                }
            }
            return jealfanum;
        }

        public static bool Identicke (string s1, string s2, out int pocetOdli, out int indexPrvni)
        {
            indexPrvni = -1;
            pocetOdli = 0;
            string pKyblik;
            bool jeIdenticke = false;
            if (s1.Contains(s2) && s2.Contains(s1))
            {
                pocetOdli = 0;
                indexPrvni = -1;
                jeIdenticke = true;
            }
            else jeIdenticke = false;
            if (s2.Length < s1.Length)
            {
                pKyblik = s1;
                s1 = s2;
                s2 = pKyblik;
            }
            for (int i = 0; i < s1.Length; i++)
            {
                if (s1[i] != s2[i] && indexPrvni == -1)
                {
                    indexPrvni = i;
                    pocetOdli++;
                }
                if (s1[i] != s2[i])
                {
                    pocetOdli++;
                }
            }
            if (indexPrvni == -1)
            {
                indexPrvni = s1.Length;
            }
            int rozdil = s2.Length - s1.Length;
            pocetOdli += rozdil;
            return jeIdenticke;
        }
    }
}
