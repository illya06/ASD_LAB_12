using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASD_LAB_12
{
    class BMA
    {
        public static string buildCharArray(string pat, int size, Dictionary<string, int> table)
        {
            string answer = new String(pat.Distinct().ToArray());

            foreach (char element in answer)
            {
                table.Add($"{element}", 0);
            }
            table.Add("*", size);

            for (int i = 0; i < size; i++)
            {
                string ch = $"{pat[i]}";
                int maxShift = Math.Max(1, size - i - 1);
                table[ch] = maxShift;
            }

            #region build test output
            string lower = "";
            string upper = "";

            foreach (KeyValuePair<string, int> kvp in table)
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

            Dictionary<string, int> table = new Dictionary<string, int>();
            logRes += "Bad Char Table :\n" + buildCharArray(pat, pat.Length, table) + "\n";
            
            int skip = 0;

            for (int i = 0; i <= txt.Length - pat.Length; i += skip)
            {
                skip = 0;

                for (int j = pat.Length - 1; j >= 0; j--)
                {
                    if (pat[j] != txt[i + j])
                    {
                        if (table.ContainsKey($"{txt[i + j]}"))
                        {
                            skip = table[$"{txt[i + j]}"];
                            log += $"\n  skipped from ({i}) to ({i+skip})";
                            break;
                        }
                        else
                        {
                            skip = table["*"];
                            log += $"\n  skipped from ({i}) to ({i + skip})";
                            break;
                        }
                    }
                    log += $"\n match at position ({j}) - char ({pat[j]})";
                }

                if (skip == 0)
                {
                    logRes += $"\nEntrance of ({pat}) at position ({i})";
                    i += table["*"];
                }
            }

            return logRes + log;
        }
    }
}
