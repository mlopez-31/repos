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
namespace pBitácora
{
    public partial class Reasignación_Bitácora : SoftBase
    {
        public Reasignación_Bitácora()
        {
            InitializeComponent();
            base.ConstruyeBotonBarra(btnSalir, Boton.Salir);
            base.ConstruyeBotonBarra(btnBuscar, Boton.Buscar);
            base.ConstruyeBotonBarra(btnMostrarMas, Boton.Siguiente);
            ConstruyeBotonBarra(this.btnActualizar, Boton.Actualizar);
            ConstruyeBotonBarra(this.tsbLimpiar, Boton.Limpiar);
        }

        private void Reasignación_Bitácora_Load(object sender, EventArgs e)
        {
            txtHoraDesde.Format = DateTimePickerFormat.Custom;
            txtHoraDesde.CustomFormat = "HH:mm:ss";

            txtHoraHasta.Format = DateTimePickerFormat.Custom;
            txtHoraHasta.CustomFormat = "HH:mm:ss";

        }

        private void fechas1_Load(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tsbLimpiar_Click(object sender, EventArgs e)
        {
            //Limpiar();
        }

      

        private void dtpFechaDesde_ValueChanged_1(object sender, EventArgs e)
        {
            txtHoraDesde.Enabled = dtpFechaDesde.Checked;
        }


        private void dtpFechaHasta_ValueChanged_1(object sender, EventArgs e)
        {
            txtHoraHasta.Enabled = dtpFechaHasta.Checked;
        }

        
    }
}
