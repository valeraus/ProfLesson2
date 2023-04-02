using System.Collections.Generic;

namespace Task3
{
    /*
    Декількома способами створіть колекцію, в якій можна зберігати тільки цілі та речові значення, 
    на кшталт «рахунок підприємства – доступна сума» відповідн
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            // Первый способ
            var dict = new Dictionary<int, double>();

            // Второй способ
            var sortedDict = new SortedDictionary<int, double>();
        }
    }
}
