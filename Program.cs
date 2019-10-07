using System;

namespace pointertype
{
    class Program
    {
        static void Main(string[] args)
        {
            unsafe
            {
                int i = 5;
                int* p = &i;
                Console.WriteLine((long)p);
                Console.WriteLine(*p);
            }

        }
    }
}
