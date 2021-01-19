using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Problem1_KeywordSearch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter search word: ");
            var userText = Console.ReadLine();

            var groupsList = new Groups().GroupsOfItems();
            
            Console.Clear();
            Console.WriteLine("Results for '" + userText + "': \n");
            foreach (var group in groupsList)
            {
                foreach (var matchedCase in group)
                {
                    var match = new Regex(String.Join("|", userText.ToLower())).Match(matchedCase.ToLower());
                    while (match.Success)
                    {
                        Console.WriteLine(matchedCase);
                        match = match.NextMatch();

                    }
                }

            }


            Console.ReadLine();

        }
    }
}

