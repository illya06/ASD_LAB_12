using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ASD_LAB_12
{
    //15.   
    //Дано текст що складається з n стрічок. 
    //Визначити чи є серед даного тексту цифри, якщо є вилучити їх з тексту. 
    //Знайти задане слово в тексті.
    
    class Task15
    {
        public static string perform(string text)
        {
            text = Regex.Replace(text, @"\d", "");
            text = text.Replace("  ", " ");
            return text;
        }
    }
}
