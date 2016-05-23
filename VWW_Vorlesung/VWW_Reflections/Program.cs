using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace VWW_Reflections
{
    [Vww(7)]
    class Sample
    {
        public int ID { get; set; }
    }

    class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("Hallo");
            Assembly a = Assembly.GetExecutingAssembly();
            var p = new Program();
            foreach (Type t in a.GetTypes())
            {
                Console.WriteLine("Type: " + t);
                foreach (var m in t.GetCustomAttributes())
                {
                    if (m is VwwAttribute)
                    {
                        VwwAttribute v = (VwwAttribute)m;
                        Console.WriteLine(v.VL);
                    }
                    Console.WriteLine(m);
                }
                //Console.WriteLine(t.GetCustomAttribute(typeof(RequiredAttribute)));
                Console.WriteLine();
            }

            Console.ReadKey();
        }

        public void SayHallo()
        {
            Console.WriteLine("Moin");
        }

        public static void SayBye()
        {
            Console.WriteLine("Tschüss");
        }
    }
}
