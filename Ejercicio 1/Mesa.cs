using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1
{
    internal class Mesa:Producto
    {
        double largo;

        public Mesa(string descripcion, double precioBase, int tipoMaterial, double largo) : base(descripcion, precioBase, tipoMaterial)
        {
            this.largo = largo;
        }


        public override double CalcularPrecio()
        {
            return (PrecioBase * largo) * (1 + TipoMaterial * 0.33);
        }

        public override string VerDetalle()
        {
            string act="";
            if (TipoMaterial == 0)
            {
                act = "Pino";
            }
            else if(TipoMaterial == 1)
            {
                act = "Algarrobo";
            }
            else if (TipoMaterial == 2)
            {
                act = "Caoba"; 
            }


            return $"Material: {act}, Precio Base: {PrecioBase}$, Largo: {largo}, Descripcion: {descripcion}";
        }
    }   
}
