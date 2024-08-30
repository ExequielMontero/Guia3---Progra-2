using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Ejercicio_4
{
    internal class Prestador : Persona
    {
        ArrayList consultas = new ArrayList();

        public Prestador(string apellidosNombre) : base(apellidosNombre)
        {
        }

        public void AgregarConsulta(Prestacion consulta)
        {
            consultas.Add(consulta);
        }

        public double GenerarPago()
        {

        }
    }
}
