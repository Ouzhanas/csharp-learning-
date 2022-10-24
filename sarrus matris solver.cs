using System;
//Oğuzhan Bintepe 200106206026
class Sarrus
{
    static void Main()
    {
        int i, j;

        int[,] matris = new int[3, 3];
        for (i = 0; i < 3; i++)
        {
            for (j = 0; j < 3; j++)
            {
                Console.Write("[" + i + "]" + "[" + j + "] = ");
                matris[i, j] = Convert.ToInt32(Console.ReadLine());
            }
        }
        Console.WriteLine("\n");
        for (int a = 0; a < 3; a++)
        {
            for (int b = 0; b < 3; b++)
            {
                Console.Write(matris[a, b] + "\t");
            }
            Console.WriteLine("");
        }

        Console.WriteLine("Sarrus Kuralına Göre Determinantı :");
        int det = 0;
        for (i = 0; i < 3; i++)
            det = det + (matris[0, i] * (matris[1, (i + 1) % 3] * matris[2, (i + 2) % 3] - matris[1, (i + 2) % 3] * matris[2, (i + 1) % 3]));

        Console.WriteLine("determinant " + det);
        Console.Read();
    }
}
