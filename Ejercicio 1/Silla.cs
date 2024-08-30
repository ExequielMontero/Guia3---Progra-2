using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1
{
    internal class Silla : Producto
    {
        public Silla(string descripcion, double precioBase, int tipoMaterial) : base(descripcion, precioBase, tipoMaterial)
        {
        }

        public override string VerDetalle()
        {
            string act = "";
            if (TipoMaterial == 0)
            {
                act = "Pino";
            }
            else if (TipoMaterial == 1)
            {
                act = "Algarrobo";
            }
            else if (TipoMaterial == 2)
            {
                act = "Caoba";
            }


            return $"Material: {act}, Precio Base: {PrecioBase}$, Descripcion: {descripcion}";
        }



        public override double CalcularPrecio()
        {
            return (PrecioBase * (1 + TipoMaterial * 0.25));        
        }
    }
}
