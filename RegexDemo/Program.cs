using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegexDemo
{
    public class Program
    {
        public static void Main(string[] args)
        {

            while (true)
            {
                Console.WriteLine("Please choose the option below:");
                Console.WriteLine("1: Regex exp");
                Console.WriteLine("2: Check Name");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Regex_Match reger_match = new Regex_Match();
                        reger_match.MyRegex();
                        break;
                    case 2:
                        Regex_Match reger_Match = new Regex_Match();
                        reger_Match.CheckName("Kirti");
                        break;
                    case 3:
                        Regex_Match Match = new Regex_Match();
                        Match.LastName("Puri");
                        break;


                }
            }
        }
    }

}
