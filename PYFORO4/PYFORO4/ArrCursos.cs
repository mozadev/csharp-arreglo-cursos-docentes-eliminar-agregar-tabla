using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PYFORO4
{
    public class ArrCursos
    {
        public List<Curso> arrCursos = new List<Curso>();
        public void insertarCurso(int codigocurso, string nombrecurso, int creditos)
        {
            Curso nuevo = new Curso(codigocurso, nombrecurso, creditos);
            arrCursos.Add(nuevo);
        }
        public int buscarcursocodigo(int codigo)
        {
            for (int i = 0; i < arrCursos.Count(); i++)
            {
                if (arrCursos[i].codigocurso == codigo)
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
