using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4
{
    class program
    {

        string name;
        int id;

        public program(string name, int id)
        {
            this.name = name;
            this.id = id;
        }

         program(program cc)
        {
            this.name = cc.name;
            this.id = cc.id;
        }

        public void Getdata()
        {
            Console.WriteLine(name);
            Console.WriteLine(id);

        }

        class CopyConstructor
        {
            public static void Main()
            {
                program p = new program("Tejas", 2);
                p.Getdata();
            }
        }
    }
}
