using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Runtime.InteropServices;

namespace program
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "C:/Users/joshua.england1/source/repos/Setup1420/Setup1420/data.json";
            string text = File.ReadAllText(path).ToLower();

            var manual = JsonSerializer.Deserialize<ZombieSurvivalJournal>(text);

            List<string> ignore = new List<string> { "the", "and", "is", "in", "of", "to", "a", "we", "it", "for", "on", "with" , "i", "an"};

            Dictionary<string, int> keyWords = new Dictionary<string, int>();

            foreach (var item in manual.Entries)
            {
                var words = item.Text.Split(" ");

                foreach (var word in words)
                {
                    string result = word.Replace("!", "").Replace(".", "").Replace(",", "");
                    if (ignore.Contains(word))
                    {
                        continue;
                    }
                    if (!keyWords.ContainsKey(result))
                    {
                        keyWords.Add(result, 1);

                    }
                    else
                    {
                        keyWords[result] += 1;
                    }
                }
            }

            foreach (var word in keyWords)
            {
                Console.WriteLine($"{word.Key} {word.Value}");
            }
        }
    }
}
