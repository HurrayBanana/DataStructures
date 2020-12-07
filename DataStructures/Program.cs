using System;

namespace DataStructures
{
    
    class Program
    {
        static void Main(string[] args)
        {
            //Stack a = new Stack(10);

            ConsoleStack superduper = new ConsoleStack(5);


            superduper.Push(10);
            superduper.Push(4);
            superduper.Push(8);
            superduper.Push(9);
            superduper.Print();



        }
    }
}
