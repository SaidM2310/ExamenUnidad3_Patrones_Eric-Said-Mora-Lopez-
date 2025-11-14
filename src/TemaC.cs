using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    public class TemaC: Itema
    {
        public virtual void Aplicar()
        {
            Console.BackgroundColor = ConsoleColor.Cyan;   
            Console.ForegroundColor = ConsoleColor.Black;  
            Console.Clear(); ;
        }
    }
}
