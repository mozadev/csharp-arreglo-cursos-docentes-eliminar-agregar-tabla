using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PYFORO4
{
    public class Curso
    {
         public int codigocurso { get; set; }
        public string nombrecurso { get; set; }
        public int creditos { get; set; }
        public Curso(int codigocurso, string nombrecurso, int creditos)
        {
            this.codigocurso = codigocurso;
            this.nombrecurso = nombrecurso;
            this.creditos = creditos;
        }
    }
}
