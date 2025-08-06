using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pMatriculacionOnline
{
    public partial class frmRegistroEstudiantes : Form
    {
        public frmRegistroEstudiantes()
        {
            InitializeComponent();
        }

        private void frmRegistroEstudiantes_Load(object sender, EventArgs e)
        {

        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                string error = errorToolStripTextBox.Text;
                this.sp_mantenimiento_estudianteTableAdapter.Fill(this.matriculacionOnlineDataSet1.sp_mantenimiento_estudiante, opcionToolStripTextBox.Text, new System.Nullable<int>(((int)(System.Convert.ChangeType(idEstudianteToolStripTextBox.Text, typeof(int))))), nombreToolStripTextBox.Text, documentoIdentidadToolStripTextBox.Text, ref error);
            
            
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            // tu crees?
        }
    }
}
