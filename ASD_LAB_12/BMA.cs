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

        public static void buildCharArray(string pat, int size, Dictionary<string, int> table)
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
        }

        public static string search(string txt, string pat)
        {
            string log = "";
            string logRes = "";

            Dictionary<string, int> table = new Dictionary<string, int>();
            buildCharArray(pat, pat.Length, table);
/*
            int shift = 0; 
            
            while (shift <= (txt.Length - pat.Length))
            {
                int j = pat.Length - 1;

                log += "\n";
                while (j >= 0 && pat[j] == txt[shift + j])
                {
                    log += $"\nMatch at {shift + j} of letter {pat[j]}:({j})";
                    j--;
                }

                if (j < 0)
                {
                    logRes += $"\n> Entrance of {pat} at {shift} ";
                    shift += (shift + pat.Length < txt.Length) ? pat.Length - badchar[txt[shift + pat.Length]] : 1;
                }
                else
                {
                    log += $"\n Shifted on ({max(1, j - badchar[txt[shift + j]])}) from {shift} to ";
                    shift += max(1, j - badchar[txt[shift + j]]);
                    log += $"{shift}";
                }
            }*/
            return logRes + log;
        }
    }
}
