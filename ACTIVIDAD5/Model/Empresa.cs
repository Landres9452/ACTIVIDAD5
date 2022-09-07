using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACTIVIDAD5.Model
{
    internal class Empresa : Entidad
    {
        public string Name { get; private set; }

        public string Direccion { get; private set; }

        public List<Coordinador> Coordinadores { get; private set; }

        public List<Empleado> Empleados{ get; private set; }


        private Empresa(int id, string Name, string direccion) : base(id)
        {
            Coordinadores = new List<Coordinador>();
            Empleados = new List<Empleado>();
            this.Name = Name;
            this.Direccion = direccion;

        }
        public static Empresa Build(int id, string Name, string direccion)
        {
            return new Empresa(id, Name, direccion);
        }

        public void AgregarCoordinadores(Coordinador coordinador)
        {
            this.Coordinadores.Add(coordinador);
        }

        public void AgregarEmpleados(Empleado empleado)
        {
            this.Empleados.Add(empleado);
        }
    }
}
