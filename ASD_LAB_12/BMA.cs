using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASD_LAB_12
{
    class BMA
    {
        public static string buildCharArray(string pat, Dictionary<char, int> table)
        {
            int size = pat.Length;
            string letters = new String(pat.Distinct().ToArray());

            for (int i = size - 2, j = 1; i >= 0; i--)
            {
                char ch = pat[i];
                if (!table.ContainsKey(ch))
                {
                    table[ch] = j;
                }
                j++;
            }

            #region build test output
            string lower = "";
            string upper = "";

            foreach (KeyValuePair<char, int> kvp in table)
            {
                upper += kvp.Key.ToString() + " ";
                lower += kvp.Value + " ";
            }

            return "\n" + upper + "\n" + lower;
            #endregion
        }

        public static string search(string txt, string pat)
        {
            string log = "";
            string logRes = "";

            Dictionary<char, int> table = new Dictionary<char, int>();
            logRes += "Bad Char Table :\n" + buildCharArray(pat, table) + "\n";


            int m = pat.Length;
            int n = txt.Length;

            if (m > n)
            {
                return "null";
            }

            int i = m - 1, j = m - 1;
            while (j >= 0 && i < n)
            {
                if (txt[i] == pat[j])
                {
                    log += $"\nMatch at position ({i}) symbol ({txt[i]})";
                    if (j == 0)
                    {
                        logRes += $"\nEntrance of word({pat}) at position ({i})";
                        i += m;
                        j = m - 1;
                        continue;
                    }
                    i--;
                    j--;
                }
                else
                {
                    if (!table.ContainsKey(txt[i]))
                    {
                        log += $"\nMismatch at ({i}) | skipping on ({m}) -> ({i+m})";
                        i += m;
                    }
                    else
                    {
                        log += $"\nMismatch at ({i}) | skipping on ({table[txt[i]]}) -> ({i + table[txt[i]]})";
                        i += table[txt[i]];
                    }
                    j = m - 1;
                }
            }

            return logRes + "\n\n" + log;
        }
    }
}
