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
    public partial class FormPrincipalClientes : Form
    {
        private int ultimoID = 0;
        public FormPrincipalClientes()
        {
            InitializeComponent();
        }

        private void AbrirFormularioAgregarClientes(object sender, EventArgs e)
        {
            FormAgregarClientes formAgregar = new FormAgregarClientes(this); // this = form principal
            formAgregar.Show(); //
        }

        public void agregarFilaCleinte(string nombre, string apellido, int dni, string email, string telefono, string direccion, DateTime fechaDeNacimiento)
        {
            int id = ultimoID; // ID como int
            string activo = "SI";
            string fecha = fechaDeNacimiento.ToShortDateString();

            DGVClientes.Rows.Add(id, nombre, apellido, dni, email, telefono, direccion, fecha, activo);

            ultimoID++;
        }

        private void bajaCliente(object sender, EventArgs e)
        {
            if (DGVClientes.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow fila in DGVClientes.SelectedRows)
                {
                    // Cambiamos el valor de la columna "Activo" a "NO"
                    fila.Cells["ActivoColumna"].Value = "NO";

                    // Pintamos la fila de rojo
                    fila.DefaultCellStyle.BackColor = Color.Red;
                }
            }
            else
            {
                MessageBox.Show("Selecciona un usuario primero.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void activarCliente(object sender, EventArgs e)
        {
            if (DGVClientes.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow fila in DGVClientes.SelectedRows)
                {
                    // Cambiamos el valor de la columna "Activo" a "NO"
                    fila.Cells["ActivoColumna"].Value = "SI";

                    // Pintamos la fila de rojo
                    fila.DefaultCellStyle.BackColor = Color.White;
                }
            }
            else
            {
                MessageBox.Show("Selecciona un usuario primero.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void modificarCliente(object sender, EventArgs e)
        {
            if (DGVClientes.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Selecciona un cliente para modificar");
                return;
            }

            // Obtenemos la fila seleccionada
            DataGridViewRow filaSeleccionada = DGVClientes.SelectedRows[0];

            // Abrimos el form de agregar cliente pasando la fila
            FormAgregarClientes formModificar = new FormAgregarClientes(filaSeleccionada);
            formModificar.Show();
        }
    }
}
