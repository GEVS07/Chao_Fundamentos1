using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejer1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int f, c;
            Console.Write("Ingrese el numero de filas: ");
            while (!int.TryParse(Console.ReadLine().Trim(), out f) | f < 0)
            {
                Console.Write("Error: numero de filas no valido,volver a ingresar: ");
            }
            Console.Write("Ingrese el numero de columnas: ");
            while (!int.TryParse(Console.ReadLine().Trim(), out c) | c < 0)
            {
                Console.Write("Error: numero de columnas no valido,volver a ingresar: ");
            }
            int[,] matriz = new int[f, c];
            Random rnd = new Random();
            Console.Clear();
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    matriz[i, j] = rnd.Next(30, 51);
                    Console.Write(matriz[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
