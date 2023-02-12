namespace SystemKenkou
{
    partial class Frm_cadastro_consulta
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
            System.Windows.Forms.Label cod_consultLabel;
            System.Windows.Forms.Label data_consultLabel;
            System.Windows.Forms.Label anot_consultLabel;
            System.Windows.Forms.Label hr_consultLabel;
            System.Windows.Forms.Label retor_consultLabel;
            System.Windows.Forms.Label cod_medLabel;
            System.Windows.Forms.Label cod_pacLabel;
            System.Windows.Forms.Label con_valorLabel;
            System.Windows.Forms.Label horario_retornoLabel;
            System.Windows.Forms.Label situacaoLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_cadastro_consulta));
            this.clinicaDataSet = new SystemKenkou.ClinicaDataSet();
            this.consultaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.consultaTableAdapter = new SystemKenkou.ClinicaDataSetTableAdapters.consultaTableAdapter();
            this.tableAdapterManager = new SystemKenkou.ClinicaDataSetTableAdapters.TableAdapterManager();
            this.cod_consultTextBox = new System.Windows.Forms.TextBox();
            this.data_consultMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.anot_consultTextBox = new System.Windows.Forms.TextBox();
            this.hr_consultMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.retor_consultMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.con_valorTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_pacient = new System.Windows.Forms.Button();
            this.situacaoComboBox = new System.Windows.Forms.ComboBox();
            this.horario_retornoMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.medicoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboPaciente = new System.Windows.Forms.ComboBox();
            this.pacienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
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
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.conta_receberTableAdapter = new SystemKenkou.ClinicaDataSetTableAdapters.conta_receberTableAdapter();
            this.pacienteTableAdapter = new SystemKenkou.ClinicaDataSetTableAdapters.pacienteTableAdapter();
            this.medicoTableAdapter = new SystemKenkou.ClinicaDataSetTableAdapters.medicoTableAdapter();
            this.conta_receberBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            cod_consultLabel = new System.Windows.Forms.Label();
            data_consultLabel = new System.Windows.Forms.Label();
            anot_consultLabel = new System.Windows.Forms.Label();
            hr_consultLabel = new System.Windows.Forms.Label();
            retor_consultLabel = new System.Windows.Forms.Label();
            cod_medLabel = new System.Windows.Forms.Label();
            cod_pacLabel = new System.Windows.Forms.Label();
            con_valorLabel = new System.Windows.Forms.Label();
            horario_retornoLabel = new System.Windows.Forms.Label();
            situacaoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.clinicaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.consultaBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.medicoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingNavigator)).BeginInit();
            this.clienteBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.conta_receberBindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // cod_consultLabel
            // 
            cod_consultLabel.AutoSize = true;
            cod_consultLabel.Location = new System.Drawing.Point(26, 43);
            cod_consultLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            cod_consultLabel.Name = "cod_consultLabel";
            cod_consultLabel.Size = new System.Drawing.Size(127, 20);
            cod_consultLabel.TabIndex = 1;
            cod_consultLabel.Text = "Código consulta:";
            // 
            // data_consultLabel
            // 
            data_consultLabel.AutoSize = true;
            data_consultLabel.Location = new System.Drawing.Point(26, 169);
            data_consultLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            data_consultLabel.Name = "data_consultLabel";
            data_consultLabel.Size = new System.Drawing.Size(112, 20);
            data_consultLabel.TabIndex = 3;
            data_consultLabel.Text = "Data consulta:";
            // 
            // anot_consultLabel
            // 
            anot_consultLabel.AutoSize = true;
            anot_consultLabel.Location = new System.Drawing.Point(26, 304);
            anot_consultLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            anot_consultLabel.Name = "anot_consultLabel";
            anot_consultLabel.Size = new System.Drawing.Size(146, 20);
            anot_consultLabel.TabIndex = 5;
            anot_consultLabel.Text = "Anotação consulta:";
            // 
            // hr_consultLabel
            // 
            hr_consultLabel.AutoSize = true;
            hr_consultLabel.Location = new System.Drawing.Point(26, 233);
            hr_consultLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            hr_consultLabel.Name = "hr_consultLabel";
            hr_consultLabel.Size = new System.Drawing.Size(65, 20);
            hr_consultLabel.TabIndex = 7;
            hr_consultLabel.Text = "Horário:";
            // 
            // retor_consultLabel
            // 
            retor_consultLabel.AutoSize = true;
            retor_consultLabel.Location = new System.Drawing.Point(62, 45);
            retor_consultLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            retor_consultLabel.Name = "retor_consultLabel";
            retor_consultLabel.Size = new System.Drawing.Size(117, 20);
            retor_consultLabel.TabIndex = 9;
            retor_consultLabel.Text = "Dia do Retorno";
            // 
            // cod_medLabel
            // 
            cod_medLabel.AutoSize = true;
            cod_medLabel.Location = new System.Drawing.Point(357, 109);
            cod_medLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            cod_medLabel.Name = "cod_medLabel";
            cod_medLabel.Size = new System.Drawing.Size(64, 20);
            cod_medLabel.TabIndex = 11;
            cod_medLabel.Text = "Médico:";
            // 
            // cod_pacLabel
            // 
            cod_pacLabel.AutoSize = true;
            cod_pacLabel.Location = new System.Drawing.Point(26, 109);
            cod_pacLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            cod_pacLabel.Name = "cod_pacLabel";
            cod_pacLabel.Size = new System.Drawing.Size(75, 20);
            cod_pacLabel.TabIndex = 13;
            cod_pacLabel.Text = "Paciente:";
            // 
            // con_valorLabel
            // 
            con_valorLabel.AutoSize = true;
            con_valorLabel.Location = new System.Drawing.Point(187, 169);
            con_valorLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            con_valorLabel.Name = "con_valorLabel";
            con_valorLabel.Size = new System.Drawing.Size(116, 20);
            con_valorLabel.TabIndex = 15;
            con_valorLabel.Text = "Valor da conta:";
            // 
            // horario_retornoLabel
            // 
            horario_retornoLabel.AutoSize = true;
            horario_retornoLabel.Location = new System.Drawing.Point(62, 122);
            horario_retornoLabel.Name = "horario_retornoLabel";
            horario_retornoLabel.Size = new System.Drawing.Size(145, 20);
            horario_retornoLabel.TabIndex = 19;
            horario_retornoLabel.Text = "Horario do Retorno";
            // 
            // situacaoLabel
            // 
            situacaoLabel.AutoSize = true;
            situacaoLabel.Location = new System.Drawing.Point(357, 233);
            situacaoLabel.Name = "situacaoLabel";
            situacaoLabel.Size = new System.Drawing.Size(76, 20);
            situacaoLabel.TabIndex = 20;
            situacaoLabel.Text = "Situação:";
            // 
            // clinicaDataSet
            // 
            this.clinicaDataSet.DataSetName = "ClinicaDataSet";
            this.clinicaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // consultaBindingSource
            // 
            this.consultaBindingSource.DataMember = "consulta";
            this.consultaBindingSource.DataSource = this.clinicaDataSet;
            this.consultaBindingSource.CurrentChanged += new System.EventHandler(this.consultaBindingSource_CurrentChanged);
            // 
            // consultaTableAdapter
            // 
            this.consultaTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.cidadeTableAdapter = null;
            this.tableAdapterManager.consultaTableAdapter = this.consultaTableAdapter;
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
            this.tableAdapterManager.vendaTableAdapter = null;
            // 
            // cod_consultTextBox
            // 
            this.cod_consultTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.consultaBindingSource, "cod_consult", true));
            this.cod_consultTextBox.Enabled = false;
            this.cod_consultTextBox.Location = new System.Drawing.Point(30, 68);
            this.cod_consultTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cod_consultTextBox.Name = "cod_consultTextBox";
            this.cod_consultTextBox.Size = new System.Drawing.Size(45, 26);
            this.cod_consultTextBox.TabIndex = 1;
            this.cod_consultTextBox.TextChanged += new System.EventHandler(this.cod_consultTextBox_TextChanged);
            // 
            // data_consultMaskedTextBox
            // 
            this.data_consultMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.consultaBindingSource, "data_consult", true));
            this.data_consultMaskedTextBox.Location = new System.Drawing.Point(30, 194);
            this.data_consultMaskedTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.data_consultMaskedTextBox.Mask = "00/00/0000";
            this.data_consultMaskedTextBox.Name = "data_consultMaskedTextBox";
            this.data_consultMaskedTextBox.Size = new System.Drawing.Size(91, 26);
            this.data_consultMaskedTextBox.TabIndex = 3;
            this.data_consultMaskedTextBox.ValidatingType = typeof(System.DateTime);
            // 
            // anot_consultTextBox
            // 
            this.anot_consultTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.consultaBindingSource, "anot_consult", true));
            this.anot_consultTextBox.Location = new System.Drawing.Point(30, 329);
            this.anot_consultTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.anot_consultTextBox.MaxLength = 200;
            this.anot_consultTextBox.Multiline = true;
            this.anot_consultTextBox.Name = "anot_consultTextBox";
            this.anot_consultTextBox.Size = new System.Drawing.Size(485, 128);
            this.anot_consultTextBox.TabIndex = 6;
            this.anot_consultTextBox.TextChanged += new System.EventHandler(this.anot_consultTextBox_TextChanged);
            // 
            // hr_consultMaskedTextBox
            // 
            this.hr_consultMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.consultaBindingSource, "hr_consult", true));
            this.hr_consultMaskedTextBox.Location = new System.Drawing.Point(30, 258);
            this.hr_consultMaskedTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.hr_consultMaskedTextBox.Mask = "90:00";
            this.hr_consultMaskedTextBox.Name = "hr_consultMaskedTextBox";
            this.hr_consultMaskedTextBox.Size = new System.Drawing.Size(52, 26);
            this.hr_consultMaskedTextBox.TabIndex = 5;
            this.hr_consultMaskedTextBox.ValidatingType = typeof(System.DateTime);
            // 
            // retor_consultMaskedTextBox
            // 
            this.retor_consultMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.consultaBindingSource, "retor_consult", true));
            this.retor_consultMaskedTextBox.Location = new System.Drawing.Point(66, 70);
            this.retor_consultMaskedTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.retor_consultMaskedTextBox.Mask = "00/00/0000";
            this.retor_consultMaskedTextBox.Name = "retor_consultMaskedTextBox";
            this.retor_consultMaskedTextBox.Size = new System.Drawing.Size(88, 26);
            this.retor_consultMaskedTextBox.TabIndex = 8;
            this.retor_consultMaskedTextBox.ValidatingType = typeof(System.DateTime);
            // 
            // con_valorTextBox
            // 
            this.con_valorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.consultaBindingSource, "con_valor", true));
            this.con_valorTextBox.Location = new System.Drawing.Point(175, 194);
            this.con_valorTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.con_valorTextBox.Name = "con_valorTextBox";
            this.con_valorTextBox.Size = new System.Drawing.Size(148, 26);
            this.con_valorTextBox.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.btn_pacient);
            this.groupBox1.Controls.Add(situacaoLabel);
            this.groupBox1.Controls.Add(this.situacaoComboBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.comboBox2);
            this.groupBox1.Controls.Add(this.comboPaciente);
            this.groupBox1.Controls.Add(this.con_valorTextBox);
            this.groupBox1.Controls.Add(cod_consultLabel);
            this.groupBox1.Controls.Add(con_valorLabel);
            this.groupBox1.Controls.Add(this.cod_consultTextBox);
            this.groupBox1.Controls.Add(data_consultLabel);
            this.groupBox1.Controls.Add(cod_pacLabel);
            this.groupBox1.Controls.Add(this.data_consultMaskedTextBox);
            this.groupBox1.Controls.Add(anot_consultLabel);
            this.groupBox1.Controls.Add(cod_medLabel);
            this.groupBox1.Controls.Add(this.anot_consultTextBox);
            this.groupBox1.Controls.Add(hr_consultLabel);
            this.groupBox1.Controls.Add(this.hr_consultMaskedTextBox);
            this.groupBox1.Enabled = false;
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Window;
            this.groupBox1.Location = new System.Drawing.Point(17, 39);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(885, 479);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados:";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btn_pacient
            // 
            this.btn_pacient.BackColor = System.Drawing.Color.White;
            this.btn_pacient.BackgroundImage = global::SystemKenkou.Properties.Resources.lupa;
            this.btn_pacient.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_pacient.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_pacient.Location = new System.Drawing.Point(286, 132);
            this.btn_pacient.Name = "btn_pacient";
            this.btn_pacient.Size = new System.Drawing.Size(37, 28);
            this.btn_pacient.TabIndex = 21;
            this.btn_pacient.UseVisualStyleBackColor = false;
            this.btn_pacient.Click += new System.EventHandler(this.button1_Click);
            // 
            // situacaoComboBox
            // 
            this.situacaoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.consultaBindingSource, "situacao", true));
            this.situacaoComboBox.FormattingEnabled = true;
            this.situacaoComboBox.Items.AddRange(new object[] {
            "Espera",
            "Finalizada",
            "Não Realizada"});
            this.situacaoComboBox.Location = new System.Drawing.Point(361, 256);
            this.situacaoComboBox.Name = "situacaoComboBox";
            this.situacaoComboBox.Size = new System.Drawing.Size(142, 28);
            this.situacaoComboBox.TabIndex = 10;
            // 
            // horario_retornoMaskedTextBox
            // 
            this.horario_retornoMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.consultaBindingSource, "horario_retorno", true));
            this.horario_retornoMaskedTextBox.Location = new System.Drawing.Point(66, 145);
            this.horario_retornoMaskedTextBox.Mask = "90:00";
            this.horario_retornoMaskedTextBox.Name = "horario_retornoMaskedTextBox";
            this.horario_retornoMaskedTextBox.Size = new System.Drawing.Size(51, 26);
            this.horario_retornoMaskedTextBox.TabIndex = 9;
            this.horario_retornoMaskedTextBox.ValidatingType = typeof(System.DateTime);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(282, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 20);
            this.label1.TabIndex = 19;
            this.label1.Text = "Cadastro de Consulta";
            // 
            // comboBox2
            // 
            this.comboBox2.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.consultaBindingSource, "cod_med", true));
            this.comboBox2.DataSource = this.medicoBindingSource;
            this.comboBox2.DisplayMember = "nome_med";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(361, 132);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(259, 28);
            this.comboBox2.TabIndex = 7;
            this.comboBox2.ValueMember = "cod_med";
            // 
            // medicoBindingSource
            // 
            this.medicoBindingSource.DataMember = "medico";
            this.medicoBindingSource.DataSource = this.clinicaDataSet;
            // 
            // comboPaciente
            // 
            this.comboPaciente.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.consultaBindingSource, "cod_pac", true));
            this.comboPaciente.DataSource = this.pacienteBindingSource;
            this.comboPaciente.DisplayMember = "nome_pac";
            this.comboPaciente.FormattingEnabled = true;
            this.comboPaciente.Location = new System.Drawing.Point(30, 132);
            this.comboPaciente.Name = "comboPaciente";
            this.comboPaciente.Size = new System.Drawing.Size(247, 28);
            this.comboPaciente.TabIndex = 2;
            this.comboPaciente.ValueMember = "cod_pac";
            // 
            // pacienteBindingSource
            // 
            this.pacienteBindingSource.DataMember = "paciente";
            this.pacienteBindingSource.DataSource = this.clinicaDataSet;
            // 
            // clienteBindingNavigator
            // 
            this.clienteBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.clienteBindingNavigator.BackColor = System.Drawing.SystemColors.Window;
            this.clienteBindingNavigator.BindingSource = this.consultaBindingSource;
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
            this.btTratamento,
            this.toolStripButton4,
            this.toolStripButton5});
            this.clienteBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.clienteBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.clienteBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.clienteBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.clienteBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.clienteBindingNavigator.Name = "clienteBindingNavigator";
            this.clienteBindingNavigator.Padding = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.clienteBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.clienteBindingNavigator.Size = new System.Drawing.Size(915, 38);
            this.clienteBindingNavigator.TabIndex = 18;
            this.clienteBindingNavigator.Text = "bindingNavigator1";
            this.clienteBindingNavigator.RefreshItems += new System.EventHandler(this.clienteBindingNavigator_RefreshItems);
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
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(108, 23);
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
            this.btTratamento.Image = global::SystemKenkou.Properties.Resources.tratamento2;
            this.btTratamento.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btTratamento.Name = "btTratamento";
            this.btTratamento.Size = new System.Drawing.Size(101, 35);
            this.btTratamento.Text = "Criar Tratamento";
            this.btTratamento.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btTratamento.Click += new System.EventHandler(this.btTratamento_Click);
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.ForeColor = System.Drawing.Color.Black;
            this.toolStripButton4.Image = global::SystemKenkou.Properties.Resources.lupa;
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(107, 35);
            this.toolStripButton4.Text = "Localizar Consulta";
            this.toolStripButton4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton4.Click += new System.EventHandler(this.toolStripButton4_Click);
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.ForeColor = System.Drawing.Color.Black;
            this.toolStripButton5.Image = global::SystemKenkou.Properties.Resources._1472081952_Windows_Card_Space;
            this.toolStripButton5.ImageTransparentColor = System.Drawing.Color.White;
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.Size = new System.Drawing.Size(137, 35);
            this.toolStripButton5.Text = "Registrar o recebimento";
            this.toolStripButton5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton5.Click += new System.EventHandler(this.toolStripButton5_Click);
            // 
            // conta_receberTableAdapter
            // 
            this.conta_receberTableAdapter.ClearBeforeFill = true;
            // 
            // pacienteTableAdapter
            // 
            this.pacienteTableAdapter.ClearBeforeFill = true;
            // 
            // medicoTableAdapter
            // 
            this.medicoTableAdapter.ClearBeforeFill = true;
            // 
            // conta_receberBindingSource
            // 
            this.conta_receberBindingSource.DataMember = "conta_receber";
            this.conta_receberBindingSource.DataSource = this.clinicaDataSet;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.retor_consultMaskedTextBox);
            this.groupBox2.Controls.Add(retor_consultLabel);
            this.groupBox2.Controls.Add(this.horario_retornoMaskedTextBox);
            this.groupBox2.Controls.Add(horario_retornoLabel);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(604, 256);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(246, 195);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Controle de Retorno";
            // 
            // Frm_cadastro_consulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.BackgroundImage = global::SystemKenkou.Properties.Resources.Sem_título7;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(915, 537);
            this.Controls.Add(this.clienteBindingNavigator);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.Window;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Frm_cadastro_consulta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_cadastro_consulta";
            this.Load += new System.EventHandler(this.Frm_cadastro_consulta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.clinicaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.consultaBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.medicoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingNavigator)).EndInit();
            this.clienteBindingNavigator.ResumeLayout(false);
            this.clienteBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.conta_receberBindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ClinicaDataSet clinicaDataSet;
        private System.Windows.Forms.BindingSource consultaBindingSource;
        private ClinicaDataSetTableAdapters.consultaTableAdapter consultaTableAdapter;
        private ClinicaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox cod_consultTextBox;
        private System.Windows.Forms.MaskedTextBox data_consultMaskedTextBox;
        private System.Windows.Forms.TextBox anot_consultTextBox;
        private System.Windows.Forms.MaskedTextBox hr_consultMaskedTextBox;
        private System.Windows.Forms.MaskedTextBox retor_consultMaskedTextBox;
        private System.Windows.Forms.TextBox con_valorTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
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
        private System.Windows.Forms.ComboBox comboPaciente;
        private ClinicaDataSetTableAdapters.conta_receberTableAdapter conta_receberTableAdapter;
        private System.Windows.Forms.BindingSource pacienteBindingSource;
        private ClinicaDataSetTableAdapters.pacienteTableAdapter pacienteTableAdapter;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.BindingSource medicoBindingSource;
        private ClinicaDataSetTableAdapters.medicoTableAdapter medicoTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox situacaoComboBox;
        private System.Windows.Forms.MaskedTextBox horario_retornoMaskedTextBox;
        private System.Windows.Forms.ToolStripButton btTratamento;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.Button btn_pacient;
        private System.Windows.Forms.BindingSource conta_receberBindingSource;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}