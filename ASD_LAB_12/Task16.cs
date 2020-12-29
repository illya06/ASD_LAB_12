using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASD_LAB_12
{
    /*
    
        TO DO : 
        
        16.   
        Задано два тексти.
        В першому тексті знайти слово 
        яке складається з найменшої кількості голосних літер 
        знайти його входження в другий текст відповідним алгоритмом пошуку.
    
    */

    class Task16
    {
        public static string perform(string text)
        {
            var words = text.Split(' ', ',', '.', ':', '\t').Distinct();
            int max = 0;
            string ret = "";
            foreach(string word in words)
            {
                int temp = 0;
                for (int i = 0; i < word.Length; i++)
                {
                    if (word[i] == 'a' || word[i] == 'e' || word[i] == 'i' || word[i] == 'o' || word[i] == 'u')
                    {
                        temp++;
                    }
                }
                if(temp > max)
                {
                    max = temp;
                    ret = word;
                }
            }
            return ret;
            
        }
    }
}
