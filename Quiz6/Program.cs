using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string candidate1 = "";
            string candidate2 = "";
            int vote = 0;
            int totalVotes = 3;
            Console.WriteLine("Input name of candidate 1:");
            candidate1 = Console.ReadLine();
            Console.WriteLine("Input name of candidate 2:");
            candidate2 = Console.ReadLine();
            Console.WriteLine();

            
            Console.WriteLine("Who do you want to vote for? (1 for Trump, 2 for Kamala, 0 for exit");
            vote = Convert.ToInt32(Console.ReadLine());



        }
    }
}
