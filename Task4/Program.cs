using System;
using System.Collections;
using System.Collections.Specialized;

namespace Task4
/*
Створіть колекцію типу OrderedDictionary та реалізуйте у ній можливість порівняння значень.
 */
{
    internal class Program
    {
        static void Main(string[] args)
        {
            OrderedDictionaryComparer Comparer = new OrderedDictionaryComparer();

            OrderedDictionary dict1 = new OrderedDictionary(Comparer);
            dict1.Add("1", "один");
            dict1.Add("2", "два");
            dict1.Add("3", "три");

            OrderedDictionary dict2 = new OrderedDictionary();
            dict2.Add("1", "один");

            foreach (DictionaryEntry item1 in dict1)
            {
                foreach (DictionaryEntry item2 in dict2)
                {
                    Console.WriteLine(item1.Equals(item2).ToString());
                }
            }
            //Delay
            Console.ReadLine();
        }
    }
}
