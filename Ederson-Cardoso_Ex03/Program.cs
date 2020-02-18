using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ederson_Cardoso_Ex03
{
    class Program
    {
        static void Main(string[] args)
        {
            WordsDictionary();
        }

        public static void WordsDictionary()
        {
            Console.Write("Enter a sentence: ");
            string sentence = Console.ReadLine();

            string[] words = sentence.Split(' ');

            // Create Dictionaty
            Dictionary<int, string> dict = new Dictionary<int, string>();

            // Populate Dictionary
            for (int i = 0; i < words.Length; i++)
            {
                dict.Add(i, words[i]);
            }

            // Count word occurence
            var wc = new Dictionary<string, int>();
            foreach (string w in words)
            {
                if (wc.ContainsKey(w))
                { 
                    wc[w]++;
                }
                else
                {                   
                    wc[w] = 1;
                }
            }

            Console.WriteLine("Sorted by Value");
            foreach (KeyValuePair<int, string> w in dict.OrderBy(key => key.Value))
            {
                Console.WriteLine("Key: {0}, Value: {1}", w.Key, w.Value);
            }

            // Display Dictionary content
            Console.WriteLine("Dictionary content:");
            var str = new Dictionary<string, int>();
            foreach (string w in words)
            {
                Console.WriteLine(w);
            }

            // Print countec words
            List<string> str1 = new List<string>(wc.Keys);
            str1.Sort();
            foreach (string w in str1)
            {
                if (wc[w] >= 0)
                {
                    Console.WriteLine("{0}: {1}", w, wc[w]);
                }
            }

            Console.ReadKey();
        }
    }
}
