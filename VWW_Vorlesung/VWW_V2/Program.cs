using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VWW_V2
{
    class Program
    {
        /// <summary>
        /// checking numbers
        /// </summary>
        /// <param name="i"></param>
        /// <returns></returns>
        delegate TResult Predicate<T, TResult>(T i);
        delegate TResult Predicate2<T, T2, TResult>(T i, T2 j);

        static void Main(string[] args)
        {
            Func<int, bool> myFunc = IsOdd;

            ExecuteForOneToTen(i => i % 2 != 0);
            ExecuteForOneToTen(IsEven);

            Console.WriteLine(myFunc(5));

            Console.ReadKey();
        }

        static void ExecuteForOneToTen(Predicate<int, bool> f)
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
