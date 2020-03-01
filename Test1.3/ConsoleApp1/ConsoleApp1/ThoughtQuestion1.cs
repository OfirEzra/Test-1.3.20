using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class ThoughtQuestion1
    {
        public ThoughtQuestion1()
        {

        }
        public static void Run()
        {
            string[] words = { "java", "jjava", "vaj", "aavj", "j", "vjaa", "dan", "and", "ddan" };
            Dictionary<string, int> dict = new Dictionary<string, int>();
            foreach (string word in words)
            {
                char[] letters = word.ToCharArray();
                Array.Sort(letters);
                string newWord = new string(letters);
                if (dict.ContainsKey(newWord))
                {
                    dict[newWord] = dict[newWord] + 1;
                }
                else
                {
                    dict.Add(newWord, 1);
                }
            }
            int mostAppearancesInt = 0;
            string mostAppearancesString = "";
            foreach(KeyValuePair<string,int> pair in dict)
            {
                if (pair.Value > mostAppearancesInt)
                {
                    mostAppearancesInt = pair.Value;
                    mostAppearancesString = pair.Key;
                }
            }
            Console.WriteLine($"Most appearances is of word {mostAppearancesString} with {mostAppearancesInt} appearances");
        }
    }
}
