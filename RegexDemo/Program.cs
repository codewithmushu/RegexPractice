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
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Regex_Match reger_match = new Regex_Match();
                        reger_match.MyRegex();
                        break;

                }
            }
        }
    }

}
