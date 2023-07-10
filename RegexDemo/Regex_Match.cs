using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexDemo
{
    //A regex (Regular Expresion) is a pattern that is used to check wheather a given string matches that.
    public class Regex_Match
    {
        static string pattern = "^cen$";
        //^ it will indicate string start
        // $ it will indicate the end of string

        public void MyRegex()
        {
            //we have created object of class
            //we have pass a parameter pattern in given class constructor
            Regex regex = new Regex(pattern);
            //is match return 
            if (regex.IsMatch("Muskan"))
            {
                Console.WriteLine("String is matching with Pattern");
            }
            else
            {
                Console.WriteLine("String doesnt matches");
            }
        }


        public void CheckName(string name)
        {
            //? it will check value we are using the
            string myName = "^[A-Z][a-z]{3,}?";
            if (Regex.IsMatch(name, myName))
            {
                Console.WriteLine("String is matching with Pattern");
            }
            else
            {
                Console.WriteLine("String doesnt matches");
            }

        }
    }
}
