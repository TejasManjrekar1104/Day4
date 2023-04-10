using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4
{
    class ConstructorOverloading
    {
        public ConstructorOverloading()
        {
            Console.WriteLine("Hello");
        }

        public ConstructorOverloading(int a, int b)
        {
            Console.WriteLine(a+b);
        }

        public ConstructorOverloading(int a, int b, int c)
        {
            Console.WriteLine(a+b+c);
        }
        public static void Main1()
        {
            ConstructorOverloading co = new ConstructorOverloading();

            ConstructorOverloading c1 = new ConstructorOverloading(10,20);

            ConstructorOverloading c2 = new ConstructorOverloading(10,20,30);


        }
    }
}
