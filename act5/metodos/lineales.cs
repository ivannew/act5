using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace act5.metodos
{
    internal class lineales
    {
        public void Trabajo1()
        {
            {
                int[] numeros = { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 };

                Console.Write("Ingrese un número a buscar: ");
                int numeroBuscado = int.Parse(Console.ReadLine());

                int posicion = BuscarNumero(numeros, numeroBuscado);

                if (posicion != -1)
                    Console.WriteLine($"El número {numeroBuscado} se encuentra en la posición {posicion}.");
                else
                    Console.WriteLine($"El número {numeroBuscado} no se encuentra en la matriz.");
            }

       
        }
       public int BuscarNumero(int[] numeros, int numeroBuscado)
        {
            for (int i = 0; i < numeros.Length; i++)
            {
                if (numeros[i] == numeroBuscado)
                {
                    return i;
                }
            }
            return -1;
        }
        public void Trabajo2()
        {
            {
                string[] cadenas = { "Manzana", "Banana", "Cereza", "Damasco", "Uva" };

                Console.Write("Ingrese una cadena a buscar: ");
                string cadenaBuscada = Console.ReadLine();

                int posicion = BuscarCadena(cadenas, cadenaBuscada);

                if (posicion != -1)
                    Console.WriteLine($"La cadena '{cadenaBuscada}' se encuentra en la posición {posicion}.");
                else
                    Console.WriteLine($"La cadena '{cadenaBuscada}' no se encuentra en la matriz.");
            }

           
        }
        public int BuscarCadena(string[] cadenas, string cadenaBuscada)
        {
            for (int i = 0; i < cadenas.Length; i++)
            {
                if (cadenas[i] == cadenaBuscada)
                {
                    return i;
                }
            }
            return -1;
        }
        public void Trabajo3()
        {
            {
                int[] numeros = { 3, 5, 8, 11, 14, 20, 29, 36, 40, 47 };

                int posicion = BuscarNumeroPar(numeros);

                if (posicion != -1)
                    Console.WriteLine($"El primer número par se encuentra en la posición {posicion}.");
                else
                    Console.WriteLine("No se encontraron números pares en la matriz.");
            }

          
        }
        public int BuscarNumeroPar(int[] numeros)
        {
            for (int i = 0; i < numeros.Length; i++)
            {
                if (numeros[i] % 2 == 0)
                {
                    return i;
                }
            }
            return -1;
        }
        public void Trabajo4()
        {
            {
                int[] numeros = { 3, 5, 8, 11, 14, 20, 29, 36, 40, 47 };

                BuscarNumerosPares(numeros);
            }

            
        }
        public void BuscarNumerosPares(int[] numeros)
        {
            Console.WriteLine("Posiciones de números pares en la matriz:");
            for (int i = 0; i < numeros.Length; i++)
            {
                if (numeros[i] % 2 == 0)
                {
                    Console.WriteLine($"Número par {numeros[i]} en la posición {i}");
                }
            }
        }
    }
}
