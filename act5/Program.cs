using act5.metodos;

namespace act5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            lineales miBusqueda = new lineales();

            Console.WriteLine("Trabajo 1 - Búsqueda Lineal en una Lista de Enteros:");
            miBusqueda.Trabajo1();

            Console.WriteLine("\nTrabajo 2 - Búsqueda Lineal en un Arreglo de Cadenas:");
            miBusqueda.Trabajo2();

            Console.WriteLine("\nTrabajo 3 - Búsqueda Lineal para Encontrar un Número Par en un Arreglo de Números Enteros:");
            miBusqueda.Trabajo3();

            Console.WriteLine("\nTrabajo 4 - Búsqueda Lineal para Encontrar Todos los Números Pares en una Matriz de Números Enteros:");
            miBusqueda.Trabajo4();
        }
    }
}