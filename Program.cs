using System;
using System.Collections.Generic;

namespace Assessment
{
    class Program
    {
        static void Main(string[] args)
        {
         Console.WriteLine("do u want to roll Yes/No");

             while (true)
             {
             string ans = Console.ReadLine();
              if (ans != null && ans == "y")
                 {
                 Random rnd = new Random();
                 int dice   = rnd.Next(1, 7);       
                 Console.WriteLine(dice);
                 }
              else if ( ans != null && ans == "n")
                 {

                 }
              else
                {
                  Console.Write("Only y or n Allowed");

                }
             }

        }  
    }
}
