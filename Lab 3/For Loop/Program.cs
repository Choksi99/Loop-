using System;

namespace For_Loop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int i_StartYear = 2018;
            for (int i_CurrentYear = i_StartYear; i_CurrentYear <= i_StartYear + 10; i_CurrentYear++)
            {
                Console.Write(i_CurrentYear + " ");
            }

        }
    }
}
