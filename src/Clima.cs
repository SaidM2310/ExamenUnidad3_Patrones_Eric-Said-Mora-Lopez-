using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    public class Clima : Iclima
    {
        private EstadoClima estado;
        private int temperatura;

        public Clima(string tipoEstado, int temp)
        {
            estado = EstadoClimaFactory.ObtenerEstado(tipoEstado);
            temperatura = temp;
        }

        public string ObtenerEstado()
        {
            return estado.Nombre;
        }

        public string ObtenerTemperatura()
        {
            return temperatura.ToString() + "°C";
        }
    }


}
