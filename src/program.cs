using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main()
        {
            Iclima climaInicial = ClimaP();
            Itema tema = new TemaC();
            tema.Aplicar();
            string opcion;
            
            Console.WriteLine("=== CLIMA ACTUAL ===");
            MostrarClima(climaInicial);
            Console.ReadLine();
            do
            {

                Console.WriteLine("=== APP DEL CLIMA ===");
                Console.WriteLine("1) Soleado");
            Console.WriteLine("2) Lluvioso");
            Console.WriteLine("3) Nublado");
            Console.WriteLine("4) Tormenta");
            Console.WriteLine("5) Cambiar a modo oscuro");
            Console.WriteLine("6) Cambiar a modo claro");
            Console.WriteLine("0) Salir");

           
            
                Console.Write("\nElige opción: ");
                opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        MostrarClima(new Clima("Soleado", 28));
                       
                        break;

                    case "2":
                        MostrarClima(new Clima("Lluvioso", 19));
                        break;

                    case "3":
                        MostrarClima(new Clima("Nublado", 22));
                        break;

                    case "4":
                        MostrarClima(new Clima("Tormenta", 16));
                        break;

                    case "5":
                        tema = new TemaO(tema);
                        tema.Aplicar();
                        break;
                    case "6":
                        tema = new TemaC();
                        tema.Aplicar();
                        break;


                }
                
            } while (opcion != "0");
        }

        static void MostrarClima(Iclima clima)
        {
            Console.WriteLine($"\nClima: {clima.ObtenerEstado()}");
            Console.WriteLine($"Temperatura: {clima.ObtenerTemperatura()}°C");
        }


        private static Iclima ClimaP()
        {
            Random r = new Random();
            int opcion = r.Next(1, 5);  

            switch (opcion)
            {
                case 1: return new Clima("Soleado", 28);
                case 2: return new Clima("Lluvioso", 19);
                case 3: return new Clima("Nublado", 22);
                case 4: return new Clima("Tormenta", 16);
            }

            return new Clima("Desconocido", 0);
        }
    }
}
