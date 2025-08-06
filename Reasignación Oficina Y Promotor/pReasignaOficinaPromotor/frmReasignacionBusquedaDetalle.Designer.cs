
namespace pReasignaOficinaPromotor
{
    partial class ReasignaciónMasiva_BúsquedaDetalle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReasignaciónMasiva_BúsquedaDetalle));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.listView1 = new System.Windows.Forms.ListView();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkTodos = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.txtPromotor = new System.Windows.Forms.TextBox();
            this.lblPromotor = new System.Windows.Forms.Label();
            this.lblOficina = new System.Windows.Forms.Label();
            this.txtOficina = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.lblContadorRegistrosSeleccionados = new System.Windows.Forms.Label();
            this.lblRegistrosSeleccionados = new System.Windows.Forms.Label();
            this.rdbTodasLasCuentas = new System.Windows.Forms.RadioButton();
            this.rdbCuentasActivas = new System.Windows.Forms.RadioButton();
            this.lblCriterioaMostrar = new System.Windows.Forms.Label();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.txtCuenta = new System.Windows.Forms.TextBox();
            this.lblCuenta = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnSalir = new System.Windows.Forms.ToolStripButton();
            this.btnBuscar = new System.Windows.Forms.ToolStripButton();
            this.btnLimpiar = new System.Windows.Forms.ToolStripButton();
            this.btnReasignar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 790F));
            this.tableLayoutPanel1.Controls.Add(this.listView1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.toolStrip1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 21F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(790, 406);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // listView1
            // 
            this.listView1.CheckBoxes = true;
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(3, 139);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(784, 264);
            this.listView1.TabIndex = 13;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel2.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.groupBox2, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 24);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(784, 109);
            this.tableLayoutPanel2.TabIndex = 14;
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.Controls.Add(this.chkTodos);
            this.groupBox1.Controls.Add(this.tableLayoutPanel3);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(229, 103);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // chkTodos
            // 
            this.chkTodos.AutoSize = true;
            this.chkTodos.Location = new System.Drawing.Point(26, 74);
            this.chkTodos.Name = "chkTodos";
            this.chkTodos.Size = new System.Drawing.Size(86, 17);
            this.chkTodos.TabIndex = 14;
            this.chkTodos.Text = "Marcar Todo";
            this.chkTodos.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.txtPromotor, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.lblPromotor, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.lblOficina, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.txtOficina, 1, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(6, 19);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(185, 52);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // txtPromotor
            // 
            this.txtPromotor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPromotor.Location = new System.Drawing.Point(95, 29);
            this.txtPromotor.Name = "txtPromotor";
            this.txtPromotor.Size = new System.Drawing.Size(87, 21);
            this.txtPromotor.TabIndex = 6;
            this.txtPromotor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblPromotor
            // 
            this.lblPromotor.AutoSize = true;
            this.lblPromotor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPromotor.Location = new System.Drawing.Point(3, 26);
            this.lblPromotor.Name = "lblPromotor";
            this.lblPromotor.Size = new System.Drawing.Size(86, 26);
            this.lblPromotor.TabIndex = 5;
            this.lblPromotor.Text = "Promotor";
            this.lblPromotor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblOficina
            // 
            this.lblOficina.AutoSize = true;
            this.lblOficina.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblOficina.Location = new System.Drawing.Point(3, 0);
            this.lblOficina.Name = "lblOficina";
            this.lblOficina.Size = new System.Drawing.Size(86, 26);
            this.lblOficina.TabIndex = 2;
            this.lblOficina.Text = "Oficina";
            this.lblOficina.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtOficina
            // 
            this.txtOficina.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtOficina.Location = new System.Drawing.Point(95, 3);
            this.txtOficina.Name = "txtOficina";
            this.txtOficina.Size = new System.Drawing.Size(87, 21);
            this.txtOficina.TabIndex = 4;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.AutoSize = true;
            this.groupBox2.Controls.Add(this.tableLayoutPanel5);
            this.groupBox2.Controls.Add(this.tableLayoutPanel4);
            this.groupBox2.Location = new System.Drawing.Point(238, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(543, 103);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 4;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.64407F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 44.55206F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.0073F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.489051F));
            this.tableLayoutPanel5.Controls.Add(this.lblContadorRegistrosSeleccionados, 3, 0);
            this.tableLayoutPanel5.Controls.Add(this.lblRegistrosSeleccionados, 2, 0);
            this.tableLayoutPanel5.Controls.Add(this.rdbTodasLasCuentas, 1, 1);
            this.tableLayoutPanel5.Controls.Add(this.rdbCuentasActivas, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.lblCriterioaMostrar, 0, 0);
            this.tableLayoutPanel5.Location = new System.Drawing.Point(19, 48);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 2;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(416, 46);
            this.tableLayoutPanel5.TabIndex = 1;
            // 
            // lblContadorRegistrosSeleccionados
            // 
            this.lblContadorRegistrosSeleccionados.AutoSize = true;
            this.lblContadorRegistrosSeleccionados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblContadorRegistrosSeleccionados.Location = new System.Drawing.Point(377, 0);
            this.lblContadorRegistrosSeleccionados.Name = "lblContadorRegistrosSeleccionados";
            this.lblContadorRegistrosSeleccionados.Size = new System.Drawing.Size(36, 23);
            this.lblContadorRegistrosSeleccionados.TabIndex = 12;
            this.lblContadorRegistrosSeleccionados.Text = "0";
            // 
            // lblRegistrosSeleccionados
            // 
            this.lblRegistrosSeleccionados.AutoSize = true;
            this.lblRegistrosSeleccionados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblRegistrosSeleccionados.Location = new System.Drawing.Point(265, 0);
            this.lblRegistrosSeleccionados.Name = "lblRegistrosSeleccionados";
            this.lblRegistrosSeleccionados.Size = new System.Drawing.Size(106, 23);
            this.lblRegistrosSeleccionados.TabIndex = 11;
            this.lblRegistrosSeleccionados.Text = "Registros Seleccionados: ";
            // 
            // rdbTodasLasCuentas
            // 
            this.rdbTodasLasCuentas.AutoSize = true;
            this.rdbTodasLasCuentas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rdbTodasLasCuentas.Location = new System.Drawing.Point(80, 26);
            this.rdbTodasLasCuentas.Name = "rdbTodasLasCuentas";
            this.rdbTodasLasCuentas.Size = new System.Drawing.Size(179, 17);
            this.rdbTodasLasCuentas.TabIndex = 10;
            this.rdbTodasLasCuentas.TabStop = true;
            this.rdbTodasLasCuentas.Text = "Todas las Cuentas";
            this.rdbTodasLasCuentas.UseVisualStyleBackColor = true;
            // 
            // rdbCuentasActivas
            // 
            this.rdbCuentasActivas.AutoSize = true;
            this.rdbCuentasActivas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rdbCuentasActivas.Location = new System.Drawing.Point(80, 3);
            this.rdbCuentasActivas.Name = "rdbCuentasActivas";
            this.rdbCuentasActivas.Size = new System.Drawing.Size(179, 17);
            this.rdbCuentasActivas.TabIndex = 9;
            this.rdbCuentasActivas.TabStop = true;
            this.rdbCuentasActivas.Text = "Cuentas Activas";
            this.rdbCuentasActivas.UseVisualStyleBackColor = true;
            // 
            // lblCriterioaMostrar
            // 
            this.lblCriterioaMostrar.AutoSize = true;
            this.lblCriterioaMostrar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCriterioaMostrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCriterioaMostrar.Location = new System.Drawing.Point(3, 0);
            this.lblCriterioaMostrar.Name = "lblCriterioaMostrar";
            this.lblCriterioaMostrar.Size = new System.Drawing.Size(71, 23);
            this.lblCriterioaMostrar.TabIndex = 8;
            this.lblCriterioaMostrar.Text = "Criterio a Mostrar";
            this.lblCriterioaMostrar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel4.Controls.Add(this.txtCuenta, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.lblCuenta, 0, 0);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(19, 19);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(260, 26);
            this.tableLayoutPanel4.TabIndex = 0;
            // 
            // txtCuenta
            // 
            this.txtCuenta.Location = new System.Drawing.Point(81, 3);
            this.txtCuenta.Name = "txtCuenta";
            this.txtCuenta.Size = new System.Drawing.Size(176, 21);
            this.txtCuenta.TabIndex = 7;
            // 
            // lblCuenta
            // 
            this.lblCuenta.AutoSize = true;
            this.lblCuenta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCuenta.Location = new System.Drawing.Point(3, 0);
            this.lblCuenta.Name = "lblCuenta";
            this.lblCuenta.Size = new System.Drawing.Size(72, 26);
            this.lblCuenta.TabIndex = 6;
            this.lblCuenta.Text = "Cuenta";
            this.lblCuenta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator4,
            this.btnSalir,
            this.toolStripSeparator3,
            this.btnBuscar,
            this.toolStripSeparator1,
            this.btnLimpiar,
            this.toolStripSeparator2,
            this.btnReasignar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(790, 21);
            this.toolStrip1.TabIndex = 15;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnSalir
            // 
            this.btnSalir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(23, 18);
            this.btnSalir.Text = "Salir";
            this.btnSalir.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(23, 18);
            this.btnBuscar.Text = "Buscar";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnLimpiar.Image = ((System.Drawing.Image)(resources.GetObject("btnLimpiar.Image")));
            this.btnLimpiar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(23, 18);
            this.btnLimpiar.Text = "Limpiar";
            // 
            // btnReasignar
            // 
            this.btnReasignar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnReasignar.Image = ((System.Drawing.Image)(resources.GetObject("btnReasignar.Image")));
            this.btnReasignar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnReasignar.Name = "btnReasignar";
            this.btnReasignar.Size = new System.Drawing.Size(23, 18);
            this.btnReasignar.Text = "Reasignar";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 21);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 21);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 21);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 21);
            // 
            // ReasignaciónMasiva_BúsquedaDetalle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 406);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ReasignaciónMasiva_BúsquedaDetalle";
            this.Text = "Reasignación Masiva Busqueda Detalle";
            this.Load += new System.EventHandler(this.ReasignaciónMasiva_BúsquedaDetalle_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label lblOficina;
        private System.Windows.Forms.TextBox txtOficina;
        private System.Windows.Forms.Label lblPromotor;
        private System.Windows.Forms.TextBox txtPromotor;
        private System.Windows.Forms.CheckBox chkTodos;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label lblCuenta;
        private System.Windows.Forms.TextBox txtCuenta;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Label lblCriterioaMostrar;
        private System.Windows.Forms.RadioButton rdbCuentasActivas;
        private System.Windows.Forms.RadioButton rdbTodasLasCuentas;
        private System.Windows.Forms.Label lblRegistrosSeleccionados;
        private System.Windows.Forms.Label lblContadorRegistrosSeleccionados;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnSalir;
        private System.Windows.Forms.ToolStripButton btnBuscar;
        private System.Windows.Forms.ToolStripButton btnLimpiar;
        private System.Windows.Forms.ToolStripButton btnReasignar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
    }
}

