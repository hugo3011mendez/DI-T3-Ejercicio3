using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    public class Videojuego
    {
        string titulo { set; get; }
        public int anho { set; get; }
        public enum Estilo
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
