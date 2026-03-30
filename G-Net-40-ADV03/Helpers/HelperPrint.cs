using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Helpers
{
    public static class HelperPrint
    {
        public static void Print(List<int> Elements)
        {
            foreach (var item in Elements)
                Console.WriteLine($"Grade : {item}");
        }
        public static void printDictionary(SortedList<int, string> leaderboard)
        {
            foreach (var item in leaderboard)
                Console.WriteLine($"Score : {item.Key} , Name : {item.Value}");
        }
        public static void printDictionary(Dictionary<string, string> phoneBook)
        {
            Console.Write("Keys : ");
            phoneBook.Keys.ToList().ForEach(key => Console.Write($"{key} "));
            Console.WriteLine();
        }
        public static void printDictionary2(Dictionary<string, string> phoneBook)
        {
            Console.Write("Values : ");
            phoneBook.Values.ToList().ForEach(value => Console.Write($"{value} "));
            Console.WriteLine();
        }
        public static void PrintQueue(Queue<string> Documents)
        {
            foreach (var item in Documents)
                Console.WriteLine($"Document : {item}");
        }
    }
}
