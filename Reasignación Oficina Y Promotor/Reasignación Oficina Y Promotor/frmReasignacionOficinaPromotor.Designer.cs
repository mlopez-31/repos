
namespace Reasignación_Oficina_Y_Promotor
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label2 = new System.Windows.Forms.Label();
            this.cboProceso = new System.Windows.Forms.ComboBox();
            this.gpbReasignacionMasiva = new System.Windows.Forms.GroupBox();
            this.rdbTodasCuentas = new System.Windows.Forms.RadioButton();
            this.rdbCuentasActivas = new System.Windows.Forms.RadioButton();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtPromotor = new System.Windows.Forms.TextBox();
            this.cboOficina = new System.Windows.Forms.ComboBox();
            this.chbxPromotor = new System.Windows.Forms.CheckBox();
            this.chbOficina = new System.Windows.Forms.CheckBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnImportarDatos = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.btnSalir = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.btnBuscar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btnLimpiar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnReasignar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnBitacora = new System.Windows.Forms.ToolStripButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblCuenta = new System.Windows.Forms.Label();
            this.chbxCuenta = new System.Windows.Forms.CheckBox();
            this.chbxNombre = new System.Windows.Forms.CheckBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lblPrimerNombre = new System.Windows.Forms.Label();
            this.lblSegundoNombre = new System.Windows.Forms.Label();
            this.lblPrimerApellido = new System.Windows.Forms.Label();
            this.lblSegundoApellido = new System.Windows.Forms.Label();
            this.txtPrimerNombre = new System.Windows.Forms.TextBox();
            this.txtSegundoNombre = new System.Windows.Forms.TextBox();
            this.txtPrimerApellido = new System.Windows.Forms.TextBox();
            this.txtSegundoApellido = new System.Windows.Forms.TextBox();
            this.lblOficinaActual = new System.Windows.Forms.Label();
            this.lblPromotorActual = new System.Windows.Forms.Label();
            this.txtOficinaActual = new System.Windows.Forms.TextBox();
            this.txtPromotorActual = new System.Windows.Forms.TextBox();
            this.lblReasignarOficina = new System.Windows.Forms.Label();
            this.lblReasignarPromotor = new System.Windows.Forms.Label();
            this.cboReasignarOficina = new System.Windows.Forms.ComboBox();
            this.gpbReasignacionPorCuenta = new System.Windows.Forms.GroupBox();
            this.tlpBaseTipoProceso = new System.Windows.Forms.TableLayoutPanel();
            this.tlpContenedorCuentaYmasiva = new System.Windows.Forms.TableLayoutPanel();
            this.txtCuenta = new controlesTS.TextBoxFormat();
            this.txtReasignaPromotor = new controlesTS.TextBoxFormat();
            this.gpbReasignacionMasiva.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.gpbReasignacionPorCuenta.SuspendLayout();
            this.tlpBaseTipoProceso.SuspendLayout();
            this.tlpContenedorCuentaYmasiva.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 31);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tipo de Proceso";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cboProceso
            // 
            this.cboProceso.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cboProceso.FormattingEnabled = true;
            this.cboProceso.Location = new System.Drawing.Point(107, 5);
            this.cboProceso.Name = "cboProceso";
            this.cboProceso.Size = new System.Drawing.Size(151, 21);
            this.cboProceso.TabIndex = 3;
            this.cboProceso.SelectedIndexChanged += new System.EventHandler(this.cboProceso_SelectedIndexChanged);
            // 
            // gpbReasignacionMasiva
            // 
            this.gpbReasignacionMasiva.Controls.Add(this.rdbTodasCuentas);
            this.gpbReasignacionMasiva.Controls.Add(this.rdbCuentasActivas);
            this.gpbReasignacionMasiva.Controls.Add(this.label12);
            this.gpbReasignacionMasiva.Controls.Add(this.label11);
            this.gpbReasignacionMasiva.Controls.Add(this.txtPromotor);
            this.gpbReasignacionMasiva.Controls.Add(this.cboOficina);
            this.gpbReasignacionMasiva.Controls.Add(this.chbxPromotor);
            this.gpbReasignacionMasiva.Controls.Add(this.chbOficina);
            this.gpbReasignacionMasiva.Controls.Add(this.groupBox5);
            this.gpbReasignacionMasiva.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gpbReasignacionMasiva.Enabled = false;
            this.gpbReasignacionMasiva.Location = new System.Drawing.Point(3, 283);
            this.gpbReasignacionMasiva.Name = "gpbReasignacionMasiva";
            this.gpbReasignacionMasiva.Size = new System.Drawing.Size(667, 140);
            this.gpbReasignacionMasiva.TabIndex = 0;
            this.gpbReasignacionMasiva.TabStop = false;
            this.gpbReasignacionMasiva.Text = "Reasignación Masiva";
            this.gpbReasignacionMasiva.Enter += new System.EventHandler(this.gpbReasignacionMasiva_Enter);
            // 
            // rdbTodasCuentas
            // 
            this.rdbTodasCuentas.AutoSize = true;
            this.rdbTodasCuentas.Location = new System.Drawing.Point(290, 81);
            this.rdbTodasCuentas.Name = "rdbTodasCuentas";
            this.rdbTodasCuentas.Size = new System.Drawing.Size(113, 17);
            this.rdbTodasCuentas.TabIndex = 8;
            this.rdbTodasCuentas.TabStop = true;
            this.rdbTodasCuentas.Text = "Todas las Cuentas";
            this.rdbTodasCuentas.UseVisualStyleBackColor = true;
            // 
            // rdbCuentasActivas
            // 
            this.rdbCuentasActivas.AutoSize = true;
            this.rdbCuentasActivas.Location = new System.Drawing.Point(290, 48);
            this.rdbCuentasActivas.Name = "rdbCuentasActivas";
            this.rdbCuentasActivas.Size = new System.Drawing.Size(103, 17);
            this.rdbCuentasActivas.TabIndex = 7;
            this.rdbCuentasActivas.TabStop = true;
            this.rdbCuentasActivas.Text = "Cuentas Activas";
            this.rdbCuentasActivas.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(287, 19);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(107, 13);
            this.label12.TabIndex = 6;
            this.label12.Text = "Criterio a Mostrar";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(17, 20);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(121, 13);
            this.label11.TabIndex = 5;
            this.label11.Text = "Búsqueda Avanzada";
            // 
            // txtPromotor
            // 
            this.txtPromotor.Location = new System.Drawing.Point(114, 81);
            this.txtPromotor.Name = "txtPromotor";
            this.txtPromotor.Size = new System.Drawing.Size(138, 21);
            this.txtPromotor.TabIndex = 4;
            // 
            // cboOficina
            // 
            this.cboOficina.FormattingEnabled = true;
            this.cboOficina.Location = new System.Drawing.Point(114, 51);
            this.cboOficina.Name = "cboOficina";
            this.cboOficina.Size = new System.Drawing.Size(138, 21);
            this.cboOficina.TabIndex = 3;
            // 
            // chbxPromotor
            // 
            this.chbxPromotor.AutoSize = true;
            this.chbxPromotor.Location = new System.Drawing.Point(21, 83);
            this.chbxPromotor.Name = "chbxPromotor";
            this.chbxPromotor.Size = new System.Drawing.Size(70, 17);
            this.chbxPromotor.TabIndex = 2;
            this.chbxPromotor.Text = "Promotor";
            this.chbxPromotor.UseVisualStyleBackColor = true;
            // 
            // chbOficina
            // 
            this.chbOficina.AutoSize = true;
            this.chbOficina.Location = new System.Drawing.Point(21, 53);
            this.chbOficina.Name = "chbOficina";
            this.chbOficina.Size = new System.Drawing.Size(59, 17);
            this.chbOficina.TabIndex = 1;
            this.chbOficina.Text = "Oficina";
            this.chbOficina.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnImportarDatos);
            this.groupBox5.Enabled = false;
            this.groupBox5.Location = new System.Drawing.Point(416, 20);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(207, 81);
            this.groupBox5.TabIndex = 0;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Reasignación Manual";
            // 
            // btnImportarDatos
            // 
            this.btnImportarDatos.Location = new System.Drawing.Point(51, 29);
            this.btnImportarDatos.Name = "btnImportarDatos";
            this.btnImportarDatos.Size = new System.Drawing.Size(109, 23);
            this.btnImportarDatos.TabIndex = 0;
            this.btnImportarDatos.Text = "Importar Datos";
            this.btnImportarDatos.UseVisualStyleBackColor = true;
            this.btnImportarDatos.Click += new System.EventHandler(this.btnImportarDatos_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator5,
            this.btnSalir,
            this.toolStripSeparator4,
            this.btnBuscar,
            this.toolStripSeparator3,
            this.btnLimpiar,
            this.toolStripSeparator1,
            this.btnReasignar,
            this.toolStripSeparator2,
            this.btnBitacora});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(673, 25);
            this.toolStrip1.TabIndex = 5;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
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
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // btnBuscar
            // 
            this.btnBuscar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(23, 22);
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnLimpiar.Image = ((System.Drawing.Image)(resources.GetObject("btnLimpiar.Image")));
            this.btnLimpiar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(23, 22);
            this.btnLimpiar.Text = "toolStripButton3";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // btnReasignar
            // 
            this.btnReasignar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnReasignar.Image = ((System.Drawing.Image)(resources.GetObject("btnReasignar.Image")));
            this.btnReasignar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnReasignar.Name = "btnReasignar";
            this.btnReasignar.Size = new System.Drawing.Size(23, 22);
            this.btnReasignar.Text = "Reasignar";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // btnBitacora
            // 
            this.btnBitacora.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnBitacora.Image = ((System.Drawing.Image)(resources.GetObject("btnBitacora.Image")));
            this.btnBitacora.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnBitacora.Name = "btnBitacora";
            this.btnBitacora.Size = new System.Drawing.Size(23, 22);
            this.btnBitacora.Text = "toolStripButton1";
            this.btnBitacora.Click += new System.EventHandler(this.btnBitacora_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtCuenta);
            this.groupBox3.Controls.Add(this.lblCuenta);
            this.groupBox3.Location = new System.Drawing.Point(10, 42);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(248, 55);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            // 
            // lblCuenta
            // 
            this.lblCuenta.AutoSize = true;
            this.lblCuenta.Location = new System.Drawing.Point(35, 21);
            this.lblCuenta.Name = "lblCuenta";
            this.lblCuenta.Size = new System.Drawing.Size(46, 13);
            this.lblCuenta.TabIndex = 0;
            this.lblCuenta.Text = "Cuenta:";
            // 
            // chbxCuenta
            // 
            this.chbxCuenta.AutoSize = true;
            this.chbxCuenta.Location = new System.Drawing.Point(16, 20);
            this.chbxCuenta.Name = "chbxCuenta";
            this.chbxCuenta.Size = new System.Drawing.Size(115, 17);
            this.chbxCuenta.TabIndex = 1;
            this.chbxCuenta.Text = "Buscar Por Cuenta";
            this.chbxCuenta.UseVisualStyleBackColor = true;
            this.chbxCuenta.CheckedChanged += new System.EventHandler(this.chbxCuenta_CheckedChanged);
            // 
            // chbxNombre
            // 
            this.chbxNombre.AutoSize = true;
            this.chbxNombre.Location = new System.Drawing.Point(290, 20);
            this.chbxNombre.Name = "chbxNombre";
            this.chbxNombre.Size = new System.Drawing.Size(117, 17);
            this.chbxNombre.TabIndex = 2;
            this.chbxNombre.Text = "Buscar Por Nombre";
            this.chbxNombre.UseVisualStyleBackColor = true;
            this.chbxNombre.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtSegundoApellido);
            this.groupBox4.Controls.Add(this.txtPrimerApellido);
            this.groupBox4.Controls.Add(this.txtSegundoNombre);
            this.groupBox4.Controls.Add(this.txtPrimerNombre);
            this.groupBox4.Controls.Add(this.lblSegundoApellido);
            this.groupBox4.Controls.Add(this.lblPrimerApellido);
            this.groupBox4.Controls.Add(this.lblSegundoNombre);
            this.groupBox4.Controls.Add(this.lblPrimerNombre);
            this.groupBox4.Location = new System.Drawing.Point(281, 42);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(331, 154);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            // 
            // lblPrimerNombre
            // 
            this.lblPrimerNombre.AutoSize = true;
            this.lblPrimerNombre.Location = new System.Drawing.Point(17, 26);
            this.lblPrimerNombre.Name = "lblPrimerNombre";
            this.lblPrimerNombre.Size = new System.Drawing.Size(77, 13);
            this.lblPrimerNombre.TabIndex = 0;
            this.lblPrimerNombre.Text = "Primer Nombre";
            // 
            // lblSegundoNombre
            // 
            this.lblSegundoNombre.AutoSize = true;
            this.lblSegundoNombre.Location = new System.Drawing.Point(17, 57);
            this.lblSegundoNombre.Name = "lblSegundoNombre";
            this.lblSegundoNombre.Size = new System.Drawing.Size(89, 13);
            this.lblSegundoNombre.TabIndex = 1;
            this.lblSegundoNombre.Text = "Segundo Nombre";
            // 
            // lblPrimerApellido
            // 
            this.lblPrimerApellido.AutoSize = true;
            this.lblPrimerApellido.Location = new System.Drawing.Point(17, 90);
            this.lblPrimerApellido.Name = "lblPrimerApellido";
            this.lblPrimerApellido.Size = new System.Drawing.Size(77, 13);
            this.lblPrimerApellido.TabIndex = 2;
            this.lblPrimerApellido.Text = "Primer Apellido";
            // 
            // lblSegundoApellido
            // 
            this.lblSegundoApellido.AutoSize = true;
            this.lblSegundoApellido.Location = new System.Drawing.Point(17, 124);
            this.lblSegundoApellido.Name = "lblSegundoApellido";
            this.lblSegundoApellido.Size = new System.Drawing.Size(89, 13);
            this.lblSegundoApellido.TabIndex = 3;
            this.lblSegundoApellido.Text = "Segundo Apellido";
            // 
            // txtPrimerNombre
            // 
            this.txtPrimerNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPrimerNombre.Location = new System.Drawing.Point(135, 23);
            this.txtPrimerNombre.MaxLength = 30;
            this.txtPrimerNombre.Name = "txtPrimerNombre";
            this.txtPrimerNombre.ShortcutsEnabled = false;
            this.txtPrimerNombre.Size = new System.Drawing.Size(176, 21);
            this.txtPrimerNombre.TabIndex = 4;
            this.txtPrimerNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrimerNombre_KeyPress);
            // 
            // txtSegundoNombre
            // 
            this.txtSegundoNombre.Location = new System.Drawing.Point(135, 54);
            this.txtSegundoNombre.MaxLength = 30;
            this.txtSegundoNombre.Name = "txtSegundoNombre";
            this.txtSegundoNombre.Size = new System.Drawing.Size(176, 21);
            this.txtSegundoNombre.TabIndex = 5;
            this.txtSegundoNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSegundoNombre_KeyPress);
            // 
            // txtPrimerApellido
            // 
            this.txtPrimerApellido.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPrimerApellido.Location = new System.Drawing.Point(135, 87);
            this.txtPrimerApellido.MaxLength = 30;
            this.txtPrimerApellido.Name = "txtPrimerApellido";
            this.txtPrimerApellido.Size = new System.Drawing.Size(176, 21);
            this.txtPrimerApellido.TabIndex = 6;
            // 
            // txtSegundoApellido
            // 
            this.txtSegundoApellido.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtSegundoApellido.Location = new System.Drawing.Point(135, 116);
            this.txtSegundoApellido.MaxLength = 30;
            this.txtSegundoApellido.Name = "txtSegundoApellido";
            this.txtSegundoApellido.Size = new System.Drawing.Size(176, 21);
            this.txtSegundoApellido.TabIndex = 7;
            // 
            // lblOficinaActual
            // 
            this.lblOficinaActual.AutoSize = true;
            this.lblOficinaActual.Location = new System.Drawing.Point(17, 206);
            this.lblOficinaActual.Name = "lblOficinaActual";
            this.lblOficinaActual.Size = new System.Drawing.Size(73, 13);
            this.lblOficinaActual.TabIndex = 3;
            this.lblOficinaActual.Text = "Oficina Actual";
            // 
            // lblPromotorActual
            // 
            this.lblPromotorActual.AutoSize = true;
            this.lblPromotorActual.Location = new System.Drawing.Point(17, 242);
            this.lblPromotorActual.Name = "lblPromotorActual";
            this.lblPromotorActual.Size = new System.Drawing.Size(84, 13);
            this.lblPromotorActual.TabIndex = 4;
            this.lblPromotorActual.Text = "Promotor Actual";
            // 
            // txtOficinaActual
            // 
            this.txtOficinaActual.Enabled = false;
            this.txtOficinaActual.Location = new System.Drawing.Point(114, 203);
            this.txtOficinaActual.Name = "txtOficinaActual";
            this.txtOficinaActual.ReadOnly = true;
            this.txtOficinaActual.Size = new System.Drawing.Size(138, 21);
            this.txtOficinaActual.TabIndex = 5;
            // 
            // txtPromotorActual
            // 
            this.txtPromotorActual.Enabled = false;
            this.txtPromotorActual.Location = new System.Drawing.Point(114, 239);
            this.txtPromotorActual.Name = "txtPromotorActual";
            this.txtPromotorActual.ReadOnly = true;
            this.txtPromotorActual.Size = new System.Drawing.Size(138, 21);
            this.txtPromotorActual.TabIndex = 6;
            // 
            // lblReasignarOficina
            // 
            this.lblReasignarOficina.AutoSize = true;
            this.lblReasignarOficina.Location = new System.Drawing.Point(298, 206);
            this.lblReasignarOficina.Name = "lblReasignarOficina";
            this.lblReasignarOficina.Size = new System.Drawing.Size(91, 13);
            this.lblReasignarOficina.TabIndex = 7;
            this.lblReasignarOficina.Text = "Reasignar Oficina";
            // 
            // lblReasignarPromotor
            // 
            this.lblReasignarPromotor.AutoSize = true;
            this.lblReasignarPromotor.Location = new System.Drawing.Point(298, 242);
            this.lblReasignarPromotor.Name = "lblReasignarPromotor";
            this.lblReasignarPromotor.Size = new System.Drawing.Size(102, 13);
            this.lblReasignarPromotor.TabIndex = 8;
            this.lblReasignarPromotor.Text = "Reasignar Promotor";
            // 
            // cboReasignarOficina
            // 
            this.cboReasignarOficina.FormattingEnabled = true;
            this.cboReasignarOficina.Location = new System.Drawing.Point(416, 203);
            this.cboReasignarOficina.Name = "cboReasignarOficina";
            this.cboReasignarOficina.Size = new System.Drawing.Size(176, 21);
            this.cboReasignarOficina.TabIndex = 10;
            // 
            // gpbReasignacionPorCuenta
            // 
            this.gpbReasignacionPorCuenta.Controls.Add(this.txtReasignaPromotor);
            this.gpbReasignacionPorCuenta.Controls.Add(this.cboReasignarOficina);
            this.gpbReasignacionPorCuenta.Controls.Add(this.lblReasignarPromotor);
            this.gpbReasignacionPorCuenta.Controls.Add(this.lblReasignarOficina);
            this.gpbReasignacionPorCuenta.Controls.Add(this.txtPromotorActual);
            this.gpbReasignacionPorCuenta.Controls.Add(this.txtOficinaActual);
            this.gpbReasignacionPorCuenta.Controls.Add(this.lblPromotorActual);
            this.gpbReasignacionPorCuenta.Controls.Add(this.lblOficinaActual);
            this.gpbReasignacionPorCuenta.Controls.Add(this.groupBox4);
            this.gpbReasignacionPorCuenta.Controls.Add(this.chbxNombre);
            this.gpbReasignacionPorCuenta.Controls.Add(this.chbxCuenta);
            this.gpbReasignacionPorCuenta.Controls.Add(this.groupBox3);
            this.gpbReasignacionPorCuenta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gpbReasignacionPorCuenta.Location = new System.Drawing.Point(3, 3);
            this.gpbReasignacionPorCuenta.Name = "gpbReasignacionPorCuenta";
            this.gpbReasignacionPorCuenta.Size = new System.Drawing.Size(667, 274);
            this.gpbReasignacionPorCuenta.TabIndex = 4;
            this.gpbReasignacionPorCuenta.TabStop = false;
            this.gpbReasignacionPorCuenta.Text = "Reasignación por Cuenta";
            // 
            // tlpBaseTipoProceso
            // 
            this.tlpBaseTipoProceso.ColumnCount = 2;
            this.tlpBaseTipoProceso.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.60178F));
            this.tlpBaseTipoProceso.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 84.39822F));
            this.tlpBaseTipoProceso.Controls.Add(this.cboProceso, 1, 0);
            this.tlpBaseTipoProceso.Controls.Add(this.label2, 0, 0);
            this.tlpBaseTipoProceso.Dock = System.Windows.Forms.DockStyle.Top;
            this.tlpBaseTipoProceso.Location = new System.Drawing.Point(0, 25);
            this.tlpBaseTipoProceso.Name = "tlpBaseTipoProceso";
            this.tlpBaseTipoProceso.RowCount = 1;
            this.tlpBaseTipoProceso.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpBaseTipoProceso.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpBaseTipoProceso.Size = new System.Drawing.Size(673, 31);
            this.tlpBaseTipoProceso.TabIndex = 6;
            // 
            // tlpContenedorCuentaYmasiva
            // 
            this.tlpContenedorCuentaYmasiva.ColumnCount = 1;
            this.tlpContenedorCuentaYmasiva.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpContenedorCuentaYmasiva.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpContenedorCuentaYmasiva.Controls.Add(this.gpbReasignacionPorCuenta, 0, 0);
            this.tlpContenedorCuentaYmasiva.Controls.Add(this.gpbReasignacionMasiva, 0, 1);
            this.tlpContenedorCuentaYmasiva.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpContenedorCuentaYmasiva.Location = new System.Drawing.Point(0, 56);
            this.tlpContenedorCuentaYmasiva.Name = "tlpContenedorCuentaYmasiva";
            this.tlpContenedorCuentaYmasiva.RowCount = 2;
            this.tlpContenedorCuentaYmasiva.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 65.96244F));
            this.tlpContenedorCuentaYmasiva.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 34.03756F));
            this.tlpContenedorCuentaYmasiva.Size = new System.Drawing.Size(673, 426);
            this.tlpContenedorCuentaYmasiva.TabIndex = 0;
            // 
            // txtCuenta
            // 
            this.txtCuenta.Decimals = ((byte)(0));
            this.txtCuenta.Format = controlesTS.tbFormats.UnsignedNumber;
            this.txtCuenta.Location = new System.Drawing.Point(104, 18);
            this.txtCuenta.MaxLength = 10;
            this.txtCuenta.MaxValue = controlesTS.TipoDatos.Decimal;
            this.txtCuenta.MaxValuePersonalizado = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtCuenta.Name = "txtCuenta";
            this.txtCuenta.ShortcutsEnabled = false;
            this.txtCuenta.Size = new System.Drawing.Size(118, 21);
            this.txtCuenta.TabIndex = 7;
            this.txtCuenta.UserValues = "";
            this.txtCuenta.ValidaActivaMensajeAlerta = false;
            this.txtCuenta.ValidaColorFondoAlerta = System.Drawing.Color.LightCoral;
            // 
            // txtReasignaPromotor
            // 
            this.txtReasignaPromotor.Decimals = ((byte)(0));
            this.txtReasignaPromotor.Format = controlesTS.tbFormats.UnsignedNumber;
            this.txtReasignaPromotor.Location = new System.Drawing.Point(416, 242);
            this.txtReasignaPromotor.MaxLength = 10;
            this.txtReasignaPromotor.MaxValue = controlesTS.TipoDatos.Decimal;
            this.txtReasignaPromotor.MaxValuePersonalizado = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtReasignaPromotor.Name = "txtReasignaPromotor";
            this.txtReasignaPromotor.ShortcutsEnabled = false;
            this.txtReasignaPromotor.Size = new System.Drawing.Size(176, 21);
            this.txtReasignaPromotor.TabIndex = 11;
            this.txtReasignaPromotor.UserValues = "";
            this.txtReasignaPromotor.ValidaActivaMensajeAlerta = false;
            this.txtReasignaPromotor.ValidaColorFondoAlerta = System.Drawing.Color.LightCoral;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 482);
            this.Controls.Add(this.tlpContenedorCuentaYmasiva);
            this.Controls.Add(this.tlpBaseTipoProceso);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Form1";
            this.Text = " Reasignación Oficina y Promotor";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gpbReasignacionMasiva.ResumeLayout(false);
            this.gpbReasignacionMasiva.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.gpbReasignacionPorCuenta.ResumeLayout(false);
            this.gpbReasignacionPorCuenta.PerformLayout();
            this.tlpBaseTipoProceso.ResumeLayout(false);
            this.tlpBaseTipoProceso.PerformLayout();
            this.tlpContenedorCuentaYmasiva.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboProceso;
        private System.Windows.Forms.GroupBox gpbReasignacionMasiva;
        private System.Windows.Forms.RadioButton rdbTodasCuentas;
        private System.Windows.Forms.RadioButton rdbCuentasActivas;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtPromotor;
        private System.Windows.Forms.ComboBox cboOficina;
        private System.Windows.Forms.CheckBox chbxPromotor;
        private System.Windows.Forms.CheckBox chbOficina;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnImportarDatos;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnSalir;
        private System.Windows.Forms.ToolStripButton btnBuscar;
        private System.Windows.Forms.ToolStripButton btnLimpiar;
        private System.Windows.Forms.ToolStripButton btnReasignar;
        private System.Windows.Forms.ToolStripButton btnBitacora;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblCuenta;
        private System.Windows.Forms.CheckBox chbxCuenta;
        private System.Windows.Forms.CheckBox chbxNombre;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtSegundoApellido;
        private System.Windows.Forms.TextBox txtPrimerApellido;
        private System.Windows.Forms.TextBox txtSegundoNombre;
        private System.Windows.Forms.TextBox txtPrimerNombre;
        private System.Windows.Forms.Label lblSegundoApellido;
        private System.Windows.Forms.Label lblPrimerApellido;
        private System.Windows.Forms.Label lblSegundoNombre;
        private System.Windows.Forms.Label lblPrimerNombre;
        private System.Windows.Forms.Label lblOficinaActual;
        private System.Windows.Forms.Label lblPromotorActual;
        private System.Windows.Forms.TextBox txtOficinaActual;
        private System.Windows.Forms.TextBox txtPromotorActual;
        private System.Windows.Forms.Label lblReasignarOficina;
        private System.Windows.Forms.Label lblReasignarPromotor;
        private System.Windows.Forms.ComboBox cboReasignarOficina;
        private System.Windows.Forms.GroupBox gpbReasignacionPorCuenta;
        private System.Windows.Forms.TableLayoutPanel tlpBaseTipoProceso;
        private System.Windows.Forms.TableLayoutPanel tlpContenedorCuentaYmasiva;
        private controlesTS.TextBoxFormat txtCuenta;
        private controlesTS.TextBoxFormat txtReasignaPromotor;
    }
}

