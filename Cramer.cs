using System;

// cramer yöntemi ile matris çözmeye yarar
public class Cramerr
{
    public static void Main()
    {
        int i, j;
        int ai, aj; // a matrisinin satır sütun
        int bi; // b matrisinin satır 
        Console.WriteLine("Program şu an için sadece int tipi sayılar için çalışmaktadır\nve 3x3 2x2 matrisleri desteklemektedir");
        Console.WriteLine("Söz konusu matris A.x = B olmak üzere istenilenleri giriniz");
       
        Console.Write("A Matrisin satır sayısı girin: ");
        ai = Convert.ToInt32(Console.ReadLine());
        Console.Write("A matrisinin Sütun sayısı girin: ");
        aj = Convert.ToInt32(Console.ReadLine());
       
        Console.Write("B matirsinin satır sayısı: ");
        bi = Convert.ToInt32(Console.ReadLine());
        

        int[,] Amatris = new int[ai, aj];
        int[,] Bmatris = new int[bi, 1];


       
        
        if (ai == aj)
        {
            
            if(aj == bi)
            {
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
                for (int a = 0; a < ai; a++)
                {
                    for (int b = 0; b < aj; b++)
                    {
                        Console.Write(Amatris[a, b] + "\t");
                    }
                    Console.WriteLine("");
                }
                Console.WriteLine();
                Console.WriteLine("B matrisini giriniz: ");
                for(i= 0; i < bi; i++)
                {
                    Console.Write("[" + i + "]" + "[" + 0 + "] = ");
                    Bmatris[i, 0] = Convert.ToInt32(Console.ReadLine());
                }
                Console.WriteLine();
                for (int a = 0; a < bi; a++)
                {
                    for (int b = 0; b < 1; b++)
                    {
                        Console.Write("\t" + Bmatris[a, b] );
                    }
                    Console.WriteLine("");
                }
                Console.WriteLine();

                if (ai == 1)
                {
                    float determinanta;
                    float determinantb;
                    float xi;
                    determinanta = Amatris[0, 0];
                    determinantb = Bmatris[0, 0];
                    xi = determinantb / determinanta;
                    Console.WriteLine("Xi = "+ xi);
                }
                
                if (ai == 2)
                {
                    float deta = 0;
                    float detx = 0;
                    float dety = 0;

                    int[,] matrisX = new int[2, 2];
                    int[,] matrisY = new int[2, 2];
                    
                    for (i = 0; i < 2; i++)
                    {
                        for (j = 0; j < 2; j++)
                        {
                            matrisX[i, 0] = Bmatris[i, 0];
                        }
                    }
                    for (i = 0; i < 2; i++)
                    {
                        for (j = 1; j < 2; j++)
                        {
                            matrisX[i, j] = Amatris[i, j];
                        }
                    }
                    Console.WriteLine();
                    Console.WriteLine("Xi matrisi :");
                    for (i = 0; i < 2; i++)
                    {
                        for (j = 0; j < 2; j++)
                        {
                            Console.Write(matrisX[i, j] + "\t");
                        }
                        Console.WriteLine("");
                    }
                    Console.WriteLine();

                    for (i = 0; i < 2; i++)
                    {
                        for (j = 0; j < 2; j++)
                        {
                            matrisY[i, j] = Amatris[i, j];
                        }
                    }
                    for (i = 0; i < 2; i++)
                    {
                        for (j = 0; j < 2; j++)
                        {
                            matrisY[i, 1] = Bmatris[i, 0];
                        }
                    }
                    Console.WriteLine("Yi matrisi ");
                    for (i = 0; i < 2; i++)
                    {
                        for (j = 0; j < 2; j++)
                        {
                            Console.Write(matrisY[i, j] + "\t");
                        }
                        Console.WriteLine("");
                    }
                    Console.WriteLine();

                    deta = deta + (Amatris[0,0] * Amatris[1,1]) - (Amatris[0,1] * Amatris[1,0]);
                    Console.WriteLine("A matrisinin determinantı = " + deta);
                    if(deta != 0)
                    {
                        detx = detx + (matrisX[0, 0] * matrisX[1, 1]) - (matrisX[0, 1] * matrisX[1, 0]);
                        Console.WriteLine("Xi determinantı = "+ detx);
                        dety = dety + (matrisY[0, 0] * matrisY[1, 1]) - (matrisY[0, 1] * matrisY[1, 0]);
                        Console.WriteLine("Yi determinantı = " + dety);
                         Console.WriteLine("X = " + detx/deta + "Y = " + dety/deta);
                    }
                    else
                    {
                        Console.WriteLine("A matrisinin determinantı 0 olmamalı ");
                    }
                    
                }
                if(ai == 3)
                {
                    
                    float detA = 0;
                    float detX = 0;
                    float detY = 0;
                    float detZ = 0;

                    int [,] takas = new int [3,3];
                    int [,] takas2 = new int[3,3];
                    int [,] takas3 = new int[3,3];
                    for(i = 0; i < 3; i++)
                    {
                        for (j = 0; j < 3; j++)
                        {
                            takas[i, 0] = Bmatris[i, 0];
                        }
                    }
                    for(i = 0; i < 3; i++)
                    {
                        for(j = 1; j < 3; j++)
                        {
                           takas [i, j] = Amatris[i, j];
                        }
                    }
                    Console.WriteLine();
                    Console.WriteLine("Xi matrisi :");
                    for(i = 0; i < 3; i++) 
                    {
                        for(j=0; j < 3; j++)
                        {
                            Console.Write(takas[i,j]+"\t");
                        }
                        Console.WriteLine("");
                    }
                    Console.WriteLine();
                    
                    for (i = 0; i < 3; i++)
                    {
                        for(j=0; j<3; j++) 
                        {
                            takas2[i, j] = Amatris[i, j];
                        }
                    }
                    for (i = 0; i < 3; i++)
                    {
                        for (j = 0; j < 3; j++)
                        {
                            takas2[i, 1] = Bmatris[i, 0];
                        }
                    }
                    Console.WriteLine("Yi matrisi ");
                    for (i = 0; i < 3; i++)
                    {
                        for (j = 0; j < 3; j++)
                        {
                            Console.Write(takas2[i, j] + "\t");
                        }
                        Console.WriteLine("");
                    }
                    Console.WriteLine();
                    for (i = 0; i < 3; i++)
                    {
                        for (j = 0; j < 3; j++)
                        {
                            takas3[i, j] = Amatris[i, j];
                        }
                    }
                    for (i = 0; i < 3; i++)
                    {
                        for (j = 0; j < 3; j++)
                        {
                            takas3[i, 2] = Bmatris[i, 0];
                        }
                    }
                    Console.WriteLine("Zi matrisi ");
                    for (i = 0; i < 3; i++)
                    {
                        for (j = 0; j < 3; j++)
                        {
                            Console.Write(takas3[i, j] + "\t");
                        }
                        Console.WriteLine("");
                    }
                    Console.WriteLine();

                    Console.WriteLine("^A^ determinantı");
                    for (i = 0; i < 3; i++)
                        detA = detA + (Amatris[0, i] * (Amatris[1, (i + 1) % 3] * Amatris[2, (i + 2) % 3] - Amatris[1, (i + 2) % 3] * Amatris[2, (i + 1) % 3]));
                    Console.WriteLine("DET A: " + detA);

                    if(detA !=0)
                    {
                        Console.WriteLine("^Xi^ determinantı");
                        for (i = 0; i < 3; i++)

                            detX = detX + (takas[0, i] * (takas[1, (i + 1) % 3] * takas[2, (i + 2) % 3] - takas[1, (i + 2) % 3] * takas[2, (i + 1) % 3]));
                        Console.WriteLine("DET X: " + detX);
                        Console.WriteLine("^Yi^ determinantı");
                        for (i = 0; i < 3; i++)

                            detY = detY + (takas2[0, i] * (takas2[1, (i + 1) % 3] * takas2[2, (i + 2) % 3] - takas2[1, (i + 2) % 3] * takas2[2, (i + 1) % 3]));
                        Console.WriteLine("DET Y: " + detY);
                        Console.WriteLine("^Zi^ determinantı");
                        for (i = 0; i < 3; i++)

                            detZ = detZ + (takas3[0, i] * (takas3[1, (i + 1) % 3] * takas3[2, (i + 2) % 3] - takas3[1, (i + 2) % 3] * takas3[2, (i + 1) % 3]));
                        Console.WriteLine("DET Z: " + detZ);

                        Console.WriteLine("X = " + detX / detA + " Y = " + detY / detA + " Z = " + detZ / detA);
                    }
                    else
                    {
                        Console.WriteLine("A matrisinin determinantı 0 olmamalıdır");
                    }
                }
            }
        }

        
    }
}