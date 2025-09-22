using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoTaller
{
    public partial class FormModificarUsuario : Form
    {
        public FormModificarUsuario()
        {
            InitializeComponent();
        }

        private void cerrarFormModificarUsuario(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CargarTiposUsuario()
        {
            using (SqlConnection conn = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=Concesionaria;Integrated Security=True"))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT ID_Perfiles, Descripcion FROM Perfiles", conn);
                SqlDataReader dr = cmd.ExecuteReader();

                DataTable dt = new DataTable();
                dt.Load(dr);

                CBEditarPerfil.DataSource = dt;
                CBEditarPerfil.DisplayMember = "Descripcion";   // Lo que se ve en el combo
                CBEditarPerfil.ValueMember = "ID_Perfiles";     // El valor interno (clave primaria)
            }
        }

        private void cargarTiposDePerfilModificar(object sender, EventArgs e)
        {
            CargarTiposUsuario();
        }
    }
}
