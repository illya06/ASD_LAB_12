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
            int i;
            for (i = 0; i < 256; i++)
                badchar[i] = -1;

            for (i = 0; i < size; i++)
                badchar[(int)str[i]] = i;
        }

        public static string search(string txt, string pat)
        {
            string log = "";
            string logRes = "";

            int[] badchar = new int[256];
            buildCharArray(pat, pat.Length, badchar);

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
            }
            return logRes + log;
        }
    }
}
