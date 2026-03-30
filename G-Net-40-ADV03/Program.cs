using ConsoleApp1.Helpers;
using System.Net.Http.Headers;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Exercise 1: Student Grade Manager
            Console.WriteLine("Total ELments : ");
            List<int> grades = [85, 92, 78, 95, 88, 70, 100, 65];
            HelperPrint.Print(grades);
            Console.WriteLine(new string('=' ,  70));
            // ===============================================================
            Console.WriteLine($"First Element :  {grades.First()}");
            Console.WriteLine($"Last Element :  {grades.Last()}");
            Console.WriteLine($"Total Elements  : {grades.Count}");
            // ===============================================================
            grades.Sort();
            Console.WriteLine("Total ELments After Sorting : ");
            HelperPrint.Print(grades);
            Console.WriteLine(new string('=', 70));
            // ===============================================================
            int number = grades.Find(x=> x >90);
            Console.WriteLine($"First Element Above 90 : {number}");
            Console.WriteLine(new string('=', 70));
            // ===============================================================
            Console.WriteLine("Number Below 75 : ");
            List<int>NumbersBelow75 =  grades.FindAll(x => x < 75);
            HelperPrint.Print(NumbersBelow75);
            Console.WriteLine(new string('=', 70));
            // ===============================================================
            List<int>numberRemove =  new List<int> ();
            numberRemove.Add(grades.RemoveAll(x => x < 80));
            Console.WriteLine("Total ELments After Removing Below 80 : ");
            HelperPrint.Print(numberRemove);
            Console.WriteLine(new string('=', 70));
            // ===============================================================
            #endregion
            #region Exercise 2: Leaderboard
            SortedList<int, string> leaderboard = new() {
                [500] = "Ahmed",
                [200] ="Sara",
                [800] = "Ali",
                [350] = "Mona"

                };
            HelperPrint.printDictionary(leaderboard);
            Console.WriteLine(new string('=',70));
            Console.WriteLine($"First Key  =>  key {leaderboard.First().Key} and Key  : {leaderboard.First().Value}");
            // ===============================================================
            Console.WriteLine(new string('=', 70));
            
            
            
             bool FlagFound = leaderboard.ContainsKey(500);
            if (FlagFound)
            {
                Console.WriteLine("Key 500  Found ");
            }
            else
            {
                Console.WriteLine("Key 500 Not Found");
            }
            // ===============================================================
            Console.WriteLine(new string('=', 70));

            //  Remove the key 500 and print the leaderboard again
            bool KeyFoundOrnot = leaderboard.TryGetValue(999, out string? value);
            if (KeyFoundOrnot)
            {
                Console.WriteLine($"Key 999 Found with Value : {value}");
            }
            else
            {
                Console.WriteLine("Key 999 Not Found");
            }

            // ===============================================================
            Console.WriteLine(new string('=', 70));
            Console.WriteLine("After Delete Element :");
            leaderboard.Remove(200);
            HelperPrint.printDictionary(leaderboard);
            Console.WriteLine(new string('=', 70));

            #endregion
            #region Exercise 3: Phone Book
            Dictionary<string, string> phoneBook = new() {
                    ["Ahmed"] = "1234567890",
                    ["Sara"] = "9876543210",
                    ["Ali"] = "5555555555",
                    ["Mona"] = "1111111111"
    
                    };

            phoneBook.Add("Omar", "2222222222");
            phoneBook["Sara"] = "9999999999";
            // ===============================================================
            try
            {
            phoneBook.Add("Ahmed" , "01015668791") ; 

            }catch(Exception ms )
            {
                 Console.WriteLine($"Error : {ms.Message}");
            }
            Console.WriteLine(new string('=', 70));
            // ===============================================================
            bool FlagTryCreate = phoneBook.TryAdd("Ahmed", "01015668791");
            if (FlagTryCreate)
            {
                Console.WriteLine("Key Ahmed Added Successfully");
            }
            else
            {
                Console.WriteLine("Key Ahmed Already Exists");
            }
            Console.WriteLine(new string('=', 70));
            // ===============================================================
            bool  FlagGetValue = phoneBook.TryGetValue("Ramzy", out string? phoneNumber);
            if (FlagGetValue)
            {
                Console.WriteLine($"Key Ramzy Found with Value : {phoneNumber}");
            }
            else
            {
                Console.WriteLine("Key Ramzy Not Found");
            }
            // ===============================================================
            Console.WriteLine(new string('=', 70));
            Console.WriteLine($"Get Value Or Default for Key Sara : {phoneBook.GetValueOrDefault("Sara", "Key Not Found")}");
            Console.WriteLine($"Get Value Or Default for Key Ramzy : {phoneBook.GetValueOrDefault("Ramzy", "Key Not Found")}");
            // ================================================================
            Console.WriteLine(new string('=', 70));
            HelperPrint.printDictionary(phoneBook);
            HelperPrint.printDictionary2(phoneBook);
            Console.WriteLine(new string('=', 70));
            #endregion
            #region Exercise 4: Unique Email Validator
            HashSet<string> Emails = new HashSet<string>(StringComparer.OrdinalIgnoreCase);
            Emails.Add("ahmed@test.com");
            Emails.Add("AHMED@test.com");
            Emails.Add("sara@test.com");
            Emails.Add("Sara@test.com");
            Console.WriteLine($"Total Emails :  {Emails.Count}");
            Console.WriteLine(new string('=' , 70) );
            //  HashSet will ignore the duplicate email
            HashSet<int> Numbers1 = [ 1,2,3,4,5 ];
            HashSet<int> Numbers2 = [ 4,5,6,7,8 ];
            Numbers1.UnionWith(Numbers2);
            Numbers1.IntersectWith(Numbers2);
            Numbers1.ExceptWith(Numbers2);
            bool isSubset = Numbers1.IsSubsetOf([1,2 ]);
            if (isSubset)
            {
                Console.WriteLine("Numbers1 is a subset of [1, 2]");
            }
            else
            {
                Console.WriteLine("Numbers1 is not a subset of [1, 2]");
            }
            Console.WriteLine(new string('=', 70));

            #endregion
            #region Exercise 5: Print Queue Simulator
            Queue<string> documents =  new Queue<string>();
            documents.Enqueue("Report.pdf");
            documents.Enqueue("Invoice.pdf");
            documents.Enqueue("Letter.docx");
            documents.Enqueue("Resume.pdf");
            documents.Enqueue("Photo.jpg");
            HelperPrint.PrintQueue(documents);
            Console.WriteLine(new string('=', 70));
            Console.WriteLine($"Total Counts in Queue : {documents.Count}");
            Console.WriteLine($"Now Document Will Print {documents.Peek()}");
            Console.WriteLine($"This Document  Deleted Now  {documents.Dequeue()}");
            Console.WriteLine(new string('=', 70));
            Queue<int> Q1 = [];
          bool  Flag =   Q1.TryDequeue(out int result);
            if (Flag)
            {
                Console.WriteLine($"Dequeue Successful, Result: {result}");
            }
            else
            {
                Console.WriteLine("Dequeue Failed, Queue is empty.");
            }
            Console.WriteLine(new string('=', 70));
            //  What Happens if we try to TryDequeue from an empty queue ?
            //   using to  check  there is elemnt or not before Dequeue
            //  if exsiting Element return  true and return the element in result variable
            //  if not exsiting Element return false and result variable will be default value of int which is 0


            #endregion
            #region Exercise 6: Browser History (Undo)
            Stack<string> browserHistory = new();
            browserHistory.Push("google.com");
            browserHistory.Push("github.com");
            browserHistory.Push("stackoverflow.com");
            browserHistory.Push("youtube.com");
            browserHistory.Push("claude.ai");
            Console.WriteLine($" current page {browserHistory.Peek()}");
            Console.WriteLine(new string('=', 70));
            Console.WriteLine($"Back : {browserHistory.Pop()}");
            Console.WriteLine($"Back : {browserHistory.Pop()}");
            Console.WriteLine($"Back : {browserHistory.Pop()}");
            Console.WriteLine($"current page {browserHistory.Peek()}");
            Console.WriteLine(new string('=', 70));
            Stack<int> S1 = new(); 
            bool  FlagStack =  S1.TryPop(out int StackResult);
            if (FlagStack)
            {
                Console.WriteLine($"Element Deleted : {StackResult}");
            }
            else
            {
                Console.WriteLine("No Element To Delete ");
            }
            Console.WriteLine(new string('=', 70));


            #endregion


        }

    }
}
