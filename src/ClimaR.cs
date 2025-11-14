using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    public class ClimaR: Iclima
    {
        private Random rand = new Random();

        public string ObtenerTemperatura()
        {
            return rand.Next(18, 35) + "°C";
        }

        public string ObtenerEstado()
        {
            string[] estados = { "Soleado", "Lluvioso", "Nublado", "Tormenta" };
            return estados[rand.Next(estados.Length)];
        }
    }
}
