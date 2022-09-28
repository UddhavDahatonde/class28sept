using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class28sept
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str1 = "I Am Good Boy";
            string str2 = "I Am Fine";
            int year = 2020;
            char[] prem=str1.ToCharArray();
            Console.WriteLine(prem);
            Console.WriteLine("---------------------------");
           string str3= string.Concat(str1," ",str2," ",year);
            Console.WriteLine(str3);
            Console.WriteLine(str3.Length);
            string str4 = str1.Substring(1);
            Console.WriteLine(str4);
            bool result=str1.Contains("Am");
            Console.WriteLine(result);
            bool resul= str2.Equals(str1);
            Console.WriteLine(resul);
            
        }
    }
}
