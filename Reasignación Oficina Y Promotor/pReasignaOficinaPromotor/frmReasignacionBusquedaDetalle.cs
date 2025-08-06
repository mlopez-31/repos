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

namespace pReasignaOficinaPromotor
{
    public partial class ReasignaciónMasiva_BúsquedaDetalle : SoftBase
    {
        public ReasignaciónMasiva_BúsquedaDetalle()
        {
            InitializeComponent();
            base.ConstruyeBotonBarra(btnSalir, Boton.Salir);
            base.ConstruyeBotonBarra(btnBuscar, Boton.Buscar);
            base.ConstruyeBotonBarra(btnLimpiar, Boton.Limpiar);
            base.ConstruyeBotonBarra(btnReasignar, Boton.Aprobar2);
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ReasignaciónMasiva_BúsquedaDetalle_Load(object sender, EventArgs e)
        {
            
                // Esto hace que la última columna ocupe el espacio sobrante
               // listView1.Columns[listView1.Columns.Count - 1].Width = -2;
            
        }
    }
}
