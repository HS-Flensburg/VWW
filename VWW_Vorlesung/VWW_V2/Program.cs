using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VWW_V2
{
    class Program
    {
        delegate bool Predicate(int i);

        static void Main(string[] args)
        {
            Predicate myFunc = IsOdd;

            ExecuteForOneToTen(IsOdd);
            ExecuteForOneToTen(IsEven);

            Console.WriteLine(myFunc(5));

            Console.ReadKey();
        }

        static void ExecuteForOneToTen(Predicate f)
        {
            for (int i = 1; i <= 10; i++)
                Console.WriteLine(f(i));
        }

        static bool IsOdd(int i)
        {
            return i % 2 != 0;
        }
        static bool IsEven(int i)
        {
            return i % 2 == 0;
        }
    }
}
