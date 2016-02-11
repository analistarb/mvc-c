using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System
{
    public static class Funcoes
    {

        public static bool ToBool(this string s)
        {
            if (s == "1")
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        public static int BoolToInt(this Boolean b)
        {
            if (b == true)
            {
                return 1;
            }
            else
            {
                return 2;
            }
        }



        public static int ToInt(this string s)
        {
                int total = 0;
                int y = 0;
                for (int i = 0; i < s.Length; i++)
                    y = y * 10 + (s[i] - '0');
                return total += y;
        }


        public static decimal ToDec(this string s)
        {
            if (String.IsNullOrEmpty(s))
                return 0;
            else
            {
                return decimal.Parse(s.Replace(".",","));
            }

        }

        public static string ToDecDb(this string s)
        {
            if (String.IsNullOrEmpty(s))
                return "0";
            else
            {
                return s.Replace(",", ".");
            }

        }

        public static DateTime ToDate(this string s)
        {
            return DateTime.Parse(s);
        }



        public static string CpfCpnjMask(this string numCpfCnpj)
        {
            if (numCpfCnpj != null && numCpfCnpj != String.Empty)
            {
                if (numCpfCnpj.Length == 14)
                {
                    return numCpfCnpj.Insert(2, ".").Insert(6, ".").Insert(10, "/").Insert(15, "-");
                }

                else if (numCpfCnpj.Length == 11)
                {
                    return numCpfCnpj.Insert(3, ".").Insert(7, ".").Insert(11, "-");
                }
                else
                    return numCpfCnpj;
            }

            return String.Empty;
        }


        public static string PhoneMask(this string numberPhone)
        {
            if (numberPhone != null && numberPhone != String.Empty)
            {
                if (numberPhone.IndexOf("0", 0) == 0)
                    numberPhone = numberPhone.Remove(0, 1);

                return numberPhone.Insert(0, "(").Insert(3, ")").Insert(8, "-");
            }

            return String.Empty;
        }

        public static string CnpjRemoveMask(this string cnpj)
        {
            if (cnpj != null && cnpj != String.Empty)
            {
                return cnpj.Replace(".", "").Replace(".", "").Replace("/", "").Replace("-", "");
            }

            return String.Empty;
        }
    }
}
