using System.Text.Json.Serialization;

namespace ConsoleApp8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            int[,] uniforme = new int[3, 3]
            {
                { 0,1,2},
                { 3,4,5},
                { 6,7,8},
            };

            int[][] irregulier = new int[3][];
            irregulier[0] = new int[2] { 1, 2 };
            irregulier[1] = new int[3] { 1, 2, 3 };
            irregulier[2] = new int[3] { 4, 5, 6 };

            int[][] jaggedArray = new int[3][];
            jaggedArray[0] = new int[3];
            jaggedArray[1] = new int[3];
            jaggedArray[2] = new int[3];
            for (int i = 0; i < uniforme.GetLength(0); i++)  // Pour chaque ligne
            {
                Console.WriteLine();    //saut de ligne avant chaque ligne de la matrice

                for (int j = 0; j < uniforme.GetLength(1); j++)   // Pour chaque colonne dans la ligne
                {
                   
                    Console.Write(uniforme[i, j] + " | ");
                   

                }
            }
            Console.WriteLine();    //saut de ligne après la matrice
            int k = 0;
            for (int i = 0; i < uniforme.GetLength(0); i++)
            {
                Console.WriteLine();
                for (int j =0 ;j < uniforme.GetLength(1) - k ;j++)
                Console.Write(uniforme[i, j] + " | ");
                k = k + 1;
            }
            k = k + 1;
            Console.WriteLine();
            //Console.WriteLine("j="+ j );

        }
                
           
    
    
    }

}
