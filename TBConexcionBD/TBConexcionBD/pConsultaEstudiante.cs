using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Globalization;
using System.Text.RegularExpressions;
using ts.Client;

namespace TBConexcionBD
{
    public partial class pConsultaEstudiante : SoftBase
    {
        static string conexionstring = "server= localhost; database= MatriculacionOnline ; integrated security = true ";
        SqlConnection conexion = new SqlConnection(conexionstring);

        public pConsultaEstudiante()
        {
            InitializeComponent();
            base.ConstruyeBotonBarra(btnSalir, Boton.Salir);
            base.ConstruyeBotonBarra(btnRegistrarEstudiante, Boton.Nuevo);

            conexion.Open();
            MessageBox.Show("La conexion a la BD: " + conexion.Database + " ha sido exitosa");

            // Capturar el evento "Enter" para el TextBox
            txt_Consulta.KeyDown += new KeyEventHandler(txt_Consulta_KeyDown);
        }

        // Función para eliminar tildes
        public static string EliminarTildes(string texto)
        {
            var normalizedString = texto.Normalize(NormalizationForm.FormD);
            var stringBuilder = new StringBuilder();

            foreach (var c in normalizedString)
            {
                if (CharUnicodeInfo.GetUnicodeCategory(c) != UnicodeCategory.NonSpacingMark)
                {
                    stringBuilder.Append(c);
                }
            }

            return stringBuilder.ToString().Normalize(NormalizationForm.FormC);
        }

        private void btnConsulta_Click(object sender, EventArgs e)
        {
            BuscarEstudiantes();
        }

        // Método que realiza la búsqueda
        private void BuscarEstudiantes()
        {
            string query;

            // Eliminar tildes del texto que ingresó el usuario
            string textoConsulta = EliminarTildes(txt_Consulta.Text);

            if (string.IsNullOrWhiteSpace(textoConsulta))
            {
                query = "SELECT * FROM Estudiantes";
                SqlCommand comando = new SqlCommand(query, conexion);
                SqlDataAdapter data = new SqlDataAdapter(comando);
                DataTable tabla = new DataTable();
                data.Fill(tabla);
                dgvConsultar.DataSource = tabla;
            }
            else
            {
                // Colocamos la colación insensible a acentos
                query = "SELECT * FROM Estudiantes WHERE nombre COLLATE Latin1_General_CI_AI LIKE @Busqueda";

                SqlCommand comando = new SqlCommand(query, conexion);
                comando.Parameters.AddWithValue("@Busqueda", "%" + textoConsulta + "%");

                SqlDataAdapter data = new SqlDataAdapter(comando);
                DataTable tabla = new DataTable();
                data.Fill(tabla);
                dgvConsultar.DataSource = tabla;
            }
        }

        // Manejar la tecla Enter en el TextBox
        private void txt_Consulta_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)  // Si se presiona Enter
            {
                e.SuppressKeyPress = true; // Evita el "ding" al presionar Enter
                BuscarEstudiantes();  // Llamar al método para buscar
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnRegistrarEstudiante_Click(object sender, EventArgs e)
        {
            pRegistrarEstudiante form = new pRegistrarEstudiante();
            DialogResult formDialog = form.ShowDialog();
        }
    }
}



