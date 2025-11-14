using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    public class TemaD : Itema
    {
        protected Itema _tema;

        public TemaD(Itema tema)
        {
            _tema = tema ?? throw new ArgumentNullException(nameof(tema));
        }

        public virtual void Aplicar()
        {
            _tema.Aplicar();
        }

    }
}
