using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6._2
{
    internal class StackArray
    {
        int[] data;
        int top;

        public StackArray(int size)
        {
            data = new int[size];
            top = -1;
        }

        public bool IsEmpty()
        {
            return top == -1;
        }

        public bool IsFull()
        {
            return top == data.Length - 1;
        }

        public void Push(int value)
        {
            if (IsFull())
            {
                Console.WriteLine("Stack is full");
                return;
            }
            else
            {
                top++;
                data[top] = value;
            }
        }

        public int Pop()
        {
            if(IsEmpty())
            {
                Console.WriteLine("Stack is empty");
                return -1;
            }
            else
            {
                int value = data[top];
                top--;
                return value;
            }
        }

        public void Display()
        {
            for (int i = 0; i >= 0; i--)
            {
                Console.WriteLine(data[i]);
            }
            }
            

        
    }
}
