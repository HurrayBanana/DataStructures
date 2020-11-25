using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
    /// <summary>
    /// implements an integer based stack
    /// </summary>
    class Stack
    {
        /// <summary>
        /// stack space
        /// </summary>
        int[] stack;
        /// <summary>
        /// stack pointer
        /// </summary>
        int sp;
        /// <summary>
        /// size set at construction
        /// </summary>
        int max;
        /// <summary>
        /// creates a stack with the given number of entries
        /// </summary>
        /// <param name="size">how many values to store</param>
        public Stack(int size)
        {
            max = size;
            stack = new int[max];
            sp = 0;
        }

        /// <summary>
        /// places an item if possible onto top of stack
        /// </summary>
        /// <param name="item"></param>
        public void Push(int item)
        {
            if (sp < max)
            {
                stack[sp] = item;
                sp++;
            }
            else
                throw new Exception("STACK FULL");
        }

        /// <summary>
        /// removes an item from the top of stack if possible
        /// </summary>
        /// <returns>top of stack if not empty</returns>
        public int Pop()
        {
            if (sp > 0)
            {
                sp--;
                return stack[sp];
            }
            throw new Exception("STACK EMPTY");
        }
        /// <summary>
        /// retrieves the top value of the stack without altering the stack
        /// </summary>
        /// <returns>a copy of the top value of the stack</returns>
        public int Peek()
        {
            if (sp > 0)
            {
                return stack[sp - 1];
            }
            throw new Exception("empty stack");
        }
        /// <summary>
        /// returns the item at the required offset fro the top of the stack
        /// </summary>
        /// <param name="offset">positive offset 0 is top of stack, 1 is next one down etc...</param>
        /// <returns>requested item from the stack if posible</returns>
        public int Peek(int offset)
        {
            if ((sp - 1 - offset) >= 0 &&
                offset >= 0)
            {
                return stack[sp - 1 - offset];
            }
            throw new Exception("out of stack");
        }


    }
}
