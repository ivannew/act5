using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace act5.metodos
{
    internal class Binarios
    {
        public void binario1()
        {
            int[] arregloEnteros = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            Console.Write("Ingrese el número a buscar: ");
            int objetivo = Convert.ToInt32(Console.ReadLine());

            int izquierda = 0;
            int derecha = arregloEnteros.Length - 1;
            int resultado = -1;

            while (izquierda <= derecha)
            {
                int medio = izquierda + (derecha - izquierda) / 2;

                if (arregloEnteros[medio] == objetivo)
                {
                    resultado = medio;
                    break;
                }
                else if (arregloEnteros[medio] < objetivo)
                {
                    izquierda = medio + 1;
                }
                else
                {
                    derecha = medio - 1;
                }
            }

            if (resultado != -1)
            {
                Console.WriteLine("El número se encuentra en la posición " + resultado);
            }
            else
            {
                Console.WriteLine("El número no está en el arreglo.");
            }
        }
        public void binario2()
        {
            string[] arregloCadenas = { "manzana", "banana", "cereza", "dátil", "uva", "zarzamora" };

            Console.Write("Ingrese la cadena a buscar: ");
            string objetivo = Console.ReadLine();

            int izquierda = 0;
            int derecha = arregloCadenas.Length - 1;
            int resultado = -1;

            while (izquierda <= derecha)
            {
                int medio = izquierda + (derecha - izquierda) / 2;
                int comparacion = string.Compare(arregloCadenas[medio], objetivo, StringComparison.OrdinalIgnoreCase);

                if (comparacion == 0)
                {
                    resultado = medio;
                    break;
                }
                else if (comparacion < 0)
                {
                    izquierda = medio + 1;
                }
                else
                {
                    derecha = medio - 1;
                }
            }

            if (resultado != -1)
            {
                Console.WriteLine("La cadena se encuentra en la posición " + resultado);
            }
            else
            {
                Console.WriteLine("La cadena no está en el arreglo.");
            }
        }

        public void binario3()
        {
            int[] arregloEnteros = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            int izquierda = 0;
            int derecha = arregloEnteros.Length - 1;
            int posicion = -1;

            while (izquierda <= derecha)
            {
                int medio = izquierda + (derecha - izquierda) / 2;

                if (arregloEnteros[medio] % 2 == 0)
                {
                    posicion = medio;
                    derecha = medio - 1; // Buscar más a la izquierda para encontrar el primer número par.
                }
                else
                {
                    izquierda = medio + 1;
                }
            }

            if (posicion != -1)
            {
                Console.WriteLine("La posición del primer número par es " + posicion);
            }
            else
            {
                Console.WriteLine("No se encontró ningún número par en el arreglo.");
            }
        }
    }
}
