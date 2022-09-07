using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACTIVIDAD5.Model
{
    internal class CoordinadorTrabajo : Entidad
    {
        public string IdTrabajo { set; private get; }
        public string IdCoordinador { set; private get; }

        public CoordinadorTrabajo(int id, string idTrabajo, string idCoordinador): base(id)
        {
            IdTrabajo = idTrabajo;
            IdCoordinador = idCoordinador;
        }
    }
}
