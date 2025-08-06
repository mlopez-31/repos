using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ts.Client;

namespace Reasignación_Oficina_Y_Promotor
{
    public partial class Form1 : SoftBase
    {

        public Form1()
        {
            InitializeComponent();

            base.ConstruyeBotonBarra(btnSalir, Boton.Salir);
            base.ConstruyeBotonBarra(btnBuscar, Boton.Buscar);
            base.ConstruyeBotonBarra(btnLimpiar, Boton.Limpiar);
            base.ConstruyeBotonBarra(btnReasignar, Boton.Aprobar2);
            base.ConstruyeBotonBarra(btnBitacora, Boton.ArchivoPlano);


            ActivarTodosBotones();

        }

        private void ActivarTodosBotones()
        {
            //btnSalir.Enabled = true;
            btnBuscar.Enabled = true;
            btnLimpiar.Enabled = true;
            btnReasignar.Enabled = true;
            btnBitacora.Enabled = true;
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            
            ComboBox comboBox1 = new ComboBox();
            //comboBox1.Items.Add("Reasignación por Cuenta");
            //comboBox1.Items.Add("Reasignación Masiva");
            //cboProceso.Items.Add("Seleccione una opción");
            cboProceso.Items.Add("Reasignación por Cuenta");
            cboProceso.Items.Add("Reasignación Masiva");
            cboProceso.SelectedIndex = 0;
        }


        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (chbxNombre.Checked)
            {
                chbxCuenta.Enabled = false;
                groupBox3.Enabled = false;
            }

            else
            {
                chbxCuenta.Enabled = true;
                groupBox3.Enabled = true;
            }
        }
     

        private void chbxCuenta_CheckedChanged(object sender, EventArgs e)
        {
            if (chbxCuenta.Checked)
            {
                groupBox4.Enabled = false;
                chbxNombre.Enabled = false;
            }

            else
            {
                groupBox4.Enabled = true;
                chbxNombre.Enabled = true;
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnImportarDatos_Click(object sender, EventArgs e)
        {

        }

        private void gpbReasignacionMasiva_Enter(object sender, EventArgs e)
        {

        }



        private void cboProceso_SelectedIndexChanged(object sender, EventArgs e)
        {
            

            
            //if (cboProceso.SelectedIndex == 0)
            //{
            //    btnBuscar.Enabled = true;
            //    btnLimpiar.Enabled = true;
            //    btnReasignar.Enabled = true;
            //    btnBitacora.Enabled = true;
            //}

            if (cboProceso.SelectedIndex == 0)
            {
                gpbReasignacionPorCuenta.Enabled = true;
                gpbReasignacionMasiva.Enabled = false;

                //solo activa el boton Aprobar2
                btnReasignar.Enabled = true;
               
                //btnSalir.Enabled = false;
                btnBuscar.Enabled = false;
                btnLimpiar.Enabled = false;
                btnBitacora.Enabled = false;

                //btnSalir.Enabled = true;
                btnBuscar.Enabled = false;
                btnLimpiar.Enabled = false;
                btnReasignar.Enabled = true;
                btnBitacora.Enabled = false;
            }
            if (cboProceso.SelectedIndex == 1)
            {
                gpbReasignacionPorCuenta.Enabled = false;
                gpbReasignacionMasiva.Enabled = true;

                //btnSalir.Enabled = true;
                btnBuscar.Enabled = true;
                btnLimpiar.Enabled = true;
                btnReasignar.Enabled = false;
                btnBitacora.Enabled = true;
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (cboProceso.SelectedIndex == 0)
            {
                Reasignación___Seleccionar_Cuenta_Única form = new Reasignación___Seleccionar_Cuenta_Única();
                DialogResult formDialog = form.ShowDialog();
            }
            else if (cboProceso.SelectedIndex == 1)
            {
                //aqui va ir la nueva pantalla
                Reasignación_Masiva___Búsqueda_General form = new Reasignación_Masiva___Búsqueda_General();
                DialogResult formDialog = form.ShowDialog();

            }
        }

        private void txtPrimerNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                // Convertir a mayúsculas al momento de escribir
                e.KeyChar = char.ToUpper(e.KeyChar);
            }
            else if (!char.IsControl(e.KeyChar))
            {
                // Bloquear todo lo que no sea letra o tecla de control
                e.Handled = true;
            }
        }

        private void txtSegundoNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.KeyChar = char.ToUpper(e.KeyChar);
            }
            else if (!char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnBitacora_Click(object sender, EventArgs e)
        {
            //Reasignación_Masiva___Búsqueda_General form = new Reasignación_Masiva___Búsqueda_General();
               // DialogResult formDialog = form.ShowDialog();

        }
    }
}
