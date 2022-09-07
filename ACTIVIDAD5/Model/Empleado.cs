using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACTIVIDAD5.Model
{
    internal class Empleado : Entidad
    {
        public int Cedula { get; private set; }
        public List<CoordinadorTrabajo> coordinadortrabajo { get; private set; }

        public Empresa Empresa { get; private set; }


        private Empleado(int id, int cedula, Empresa empresa) : base(id)
        {
            if (id == null)
            {
                Console.WriteLine("El id  esta vacio no puede continuar");
            }
            Cedula = cedula;
            coordinadortrabajo = new();
            Empresa = empresa;
        }

        public static Empleado Build(int id, int cedula, Empresa empresa)
        {
            return new Empleado(id, cedula, empresa);
        }

        public void AgregarCoordinador(string IdCoordinador)
        {
            this.coordinadortrabajo.Add(
                new CoordinadorTrabajo(this.Id, Guid.NewGuid().ToString(), IdCoordinador));
        }
    }
}
