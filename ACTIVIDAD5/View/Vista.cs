using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACTIVIDAD5.View
{
    internal interface Vista<Empleado>
    {
        void Render(Empleado empleado);
    }
}
