using System;
using System.Collections.Generic;

namespace MyDictionaryIntro1
{
    class Program
    {
        static void Main(string[] args)
        {
            IDictionary<int, string> numberNames = new Dictionary<int, string>();
            numberNames.Add(1, "One"); //adding key/value using the Add() method
            numberNames.Add(3, "Three");
            numberNames.Add(2, "Two");
            numberNames.Add(4, "four");
            numberNames.Add(5, "five");
            foreach (var nM in numberNames)
            {
                Console.WriteLine(nM.Key+"-"+nM.Value);
                
            }
            Console.WriteLine(numberNames.Count);
            Console.WriteLine("---------");

            MyDictionary<int, string> nameNumber = new MyDictionary<int, string>();
            nameNumber.Add(1, "one");
            nameNumber.Add(2, "two");
            nameNumber.Add(3, "three");
            nameNumber.Add(4, "four");
            nameNumber.Add(5, "five");
            nameNumber.Add(6, "six");
            foreach (var Key in nameNumber.Keys)
            {
                Console.WriteLine(Key);
                
            }
            foreach (var Value in nameNumber.Values)
            {
                Console.WriteLine(Value);
                
            }

            Console.WriteLine(nameNumber.Lenght);
        }
    }
}
