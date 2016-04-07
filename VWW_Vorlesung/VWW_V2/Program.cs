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
            

            foreach (var item in myUntil(i => i % 2 == 0, a))
                Console.WriteLine(item + ",");
            Console.ReadKey();
        }

        static IEnumerable<T> myUntil<T>(Func<T, bool> predicate, IEnumerable<T> original)
        {
            foreach (T item in original)
            {
                if (!predicate(item))
                    yield return item;
                else
                    yield break;
            }
        }
    }
}
