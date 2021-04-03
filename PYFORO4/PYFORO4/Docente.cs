using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PYFORO4
{
    public class Docente
    {
         public int codigodocente { get; set; }
        public string nombredocente { get; set; }
        public int edad { get; set; }
        public Docente(int codigodocente, string nombredocente, int edad)
        {
            this.codigodocente = codigodocente;
            this.nombredocente = nombredocente;
            this.edad = edad;
        }

    }
}
