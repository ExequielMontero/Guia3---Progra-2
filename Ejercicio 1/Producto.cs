using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1
{
    internal abstract class Producto
    {
        protected string descripcion;

        public Producto(string descripcion, double precioBase, int tipoMaterial)
        {
            this.descripcion = descripcion;
            PrecioBase = precioBase;
            TipoMaterial = tipoMaterial;
        }

        public double PrecioBase { get; protected set; }
        public int TipoMaterial { get; protected set; }

        public abstract double CalcularPrecio();
        public abstract string VerDetalle();

          
    }
}
