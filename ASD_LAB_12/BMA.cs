using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASD_LAB_12
{
    class BMA
    {
        public static int max(int a, int b) { return (a > b) ? a : b; }

        public static void buildCharArray(string str, int size, int[] badchar)
        {
            for (int i = 0; i < 256; i++)
                badchar[i] = size;

            for (int i = 0; i < size; i++)
                badchar[str[i]] = i;
        }

        public static string search(string txt, string pat)
        {
            string log = "";
            string logRes = "";

            int[] badchar = new int[256];
            buildCharArray(pat, pat.Length, badchar);

            int i = pat.Length;
            int j = pat.Length;

            while (j > 0 && i <= txt.Length)
            {
                if (pat[i] == txt[j])
                {
                    i = i - 1;
                    j = j - 1;
                }
                else
                {
                    i = i + badchar[txt[i]];
                    j = pat.Length;
                }
            }
            if (j < 1)
            {
                return $"\n Entrance of ({pat}) in ({i+1})";
            }
            else
            {
                return "";
            }

            return logRes + log;
        }
    }
}
