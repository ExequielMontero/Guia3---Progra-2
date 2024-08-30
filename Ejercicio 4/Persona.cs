using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_4
{
    internal abstract class Persona
    {
        public Persona(string apellidosNombre)
        {
            ApellidosNombre = apellidosNombre;
        }

        public string ApellidosNombre { get; set; }

    }
}
