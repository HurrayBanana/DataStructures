using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
    class ConsoleStack : Stack
    {
        public ConsoleStack(int size) 
            : base(size)
        {
        }

        public void Print()
        {
            for (int i = 0; i < a.Count; i++)
            {
                Console.WriteLine(a.Peek(i));
            }
        }
    }
}
