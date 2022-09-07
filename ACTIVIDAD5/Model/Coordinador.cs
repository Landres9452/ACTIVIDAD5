using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACTIVIDAD5.Model
{
    internal class Coordinador : Entidad
    {
       

        public string Name { get; private set; }
        public string Descripcion { get; private set; }
        public List<CoordinadorTrabajo> coordinadortrabajo { get; private set; }
        public Empresa empresa{ get; private set; }


        private Coordinador(int id, string name, Empresa empresa) : base(id)
        {
            if (id == null)
            {
                Console.WriteLine("El id  esta vacio no puede continuar");
            }
            this.Name = name;
            this.Descripcion = name;
            coordinadortrabajo = new();
            this.empresa = empresa;

        }

        public static Coordinador Build(int id, string description, Empresa empresa)
        {
            return new Coordinador(id, description, empresa);
        }

        public void AgregarTrabajo(string IdTrabajo)
        {
            this.coordinadortrabajo.Add(
                new CoordinadorTrabajo(this.Id, Guid.NewGuid().ToString(), IdTrabajo));

        }
    }
}
