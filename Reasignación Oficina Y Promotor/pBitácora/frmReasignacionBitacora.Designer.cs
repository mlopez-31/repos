
namespace pBitácora
{
    partial class Reasignación_Bitácora
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reasignación_Bitácora));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnSalir = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnBuscar = new System.Windows.Forms.ToolStripButton();
            this.btnMostrarMas = new System.Windows.Forms.ToolStripButton();
            this.btnActualizar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbLimpiar = new System.Windows.Forms.ToolStripButton();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.tlpContainerCentral = new System.Windows.Forms.TableLayoutPanel();
            this.tlpContainerSuperior = new System.Windows.Forms.TableLayoutPanel();
            this.gpbModuloBitacora = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.txtHoraHasta = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaHasta = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaDesde = new System.Windows.Forms.DateTimePicker();
            this.lblDesde = new System.Windows.Forms.Label();
            this.txtHoraDesde = new System.Windows.Forms.DateTimePicker();
            this.lblHasta = new System.Windows.Forms.Label();
            this.gpbDatos = new System.Windows.Forms.GroupBox();
            this.tlpDatos = new System.Windows.Forms.TableLayoutPanel();
            this.lblIdLote = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.txtIdLote = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.lblModuloBitacora = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.tlpContainerCentral.SuspendLayout();
            this.tlpContainerSuperior.SuspendLayout();
            this.gpbModuloBitacora.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.gpbDatos.SuspendLayout();
            this.tlpDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.toolStrip1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(676, 26);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator2,
            this.btnSalir,
            this.toolStripSeparator1,
            this.btnBuscar,
            this.btnMostrarMas,
            this.btnActualizar,
            this.toolStripSeparator5,
            this.tsbLimpiar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(676, 26);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 26);
            // 
            // btnSalir
            // 
            this.btnSalir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(24, 23);
            this.btnSalir.Text = "toolStripButton1";
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 26);
            // 
            // btnBuscar
            // 
            this.btnBuscar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(24, 23);
            this.btnBuscar.Text = "Buscar";
            // 
            // btnMostrarMas
            // 
            this.btnMostrarMas.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnMostrarMas.Image = ((System.Drawing.Image)(resources.GetObject("btnMostrarMas.Image")));
            this.btnMostrarMas.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnMostrarMas.Name = "btnMostrarMas";
            this.btnMostrarMas.Size = new System.Drawing.Size(24, 23);
            this.btnMostrarMas.Text = "Mostrar Mas";
            // 
            // btnActualizar
            // 
            this.btnActualizar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnActualizar.Image = ((System.Drawing.Image)(resources.GetObject("btnActualizar.Image")));
            this.btnActualizar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(24, 23);
            this.btnActualizar.Text = "toolStripButton4";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 26);
            // 
            // tsbLimpiar
            // 
            this.tsbLimpiar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbLimpiar.Image = ((System.Drawing.Image)(resources.GetObject("tsbLimpiar.Image")));
            this.tsbLimpiar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbLimpiar.Name = "tsbLimpiar";
            this.tsbLimpiar.Size = new System.Drawing.Size(24, 23);
            this.tsbLimpiar.Text = "toolStripButton5";
            this.tsbLimpiar.Click += new System.EventHandler(this.tsbLimpiar_Click);
            // 
            // tlpContainerCentral
            // 
            this.tlpContainerCentral.ColumnCount = 1;
            this.tlpContainerCentral.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpContainerCentral.Controls.Add(this.tlpContainerSuperior, 0, 0);
            this.tlpContainerCentral.Controls.Add(this.listView1, 0, 1);
            this.tlpContainerCentral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpContainerCentral.Location = new System.Drawing.Point(0, 26);
            this.tlpContainerCentral.Name = "tlpContainerCentral";
            this.tlpContainerCentral.RowCount = 2;
            this.tlpContainerCentral.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 28.53773F));
            this.tlpContainerCentral.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 71.46227F));
            this.tlpContainerCentral.Size = new System.Drawing.Size(676, 424);
            this.tlpContainerCentral.TabIndex = 1;
            // 
            // tlpContainerSuperior
            // 
            this.tlpContainerSuperior.ColumnCount = 3;
            this.tlpContainerSuperior.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.01493F));
            this.tlpContainerSuperior.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 56.86567F));
            this.tlpContainerSuperior.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.268657F));
            this.tlpContainerSuperior.Controls.Add(this.gpbModuloBitacora, 1, 1);
            this.tlpContainerSuperior.Controls.Add(this.gpbDatos, 0, 1);
            this.tlpContainerSuperior.Controls.Add(this.lblModuloBitacora, 1, 0);
            this.tlpContainerSuperior.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpContainerSuperior.Location = new System.Drawing.Point(3, 3);
            this.tlpContainerSuperior.Name = "tlpContainerSuperior";
            this.tlpContainerSuperior.RowCount = 2;
            this.tlpContainerSuperior.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.93204F));
            this.tlpContainerSuperior.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 81.06796F));
            this.tlpContainerSuperior.Size = new System.Drawing.Size(670, 114);
            this.tlpContainerSuperior.TabIndex = 0;
            // 
            // gpbModuloBitacora
            // 
            this.gpbModuloBitacora.Controls.Add(this.tableLayoutPanel2);
            this.gpbModuloBitacora.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gpbModuloBitacora.Location = new System.Drawing.Point(250, 24);
            this.gpbModuloBitacora.Name = "gpbModuloBitacora";
            this.gpbModuloBitacora.Size = new System.Drawing.Size(374, 87);
            this.gpbModuloBitacora.TabIndex = 1;
            this.gpbModuloBitacora.TabStop = false;
            this.gpbModuloBitacora.Text = "Fecha";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.19565F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.71739F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 51.3587F));
            this.tableLayoutPanel2.Controls.Add(this.txtHoraHasta, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.dtpFechaHasta, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.dtpFechaDesde, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblDesde, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.txtHoraDesde, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblHasta, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 17);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 38.80597F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 61.19403F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(368, 67);
            this.tableLayoutPanel2.TabIndex = 5;
            // 
            // txtHoraHasta
            // 
            this.txtHoraHasta.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.txtHoraHasta.Location = new System.Drawing.Point(181, 28);
            this.txtHoraHasta.Name = "txtHoraHasta";
            this.txtHoraHasta.ShowUpDown = true;
            this.txtHoraHasta.Size = new System.Drawing.Size(84, 21);
            this.txtHoraHasta.TabIndex = 24;
            this.txtHoraHasta.Value = new System.DateTime(2025, 7, 15, 12, 49, 4, 0);
            // 
            // dtpFechaHasta
            // 
            this.dtpFechaHasta.Checked = false;
            this.dtpFechaHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaHasta.Location = new System.Drawing.Point(80, 28);
            this.dtpFechaHasta.Name = "dtpFechaHasta";
            this.dtpFechaHasta.ShowCheckBox = true;
            this.dtpFechaHasta.Size = new System.Drawing.Size(95, 21);
            this.dtpFechaHasta.TabIndex = 23;
            this.dtpFechaHasta.ValueChanged += new System.EventHandler(this.dtpFechaHasta_ValueChanged_1);
            // 
            // dtpFechaDesde
            // 
            this.dtpFechaDesde.Checked = false;
            this.dtpFechaDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaDesde.Location = new System.Drawing.Point(80, 3);
            this.dtpFechaDesde.Name = "dtpFechaDesde";
            this.dtpFechaDesde.ShowCheckBox = true;
            this.dtpFechaDesde.Size = new System.Drawing.Size(95, 21);
            this.dtpFechaDesde.TabIndex = 22;
            this.dtpFechaDesde.ValueChanged += new System.EventHandler(this.dtpFechaDesde_ValueChanged_1);
            // 
            // lblDesde
            // 
            this.lblDesde.AutoSize = true;
            this.lblDesde.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDesde.Location = new System.Drawing.Point(3, 0);
            this.lblDesde.Name = "lblDesde";
            this.lblDesde.Size = new System.Drawing.Size(71, 25);
            this.lblDesde.TabIndex = 1;
            this.lblDesde.Text = "Desde:";
            this.lblDesde.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtHoraDesde
            // 
            this.txtHoraDesde.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.txtHoraDesde.Location = new System.Drawing.Point(181, 3);
            this.txtHoraDesde.Name = "txtHoraDesde";
            this.txtHoraDesde.ShowUpDown = true;
            this.txtHoraDesde.Size = new System.Drawing.Size(84, 21);
            this.txtHoraDesde.TabIndex = 4;
            this.txtHoraDesde.Value = new System.DateTime(2025, 7, 15, 12, 49, 4, 0);
            // 
            // lblHasta
            // 
            this.lblHasta.AutoSize = true;
            this.lblHasta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblHasta.Location = new System.Drawing.Point(3, 25);
            this.lblHasta.Name = "lblHasta";
            this.lblHasta.Size = new System.Drawing.Size(71, 42);
            this.lblHasta.TabIndex = 2;
            this.lblHasta.Text = "Hasta:";
            this.lblHasta.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // gpbDatos
            // 
            this.gpbDatos.Controls.Add(this.tlpDatos);
            this.gpbDatos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gpbDatos.Location = new System.Drawing.Point(3, 24);
            this.gpbDatos.Name = "gpbDatos";
            this.gpbDatos.Size = new System.Drawing.Size(241, 87);
            this.gpbDatos.TabIndex = 2;
            this.gpbDatos.TabStop = false;
            // 
            // tlpDatos
            // 
            this.tlpDatos.ColumnCount = 2;
            this.tlpDatos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 43.23144F));
            this.tlpDatos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 56.76856F));
            this.tlpDatos.Controls.Add(this.lblIdLote, 0, 0);
            this.tlpDatos.Controls.Add(this.lblUsuario, 0, 1);
            this.tlpDatos.Controls.Add(this.txtIdLote, 1, 0);
            this.tlpDatos.Controls.Add(this.txtUsuario, 1, 1);
            this.tlpDatos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpDatos.Location = new System.Drawing.Point(3, 17);
            this.tlpDatos.Name = "tlpDatos";
            this.tlpDatos.RowCount = 2;
            this.tlpDatos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40.29851F));
            this.tlpDatos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 59.70149F));
            this.tlpDatos.Size = new System.Drawing.Size(235, 67);
            this.tlpDatos.TabIndex = 0;
            // 
            // lblIdLote
            // 
            this.lblIdLote.AutoSize = true;
            this.lblIdLote.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblIdLote.Location = new System.Drawing.Point(3, 0);
            this.lblIdLote.Name = "lblIdLote";
            this.lblIdLote.Size = new System.Drawing.Size(95, 27);
            this.lblIdLote.TabIndex = 0;
            this.lblIdLote.Text = "ID Lote";
            this.lblIdLote.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblUsuario.Location = new System.Drawing.Point(3, 27);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(95, 40);
            this.lblUsuario.TabIndex = 1;
            this.lblUsuario.Text = "Usuario";
            this.lblUsuario.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtIdLote
            // 
            this.txtIdLote.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtIdLote.Enabled = false;
            this.txtIdLote.Location = new System.Drawing.Point(104, 3);
            this.txtIdLote.MaxLength = 10;
            this.txtIdLote.Name = "txtIdLote";
            this.txtIdLote.ReadOnly = true;
            this.txtIdLote.Size = new System.Drawing.Size(128, 21);
            this.txtIdLote.TabIndex = 2;
            this.toolTip1.SetToolTip(this.txtIdLote, "id de lote para la busqueda ");
            // 
            // txtUsuario
            // 
            this.txtUsuario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtUsuario.Enabled = false;
            this.txtUsuario.Location = new System.Drawing.Point(104, 30);
            this.txtUsuario.MaxLength = 10;
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.ReadOnly = true;
            this.txtUsuario.Size = new System.Drawing.Size(128, 21);
            this.txtUsuario.TabIndex = 3;
            // 
            // lblModuloBitacora
            // 
            this.lblModuloBitacora.AutoSize = true;
            this.lblModuloBitacora.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblModuloBitacora.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModuloBitacora.Location = new System.Drawing.Point(250, 0);
            this.lblModuloBitacora.Name = "lblModuloBitacora";
            this.lblModuloBitacora.Size = new System.Drawing.Size(374, 21);
            this.lblModuloBitacora.TabIndex = 3;
            this.lblModuloBitacora.Text = "Módulo de Bitácora";
            this.lblModuloBitacora.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // listView1
            // 
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(3, 123);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(670, 298);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // Reasignación_Bitácora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 450);
            this.Controls.Add(this.tlpContainerCentral);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Reasignación_Bitácora";
            this.Text = "Reasignación – Bitácora";
            this.Load += new System.EventHandler(this.Reasignación_Bitácora_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tlpContainerCentral.ResumeLayout(false);
            this.tlpContainerSuperior.ResumeLayout(false);
            this.tlpContainerSuperior.PerformLayout();
            this.gpbModuloBitacora.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.gpbDatos.ResumeLayout(false);
            this.tlpDatos.ResumeLayout(false);
            this.tlpDatos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnSalir;
        private System.Windows.Forms.ToolStripButton btnBuscar;
        private System.Windows.Forms.ToolStripButton btnMostrarMas;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnActualizar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton tsbLimpiar;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TableLayoutPanel tlpContainerCentral;
        private System.Windows.Forms.TableLayoutPanel tlpContainerSuperior;
        private System.Windows.Forms.GroupBox gpbModuloBitacora;
        private System.Windows.Forms.GroupBox gpbDatos;
        private System.Windows.Forms.TableLayoutPanel tlpDatos;
        private System.Windows.Forms.Label lblIdLote;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.TextBox txtIdLote;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label lblModuloBitacora;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label lblHasta;
        private System.Windows.Forms.Label lblDesde;
        private System.Windows.Forms.DateTimePicker txtHoraDesde;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.DateTimePicker dtpFechaHasta;
        private System.Windows.Forms.DateTimePicker dtpFechaDesde;
        private System.Windows.Forms.DateTimePicker txtHoraHasta;
    }
}

