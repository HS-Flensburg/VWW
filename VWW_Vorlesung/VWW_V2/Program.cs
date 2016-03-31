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
            Func<string> myFunc2 = () => "Hallo Flensburg";
            Action<string, int> myFunc3 = (s, i) => Console.WriteLine(s.Substring(i));
            Action<Func<string>> a = (s) => Console.WriteLine(s());


            a(myFunc2);

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
