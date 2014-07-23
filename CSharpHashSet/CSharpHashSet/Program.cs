using System;
using System.Collections.Generic;

namespace CSharpHashSet
{
    class Program
    {
        static void Main(string[] args)
        { 
            HashSet<string> nameHashSet=
                new HashSet<string>
                {
                    "Jalpesh", "Vishal", "Tushar", "Jalpesh"
                };


            nameHashSet.Add("Chirag");
            nameHashSet.Remove("Tushar");

            foreach (var item in nameHashSet)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}
