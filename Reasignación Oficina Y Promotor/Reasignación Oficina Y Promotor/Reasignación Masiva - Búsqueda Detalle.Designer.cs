
namespace Reasignación_Oficina_Y_Promotor
{
    partial class Reasignación_Masiva___Búsqueda_Detalle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reasignación_Masiva___Búsqueda_Detalle));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnSalir = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.lblOficina = new System.Windows.Forms.Label();
            this.lblPromotor = new System.Windows.Forms.Label();
            this.txtOficina = new System.Windows.Forms.TextBox();
            this.txtPromotor = new System.Windows.Forms.TextBox();
            this.lblCuenta = new System.Windows.Forms.Label();
            this.lblCriterioaMostrar = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.listView1 = new System.Windows.Forms.ListView();
            this.clmCheck = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmCuenta = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmOficinaActual = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chkTodos = new System.Windows.Forms.CheckBox();
            this.clmPromotorActual = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmPrimerNombre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmSegundoNombre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmPrimerApellido = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmSegundoApellido = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtCuenta = new System.Windows.Forms.TextBox();
            this.rdbCuentasActivas = new System.Windows.Forms.RadioButton();
            this.lblRegistrosSeleccionados = new System.Windows.Forms.Label();
            this.lblContadorRegistrosSeleccionados = new System.Windows.Forms.Label();
            this.rdbTodasLasCuentas = new System.Windows.Forms.RadioButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnSalir,
            this.toolStripButton2,
            this.toolStripButton3,
            this.toolStripButton4});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(781, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnSalir
            // 
            this.btnSalir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(23, 22);
            this.btnSalir.Text = "Salir";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "toolStripButton2";
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton3.Text = "toolStripButton3";
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton4.Text = "toolStripButton4";
            // 
            // lblOficina
            // 
            this.lblOficina.AutoSize = true;
            this.lblOficina.Location = new System.Drawing.Point(25, 44);
            this.lblOficina.Name = "lblOficina";
            this.lblOficina.Size = new System.Drawing.Size(40, 13);
            this.lblOficina.TabIndex = 1;
            this.lblOficina.Text = "Oficina";
            // 
            // lblPromotor
            // 
            this.lblPromotor.AutoSize = true;
            this.lblPromotor.Location = new System.Drawing.Point(25, 72);
            this.lblPromotor.Name = "lblPromotor";
            this.lblPromotor.Size = new System.Drawing.Size(49, 13);
            this.lblPromotor.TabIndex = 2;
            this.lblPromotor.Text = "Promotor";
            // 
            // txtOficina
            // 
            this.txtOficina.Location = new System.Drawing.Point(84, 41);
            this.txtOficina.Name = "txtOficina";
            this.txtOficina.Size = new System.Drawing.Size(100, 20);
            this.txtOficina.TabIndex = 3;
            // 
            // txtPromotor
            // 
            this.txtPromotor.Location = new System.Drawing.Point(84, 69);
            this.txtPromotor.Name = "txtPromotor";
            this.txtPromotor.Size = new System.Drawing.Size(100, 20);
            this.txtPromotor.TabIndex = 4;
            // 
            // lblCuenta
            // 
            this.lblCuenta.AutoSize = true;
            this.lblCuenta.Location = new System.Drawing.Point(210, 44);
            this.lblCuenta.Name = "lblCuenta";
            this.lblCuenta.Size = new System.Drawing.Size(41, 13);
            this.lblCuenta.TabIndex = 5;
            this.lblCuenta.Text = "Cuenta";
            // 
            // lblCriterioaMostrar
            // 
            this.lblCriterioaMostrar.AutoSize = true;
            this.lblCriterioaMostrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCriterioaMostrar.Location = new System.Drawing.Point(210, 72);
            this.lblCriterioaMostrar.Name = "lblCriterioaMostrar";
            this.lblCriterioaMostrar.Size = new System.Drawing.Size(104, 13);
            this.lblCriterioaMostrar.TabIndex = 7;
            this.lblCriterioaMostrar.Text = "Criterio a Mostrar";
            // 
            // listView1
            // 
            this.listView1.CheckBoxes = true;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmCheck,
            this.clmCuenta,
            this.clmOficinaActual,
            this.clmPromotorActual,
            this.clmPrimerNombre,
            this.clmSegundoNombre,
            this.clmPrimerApellido,
            this.clmSegundoApellido});
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 139);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(757, 233);
            this.listView1.TabIndex = 12;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // clmCheck
            // 
            this.clmCheck.Text = "Check";
            // 
            // clmCuenta
            // 
            this.clmCuenta.Text = "Cuenta";
            this.clmCuenta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clmCuenta.Width = 100;
            // 
            // clmOficinaActual
            // 
            this.clmOficinaActual.Text = "Oficina Actual";
            this.clmOficinaActual.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clmOficinaActual.Width = 100;
            // 
            // chkTodos
            // 
            this.chkTodos.AutoSize = true;
            this.chkTodos.Location = new System.Drawing.Point(28, 116);
            this.chkTodos.Name = "chkTodos";
            this.chkTodos.Size = new System.Drawing.Size(87, 17);
            this.chkTodos.TabIndex = 13;
            this.chkTodos.Text = "Marcar Todo";
            this.chkTodos.UseVisualStyleBackColor = true;
            // 
            // clmPromotorActual
            // 
            this.clmPromotorActual.Text = "Promotor Actual";
            this.clmPromotorActual.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clmPromotorActual.Width = 100;
            // 
            // clmPrimerNombre
            // 
            this.clmPrimerNombre.Text = "Primer Nombre";
            this.clmPrimerNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clmPrimerNombre.Width = 100;
            // 
            // clmSegundoNombre
            // 
            this.clmSegundoNombre.Text = "Segundo Nombre";
            this.clmSegundoNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clmSegundoNombre.Width = 100;
            // 
            // clmPrimerApellido
            // 
            this.clmPrimerApellido.Text = "Primer Apellido";
            this.clmPrimerApellido.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clmPrimerApellido.Width = 100;
            // 
            // clmSegundoApellido
            // 
            this.clmSegundoApellido.Text = "Segundo Apellido";
            this.clmSegundoApellido.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clmSegundoApellido.Width = 100;
            // 
            // txtCuenta
            // 
            this.txtCuenta.Location = new System.Drawing.Point(298, 41);
            this.txtCuenta.Name = "txtCuenta";
            this.txtCuenta.Size = new System.Drawing.Size(143, 20);
            this.txtCuenta.TabIndex = 6;
            // 
            // rdbCuentasActivas
            // 
            this.rdbCuentasActivas.AutoSize = true;
            this.rdbCuentasActivas.Location = new System.Drawing.Point(328, 72);
            this.rdbCuentasActivas.Name = "rdbCuentasActivas";
            this.rdbCuentasActivas.Size = new System.Drawing.Size(102, 17);
            this.rdbCuentasActivas.TabIndex = 8;
            this.rdbCuentasActivas.TabStop = true;
            this.rdbCuentasActivas.Text = "Cuentas Activas";
            this.rdbCuentasActivas.UseVisualStyleBackColor = true;
            // 
            // lblRegistrosSeleccionados
            // 
            this.lblRegistrosSeleccionados.AutoSize = true;
            this.lblRegistrosSeleccionados.Location = new System.Drawing.Point(463, 72);
            this.lblRegistrosSeleccionados.Name = "lblRegistrosSeleccionados";
            this.lblRegistrosSeleccionados.Size = new System.Drawing.Size(130, 13);
            this.lblRegistrosSeleccionados.TabIndex = 10;
            this.lblRegistrosSeleccionados.Text = "Registros Seleccionados: ";
            // 
            // lblContadorRegistrosSeleccionados
            // 
            this.lblContadorRegistrosSeleccionados.AutoSize = true;
            this.lblContadorRegistrosSeleccionados.Location = new System.Drawing.Point(599, 72);
            this.lblContadorRegistrosSeleccionados.Name = "lblContadorRegistrosSeleccionados";
            this.lblContadorRegistrosSeleccionados.Size = new System.Drawing.Size(13, 13);
            this.lblContadorRegistrosSeleccionados.TabIndex = 11;
            this.lblContadorRegistrosSeleccionados.Text = "0";
            // 
            // rdbTodasLasCuentas
            // 
            this.rdbTodasLasCuentas.AutoSize = true;
            this.rdbTodasLasCuentas.Location = new System.Drawing.Point(328, 105);
            this.rdbTodasLasCuentas.Name = "rdbTodasLasCuentas";
            this.rdbTodasLasCuentas.Size = new System.Drawing.Size(113, 17);
            this.rdbTodasLasCuentas.TabIndex = 9;
            this.rdbTodasLasCuentas.TabStop = true;
            this.rdbTodasLasCuentas.Text = "Todas las Cuentas";
            this.rdbTodasLasCuentas.UseVisualStyleBackColor = true;
            // 
            // Reasignación_Masiva___Búsqueda_Detalle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 384);
            this.Controls.Add(this.chkTodos);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.lblContadorRegistrosSeleccionados);
            this.Controls.Add(this.lblRegistrosSeleccionados);
            this.Controls.Add(this.rdbTodasLasCuentas);
            this.Controls.Add(this.rdbCuentasActivas);
            this.Controls.Add(this.lblCriterioaMostrar);
            this.Controls.Add(this.txtCuenta);
            this.Controls.Add(this.lblCuenta);
            this.Controls.Add(this.txtPromotor);
            this.Controls.Add(this.txtOficina);
            this.Controls.Add(this.lblPromotor);
            this.Controls.Add(this.lblOficina);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Reasignación_Masiva___Búsqueda_Detalle";
            this.Text = "Reasignación_Masiva___Búsqueda_Detalle";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnSalir;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.Label lblOficina;
        private System.Windows.Forms.Label lblPromotor;
        private System.Windows.Forms.TextBox txtOficina;
        private System.Windows.Forms.TextBox txtPromotor;
        private System.Windows.Forms.Label lblCuenta;
        private System.Windows.Forms.Label lblCriterioaMostrar;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader clmCheck;
        private System.Windows.Forms.ColumnHeader clmCuenta;
        private System.Windows.Forms.ColumnHeader clmOficinaActual;
        private System.Windows.Forms.CheckBox chkTodos;
        private System.Windows.Forms.ColumnHeader clmPromotorActual;
        private System.Windows.Forms.ColumnHeader clmPrimerNombre;
        private System.Windows.Forms.ColumnHeader clmSegundoNombre;
        private System.Windows.Forms.ColumnHeader clmPrimerApellido;
        private System.Windows.Forms.ColumnHeader clmSegundoApellido;
        private System.Windows.Forms.TextBox txtCuenta;
        private System.Windows.Forms.RadioButton rdbCuentasActivas;
        private System.Windows.Forms.Label lblRegistrosSeleccionados;
        private System.Windows.Forms.Label lblContadorRegistrosSeleccionados;
        private System.Windows.Forms.RadioButton rdbTodasLasCuentas;
    }
}