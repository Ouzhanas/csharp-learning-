using System;

namespace Deneme { 
    
    class Program
    {
        static void Yap(int a, int b)
        {
            int i;
            int j;
            for( i = 0; i < b; i++)
            {
                for( j = 0; j < a; j++)
                {
                    Console.Write(i * j);
                    Console.Write("\t");
                    }
                Console.WriteLine();
            }
        }
        static void Main()
        {
           int a = 10;
           int b = 10; 
           Yap(a,b);
        }
    }

}