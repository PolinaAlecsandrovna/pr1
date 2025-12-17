using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char symbol = 'X';
            object boxed = symbol; // Boxing
            char unboxed = (char)boxed; // Unboxing

            var F = 3.14f;
            var A = "null";
            Console.WriteLine($"var number: {F}, Type:{ F.GetType()}");
            Console.WriteLine($"var string: {A}, Type:{ A.GetType()}");

            DateTime now = DateTime.Now;
            string fromInt1 = now.ToString();
            string fromInt2 = Convert.ToString(now);

            Type intType = typeof(int);
            Type stringType = typeof(string);
            Console.WriteLine($"Type of int: {intType.Name}, Namespace:{ intType.Namespace}");

        }
    }
}
