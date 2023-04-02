using System;
using System.Collections.Generic;

namespace Task2
{
    /*
    Створіть колекцію, до якої можна додавати покупців та категорію придбаної ними продукції. 
    З колекції можна отримувати категорії товарів, які купив покупець або за категорією визначити покупців.
     */
    enum Category
    {
        IT, Other
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<Employee, List<Category>> dic = new Dictionary<Employee, List<Category>>();

            dic.Add(new Employee("Ivanov"), new List<Category> { Category.IT, Category.Other });
            dic.Add(new Employee("Petrov"), new List<Category> { Category.Other });

            foreach (KeyValuePair<Employee, List<Category>> item in dic)
            {
                Console.Write(item.Key.Name + ": ");
                foreach (var category in item.Value)
                {
                    Console.Write(category + ", ");
                }
                Console.WriteLine();
                Console.WriteLine(new string('-', 10));
            }

            Console.ReadKey();
        }
    }
}