using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstructuraMVVM.Model
{
    public class Tarea
    {
        public string Titulo { get; set; }

        public string Descripcion { get; set; }

        public string Persona { get; set; }

        public DateTime FechaLimite { get; set; }
    }
}
