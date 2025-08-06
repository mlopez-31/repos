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
    public partial class Reasignación___Seleccionar_Cuenta_Única : SoftBase
    {
        public Reasignación___Seleccionar_Cuenta_Única()
        {
            InitializeComponent();

            base.ConstruyeBotonBarra(btnSalir, Boton.Salir);
            base.ConstruyeBotonBarra(btnMostrarMas, Boton.Siguiente);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {

            Close();
           
        }

        
    }
}
