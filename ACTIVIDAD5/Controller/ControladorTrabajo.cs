using ACTIVIDAD5.Model;
using ACTIVIDAD5.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACTIVIDAD5.Controller
{
    internal class ControladorTrabajo
    {
        private Vista<Empleado> vista;

        public ControladorTrabajo(Vista<Empleado> view)
        {
            this.vista = vista;
        }

        public void Crear(int id, int cedula, Empresa empresa)
        {
            Empleado empleado;

            empleado = Empleado.Build(id, cedula, empresa);

            vista.Render(empleado);
        }
    }
}
