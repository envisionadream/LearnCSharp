using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;
using System.Security.Policy;
using Microsoft.SqlServer.Server;
using Microsoft.Win32;


namespace datatypes
{
    internal class Program
    {
        public static void Main(string[] args)
        {

            // create a method  called  JoinStrings which takes in two strings then output the result to the console and
            //return a string of these stings joined with a space  between them make sure it is public
            // call JoinStrings with your first and last name



            // create a method  called  Arthimetic which takes in two  numbers and returns a result  of a  mathematical
            //function which is also sent a a single character the result sould be  printed  to the console
            // call  arithmetic with an example of each type of calculation

            //Create a method called WriteStringArray which writes the contents of an array to the console.
            // call WriteStringArray with an array containing 3 strings
            string[] myStrings = new string[] {"JoinStrings", "Arthimetic", "test3"};
            myStrings[0] = "JoinStrings";
            myStrings[1] = "Arithmetic";
            myStrings[2] = "test3";

            for (int i = 0; i < myStrings.Length; i++)
            {
                Console.WriteLine(myStrings[i]);
            }
            string myresult = JoinStrings("daisy", "garthland");

        }

        public static string JoinStrings(string firstString, string secondString)
        {
            var resultString = firstString + ' ' + secondString;
            Console.WriteLine(resultString);
            return resultString;
        }

        public static int Arithmetic(int no1, int no2, char oper)
        {
            int result = 0;
            if (oper == '+')
            {
                result = no1 + no2;

            }
            else if (oper == '-')
            {
                result = no1 - no2;

            }
            else if (oper == '/')
            {
                result = no1 / no2;

            }
            else if (oper == '*')
            {
                result = no1 * no2;


            }
            return result;
        }
    }
}