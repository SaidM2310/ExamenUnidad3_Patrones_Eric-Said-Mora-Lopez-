using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    public class TemaO : TemaD
    {
        public TemaO(Itema tema) : base(tema) { }

        public override void Aplicar()
        {
            base.Aplicar();
            Console.BackgroundColor = ConsoleColor.DarkBlue; 
            Console.ForegroundColor = ConsoleColor.White;   
            Console.Clear();

        }
    }
}
