using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PYFORO4
{
   public  class ArrDocente
    {
        public List<Docente> arrDocente = new List<Docente>();
        public void insertarDocente(int codigodocente, string nombredocente, int edad)
        {
            Docente nuevo = new Docente(codigodocente, nombredocente, edad);
            arrDocente.Add(nuevo);
        }
        public int buscardocentecodigo(int codigo)
        {
            for (int i = 0; i < arrDocente.Count(); i++)
            {
                if (arrDocente[i].codigodocente == codigo)
                    return i;
            }
            return -1;
        }
    }
}
