using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejer2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int f;
            Console.Write("Ingrese el numero de la matriz cuadrada: ");
            while (!int.TryParse(Console.ReadLine().Trim(), out f) | f < 0)
            {
                Console.Write("Error: numero no valido,volver a ingresar: ");
            }
            int[,] matriz= new int[f, f];
            int[,] matriztranspuesta = new int[f, f];
            Random rnd = new Random();
            Console.WriteLine("\nMatriz Original");
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    matriz[i, j] = rnd.Next(30, 51);
                    Console.Write(matriz[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine("\nMatriz Transpuesta");
            for (int i = 0; i < matriztranspuesta.GetLength(0); i++)
            {
                for (int j = 0; j < matriztranspuesta.GetLength(1); j++)
                {
                    matriztranspuesta[j, i] = matriz[i, j];
                }
            }
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    
                    Console.Write(matriztranspuesta[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
