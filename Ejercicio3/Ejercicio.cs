using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    class Ejercicio
    {



        static void Main(string[] args)
        {
            // Al ejecutar el programa se debe inicializar la colección automátcamente al menos con 3 ttulos (usa una directva de compilación para controlar esto).



            bool repetir = true;
            while (repetir)
            {
                Console.WriteLine("1 - Insertar nuevo videojuego");
                Console.WriteLine("2 - Eliminar videojuegos");
                Console.WriteLine("3 - Visualizar toda la lista de videojuegos");
                Console.WriteLine("4 - Visualización de videojuegos por estilo");
                Console.WriteLine("5 - Modificar videojuego ");
                Console.WriteLine("6 - Salir");
                Console.WriteLine();
                Console.WriteLine("Cuál eliges?");
                int opcion = Convert.ToInt32(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        
                        break;

                    case 2:

                        break;

                    case 3:

                        break;

                    case 4:

                        break;

                    case 5:

                        break;

                    case 6:
                        repetir = false;
                        Console.WriteLine("Hasta luego!");
                        break;

                    default:
                        Console.WriteLine("Esa opción no existe, repite");
                        break;
                }
            }
        }
    }
}
