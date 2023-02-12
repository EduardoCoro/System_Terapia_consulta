namespace SystemKenkou
{
    partial class Frm_Sessao
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
            System.Windows.Forms.Label cod_sessaoLabel;
            System.Windows.Forms.Label anotacao_sessaoLabel;
            System.Windows.Forms.Label data_sessaoLabel;
            System.Windows.Forms.Label horario_sessaoLabel;
            System.Windows.Forms.Label cod_tratamentoLabel;
            System.Windows.Forms.Label valor_sessaoLabel;
            System.Windows.Forms.Label data_ence_sessaoLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Sessao));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.data_ence_sessaoMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.sessaoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clinicaDataSet = new SystemKenkou.ClinicaDataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.horario_sessaoMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.tratamentoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.anotacao_sessaoTextBox = new System.Windows.Forms.TextBox();
            this.cod_sessaoTextBox = new System.Windows.Forms.TextBox();
            this.data_sessaoMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.valor_sessaoTextBox = new System.Windows.Forms.TextBox();
            this.sessaoTableAdapter = new SystemKenkou.ClinicaDataSetTableAdapters.sessaoTableAdapter();
            this.tableAdapterManager = new SystemKenkou.ClinicaDataSetTableAdapters.TableAdapterManager();
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
            this.btTratamento = new System.Windows.Forms.ToolStripButton();
            this.tratamentoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tratamentoTableAdapter = new SystemKenkou.ClinicaDataSetTableAdapters.tratamentoTableAdapter();
            cod_sessaoLabel = new System.Windows.Forms.Label();
            anotacao_sessaoLabel = new System.Windows.Forms.Label();
            data_sessaoLabel = new System.Windows.Forms.Label();
            horario_sessaoLabel = new System.Windows.Forms.Label();
            cod_tratamentoLabel = new System.Windows.Forms.Label();
            valor_sessaoLabel = new System.Windows.Forms.Label();
            data_ence_sessaoLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sessaoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clinicaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tratamentoBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingNavigator)).BeginInit();
            this.clienteBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tratamentoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cod_sessaoLabel
            // 
            cod_sessaoLabel.AutoSize = true;
            cod_sessaoLabel.Location = new System.Drawing.Point(26, 50);
            cod_sessaoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            cod_sessaoLabel.Name = "cod_sessaoLabel";
            cod_sessaoLabel.Size = new System.Drawing.Size(60, 18);
            cod_sessaoLabel.TabIndex = 0;
            cod_sessaoLabel.Text = "Código:";
            // 
            // anotacao_sessaoLabel
            // 
            anotacao_sessaoLabel.AutoSize = true;
            anotacao_sessaoLabel.Location = new System.Drawing.Point(14, 240);
            anotacao_sessaoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            anotacao_sessaoLabel.Name = "anotacao_sessaoLabel";
            anotacao_sessaoLabel.Size = new System.Drawing.Size(150, 18);
            anotacao_sessaoLabel.TabIndex = 2;
            anotacao_sessaoLabel.Text = "Anotação da Sessão:";
            // 
            // data_sessaoLabel
            // 
            data_sessaoLabel.AutoSize = true;
            data_sessaoLabel.Location = new System.Drawing.Point(26, 112);
            data_sessaoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            data_sessaoLabel.Name = "data_sessaoLabel";
            data_sessaoLabel.Size = new System.Drawing.Size(43, 18);
            data_sessaoLabel.TabIndex = 4;
            data_sessaoLabel.Text = "Data:";
            // 
            // horario_sessaoLabel
            // 
            horario_sessaoLabel.AutoSize = true;
            horario_sessaoLabel.Location = new System.Drawing.Point(26, 173);
            horario_sessaoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            horario_sessaoLabel.Name = "horario_sessaoLabel";
            horario_sessaoLabel.Size = new System.Drawing.Size(62, 18);
            horario_sessaoLabel.TabIndex = 6;
            horario_sessaoLabel.Text = "Horário:";
            // 
            // cod_tratamentoLabel
            // 
            cod_tratamentoLabel.AutoSize = true;
            cod_tratamentoLabel.Location = new System.Drawing.Point(220, 88);
            cod_tratamentoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            cod_tratamentoLabel.Name = "cod_tratamentoLabel";
            cod_tratamentoLabel.Size = new System.Drawing.Size(88, 18);
            cod_tratamentoLabel.TabIndex = 8;
            cod_tratamentoLabel.Text = "Tratamento:";
            // 
            // valor_sessaoLabel
            // 
            valor_sessaoLabel.AutoSize = true;
            valor_sessaoLabel.Location = new System.Drawing.Point(207, 176);
            valor_sessaoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            valor_sessaoLabel.Name = "valor_sessaoLabel";
            valor_sessaoLabel.Size = new System.Drawing.Size(121, 18);
            valor_sessaoLabel.TabIndex = 10;
            valor_sessaoLabel.Text = "Valor da Sessão:";
            // 
            // data_ence_sessaoLabel
            // 
            data_ence_sessaoLabel.AutoSize = true;
            data_ence_sessaoLabel.Location = new System.Drawing.Point(220, 222);
            data_ence_sessaoLabel.Name = "data_ence_sessaoLabel";
            data_ence_sessaoLabel.Size = new System.Drawing.Size(106, 18);
            data_ence_sessaoLabel.TabIndex = 19;
            data_ence_sessaoLabel.Text = "Encerramento:";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(data_ence_sessaoLabel);
            this.groupBox1.Controls.Add(this.data_ence_sessaoMaskedTextBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.horario_sessaoMaskedTextBox);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.anotacao_sessaoTextBox);
            this.groupBox1.Controls.Add(anotacao_sessaoLabel);
            this.groupBox1.Controls.Add(cod_sessaoLabel);
            this.groupBox1.Controls.Add(this.cod_sessaoTextBox);
            this.groupBox1.Controls.Add(data_sessaoLabel);
            this.groupBox1.Controls.Add(this.data_sessaoMaskedTextBox);
            this.groupBox1.Controls.Add(horario_sessaoLabel);
            this.groupBox1.Controls.Add(cod_tratamentoLabel);
            this.groupBox1.Controls.Add(valor_sessaoLabel);
            this.groupBox1.Controls.Add(this.valor_sessaoTextBox);
            this.groupBox1.Enabled = false;
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Window;
            this.groupBox1.Location = new System.Drawing.Point(50, 46);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(521, 350);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados:";
            // 
            // data_ence_sessaoMaskedTextBox
            // 
            this.data_ence_sessaoMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sessaoBindingSource, "data_ence_sessao", true));
            this.data_ence_sessaoMaskedTextBox.Location = new System.Drawing.Point(332, 219);
            this.data_ence_sessaoMaskedTextBox.Mask = "00/00/0000";
            this.data_ence_sessaoMaskedTextBox.Name = "data_ence_sessaoMaskedTextBox";
            this.data_ence_sessaoMaskedTextBox.Size = new System.Drawing.Size(100, 24);
            this.data_ence_sessaoMaskedTextBox.TabIndex = 20;
            this.data_ence_sessaoMaskedTextBox.ValidatingType = typeof(System.DateTime);
            // 
            // sessaoBindingSource
            // 
            this.sessaoBindingSource.DataMember = "sessao";
            this.sessaoBindingSource.DataSource = this.clinicaDataSet;
            // 
            // clinicaDataSet
            // 
            this.clinicaDataSet.DataSetName = "ClinicaDataSet";
            this.clinicaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(170, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 18);
            this.label1.TabIndex = 19;
            this.label1.Text = "Cadastro de Sessão";
            // 
            // horario_sessaoMaskedTextBox
            // 
            this.horario_sessaoMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sessaoBindingSource, "horario_sessao", true));
            this.horario_sessaoMaskedTextBox.Location = new System.Drawing.Point(29, 194);
            this.horario_sessaoMaskedTextBox.Mask = "90:00";
            this.horario_sessaoMaskedTextBox.Name = "horario_sessaoMaskedTextBox";
            this.horario_sessaoMaskedTextBox.Size = new System.Drawing.Size(53, 24);
            this.horario_sessaoMaskedTextBox.TabIndex = 3;
            this.horario_sessaoMaskedTextBox.ValidatingType = typeof(System.DateTime);
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.sessaoBindingSource, "cod_tratamento", true));
            this.comboBox1.DataSource = this.tratamentoBindingSource1;
            this.comboBox1.DisplayMember = "desc_tratamento";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(223, 109);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(271, 26);
            this.comboBox1.TabIndex = 4;
            this.comboBox1.ValueMember = "cod_tratamento";
            // 
            // tratamentoBindingSource1
            // 
            this.tratamentoBindingSource1.DataMember = "tratamento";
            this.tratamentoBindingSource1.DataSource = this.clinicaDataSet;
            // 
            // anotacao_sessaoTextBox
            // 
            this.anotacao_sessaoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sessaoBindingSource, "anotacao_sessao", true));
            this.anotacao_sessaoTextBox.Location = new System.Drawing.Point(17, 262);
            this.anotacao_sessaoTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.anotacao_sessaoTextBox.Multiline = true;
            this.anotacao_sessaoTextBox.Name = "anotacao_sessaoTextBox";
            this.anotacao_sessaoTextBox.Size = new System.Drawing.Size(477, 68);
            this.anotacao_sessaoTextBox.TabIndex = 6;
            // 
            // cod_sessaoTextBox
            // 
            this.cod_sessaoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sessaoBindingSource, "cod_sessao", true));
            this.cod_sessaoTextBox.Enabled = false;
            this.cod_sessaoTextBox.Location = new System.Drawing.Point(29, 73);
            this.cod_sessaoTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.cod_sessaoTextBox.Name = "cod_sessaoTextBox";
            this.cod_sessaoTextBox.Size = new System.Drawing.Size(44, 24);
            this.cod_sessaoTextBox.TabIndex = 1;
            this.cod_sessaoTextBox.TextChanged += new System.EventHandler(this.cod_sessaoTextBox_TextChanged);
            // 
            // data_sessaoMaskedTextBox
            // 
            this.data_sessaoMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sessaoBindingSource, "data_sessao", true));
            this.data_sessaoMaskedTextBox.Location = new System.Drawing.Point(29, 134);
            this.data_sessaoMaskedTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.data_sessaoMaskedTextBox.Mask = "00/00/0000";
            this.data_sessaoMaskedTextBox.Name = "data_sessaoMaskedTextBox";
            this.data_sessaoMaskedTextBox.Size = new System.Drawing.Size(83, 24);
            this.data_sessaoMaskedTextBox.TabIndex = 2;
            this.data_sessaoMaskedTextBox.ValidatingType = typeof(System.DateTime);
            // 
            // valor_sessaoTextBox
            // 
            this.valor_sessaoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sessaoBindingSource, "valor_sessao", true));
            this.valor_sessaoTextBox.Location = new System.Drawing.Point(332, 173);
            this.valor_sessaoTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.valor_sessaoTextBox.Name = "valor_sessaoTextBox";
            this.valor_sessaoTextBox.Size = new System.Drawing.Size(147, 24);
            this.valor_sessaoTextBox.TabIndex = 5;
            // 
            // sessaoTableAdapter
            // 
            this.sessaoTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.sessaoTableAdapter = this.sessaoTableAdapter;
            this.tableAdapterManager.tipo_de_tratamentoTableAdapter = null;
            this.tableAdapterManager.tratamento_tipos_tratamentoTableAdapter = null;
            this.tableAdapterManager.tratamentoTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = SystemKenkou.ClinicaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsuáriosTableAdapter = null;
            this.tableAdapterManager.vendaTableAdapter = null;
            // 
            // clienteBindingNavigator
            // 
            this.clienteBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.clienteBindingNavigator.BackColor = System.Drawing.SystemColors.Window;
            this.clienteBindingNavigator.BindingSource = this.sessaoBindingSource;
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
            this.toolStripButton3,
            this.btTratamento});
            this.clienteBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.clienteBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.clienteBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.clienteBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.clienteBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.clienteBindingNavigator.Name = "clienteBindingNavigator";
            this.clienteBindingNavigator.Padding = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.clienteBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.clienteBindingNavigator.Size = new System.Drawing.Size(613, 38);
            this.clienteBindingNavigator.TabIndex = 17;
            this.clienteBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.ForeColor = System.Drawing.SystemColors.InfoText;
            this.bindingNavigatorAddNewItem.Image = global::SystemKenkou.Properties.Resources._new;
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(62, 35);
            this.bindingNavigatorAddNewItem.Tag = "Adicionar";
            this.bindingNavigatorAddNewItem.Text = "Adicionar";
            this.bindingNavigatorAddNewItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 35);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = global::SystemKenkou.Properties.Resources.recuo;
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 35);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = global::SystemKenkou.Properties.Resources.ante;
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 35);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 38);
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
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 38);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = global::SystemKenkou.Properties.Resources.next;
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 35);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = global::SystemKenkou.Properties.Resources.advence;
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 35);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 38);
            // 
            // clienteBindingNavigatorSaveItem
            // 
            this.clienteBindingNavigatorSaveItem.ForeColor = System.Drawing.SystemColors.InfoText;
            this.clienteBindingNavigatorSaveItem.Image = global::SystemKenkou.Properties.Resources.save1;
            this.clienteBindingNavigatorSaveItem.Name = "clienteBindingNavigatorSaveItem";
            this.clienteBindingNavigatorSaveItem.Size = new System.Drawing.Size(42, 35);
            this.clienteBindingNavigatorSaveItem.Tag = "Salvar";
            this.clienteBindingNavigatorSaveItem.Text = "Salvar";
            this.clienteBindingNavigatorSaveItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.clienteBindingNavigatorSaveItem.Click += new System.EventHandler(this.clienteBindingNavigatorSaveItem_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.ForeColor = System.Drawing.SystemColors.InfoText;
            this.toolStripButton1.Image = global::SystemKenkou.Properties.Resources.error;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(57, 35);
            this.toolStripButton1.Tag = "Cancelar";
            this.toolStripButton1.Text = "Cancelar";
            this.toolStripButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.ForeColor = System.Drawing.SystemColors.InfoText;
            this.toolStripButton2.Image = global::SystemKenkou.Properties.Resources.draw;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(41, 35);
            this.toolStripButton2.Tag = "Editar";
            this.toolStripButton2.Text = "Editar";
            this.toolStripButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.ForeColor = System.Drawing.SystemColors.InfoText;
            this.bindingNavigatorDeleteItem.Image = global::SystemKenkou.Properties.Resources.lixeira;
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(48, 35);
            this.bindingNavigatorDeleteItem.Tag = "Deletar";
            this.bindingNavigatorDeleteItem.Text = "Deletar";
            this.bindingNavigatorDeleteItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.ForeColor = System.Drawing.SystemColors.InfoText;
            this.toolStripButton3.Image = global::SystemKenkou.Properties.Resources._1470067030_common_logout_signout_exit_outline_stroke;
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(30, 35);
            this.toolStripButton3.Tag = "Sair";
            this.toolStripButton3.Text = "Sair";
            this.toolStripButton3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton3.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // btTratamento
            // 
            this.btTratamento.ForeColor = System.Drawing.Color.Black;
            this.btTratamento.Image = global::SystemKenkou.Properties.Resources.lupa;
            this.btTratamento.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btTratamento.Name = "btTratamento";
            this.btTratamento.Size = new System.Drawing.Size(95, 35);
            this.btTratamento.Tag = "Localizar Sessão";
            this.btTratamento.Text = "Localizar Sessão";
            this.btTratamento.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btTratamento.Visible = false;
            this.btTratamento.Click += new System.EventHandler(this.btTratamento_Click);
            // 
            // tratamentoBindingSource
            // 
            this.tratamentoBindingSource.DataMember = "tratamento";
            this.tratamentoBindingSource.DataSource = this.clinicaDataSet;
            // 
            // tratamentoTableAdapter
            // 
            this.tratamentoTableAdapter.ClearBeforeFill = true;
            // 
            // Frm_Sessao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.BackgroundImage = global::SystemKenkou.Properties.Resources.Sem_título7;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(613, 409);
            this.Controls.Add(this.clienteBindingNavigator);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.Window;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Frm_Sessao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_Sessao";
            this.Load += new System.EventHandler(this.Frm_Sessao_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sessaoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clinicaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tratamentoBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingNavigator)).EndInit();
            this.clienteBindingNavigator.ResumeLayout(false);
            this.clienteBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tratamentoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private ClinicaDataSet clinicaDataSet;
        private System.Windows.Forms.BindingSource sessaoBindingSource;
        private ClinicaDataSetTableAdapters.sessaoTableAdapter sessaoTableAdapter;
        private ClinicaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox cod_sessaoTextBox;
        private System.Windows.Forms.TextBox anotacao_sessaoTextBox;
        private System.Windows.Forms.MaskedTextBox data_sessaoMaskedTextBox;
        private System.Windows.Forms.TextBox valor_sessaoTextBox;
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
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.MaskedTextBox horario_sessaoMaskedTextBox;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripButton btTratamento;
        private System.Windows.Forms.BindingSource tratamentoBindingSource;
        private ClinicaDataSetTableAdapters.tratamentoTableAdapter tratamentoTableAdapter;
        private System.Windows.Forms.BindingSource tratamentoBindingSource1;
        private System.Windows.Forms.MaskedTextBox data_ence_sessaoMaskedTextBox;
    }
}