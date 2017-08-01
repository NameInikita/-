using System;

namespace Versioning
{
    class Tree
    {
        public void Air() { Console.WriteLine("1"); }
        public /*virtual*/ void Water() { Console.WriteLine("2"); }
    }

    class Aple : Tree
    {
        public new void Air() { Console.WriteLine("3"); }//Замещение
        public /*override*/ void Water() { Console.WriteLine("4"); }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Tree inst1 = new Aple();

            inst1.Air();//1
            inst1.Water();//2

            Aple inst2= inst1 as Aple;

            inst2.Air();//3
            inst2.Water();//4

            Console.ReadKey();
        }
    }
}
