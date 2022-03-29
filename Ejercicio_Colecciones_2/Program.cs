using System;
using System.Collections.Generic;

namespace Ejercicio_Colecciones_2
{
	class Program
	{
		static void Main(string[] args)
		{
            string[] colors = new string[] { "MAGENTA", "RED", "WHITE", "BLUE", "CYAN" };
            string[] removeColors = new string[] { "RED", "WHITE", "BLUE" };

            List<string> colores = new List<string>(colors);
            List<string> coloresBorrados = new List<string>(removeColors);

            Console.WriteLine("Lista original:");
            foreach (string color in colores)
            {
                Console.Write(color + " ");
            }
            Console.Write("\n");
            Console.Write("tamaño = " + colors.Length + " capacidad = " + (colors.Length + removeColors.Length) );

            for (int i = 0; i < colores.Count; i++)
            {
                for (int j = 0; j < coloresBorrados.Count; j++)
                {
                    if (colores[i].Equals(coloresBorrados[j]))
                    {
                        colores.RemoveAt(i);
                    }
                }
            }

            Console.WriteLine("\nLista con colores borrados:");
            foreach (string color in colores)
            {
                Console.Write(color + " ");
            }
            Console.Write("\n");
            Console.Write("tamaño = " + colores.Count + " capacidad = " + (colors.Length + removeColors.Length));

            Console.ReadKey();
        }
	}
}
