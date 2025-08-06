
namespace pMatriculacionOnline
{
    partial class frmRegistroEstudiantes
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
            System.Windows.Forms.Label idEstudianteLabel;
            System.Windows.Forms.Label nombreLabel;
            System.Windows.Forms.Label documentoIdentidadLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegistroEstudiantes));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.matriculacionOnlineDataSet1 = new pMatriculacionOnline.MatriculacionOnlineDataSet1();
            this.sp_mantenimiento_estudianteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sp_mantenimiento_estudianteTableAdapter = new pMatriculacionOnline.MatriculacionOnlineDataSet1TableAdapters.sp_mantenimiento_estudianteTableAdapter();
            this.tableAdapterManager = new pMatriculacionOnline.MatriculacionOnlineDataSet1TableAdapters.TableAdapterManager();
            this.sp_mantenimiento_estudianteBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.sp_mantenimiento_estudianteBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.fillToolStrip = new System.Windows.Forms.ToolStrip();
            this.opcionToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.opcionToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.idEstudianteToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.idEstudianteToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.nombreToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.nombreToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.documentoIdentidadToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.documentoIdentidadToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.errorToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.errorToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.fillToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.idEstudianteTextBox = new System.Windows.Forms.TextBox();
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.documentoIdentidadTextBox = new System.Windows.Forms.TextBox();
            this.sp_mantenimiento_estudianteDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            idEstudianteLabel = new System.Windows.Forms.Label();
            nombreLabel = new System.Windows.Forms.Label();
            documentoIdentidadLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.matriculacionOnlineDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sp_mantenimiento_estudianteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sp_mantenimiento_estudianteBindingNavigator)).BeginInit();
            this.sp_mantenimiento_estudianteBindingNavigator.SuspendLayout();
            this.fillToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sp_mantenimiento_estudianteDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // idEstudianteLabel
            // 
            idEstudianteLabel.AutoSize = true;
            idEstudianteLabel.Location = new System.Drawing.Point(58, 87);
            idEstudianteLabel.Name = "idEstudianteLabel";
            idEstudianteLabel.Size = new System.Drawing.Size(71, 13);
            idEstudianteLabel.TabIndex = 2;
            idEstudianteLabel.Text = "id Estudiante:";
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Location = new System.Drawing.Point(58, 123);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(45, 13);
            nombreLabel.TabIndex = 4;
            nombreLabel.Text = "nombre:";
            // 
            // documentoIdentidadLabel
            // 
            documentoIdentidadLabel.AutoSize = true;
            documentoIdentidadLabel.Location = new System.Drawing.Point(58, 165);
            documentoIdentidadLabel.Name = "documentoIdentidadLabel";
            documentoIdentidadLabel.Size = new System.Drawing.Size(110, 13);
            documentoIdentidadLabel.TabIndex = 6;
            documentoIdentidadLabel.Text = "documento Identidad:";
            // 
            // matriculacionOnlineDataSet1
            // 
            this.matriculacionOnlineDataSet1.DataSetName = "MatriculacionOnlineDataSet1";
            this.matriculacionOnlineDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sp_mantenimiento_estudianteBindingSource
            // 
            this.sp_mantenimiento_estudianteBindingSource.DataMember = "sp_mantenimiento_estudiante";
            this.sp_mantenimiento_estudianteBindingSource.DataSource = this.matriculacionOnlineDataSet1;
            // 
            // sp_mantenimiento_estudianteTableAdapter
            // 
            this.sp_mantenimiento_estudianteTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AsignacionDocentesTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CarreraTableAdapter = null;
            this.tableAdapterManager.CatalogosTableAdapter = null;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.DocenteTableAdapter = null;
            this.tableAdapterManager.EstudiantesTableAdapter = null;
            this.tableAdapterManager.MatriculaTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = pMatriculacionOnline.MatriculacionOnlineDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // sp_mantenimiento_estudianteBindingNavigator
            // 
            this.sp_mantenimiento_estudianteBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.sp_mantenimiento_estudianteBindingNavigator.BindingSource = this.sp_mantenimiento_estudianteBindingSource;
            this.sp_mantenimiento_estudianteBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.sp_mantenimiento_estudianteBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.sp_mantenimiento_estudianteBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.sp_mantenimiento_estudianteBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.sp_mantenimiento_estudianteBindingNavigatorSaveItem});
            this.sp_mantenimiento_estudianteBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.sp_mantenimiento_estudianteBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.sp_mantenimiento_estudianteBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.sp_mantenimiento_estudianteBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.sp_mantenimiento_estudianteBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.sp_mantenimiento_estudianteBindingNavigator.Name = "sp_mantenimiento_estudianteBindingNavigator";
            this.sp_mantenimiento_estudianteBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.sp_mantenimiento_estudianteBindingNavigator.Size = new System.Drawing.Size(800, 27);
            this.sp_mantenimiento_estudianteBindingNavigator.TabIndex = 0;
            this.sp_mantenimiento_estudianteBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 24);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // sp_mantenimiento_estudianteBindingNavigatorSaveItem
            // 
            this.sp_mantenimiento_estudianteBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.sp_mantenimiento_estudianteBindingNavigatorSaveItem.Enabled = false;
            this.sp_mantenimiento_estudianteBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("sp_mantenimiento_estudianteBindingNavigatorSaveItem.Image")));
            this.sp_mantenimiento_estudianteBindingNavigatorSaveItem.Name = "sp_mantenimiento_estudianteBindingNavigatorSaveItem";
            this.sp_mantenimiento_estudianteBindingNavigatorSaveItem.Size = new System.Drawing.Size(24, 24);
            this.sp_mantenimiento_estudianteBindingNavigatorSaveItem.Text = "Save Data";
            // 
            // fillToolStrip
            // 
            this.fillToolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.fillToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opcionToolStripLabel,
            this.opcionToolStripTextBox,
            this.idEstudianteToolStripLabel,
            this.idEstudianteToolStripTextBox,
            this.nombreToolStripLabel,
            this.nombreToolStripTextBox,
            this.documentoIdentidadToolStripLabel,
            this.documentoIdentidadToolStripTextBox,
            this.errorToolStripLabel,
            this.errorToolStripTextBox,
            this.fillToolStripButton});
            this.fillToolStrip.Location = new System.Drawing.Point(0, 27);
            this.fillToolStrip.Name = "fillToolStrip";
            this.fillToolStrip.Size = new System.Drawing.Size(640, 23);
            this.fillToolStrip.TabIndex = 1;
            this.fillToolStrip.Text = "fillToolStrip";
            // 
            // opcionToolStripLabel
            // 
            this.opcionToolStripLabel.Name = "opcionToolStripLabel";
            this.opcionToolStripLabel.Size = new System.Drawing.Size(47, 20);
            this.opcionToolStripLabel.Text = "opcion:";
            // 
            // opcionToolStripTextBox
            // 
            this.opcionToolStripTextBox.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.opcionToolStripTextBox.Name = "opcionToolStripTextBox";
            this.opcionToolStripTextBox.Size = new System.Drawing.Size(80, 23);
            // 
            // idEstudianteToolStripLabel
            // 
            this.idEstudianteToolStripLabel.Name = "idEstudianteToolStripLabel";
            this.idEstudianteToolStripLabel.Size = new System.Drawing.Size(75, 20);
            this.idEstudianteToolStripLabel.Text = "idEstudiante:";
            // 
            // idEstudianteToolStripTextBox
            // 
            this.idEstudianteToolStripTextBox.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.idEstudianteToolStripTextBox.Name = "idEstudianteToolStripTextBox";
            this.idEstudianteToolStripTextBox.Size = new System.Drawing.Size(80, 23);
            // 
            // nombreToolStripLabel
            // 
            this.nombreToolStripLabel.Name = "nombreToolStripLabel";
            this.nombreToolStripLabel.Size = new System.Drawing.Size(52, 20);
            this.nombreToolStripLabel.Text = "nombre:";
            // 
            // nombreToolStripTextBox
            // 
            this.nombreToolStripTextBox.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.nombreToolStripTextBox.Name = "nombreToolStripTextBox";
            this.nombreToolStripTextBox.Size = new System.Drawing.Size(80, 23);
            // 
            // documentoIdentidadToolStripLabel
            // 
            this.documentoIdentidadToolStripLabel.Name = "documentoIdentidadToolStripLabel";
            this.documentoIdentidadToolStripLabel.Size = new System.Drawing.Size(122, 20);
            this.documentoIdentidadToolStripLabel.Text = "documentoIdentidad:";
            // 
            // documentoIdentidadToolStripTextBox
            // 
            this.documentoIdentidadToolStripTextBox.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.documentoIdentidadToolStripTextBox.Name = "documentoIdentidadToolStripTextBox";
            this.documentoIdentidadToolStripTextBox.Size = new System.Drawing.Size(80, 27);
            // 
            // errorToolStripLabel
            // 
            this.errorToolStripLabel.Name = "errorToolStripLabel";
            this.errorToolStripLabel.Size = new System.Drawing.Size(35, 15);
            this.errorToolStripLabel.Text = "error:";
            // 
            // errorToolStripTextBox
            // 
            this.errorToolStripTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.errorToolStripTextBox.Name = "errorToolStripTextBox";
            this.errorToolStripTextBox.Size = new System.Drawing.Size(100, 23);
            // 
            // fillToolStripButton
            // 
            this.fillToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillToolStripButton.Name = "fillToolStripButton";
            this.fillToolStripButton.Size = new System.Drawing.Size(26, 19);
            this.fillToolStripButton.Text = "Fill";
            this.fillToolStripButton.Click += new System.EventHandler(this.fillToolStripButton_Click);
            // 
            // idEstudianteTextBox
            // 
            this.idEstudianteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sp_mantenimiento_estudianteBindingSource, "idEstudiante", true));
            this.idEstudianteTextBox.Location = new System.Drawing.Point(183, 87);
            this.idEstudianteTextBox.Name = "idEstudianteTextBox";
            this.idEstudianteTextBox.Size = new System.Drawing.Size(100, 20);
            this.idEstudianteTextBox.TabIndex = 3;
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sp_mantenimiento_estudianteBindingSource, "nombre", true));
            this.nombreTextBox.Location = new System.Drawing.Point(183, 123);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(100, 20);
            this.nombreTextBox.TabIndex = 5;
            // 
            // documentoIdentidadTextBox
            // 
            this.documentoIdentidadTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sp_mantenimiento_estudianteBindingSource, "documentoIdentidad", true));
            this.documentoIdentidadTextBox.Location = new System.Drawing.Point(183, 165);
            this.documentoIdentidadTextBox.Name = "documentoIdentidadTextBox";
            this.documentoIdentidadTextBox.Size = new System.Drawing.Size(100, 20);
            this.documentoIdentidadTextBox.TabIndex = 7;
            // 
            // sp_mantenimiento_estudianteDataGridView
            // 
            this.sp_mantenimiento_estudianteDataGridView.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.sp_mantenimiento_estudianteDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.sp_mantenimiento_estudianteDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sp_mantenimiento_estudianteDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.sp_mantenimiento_estudianteDataGridView.DataSource = this.sp_mantenimiento_estudianteBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.sp_mantenimiento_estudianteDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.sp_mantenimiento_estudianteDataGridView.Location = new System.Drawing.Point(61, 206);
            this.sp_mantenimiento_estudianteDataGridView.Name = "sp_mantenimiento_estudianteDataGridView";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.sp_mantenimiento_estudianteDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.sp_mantenimiento_estudianteDataGridView.Size = new System.Drawing.Size(570, 220);
            this.sp_mantenimiento_estudianteDataGridView.TabIndex = 8;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "idEstudiante";
            this.dataGridViewTextBoxColumn1.HeaderText = "idEstudiante";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "nombre";
            this.dataGridViewTextBoxColumn2.HeaderText = "nombre";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "documentoIdentidad";
            this.dataGridViewTextBoxColumn3.HeaderText = "documentoIdentidad";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // frmRegistroEstudiantes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 471);
            this.Controls.Add(this.sp_mantenimiento_estudianteDataGridView);
            this.Controls.Add(idEstudianteLabel);
            this.Controls.Add(this.idEstudianteTextBox);
            this.Controls.Add(nombreLabel);
            this.Controls.Add(this.nombreTextBox);
            this.Controls.Add(documentoIdentidadLabel);
            this.Controls.Add(this.documentoIdentidadTextBox);
            this.Controls.Add(this.fillToolStrip);
            this.Controls.Add(this.sp_mantenimiento_estudianteBindingNavigator);
            this.Name = "frmRegistroEstudiantes";
            this.Text = "Registros de Estudiantes";
            this.Load += new System.EventHandler(this.frmRegistroEstudiantes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.matriculacionOnlineDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sp_mantenimiento_estudianteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sp_mantenimiento_estudianteBindingNavigator)).EndInit();
            this.sp_mantenimiento_estudianteBindingNavigator.ResumeLayout(false);
            this.sp_mantenimiento_estudianteBindingNavigator.PerformLayout();
            this.fillToolStrip.ResumeLayout(false);
            this.fillToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sp_mantenimiento_estudianteDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MatriculacionOnlineDataSet1 matriculacionOnlineDataSet1;
        private System.Windows.Forms.BindingSource sp_mantenimiento_estudianteBindingSource;
        private MatriculacionOnlineDataSet1TableAdapters.sp_mantenimiento_estudianteTableAdapter sp_mantenimiento_estudianteTableAdapter;
        private MatriculacionOnlineDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator sp_mantenimiento_estudianteBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton sp_mantenimiento_estudianteBindingNavigatorSaveItem;
        private System.Windows.Forms.ToolStrip fillToolStrip;
        private System.Windows.Forms.ToolStripLabel opcionToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox opcionToolStripTextBox;
        private System.Windows.Forms.ToolStripLabel idEstudianteToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox idEstudianteToolStripTextBox;
        private System.Windows.Forms.ToolStripLabel nombreToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox nombreToolStripTextBox;
        private System.Windows.Forms.ToolStripLabel documentoIdentidadToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox documentoIdentidadToolStripTextBox;
        private System.Windows.Forms.ToolStripLabel errorToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox errorToolStripTextBox;
        private System.Windows.Forms.ToolStripButton fillToolStripButton;
        private System.Windows.Forms.TextBox idEstudianteTextBox;
        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.TextBox documentoIdentidadTextBox;
        private System.Windows.Forms.DataGridView sp_mantenimiento_estudianteDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    }
}

