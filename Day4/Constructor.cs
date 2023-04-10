using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4
{
    class Constructor
    {
        int id;
        string name;

        public Constructor(int id, string name)
        {
            this.id = id;
            this.name = name;
        }

        public int Getid()
        {
            return this.id;
        }

        public string Getname()
        {
            return this.name;
        }

        static void Main1(string[] args)
        {
            Constructor Tejas = new Constructor(1, "Tejas");

            Console.WriteLine("Emp Id is: {0}", Tejas.id);
            Console.WriteLine("Emp Name is: {0}", Tejas.name);

            Console.WriteLine("--------------------");

            Constructor Yuvraj = new Constructor(2, "Yuvraj");

            Console.WriteLine("Emp Id is: {0}", Yuvraj.id);
            Console.WriteLine("Emp Name is: {0}", Yuvraj.name);



        }
    }
}