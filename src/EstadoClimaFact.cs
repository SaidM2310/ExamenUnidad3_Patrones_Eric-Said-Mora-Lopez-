using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    public static class EstadoClimaFactory
    {
        private static Dictionary<string, EstadoClima> estados = new Dictionary<string, EstadoClima>();

        public static EstadoClima ObtenerEstado(string tipo)
        {
            if (!estados.ContainsKey(tipo))
            {
                estados[tipo] = new EstadoClima(tipo);
            }

            return estados[tipo];
        }

    }
}
