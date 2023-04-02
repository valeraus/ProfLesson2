using System;
using System.Collections;

namespace AddTask
{
    /*
    Використовуючи клас SortedList, 
    створіть невелику колекцію та виведіть на екран значення пар «ключ-значення» спочатку в алфавітному порядку, 
    а потім у зворотному.
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            var sort = new SortedList();

            sort["First"] = "1st";
            sort["Second"] = "2nd";
            sort["Third"] = "3rd";
            sort["Fourth"] = "4th";

            foreach (DictionaryEntry entry in sort)
            {
                Console.WriteLine("{0} = {1}", entry.Key, entry.Value);
            }

            Console.WriteLine(new string('-', 15));

            var sortRevers = new SortedList(new DescendingComparer());

            sortRevers["First"] = "1st";
            sortRevers["Second"] = "2nd";
            sortRevers["Third"] = "3rd";
            sortRevers["Fourth"] = "4th";

            foreach (DictionaryEntry entry in sortRevers)
            {
                Console.WriteLine("{0} = {1}", entry.Key, entry.Value);
            }

            // Delay.
            Console.ReadKey();
        }
    }
}
