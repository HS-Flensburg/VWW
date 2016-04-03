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
            var a = new [] { 1, 2, 3, 4, 5 , 6, 4};

            var x = a.Reverse().Where(i => i % 2 == 0).Skip(1).Distinct()
                .Sum();
            Console.WriteLine(a);
            Console.ReadKey();
        }
    }
}
