using System;

namespace DataStructures
{
    
    class Program
    {
        static void Main(string[] args)
        {
            Stack a = new Stack(10);

            a.Push(10);
            a.Push(10);
            a.Push(10);
            a.Push(10);
            a.Peek(-2);

        }
    }
}
