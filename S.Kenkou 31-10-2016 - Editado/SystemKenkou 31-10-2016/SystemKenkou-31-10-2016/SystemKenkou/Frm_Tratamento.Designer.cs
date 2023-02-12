namespace SystemKenkou
{
    partial class Frm_Tratamento
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
            System.Windows.Forms.Label cod_tratamentoLabel;
            System.Windows.Forms.Label data_tratamentoLabel;
            System.Windows.Forms.Label cod_pacLabel;
            System.Windows.Forms.Label desc_tratamentoLabel;
            System.Windows.Forms.Label cod_consultaLabel;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Tratamento));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cod_consultaTextBox = new System.Windows.Forms.TextBox();
            this.tratamentoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clinicaDataSet = new SystemKenkou.ClinicaDataSet();
            this.comboPacientes = new System.Windows.Forms.ComboBox();
            this.pacienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.cod_tratamentoTextBox = new System.Windows.Forms.TextBox();
            this.data_tratamentoMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.desc_tratamentoTextBox = new System.Windows.Forms.TextBox();
            this.tratamentoTableAdapter = new SystemKenkou.ClinicaDataSetTableAdapters.tratamentoTableAdapter();
            this.tableAdapterManager = new SystemKenkou.ClinicaDataSetTableAdapters.TableAdapterManager();
            this.tipo_de_tratamentoTableAdapter = new SystemKenkou.ClinicaDataSetTableAdapters.tipo_de_tratamentoTableAdapter();
            this.clienteBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.clienteBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.pacienteTableAdapter = new SystemKenkou.ClinicaDataSetTableAdapters.pacienteTableAdapter();
            this.tratamento_tipos_tratamentoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tratamento_tipos_tratamentoTableAdapter = new SystemKenkou.ClinicaDataSetTableAdapters.tratamento_tipos_tratamentoTableAdapter();
            this.comboTratamentos = new System.Windows.Forms.ComboBox();
            this.tipodetratamentoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnAddTrat = new System.Windows.Forms.Button();
            this.view_tratamento_tipos_tratamentoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.view_tratamento_tipos_tratamentoTableAdapter = new SystemKenkou.ClinicaDataSetTableAdapters.View_tratamento_tipos_tratamentoTableAdapter();
            this.view_tratamento_tipos_tratamentoDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sessaoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sessaoTableAdapter = new SystemKenkou.ClinicaDataSetTableAdapters.sessaoTableAdapter();
            this.btSalvarSessoes = new System.Windows.Forms.Button();
            this.txtData = new System.Windows.Forms.DateTimePicker();
            this.txtHorario = new System.Windows.Forms.MaskedTextBox();
            this.txtValorSessao = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.sessaoDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            cod_tratamentoLabel = new System.Windows.Forms.Label();
            data_tratamentoLabel = new System.Windows.Forms.Label();
            cod_pacLabel = new System.Windows.Forms.Label();
            desc_tratamentoLabel = new System.Windows.Forms.Label();
            cod_consultaLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tratamentoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clinicaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingNavigator)).BeginInit();
            this.clienteBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tratamento_tipos_tratamentoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipodetratamentoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.view_tratamento_tipos_tratamentoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.view_tratamento_tipos_tratamentoDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sessaoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sessaoDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // cod_tratamentoLabel
            // 
            cod_tratamentoLabel.AutoSize = true;
            cod_tratamentoLabel.Location = new System.Drawing.Point(36, 94);
            cod_tratamentoLabel.Name = "cod_tratamentoLabel";
            cod_tratamentoLabel.Size = new System.Drawing.Size(140, 18);
            cod_tratamentoLabel.TabIndex = 0;
            cod_tratamentoLabel.Text = "Código Tratamento:";
            // 
            // data_tratamentoLabel
            // 
            data_tratamentoLabel.AutoSize = true;
            data_tratamentoLabel.Location = new System.Drawing.Point(36, 226);
            data_tratamentoLabel.Name = "data_tratamentoLabel";
            data_tratamentoLabel.Size = new System.Drawing.Size(161, 18);
            data_tratamentoLabel.TabIndex = 2;
            data_tratamentoLabel.Text = "Data Início Tratamento:";
            // 
            // cod_pacLabel
            // 
            cod_pacLabel.AutoSize = true;
            cod_pacLabel.Location = new System.Drawing.Point(36, 286);
            cod_pacLabel.Name = "cod_pacLabel";
            cod_pacLabel.Size = new System.Drawing.Size(69, 18);
            cod_pacLabel.TabIndex = 4;
            cod_pacLabel.Text = "Paciente:";
            // 
            // desc_tratamentoLabel
            // 
            desc_tratamentoLabel.AutoSize = true;
            desc_tratamentoLabel.Location = new System.Drawing.Point(144, 376);
            desc_tratamentoLabel.Name = "desc_tratamentoLabel";
            desc_tratamentoLabel.Size = new System.Drawing.Size(160, 18);
            desc_tratamentoLabel.TabIndex = 6;
            desc_tratamentoLabel.Text = "Descrição Tratamento:";
            // 
            // cod_consultaLabel
            // 
            cod_consultaLabel.AutoSize = true;
            cod_consultaLabel.Location = new System.Drawing.Point(36, 163);
            cod_consultaLabel.Name = "cod_consultaLabel";
            cod_consultaLabel.Size = new System.Drawing.Size(123, 18);
            cod_consultaLabel.TabIndex = 9;
            cod_consultaLabel.Text = "Código Consulta:";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(cod_consultaLabel);
            this.groupBox1.Controls.Add(this.cod_consultaTextBox);
            this.groupBox1.Controls.Add(this.comboPacientes);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(cod_tratamentoLabel);
            this.groupBox1.Controls.Add(this.cod_tratamentoTextBox);
            this.groupBox1.Controls.Add(data_tratamentoLabel);
            this.groupBox1.Controls.Add(this.data_tratamentoMaskedTextBox);
            this.groupBox1.Controls.Add(cod_pacLabel);
            this.groupBox1.Controls.Add(desc_tratamentoLabel);
            this.groupBox1.Controls.Add(this.desc_tratamentoTextBox);
            this.groupBox1.Enabled = false;
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Window;
            this.groupBox1.Location = new System.Drawing.Point(40, 104);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(436, 503);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados:";
            // 
            // cod_consultaTextBox
            // 
            this.cod_consultaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tratamentoBindingSource, "cod_consulta", true));
            this.cod_consultaTextBox.Location = new System.Drawing.Point(39, 190);
            this.cod_consultaTextBox.Name = "cod_consultaTextBox";
            this.cod_consultaTextBox.Size = new System.Drawing.Size(52, 24);
            this.cod_consultaTextBox.TabIndex = 10;
            // 
            // tratamentoBindingSource
            // 
            this.tratamentoBindingSource.DataMember = "tratamento";
            this.tratamentoBindingSource.DataSource = this.clinicaDataSet;
            // 
            // clinicaDataSet
            // 
            this.clinicaDataSet.DataSetName = "ClinicaDataSet";
            this.clinicaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comboPacientes
            // 
            this.comboPacientes.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.tratamentoBindingSource, "cod_pac", true));
            this.comboPacientes.DataSource = this.pacienteBindingSource;
            this.comboPacientes.DisplayMember = "nome_pac";
            this.comboPacientes.FormattingEnabled = true;
            this.comboPacientes.Location = new System.Drawing.Point(39, 307);
            this.comboPacientes.Name = "comboPacientes";
            this.comboPacientes.Size = new System.Drawing.Size(227, 26);
            this.comboPacientes.TabIndex = 3;
            this.comboPacientes.ValueMember = "cod_pac";
            // 
            // pacienteBindingSource
            // 
            this.pacienteBindingSource.DataMember = "paciente";
            this.pacienteBindingSource.DataSource = this.clinicaDataSet;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(155, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 18);
            this.label1.TabIndex = 8;
            this.label1.Text = "Cadastro Tratamento";
            // 
            // cod_tratamentoTextBox
            // 
            this.cod_tratamentoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tratamentoBindingSource, "cod_tratamento", true));
            this.cod_tratamentoTextBox.Enabled = false;
            this.cod_tratamentoTextBox.Location = new System.Drawing.Point(39, 125);
            this.cod_tratamentoTextBox.Name = "cod_tratamentoTextBox";
            this.cod_tratamentoTextBox.Size = new System.Drawing.Size(52, 24);
            this.cod_tratamentoTextBox.TabIndex = 1;
            this.cod_tratamentoTextBox.TextChanged += new System.EventHandler(this.cod_tratamentoTextBox_TextChanged);
            // 
            // data_tratamentoMaskedTextBox
            // 
            this.data_tratamentoMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tratamentoBindingSource, "data_tratamento", true));
            this.data_tratamentoMaskedTextBox.Location = new System.Drawing.Point(39, 247);
            this.data_tratamentoMaskedTextBox.Mask = "00/00/0000";
            this.data_tratamentoMaskedTextBox.Name = "data_tratamentoMaskedTextBox";
            this.data_tratamentoMaskedTextBox.Size = new System.Drawing.Size(84, 24);
            this.data_tratamentoMaskedTextBox.TabIndex = 2;
            this.data_tratamentoMaskedTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.data_tratamentoMaskedTextBox.ValidatingType = typeof(System.DateTime);
            // 
            // desc_tratamentoTextBox
            // 
            this.desc_tratamentoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tratamentoBindingSource, "desc_tratamento", true));
            this.desc_tratamentoTextBox.Location = new System.Drawing.Point(39, 397);
            this.desc_tratamentoTextBox.MaxLength = 100;
            this.desc_tratamentoTextBox.Multiline = true;
            this.desc_tratamentoTextBox.Name = "desc_tratamentoTextBox";
            this.desc_tratamentoTextBox.Size = new System.Drawing.Size(366, 89);
            this.desc_tratamentoTextBox.TabIndex = 4;
            // 
            // tratamentoTableAdapter
            // 
            this.tratamentoTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.tipo_de_tratamentoTableAdapter = this.tipo_de_tratamentoTableAdapter;
            this.tableAdapterManager.tratamento_tipos_tratamentoTableAdapter = null;
            this.tableAdapterManager.tratamentoTableAdapter = this.tratamentoTableAdapter;
            this.tableAdapterManager.UpdateOrder = SystemKenkou.ClinicaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsuáriosTableAdapter = null;
            this.tableAdapterManager.vendaTableAdapter = null;
            // 
            // tipo_de_tratamentoTableAdapter
            // 
            this.tipo_de_tratamentoTableAdapter.ClearBeforeFill = true;
            // 
            // clienteBindingNavigator
            // 
            this.clienteBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.clienteBindingNavigator.BackColor = System.Drawing.SystemColors.Window;
            this.clienteBindingNavigator.BindingSource = this.tratamentoBindingSource;
            this.clienteBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.clienteBindingNavigator.DeleteItem = null;
            this.clienteBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.clienteBindingNavigatorSaveItem,
            this.toolStripButton1,
            this.toolStripButton2,
            this.bindingNavigatorDeleteItem,
            this.toolStripButton3});
            this.clienteBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.clienteBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.clienteBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.clienteBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.clienteBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.clienteBindingNavigator.Name = "clienteBindingNavigator";
            this.clienteBindingNavigator.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.clienteBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.clienteBindingNavigator.Size = new System.Drawing.Size(1210, 25);
            this.clienteBindingNavigator.TabIndex = 6;
            this.clienteBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.ForeColor = System.Drawing.SystemColors.InfoText;
            this.bindingNavigatorAddNewItem.Image = global::SystemKenkou.Properties.Resources._new;
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(78, 22);
            this.bindingNavigatorAddNewItem.Tag = "Adicionar";
            this.bindingNavigatorAddNewItem.Text = "Adicionar";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = global::SystemKenkou.Properties.Resources.recuo;
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = global::SystemKenkou.Properties.Resources.ante;
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
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(73, 23);
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
            this.bindingNavigatorMoveNextItem.Image = global::SystemKenkou.Properties.Resources.next;
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = global::SystemKenkou.Properties.Resources.advence;
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
            // clienteBindingNavigatorSaveItem
            // 
            this.clienteBindingNavigatorSaveItem.ForeColor = System.Drawing.SystemColors.InfoText;
            this.clienteBindingNavigatorSaveItem.Image = global::SystemKenkou.Properties.Resources.save1;
            this.clienteBindingNavigatorSaveItem.Name = "clienteBindingNavigatorSaveItem";
            this.clienteBindingNavigatorSaveItem.Size = new System.Drawing.Size(58, 22);
            this.clienteBindingNavigatorSaveItem.Tag = "Salvar";
            this.clienteBindingNavigatorSaveItem.Text = "Salvar";
            this.clienteBindingNavigatorSaveItem.Click += new System.EventHandler(this.clienteBindingNavigatorSaveItem_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.ForeColor = System.Drawing.SystemColors.InfoText;
            this.toolStripButton1.Image = global::SystemKenkou.Properties.Resources.error;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(73, 22);
            this.toolStripButton1.Tag = "Cancelar";
            this.toolStripButton1.Text = "Cancelar";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.ForeColor = System.Drawing.SystemColors.InfoText;
            this.toolStripButton2.Image = global::SystemKenkou.Properties.Resources.draw;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(57, 22);
            this.toolStripButton2.Tag = "Editar";
            this.toolStripButton2.Text = "Editar";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.ForeColor = System.Drawing.SystemColors.InfoText;
            this.bindingNavigatorDeleteItem.Image = global::SystemKenkou.Properties.Resources.lixeira;
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(64, 22);
            this.bindingNavigatorDeleteItem.Tag = "Deletar";
            this.bindingNavigatorDeleteItem.Text = "Deletar";
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.ForeColor = System.Drawing.SystemColors.InfoText;
            this.toolStripButton3.Image = global::SystemKenkou.Properties.Resources._1470067030_common_logout_signout_exit_outline_stroke;
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(46, 22);
            this.toolStripButton3.Tag = "Sair";
            this.toolStripButton3.Text = "Sair";
            this.toolStripButton3.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // pacienteTableAdapter
            // 
            this.pacienteTableAdapter.ClearBeforeFill = true;
            // 
            // tratamento_tipos_tratamentoBindingSource
            // 
            this.tratamento_tipos_tratamentoBindingSource.DataMember = "tratamento_tipos_tratamento";
            this.tratamento_tipos_tratamentoBindingSource.DataSource = this.clinicaDataSet;
            // 
            // tratamento_tipos_tratamentoTableAdapter
            // 
            this.tratamento_tipos_tratamentoTableAdapter.ClearBeforeFill = true;
            // 
            // comboTratamentos
            // 
            this.comboTratamentos.DataSource = this.tipodetratamentoBindingSource;
            this.comboTratamentos.DisplayMember = "nome_tptratamento";
            this.comboTratamentos.FormattingEnabled = true;
            this.comboTratamentos.Location = new System.Drawing.Point(524, 51);
            this.comboTratamentos.Name = "comboTratamentos";
            this.comboTratamentos.Size = new System.Drawing.Size(306, 26);
            this.comboTratamentos.TabIndex = 7;
            this.comboTratamentos.ValueMember = "cod_tptratamento";
            // 
            // tipodetratamentoBindingSource
            // 
            this.tipodetratamentoBindingSource.DataMember = "tipo_de_tratamento";
            this.tipodetratamentoBindingSource.DataSource = this.clinicaDataSet;
            // 
            // btnAddTrat
            // 
            this.btnAddTrat.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAddTrat.Location = new System.Drawing.Point(836, 51);
            this.btnAddTrat.Name = "btnAddTrat";
            this.btnAddTrat.Size = new System.Drawing.Size(85, 26);
            this.btnAddTrat.TabIndex = 8;
            this.btnAddTrat.Text = "Adicionar";
            this.btnAddTrat.UseVisualStyleBackColor = true;
            this.btnAddTrat.Click += new System.EventHandler(this.btnAddTrat_Click);
            // 
            // view_tratamento_tipos_tratamentoBindingSource
            // 
            this.view_tratamento_tipos_tratamentoBindingSource.DataMember = "View_tratamento_tipos_tratamento";
            this.view_tratamento_tipos_tratamentoBindingSource.DataSource = this.clinicaDataSet;
            // 
            // view_tratamento_tipos_tratamentoTableAdapter
            // 
            this.view_tratamento_tipos_tratamentoTableAdapter.ClearBeforeFill = true;
            // 
            // view_tratamento_tipos_tratamentoDataGridView
            // 
            this.view_tratamento_tipos_tratamentoDataGridView.AllowUserToAddRows = false;
            this.view_tratamento_tipos_tratamentoDataGridView.AllowUserToDeleteRows = false;
            this.view_tratamento_tipos_tratamentoDataGridView.AutoGenerateColumns = false;
            this.view_tratamento_tipos_tratamentoDataGridView.BackgroundColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.view_tratamento_tipos_tratamentoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.view_tratamento_tipos_tratamentoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.view_tratamento_tipos_tratamentoDataGridView.DataSource = this.view_tratamento_tipos_tratamentoBindingSource;
            this.view_tratamento_tipos_tratamentoDataGridView.Location = new System.Drawing.Point(524, 100);
            this.view_tratamento_tipos_tratamentoDataGridView.Name = "view_tratamento_tipos_tratamentoDataGridView";
            this.view_tratamento_tipos_tratamentoDataGridView.ReadOnly = true;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Maroon;
            this.view_tratamento_tipos_tratamentoDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.view_tratamento_tipos_tratamentoDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.view_tratamento_tipos_tratamentoDataGridView.Size = new System.Drawing.Size(377, 220);
            this.view_tratamento_tipos_tratamentoDataGridView.TabIndex = 8;
            this.view_tratamento_tipos_tratamentoDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.view_tratamento_tipos_tratamentoDataGridView_CellDoubleClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "cod_tratamento";
            this.dataGridViewTextBoxColumn1.HeaderText = "cod_tratamento";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "cod_tptratamento";
            this.dataGridViewTextBoxColumn2.HeaderText = "cod_tptratamento";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Visible = false;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "nome_tptratamento";
            this.dataGridViewTextBoxColumn3.FillWeight = 250F;
            this.dataGridViewTextBoxColumn3.HeaderText = "Nome Tipo de Tratamento";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn3.Width = 188;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "desc_tptratamento";
            this.dataGridViewTextBoxColumn4.FillWeight = 400F;
            this.dataGridViewTextBoxColumn4.HeaderText = "Descrição Tipo de Tratamento";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 144;
            // 
            // sessaoBindingSource
            // 
            this.sessaoBindingSource.DataMember = "sessao";
            this.sessaoBindingSource.DataSource = this.clinicaDataSet;
            this.sessaoBindingSource.AddingNew += new System.ComponentModel.AddingNewEventHandler(this.sessaoBindingSource_AddingNew);
            // 
            // sessaoTableAdapter
            // 
            this.sessaoTableAdapter.ClearBeforeFill = true;
            // 
            // btSalvarSessoes
            // 
            this.btSalvarSessoes.ForeColor = System.Drawing.Color.Black;
            this.btSalvarSessoes.Location = new System.Drawing.Point(1042, 376);
            this.btSalvarSessoes.Name = "btSalvarSessoes";
            this.btSalvarSessoes.Size = new System.Drawing.Size(140, 34);
            this.btSalvarSessoes.TabIndex = 9;
            this.btSalvarSessoes.Text = "Incluir Sessão";
            this.btSalvarSessoes.UseVisualStyleBackColor = true;
            this.btSalvarSessoes.Click += new System.EventHandler(this.btSalvarSessoes_Click);
            // 
            // txtData
            // 
            this.txtData.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtData.Location = new System.Drawing.Point(524, 384);
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(98, 24);
            this.txtData.TabIndex = 10;
            // 
            // txtHorario
            // 
            this.txtHorario.Location = new System.Drawing.Point(701, 386);
            this.txtHorario.Mask = "00:00";
            this.txtHorario.Name = "txtHorario";
            this.txtHorario.Size = new System.Drawing.Size(100, 24);
            this.txtHorario.TabIndex = 11;
            this.txtHorario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtHorario.ValidatingType = typeof(System.DateTime);
            // 
            // txtValorSessao
            // 
            this.txtValorSessao.Location = new System.Drawing.Point(866, 384);
            this.txtValorSessao.Name = "txtValorSessao";
            this.txtValorSessao.Size = new System.Drawing.Size(100, 24);
            this.txtValorSessao.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(521, 358);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 18);
            this.label2.TabIndex = 13;
            this.label2.Text = "Data da Sessão";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(698, 358);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 18);
            this.label3.TabIndex = 14;
            this.label3.Text = "Horário da Sessão";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(863, 358);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 18);
            this.label4.TabIndex = 15;
            this.label4.Text = "Valor da Sessão";
            // 
            // sessaoDataGridView
            // 
            this.sessaoDataGridView.AllowUserToAddRows = false;
            this.sessaoDataGridView.AllowUserToDeleteRows = false;
            this.sessaoDataGridView.AutoGenerateColumns = false;
            this.sessaoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sessaoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn6});
            this.sessaoDataGridView.DataSource = this.sessaoBindingSource;
            this.sessaoDataGridView.Location = new System.Drawing.Point(524, 440);
            this.sessaoDataGridView.Name = "sessaoDataGridView";
            this.sessaoDataGridView.ReadOnly = true;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Blue;
            this.sessaoDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.sessaoDataGridView.Size = new System.Drawing.Size(648, 220);
            this.sessaoDataGridView.TabIndex = 15;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "cod_sessao";
            this.dataGridViewTextBoxColumn5.HeaderText = "cod. da Sessão";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "cod_tratamento";
            this.dataGridViewTextBoxColumn9.HeaderText = "Cod. do Tratamento";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "data_sessao";
            this.dataGridViewTextBoxColumn7.HeaderText = "Data da sessão";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "horario_sessao";
            this.dataGridViewTextBoxColumn8.HeaderText = "Horário da Sessão";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "valor_sessao";
            this.dataGridViewTextBoxColumn10.HeaderText = "Valor da Sessão";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "data_ence_sessao";
            this.dataGridViewTextBoxColumn11.HeaderText = "Encerramento Sessão";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "anotacao_sessao";
            this.dataGridViewTextBoxColumn6.HeaderText = "Anotação";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Visible = false;
            // 
            // Frm_Tratamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.BackgroundImage = global::SystemKenkou.Properties.Resources.Sem_título7;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1210, 704);
            this.Controls.Add(this.sessaoDataGridView);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtValorSessao);
            this.Controls.Add(this.txtHorario);
            this.Controls.Add(this.txtData);
            this.Controls.Add(this.btSalvarSessoes);
            this.Controls.Add(this.view_tratamento_tipos_tratamentoDataGridView);
            this.Controls.Add(this.btnAddTrat);
            this.Controls.Add(this.comboTratamentos);
            this.Controls.Add(this.clienteBindingNavigator);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.Window;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Frm_Tratamento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_Tratamento";
            this.Load += new System.EventHandler(this.Frm_Tratamento_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tratamentoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clinicaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingNavigator)).EndInit();
            this.clienteBindingNavigator.ResumeLayout(false);
            this.clienteBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tratamento_tipos_tratamentoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipodetratamentoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.view_tratamento_tipos_tratamentoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.view_tratamento_tipos_tratamentoDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sessaoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sessaoDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private ClinicaDataSet clinicaDataSet;
        private System.Windows.Forms.BindingSource tratamentoBindingSource;
        private ClinicaDataSetTableAdapters.tratamentoTableAdapter tratamentoTableAdapter;
        private ClinicaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox cod_tratamentoTextBox;
        private System.Windows.Forms.MaskedTextBox data_tratamentoMaskedTextBox;
        private System.Windows.Forms.TextBox desc_tratamentoTextBox;
        private System.Windows.Forms.BindingNavigator clienteBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton clienteBindingNavigatorSaveItem;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboPacientes;
        private System.Windows.Forms.BindingSource pacienteBindingSource;
        private ClinicaDataSetTableAdapters.pacienteTableAdapter pacienteTableAdapter;
        private System.Windows.Forms.BindingSource tratamento_tipos_tratamentoBindingSource;
        private ClinicaDataSetTableAdapters.tratamento_tipos_tratamentoTableAdapter tratamento_tipos_tratamentoTableAdapter;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        
        
        private System.Windows.Forms.ComboBox comboTratamentos;
        private System.Windows.Forms.Button btnAddTrat;
        private System.Windows.Forms.BindingSource tipodetratamentoBindingSource;
        private ClinicaDataSetTableAdapters.tipo_de_tratamentoTableAdapter tipo_de_tratamentoTableAdapter;
        private System.Windows.Forms.BindingSource view_tratamento_tipos_tratamentoBindingSource;
        private ClinicaDataSetTableAdapters.View_tratamento_tipos_tratamentoTableAdapter view_tratamento_tipos_tratamentoTableAdapter;
        private System.Windows.Forms.DataGridView view_tratamento_tipos_tratamentoDataGridView;
        private System.Windows.Forms.BindingSource sessaoBindingSource;
        private ClinicaDataSetTableAdapters.sessaoTableAdapter sessaoTableAdapter;
        private System.Windows.Forms.Button btSalvarSessoes;
        private System.Windows.Forms.DateTimePicker txtData;
        private System.Windows.Forms.MaskedTextBox txtHorario;
        private System.Windows.Forms.TextBox txtValorSessao;
        private System.Windows.Forms.TextBox cod_consultaTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView sessaoDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
    }
}