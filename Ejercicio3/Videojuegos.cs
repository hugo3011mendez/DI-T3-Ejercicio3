using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    class Videojuegos
    {
        public List<Videojuego> coleccionVideojuegos = new List<Videojuego>();

        public int Posicion(int anho)
        {
            for (int i = 0; i < coleccionVideojuegos.Count; i++)
            {
                if (anho > coleccionVideojuegos[i].anho)
                {
                    return i;
                }
            }

            return -1;
        }


        public bool Eliminar(int posMinima, int posMaxima)
        {
            for (int i = posMinima; i <= posMaxima; i++)
            {
                coleccionVideojuegos.RemoveAt(i);
            }

            if (posMinima < 0 || posMaxima > coleccionVideojuegos.Count-1)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public bool Eliminar(int posMaxima)
        {
            int posMinima = 0;

            for (int i = posMinima; i <= posMaxima; i++)
            {
                coleccionVideojuegos.RemoveAt(i);
            }

            if (posMaxima > coleccionVideojuegos.Count - 1)
            {
                return false;
            }
            else
            {
                return true;
            }
        }


        public List<Videojuego> Busqueda(Videojuego.Estilo)
        {
            
        }
    }
}
