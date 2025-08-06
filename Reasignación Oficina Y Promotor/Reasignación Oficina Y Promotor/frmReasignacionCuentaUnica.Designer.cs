
namespace Reasignación_Oficina_Y_Promotor
{
    partial class Reasignación___Seleccionar_Cuenta_Única
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reasignación___Seleccionar_Cuenta_Única));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tlpBarraNavegacion = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnSalir = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnMostrarMas = new System.Windows.Forms.ToolStripButton();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.ltvTablaDatos = new System.Windows.Forms.ListView();
            this.tableLayoutPanel1.SuspendLayout();
            this.tlpBarraNavegacion.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tlpBarraNavegacion, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(826, 27);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // tlpBarraNavegacion
            // 
            this.tlpBarraNavegacion.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1,
            this.btnSalir,
            this.toolStripSeparator2,
            this.btnMostrarMas});
            this.tlpBarraNavegacion.Location = new System.Drawing.Point(0, 0);
            this.tlpBarraNavegacion.Name = "tlpBarraNavegacion";
            this.tlpBarraNavegacion.Size = new System.Drawing.Size(826, 25);
            this.tlpBarraNavegacion.TabIndex = 0;
            this.tlpBarraNavegacion.Text = "toolStrip1";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // btnSalir
            // 
            this.btnSalir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(23, 22);
            this.btnSalir.Text = "Salir";
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // btnMostrarMas
            // 
            this.btnMostrarMas.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnMostrarMas.Image = ((System.Drawing.Image)(resources.GetObject("btnMostrarMas.Image")));
            this.btnMostrarMas.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnMostrarMas.Name = "btnMostrarMas";
            this.btnMostrarMas.Size = new System.Drawing.Size(23, 22);
            this.btnMostrarMas.Text = "Mostrar Mas";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.ltvTablaDatos, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 27);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(826, 323);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // ltvTablaDatos
            // 
            this.ltvTablaDatos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ltvTablaDatos.GridLines = true;
            this.ltvTablaDatos.HideSelection = false;
            this.ltvTablaDatos.Location = new System.Drawing.Point(3, 3);
            this.ltvTablaDatos.Name = "ltvTablaDatos";
            this.ltvTablaDatos.Size = new System.Drawing.Size(820, 317);
            this.ltvTablaDatos.TabIndex = 1;
            this.ltvTablaDatos.UseCompatibleStateImageBehavior = false;
            this.ltvTablaDatos.View = System.Windows.Forms.View.Details;
            // 
            // Reasignación___Seleccionar_Cuenta_Única
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 350);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Reasignación___Seleccionar_Cuenta_Única";
            this.Text = "Reasignación - Seleccionar Cuenta Única";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tlpBarraNavegacion.ResumeLayout(false);
            this.tlpBarraNavegacion.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ToolStrip tlpBarraNavegacion;
        private System.Windows.Forms.ToolStripButton btnSalir;
        private System.Windows.Forms.ToolStripButton btnMostrarMas;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.ListView ltvTablaDatos;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    }
}