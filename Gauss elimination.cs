using System;

// Gaus eliminasyon yöntemi ile matris çözmeye yarar 

class Gausseliminasyon
{
    public static void Main()
    {
        int i, j;
        int k, n;
        
        float  kesir;

        Console.Write("Bilinmeyen sayisini giriniz: ");
        n = Convert.ToInt32(Console.ReadLine());


        float[,] Amatris = new float[8, 8];
        float[] Bmatris = new float[8];

        for (i = 1; i <= n; i++)
        {
            for(j = 1; j <= n+1; j++)
            {
                Console.Write(" [ " + i + "]" + "[" + j + "]");
                Amatris[i, j] = Convert.ToInt32(Console.ReadLine());
            }
        }
        Console.WriteLine();
        for(i = 1; i <= n-1; i++)
        {
            if(Amatris[i, i] == 0)
            {
                Console.WriteLine("Hata");
                
            }
            for(j=i+1; j <= n; j++)
            {
                kesir = Amatris[j,i]/Amatris[i,i];

                for (k = 1; k <= n+1 ; k++)
                {
                    Amatris[j, k] = Amatris[j, k] - kesir * Amatris[i, k];
                }
            }
        }
        Bmatris[n] = Amatris[n, n + 1] / Amatris[n, n];
        for(i= n-1; i >= 1; i--)
        {
            Bmatris[i] = Amatris[i, n+1 ];
            for(j=i+1; j <= n; j++)
            {
                Bmatris[i]= Bmatris[i]- Amatris[i, j] * Bmatris[j];
            }
            Bmatris[i] = Bmatris[i] / Amatris[i, i];
        }
        for (i = 1; i <= n; i++)
        {
            Console.WriteLine(Bmatris[i]);
        }
    }
}