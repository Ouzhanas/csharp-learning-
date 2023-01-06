using System;


namespace Fonksiyondenemesi
{
    class Program
    {
        static void Main()
        {
            Whiledongu();
            While2();
            DoWhile();

        }

        private static void DoWhile()
        {
            int j = 0;
            do
            {

                Console.WriteLine("fonksiyonlu dongu");
                j++;

            } while (j < 10);
        }

        private static void While2()
        {
            int sayac = 0;
            while (sayac <= 20)
            {
                Console.WriteLine("{0,2} {1,3}", sayac, sayac * sayac);
                sayac++;
            }
        }

        private static void Whiledongu()
        {
            int i = 0;
            while (i <= 10)
            {
                Console.WriteLine("Döngü: " + i);
                i++;
            }
        }
    }
}
