using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    class Videojuego
    {
        string titulo { set; get; }
        int anho { set; get; }
        enum Estilo
        {
            Arcade,
            Videoaventura,
            Shootemup,
            Estrategia,
            Deportivo, 
            Survival,
            Terror,
            Sandbox,
            RPG,
            MOBA
        }
    }
}
