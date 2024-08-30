using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_1
{
    public partial class Form1 : Form
    {
        Datos_del_Prodcto cargar = new Datos_del_Prodcto();
        Datos cliente = new Datos();
        Resultados resultados = new Resultados();
        Presupuesto actual;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPrueba_Click(object sender, EventArgs e)
        {
          
        }

        private void btnPresupuesto_Click(object sender, EventArgs e)
        {
            if(cliente.ShowDialog() == DialogResult.OK)
            {
                string Nombre = cliente.tbNombre.Text;
                string Direccion = cliente.tbDireccion.Text;
                actual = new Presupuesto(Nombre, Direccion);
                btnPresupuesto.Enabled = false;
                btnAgregar.Enabled = true;
                btnPresu.Enabled = true;
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (cargar.ShowDialog() == DialogResult.OK)
            {
                int producto = cargar.cmbTipo.SelectedIndex;
                double largo = Convert.ToDouble(cargar.tbLargo.Text);
                string desc = cargar.tbDesc.Text;
                double precio = Convert.ToDouble(cargar.tbPrecio.Text);
                int material = cargar.cmbMaterial.SelectedIndex;

                if (producto == 0)
                {
                    actual.AgregarProducto(new Mesa(desc, precio, material, largo));
                }
                else if (producto == 1)
                {
                    actual.AgregarProducto(new Silla(desc, precio, material));
                }
            }
            cargar.cmbTipo.SelectedIndex = -1;
            cargar.tbLargo.Clear();
            cargar.tbDesc.Clear();
            cargar.tbPrecio.Clear();
            cargar.cmbMaterial.SelectedIndex = -1;
        }

        private void btnPresu_Click(object sender, EventArgs e)
        {
            resultados.tbResult.Clear();
            Producto b;
            resultados.tbResult.Text += $"-Cliente: {actual.Cliente}\r\n-Direccion: {actual.Direccion}\r\n";
            for(int i=0; i < actual.CantidadProductos; i++)
            {
                b = actual.VerProducto(i);
                resultados.tbResult.Text += $"*{b.VerDetalle()}\r\n";
            }

            resultados.ShowDialog();
        }
    }
}
