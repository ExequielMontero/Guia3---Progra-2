using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Ejercicio_1
{
    internal class Presupuesto
    {

        ArrayList presupuestados = new ArrayList();
        public Presupuesto(string cliente, string direccion)
        {
            Cliente = cliente;
            Direccion = direccion;
        }

        public int CantidadProductos { get; private set; }
        public double CostoTotal { get; private set; }
        public string Cliente { get; set; }
        public string Direccion { get; set; }

        public void AgregarProducto(Producto obj)
        {
            presupuestados.Add(obj);
            CostoTotal += obj.PrecioBase;
            CantidadProductos++;
        }

        public Producto VerProducto(int idx)
        {
            Producto b;
            b = (Producto)presupuestados[idx];
            return b;
        }

    }
}
