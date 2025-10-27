using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoTaller
{
    public partial class FormControlesCruzados : Form
    {
        private DataTable tablaDatos;
        private FormPrincipalVentasSupervisor formPadre;

        public FormControlesCruzados(FormPrincipalVentasSupervisor formPadre)
        {
            InitializeComponent();
            this.formPadre = formPadre;
            this.tablaDatos = (DataTable)this.formPadre.DGVentasSupervisor.DataSource;
            this.CalcularControlesCruzados();
        }

        private void CalcularControlesCruzados()
        {
            this.VendedorConMasVentas();
            this.VendedorQueMasRecaudo();
            this.AutoMasVendido();
        }

        private void VendedorConMasVentas()
        {
            var dt = tablaDatos;

            var ventasUnicas = dt.AsEnumerable()
            .GroupBy(r => r.Field<int>("ID_Venta"))
            .Select(g =>
                {
                   var row = g.First();
                   return new
                   {
                       ID_Venta = g.Key,
                       Vendedor = row.Field<string>("Vendedor")
                   };
                });

            // Ahora agrupamos por vendedor y contamos ventas únicas
            var vendedorTop = ventasUnicas
                .GroupBy(v => v.Vendedor)
                .Select(g => new
                {
                    Vendedor = g.Key,
                    Cantidad = g.Count()
                })
                .OrderByDescending(x => x.Cantidad)
                .FirstOrDefault();

            if (vendedorTop != null)
            {
                this.LVCMV.Text = vendedorTop.Vendedor.ToString();
                this.label8.Text = vendedorTop.Cantidad.ToString();
            }
            else
            {
                this.LVCMV.Text = "**faltan datos**";
                this.label8.Text = "**faltan datos**";
            }
        }

        private void VendedorQueMasRecaudo()
        {
            var dt = tablaDatos;

            var vendedorTop = dt.AsEnumerable()
                .GroupBy(row => row.Field<string>("Vendedor"))
                .Select(g => new
                {
                    Vendedor = g.Key,
                    Total = g.Sum(r => r.Field<decimal>("Monto_Total"))
                })
                .OrderByDescending(x => x.Total)
                .FirstOrDefault();

            if (vendedorTop != null)
            {
                this.label9.Text = vendedorTop.Vendedor.ToString();
                this.label10.Text = vendedorTop.Total.ToString();
            }
            else
            {
                this.label9.Text = "**faltan datos**";
                this.label10.Text = "**faltan datos**";
            }
        }

        private void AutoMasVendido()
        {
            var dt = tablaDatos;

            var autoTop = dt.AsEnumerable()
                .GroupBy(row => row.Field<string>("Auto"))
                .Select(g => new
                {
                    Auto = g.Key,
                    Cantidad = g.Sum(r => Convert.ToInt32(r["Cantidad"]))
                })
                .OrderByDescending(x => x.Cantidad)
                .FirstOrDefault();

            if (autoTop != null)
            {
                this.label11.Text = autoTop.Auto.ToString();
                this.label12.Text = autoTop.Cantidad.ToString();
            }
            else
            {
                this.label11.Text = "**faltan datos**";
                this.label12.Text = "**faltan datos**";
            }
        }

        private void BCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BActualizar_Click(object sender, EventArgs e)
        {
            this.tablaDatos = (DataTable)this.formPadre.DGVentasSupervisor.DataSource;
            this.CalcularControlesCruzados();
        }
    }
}
