using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aleatorio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Adivinar un número aleatorio entre 1 y 100
            //Tabata Vernaza
            Random rand = new Random();
            int numeroAleatorio = rand.Next(1, 101); // Genera un número al azar entre 1 y 100
            int intento;
            do
            {
                Console.Write("Ingresa un número (entre 1 y 100): "); //ingresal cualquier número
                intento = int.Parse(Console.ReadLine());

                if (intento < numeroAleatorio)
                {
                    Console.WriteLine("Intenta con un número mayor.");
                }
                else if (intento > numeroAleatorio)
                {
                    Console.WriteLine("Parece que es un número menor.");
                }
                else
                {
                    Console.WriteLine("¡¡¡¡¡¡¡EL NÚMERO ES CORRECTO!!!!!!!");
                }
            } while (true); //repite el programa


        }
    }
}
