namespace SystemKenkou
{
    partial class Frm_Mov_Venda
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
            System.Windows.Forms.Label cod_vendaLabel;
            System.Windows.Forms.Label valortotal_vendaLabel;
            System.Windows.Forms.Label data_vendaLabel;
            System.Windows.Forms.Label situacaoLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Mov_Venda));
            this.vendaBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.vendaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clinicaDataSet = new SystemKenkou.ClinicaDataSet();
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
            this.vendaBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.cancel = new System.Windows.Forms.ToolStripButton();
            this.edit_tool = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.cod_vendaTextBox = new System.Windows.Forms.TextBox();
            this.valortotal_vendaTextBox = new System.Windows.Forms.TextBox();
            this.grp_venda = new System.Windows.Forms.GroupBox();
            this.pacienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.situacaoComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.data_vendaMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.vendaTableAdapter = new SystemKenkou.ClinicaDataSetTableAdapters.vendaTableAdapter();
            this.tableAdapterManager = new SystemKenkou.ClinicaDataSetTableAdapters.TableAdapterManager();
            this.pacienteTableAdapter = new SystemKenkou.ClinicaDataSetTableAdapters.pacienteTableAdapter();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnLocaProd = new System.Windows.Forms.Button();
            this.txtCodPRod = new System.Windows.Forms.TextBox();
            this.txtDescPRod = new System.Windows.Forms.TextBox();
            this.txt_Valor = new System.Windows.Forms.TextBox();
            this.view_itens_VendaDataGridView = new System.Windows.Forms.DataGridView();
            this.view_itens_VendaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtQtd = new System.Windows.Forms.TextBox();
            this.produtoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.itens_vendaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.itens_vendaTableAdapter = new SystemKenkou.ClinicaDataSetTableAdapters.itens_vendaTableAdapter();
            this.view_itens_VendaTableAdapter = new SystemKenkou.ClinicaDataSetTableAdapters.View_itens_VendaTableAdapter();
            this.produtoTableAdapter = new SystemKenkou.ClinicaDataSetTableAdapters.produtoTableAdapter();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            cod_vendaLabel = new System.Windows.Forms.Label();
            valortotal_vendaLabel = new System.Windows.Forms.Label();
            data_vendaLabel = new System.Windows.Forms.Label();
            situacaoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.vendaBindingNavigator)).BeginInit();
            this.vendaBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vendaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clinicaDataSet)).BeginInit();
            this.grp_venda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pacienteBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.view_itens_VendaDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.view_itens_VendaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itens_vendaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cod_vendaLabel
            // 
            cod_vendaLabel.AutoSize = true;
            cod_vendaLabel.Location = new System.Drawing.Point(77, 69);
            cod_vendaLabel.Name = "cod_vendaLabel";
            cod_vendaLabel.Size = new System.Drawing.Size(136, 20);
            cod_vendaLabel.TabIndex = 1;
            cod_vendaLabel.Text = "Código da Venda:";
            // 
            // valortotal_vendaLabel
            // 
            valortotal_vendaLabel.AutoSize = true;
            valortotal_vendaLabel.Location = new System.Drawing.Point(457, 69);
            valortotal_vendaLabel.Name = "valortotal_vendaLabel";
            valortotal_vendaLabel.Size = new System.Drawing.Size(123, 20);
            valortotal_vendaLabel.TabIndex = 3;
            valortotal_vendaLabel.Text = "Valor da Venda:";
            // 
            // data_vendaLabel
            // 
            data_vendaLabel.AutoSize = true;
            data_vendaLabel.Location = new System.Drawing.Point(459, 117);
            data_vendaLabel.Name = "data_vendaLabel";
            data_vendaLabel.Size = new System.Drawing.Size(121, 20);
            data_vendaLabel.TabIndex = 5;
            data_vendaLabel.Text = "Data da Venda:";
            // 
            // situacaoLabel
            // 
            situacaoLabel.AutoSize = true;
            situacaoLabel.Location = new System.Drawing.Point(457, 182);
            situacaoLabel.Name = "situacaoLabel";
            situacaoLabel.Size = new System.Drawing.Size(72, 20);
            situacaoLabel.TabIndex = 7;
            situacaoLabel.Text = "Situação";
            // 
            // vendaBindingNavigator
            // 
            this.vendaBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.vendaBindingNavigator.BackColor = System.Drawing.SystemColors.Window;
            this.vendaBindingNavigator.BindingSource = this.vendaBindingSource;
            this.vendaBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.vendaBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.vendaBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.vendaBindingNavigatorSaveItem,
            this.cancel,
            this.edit_tool,
            this.bindingNavigatorDeleteItem,
            this.toolStripButton3});
            this.vendaBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.vendaBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.vendaBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.vendaBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.vendaBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.vendaBindingNavigator.Name = "vendaBindingNavigator";
            this.vendaBindingNavigator.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.vendaBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.vendaBindingNavigator.Size = new System.Drawing.Size(783, 25);
            this.vendaBindingNavigator.TabIndex = 5;
            this.vendaBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = global::SystemKenkou.Properties.Resources.new1;
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Adicionar Novo";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
            // 
            // vendaBindingSource
            // 
            this.vendaBindingSource.DataMember = "venda";
            this.vendaBindingSource.DataSource = this.clinicaDataSet;
            // 
            // clinicaDataSet
            // 
            this.clinicaDataSet.DataSetName = "ClinicaDataSet";
            this.clinicaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = global::SystemKenkou.Properties.Resources.lixeira;
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Deletar";
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click);
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = global::SystemKenkou.Properties.Resources.recuo1;
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = global::SystemKenkou.Properties.Resources.ante1;
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = global::SystemKenkou.Properties.Resources.advence1;
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = global::SystemKenkou.Properties.Resources.next1;
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // vendaBindingNavigatorSaveItem
            // 
            this.vendaBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.vendaBindingNavigatorSaveItem.Image = global::SystemKenkou.Properties.Resources.save11;
            this.vendaBindingNavigatorSaveItem.Name = "vendaBindingNavigatorSaveItem";
            this.vendaBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.vendaBindingNavigatorSaveItem.Text = "Save";
            this.vendaBindingNavigatorSaveItem.Click += new System.EventHandler(this.vendaBindingNavigatorSaveItem_Click);
            // 
            // cancel
            // 
            this.cancel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cancel.Image = global::SystemKenkou.Properties.Resources.error1;
            this.cancel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(23, 22);
            this.cancel.Text = "Cancelar";
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // edit_tool
            // 
            this.edit_tool.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.edit_tool.Image = global::SystemKenkou.Properties.Resources.draw1;
            this.edit_tool.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.edit_tool.Name = "edit_tool";
            this.edit_tool.Size = new System.Drawing.Size(23, 22);
            this.edit_tool.Text = "Editar";
            this.edit_tool.Click += new System.EventHandler(this.edit_tool_Click);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = global::SystemKenkou.Properties.Resources._1470067030_common_logout_signout_exit_outline_stroke;
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton3.Tag = "Sair";
            this.toolStripButton3.Text = "Sair";
            this.toolStripButton3.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // cod_vendaTextBox
            // 
            this.cod_vendaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vendaBindingSource, "cod_venda", true));
            this.cod_vendaTextBox.Enabled = false;
            this.cod_vendaTextBox.Location = new System.Drawing.Point(219, 66);
            this.cod_vendaTextBox.Name = "cod_vendaTextBox";
            this.cod_vendaTextBox.Size = new System.Drawing.Size(49, 26);
            this.cod_vendaTextBox.TabIndex = 1;
            this.cod_vendaTextBox.TextChanged += new System.EventHandler(this.cod_vendaTextBox_TextChanged);
            // 
            // valortotal_vendaTextBox
            // 
            this.valortotal_vendaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vendaBindingSource, "valortotal_venda", true));
            this.valortotal_vendaTextBox.Location = new System.Drawing.Point(586, 63);
            this.valortotal_vendaTextBox.Name = "valortotal_vendaTextBox";
            this.valortotal_vendaTextBox.Size = new System.Drawing.Size(130, 26);
            this.valortotal_vendaTextBox.TabIndex = 2;
            // 
            // grp_venda
            // 
            this.grp_venda.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grp_venda.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.grp_venda.Controls.Add(this.situacaoComboBox);
            this.grp_venda.Controls.Add(this.label1);
            this.grp_venda.Controls.Add(this.data_vendaMaskedTextBox);
            this.grp_venda.Controls.Add(cod_vendaLabel);
            this.grp_venda.Controls.Add(this.cod_vendaTextBox);
            this.grp_venda.Controls.Add(valortotal_vendaLabel);
            this.grp_venda.Controls.Add(this.valortotal_vendaTextBox);
            this.grp_venda.Controls.Add(data_vendaLabel);
            this.grp_venda.Controls.Add(situacaoLabel);
            this.grp_venda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grp_venda.ForeColor = System.Drawing.SystemColors.Window;
            this.grp_venda.Location = new System.Drawing.Point(19, 38);
            this.grp_venda.Name = "grp_venda";
            this.grp_venda.Size = new System.Drawing.Size(746, 229);
            this.grp_venda.TabIndex = 9;
            this.grp_venda.TabStop = false;
            this.grp_venda.Text = "Dados:";
            // 
            // pacienteBindingSource
            // 
            this.pacienteBindingSource.DataMember = "paciente";
            this.pacienteBindingSource.DataSource = this.clinicaDataSet;
            // 
            // situacaoComboBox
            // 
            this.situacaoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vendaBindingSource, "situacao", true));
            this.situacaoComboBox.FormattingEnabled = true;
            this.situacaoComboBox.Items.AddRange(new object[] {
            "Aberta",
            "Finalizada"});
            this.situacaoComboBox.Location = new System.Drawing.Point(586, 174);
            this.situacaoComboBox.Name = "situacaoComboBox";
            this.situacaoComboBox.Size = new System.Drawing.Size(149, 28);
            this.situacaoComboBox.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(170, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 20);
            this.label1.TabIndex = 18;
            this.label1.Text = "Cadastro de Venda";
            // 
            // data_vendaMaskedTextBox
            // 
            this.data_vendaMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vendaBindingSource, "data_venda", true));
            this.data_vendaMaskedTextBox.Location = new System.Drawing.Point(586, 114);
            this.data_vendaMaskedTextBox.Mask = "00/00/0000";
            this.data_vendaMaskedTextBox.Name = "data_vendaMaskedTextBox";
            this.data_vendaMaskedTextBox.Size = new System.Drawing.Size(102, 26);
            this.data_vendaMaskedTextBox.TabIndex = 3;
            this.data_vendaMaskedTextBox.ValidatingType = typeof(System.DateTime);
            // 
            // vendaTableAdapter
            // 
            this.vendaTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.cidadeTableAdapter = null;
            this.tableAdapterManager.consultaTableAdapter = null;
            this.tableAdapterManager.conta_receberTableAdapter = null;
            this.tableAdapterManager.itens_vendaTableAdapter = null;
            this.tableAdapterManager.medicoTableAdapter = null;
            this.tableAdapterManager.pacienteTableAdapter = null;
            this.tableAdapterManager.produtoTableAdapter = null;
            this.tableAdapterManager.sessaoTableAdapter = null;
            this.tableAdapterManager.tipo_de_tratamentoTableAdapter = null;
            this.tableAdapterManager.tratamento_tipos_tratamentoTableAdapter = null;
            this.tableAdapterManager.tratamentoTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = SystemKenkou.ClinicaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsuáriosTableAdapter = null;
            this.tableAdapterManager.vendaTableAdapter = this.vendaTableAdapter;
            // 
            // pacienteTableAdapter
            // 
            this.pacienteTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnLocaProd);
            this.groupBox1.Controls.Add(this.txtCodPRod);
            this.groupBox1.Controls.Add(this.txtDescPRod);
            this.groupBox1.Controls.Add(this.txt_Valor);
            this.groupBox1.Controls.Add(this.view_itens_VendaDataGridView);
            this.groupBox1.Controls.Add(this.txtQtd);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(18, 289);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(746, 377);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Itens";
            // 
            // btnLocaProd
            // 
            this.btnLocaProd.BackColor = System.Drawing.Color.White;
            this.btnLocaProd.BackgroundImage = global::SystemKenkou.Properties.Resources.lupa;
            this.btnLocaProd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLocaProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLocaProd.Location = new System.Drawing.Point(367, 59);
            this.btnLocaProd.Name = "btnLocaProd";
            this.btnLocaProd.Size = new System.Drawing.Size(35, 28);
            this.btnLocaProd.TabIndex = 6;
            this.btnLocaProd.UseVisualStyleBackColor = false;
            this.btnLocaProd.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // txtCodPRod
            // 
            this.txtCodPRod.Enabled = false;
            this.txtCodPRod.Location = new System.Drawing.Point(11, 59);
            this.txtCodPRod.Name = "txtCodPRod";
            this.txtCodPRod.Size = new System.Drawing.Size(55, 26);
            this.txtCodPRod.TabIndex = 5;
            // 
            // txtDescPRod
            // 
            this.txtDescPRod.Enabled = false;
            this.txtDescPRod.Location = new System.Drawing.Point(82, 62);
            this.txtDescPRod.Name = "txtDescPRod";
            this.txtDescPRod.Size = new System.Drawing.Size(279, 26);
            this.txtDescPRod.TabIndex = 4;
            // 
            // txt_Valor
            // 
            this.txt_Valor.Location = new System.Drawing.Point(587, 62);
            this.txt_Valor.Name = "txt_Valor";
            this.txt_Valor.Size = new System.Drawing.Size(100, 26);
            this.txt_Valor.TabIndex = 3;
            this.txt_Valor.TextChanged += new System.EventHandler(this.txt_Valor_TextChanged);
            this.txt_Valor.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_Valor_KeyDown);
            // 
            // view_itens_VendaDataGridView
            // 
            this.view_itens_VendaDataGridView.AllowUserToAddRows = false;
            this.view_itens_VendaDataGridView.AllowUserToDeleteRows = false;
            this.view_itens_VendaDataGridView.AutoGenerateColumns = false;
            this.view_itens_VendaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.view_itens_VendaDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.view_itens_VendaDataGridView.DataSource = this.view_itens_VendaBindingSource;
            this.view_itens_VendaDataGridView.Location = new System.Drawing.Point(6, 111);
            this.view_itens_VendaDataGridView.Name = "view_itens_VendaDataGridView";
            this.view_itens_VendaDataGridView.ReadOnly = true;
            this.view_itens_VendaDataGridView.Size = new System.Drawing.Size(734, 220);
            this.view_itens_VendaDataGridView.TabIndex = 2;
            // 
            // view_itens_VendaBindingSource
            // 
            this.view_itens_VendaBindingSource.DataMember = "View_itens_Venda";
            this.view_itens_VendaBindingSource.DataSource = this.clinicaDataSet;
            // 
            // txtQtd
            // 
            this.txtQtd.Location = new System.Drawing.Point(458, 62);
            this.txtQtd.Name = "txtQtd";
            this.txtQtd.Size = new System.Drawing.Size(100, 26);
            this.txtQtd.TabIndex = 2;
            this.txtQtd.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtQtd_KeyDown);
            // 
            // produtoBindingSource
            // 
            this.produtoBindingSource.DataMember = "produto";
            this.produtoBindingSource.DataSource = this.clinicaDataSet;
            // 
            // itens_vendaBindingSource
            // 
            this.itens_vendaBindingSource.DataMember = "itens_venda";
            this.itens_vendaBindingSource.DataSource = this.clinicaDataSet;
            // 
            // itens_vendaTableAdapter
            // 
            this.itens_vendaTableAdapter.ClearBeforeFill = true;
            // 
            // view_itens_VendaTableAdapter
            // 
            this.view_itens_VendaTableAdapter.ClearBeforeFill = true;
            // 
            // produtoTableAdapter
            // 
            this.produtoTableAdapter.ClearBeforeFill = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(78, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Produto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Código";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(454, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Quantidade";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(583, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Valor R$ ";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "cod_item";
            this.dataGridViewTextBoxColumn1.HeaderText = "cod_item";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "cod_venda";
            this.dataGridViewTextBoxColumn2.HeaderText = "cod_venda";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Visible = false;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "cod_prod";
            this.dataGridViewTextBoxColumn3.HeaderText = "cod_prod";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Visible = false;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "nome_prod";
            this.dataGridViewTextBoxColumn4.HeaderText = "Produto";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 300;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "quant_item";
            this.dataGridViewTextBoxColumn5.HeaderText = "Quantidade";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "valor_unit";
            this.dataGridViewTextBoxColumn6.HeaderText = "Valor unitario";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "SubTotal";
            this.dataGridViewTextBoxColumn7.HeaderText = "SubTotal";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // Frm_Mov_Venda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SystemKenkou.Properties.Resources.Sem_título7;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(783, 691);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grp_venda);
            this.Controls.Add(this.vendaBindingNavigator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_Mov_Venda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_Venda";
            this.Load += new System.EventHandler(this.Frm_Venda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vendaBindingNavigator)).EndInit();
            this.vendaBindingNavigator.ResumeLayout(false);
            this.vendaBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vendaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clinicaDataSet)).EndInit();
            this.grp_venda.ResumeLayout(false);
            this.grp_venda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pacienteBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.view_itens_VendaDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.view_itens_VendaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itens_vendaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ClinicaDataSet clinicaDataSet;
        private System.Windows.Forms.BindingSource vendaBindingSource;
        private ClinicaDataSetTableAdapters.vendaTableAdapter vendaTableAdapter;
        private ClinicaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator vendaBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton vendaBindingNavigatorSaveItem;
        private System.Windows.Forms.ToolStripButton cancel;
        private System.Windows.Forms.ToolStripButton edit_tool;
        private System.Windows.Forms.TextBox cod_vendaTextBox;
        private System.Windows.Forms.TextBox valortotal_vendaTextBox;
        private System.Windows.Forms.GroupBox grp_venda;
        private System.Windows.Forms.MaskedTextBox data_vendaMaskedTextBox;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox situacaoComboBox;
        private System.Windows.Forms.BindingSource pacienteBindingSource;
        private ClinicaDataSetTableAdapters.pacienteTableAdapter pacienteTableAdapter;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.BindingSource itens_vendaBindingSource;
        private ClinicaDataSetTableAdapters.itens_vendaTableAdapter itens_vendaTableAdapter;
        private System.Windows.Forms.TextBox txtQtd;
        private System.Windows.Forms.BindingSource view_itens_VendaBindingSource;
        private ClinicaDataSetTableAdapters.View_itens_VendaTableAdapter view_itens_VendaTableAdapter;
        private System.Windows.Forms.DataGridView view_itens_VendaDataGridView;
        private System.Windows.Forms.TextBox txt_Valor;
        private System.Windows.Forms.BindingSource produtoBindingSource;
        private ClinicaDataSetTableAdapters.produtoTableAdapter produtoTableAdapter;
        private System.Windows.Forms.Button btnLocaProd;
        private System.Windows.Forms.TextBox txtCodPRod;
        private System.Windows.Forms.TextBox txtDescPRod;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
    }
}