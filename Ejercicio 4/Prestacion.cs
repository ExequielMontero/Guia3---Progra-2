using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_4
{
    internal abstract class Prestacion:Persona
    {
        protected Prestacion(string nombremedico, string apellidosNombre) : base(apellidosNombre)
        {
            Medico = nombremedico;
        }

        public string Medico { get; protected set; }
        public double MontoTotal { get; private set; }

        abstract public double PrestarServicio();

    }
}
