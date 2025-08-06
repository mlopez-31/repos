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
    public partial class Reasignación_Masiva___Búsqueda_General : SoftBase
    {
        public Reasignación_Masiva___Búsqueda_General()
        {
            InitializeComponent();
            base.ConstruyeBotonBarra(btnSalir, Boton.Salir);
            base.ConstruyeBotonBarra(btnMostrarMas, Boton.Siguiente);
            base.ConstruyeBotonBarra(btnReasignar, Boton.Aprobar2);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            Close();
        }
    }
}
