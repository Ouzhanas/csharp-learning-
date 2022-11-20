using System;

//ters matris yöntemi ile matris çözmeye yarar

class Tersmatris
{
    public static void Main()
    {
        int i, j;
        int ai, aj;
        Console.WriteLine("2x2 matrisleri için ters matris hesaplayıcı");
        Console.WriteLine("A.x = B formatındaki matris kullanılmaktadır");

        Console.Write("A matrisinin satır sayısı: ");
        ai = Convert.ToInt32(Console.ReadLine());
        Console.Write("A matrisinin sütun sayısı: ");
        aj = Convert.ToInt32(Console.ReadLine());

        float[,] Amatris = new float[ai, aj];
        float[,] Bmatris = new float[ai,1];

        Console.WriteLine("A matrisini giriniz: ");
        for (i = 0; i < ai; i++)
        {
            for (j = 0; j < aj; j++)
            {
                Console.Write("[" + i + "]" + "[" + j + "] = ");
                Amatris[i, j] = Convert.ToInt32(Console.ReadLine());
            }
        }
        Console.WriteLine();
        for (i = 0; i < ai; i++)
        {
            for (j = 0; j < aj; j++)
            {
                Console.Write("\t" + Amatris[i, j]);
            }
            Console.WriteLine("");
        }
        Console.WriteLine();
        for (i = 0; i < ai; i++)
        {
            Console.Write("[" + i + "] = ");
            Bmatris[i,0] = Convert.ToInt32(Console.ReadLine());
        }
        Console.WriteLine();
        Console.WriteLine("B matrisi :");
        for (j = 0; j < aj; j++)
        {
            Console.WriteLine("\t" + Bmatris[j,0]);
        }
        Console.WriteLine();
        if (ai == 2)
        {
            float det;
            float[,] kopya = new float[ai, aj];
            det = Amatris[0, 0] * Amatris[1, 1] - Amatris[0, 1] * Amatris[1, 0];
            for (i = 0; i < ai; i++)
            {
                for (j = 0; j < aj; j++)
                {
                    if (i == j)
                    {
                        kopya[i, j] = Amatris[1 - i, 1 - j];
                    }
                    else
                    {
                        kopya[i, j] = -Amatris[1 - i, 1 - j];
                    }
                }
            }
            Console.WriteLine("A matrisinin tersi işlemleri: ");
            for (i = 0; i < ai; i++)
            {
                for (j = 0; j < aj; j++)
                {
                    Console.Write("\t" + kopya[i, j]);
                }
                Console.WriteLine("");
            }
            Console.WriteLine();
            for (i = 0; i < aj; i++)
            {
                for (j = 0; j < aj; j++)
                {
                    kopya[i, j] = (1 / det) * kopya[i, j];
                }
            }
            for (i = 0; i < ai; i++)
            {
                for (j = 0; j < aj; j++)
                {
                    Console.WriteLine("[" + i + "]" + "[" + j + "] =" + kopya[i, j]);
                }
                Console.WriteLine("");
            }

            for (int a = 0; a <= Amatris.GetUpperBound(0); a++)
            {
                // B nin sütun sayısı kadar
                for (int b = 0; b <= Bmatris.GetUpperBound(1); b++)
                {
                    float toplam = 0;
                    // A nın sütun sayısı kadar
                    // (ya da B nin satır sayısı)
                    for (int k = 0; k <= Amatris.GetUpperBound(1); k++)
                    {
                        toplam += kopya[a, k] * Bmatris[k, b];
                    }
                    kopya[a, b] = toplam;
                }
            }


            for (i = 0; i < ai; i++)
            {
                for (j = 0; j < aj - 1; j++)
                {
                    Console.WriteLine(kopya[i, j]);
                }
            }


        }
    }
}