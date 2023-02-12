namespace SystemKenkou
{
    partial class Frm_Cadastro_Medico
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
            System.Windows.Forms.Label cod_medLabel;
            System.Windows.Forms.Label nome_medLabel;
            System.Windows.Forms.Label tel_medLabel;
            System.Windows.Forms.Label data_nascLabel;
            System.Windows.Forms.Label cPFLabel;
            System.Windows.Forms.Label rGLabel;
            System.Windows.Forms.Label ender_medLabel;
            System.Windows.Forms.Label descr_medLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Cadastro_Medico));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cod_medTextBox = new System.Windows.Forms.TextBox();
            this.medicoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clinicaDataSet = new SystemKenkou.ClinicaDataSet();
            this.nome_medTextBox = new System.Windows.Forms.TextBox();
            this.tel_medMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.data_nascMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.cPFMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.rGMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.ender_medTextBox = new System.Windows.Forms.TextBox();
            this.descr_medTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
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
            this.medicoTableAdapter = new SystemKenkou.ClinicaDataSetTableAdapters.medicoTableAdapter();
            this.tableAdapterManager = new SystemKenkou.ClinicaDataSetTableAdapters.TableAdapterManager();
            cod_medLabel = new System.Windows.Forms.Label();
            nome_medLabel = new System.Windows.Forms.Label();
            tel_medLabel = new System.Windows.Forms.Label();
            data_nascLabel = new System.Windows.Forms.Label();
            cPFLabel = new System.Windows.Forms.Label();
            rGLabel = new System.Windows.Forms.Label();
            ender_medLabel = new System.Windows.Forms.Label();
            descr_medLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.medicoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clinicaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingNavigator)).BeginInit();
            this.clienteBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // cod_medLabel
            // 
            cod_medLabel.AutoSize = true;
            cod_medLabel.Location = new System.Drawing.Point(33, 62);
            cod_medLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            cod_medLabel.Name = "cod_medLabel";
            cod_medLabel.Size = new System.Drawing.Size(60, 18);
            cod_medLabel.TabIndex = 17;
            cod_medLabel.Text = "Código:";
            // 
            // nome_medLabel
            // 
            nome_medLabel.AutoSize = true;
            nome_medLabel.Location = new System.Drawing.Point(33, 121);
            nome_medLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            nome_medLabel.Name = "nome_medLabel";
            nome_medLabel.Size = new System.Drawing.Size(127, 18);
            nome_medLabel.TabIndex = 19;
            nome_medLabel.Text = "Nome do médico:";
            // 
            // tel_medLabel
            // 
            tel_medLabel.AutoSize = true;
            tel_medLabel.Location = new System.Drawing.Point(33, 262);
            tel_medLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            tel_medLabel.Name = "tel_medLabel";
            tel_medLabel.Size = new System.Drawing.Size(69, 18);
            tel_medLabel.TabIndex = 21;
            tel_medLabel.Text = "Telefone:";
            // 
            // data_nascLabel
            // 
            data_nascLabel.AutoSize = true;
            data_nascLabel.Location = new System.Drawing.Point(33, 198);
            data_nascLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            data_nascLabel.Name = "data_nascLabel";
            data_nascLabel.Size = new System.Drawing.Size(147, 18);
            data_nascLabel.TabIndex = 23;
            data_nascLabel.Text = "Data de Nascimento:";
            // 
            // cPFLabel
            // 
            cPFLabel.AutoSize = true;
            cPFLabel.Location = new System.Drawing.Point(296, 99);
            cPFLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            cPFLabel.Name = "cPFLabel";
            cPFLabel.Size = new System.Drawing.Size(46, 18);
            cPFLabel.TabIndex = 25;
            cPFLabel.Text = "CPF :";
            // 
            // rGLabel
            // 
            rGLabel.AutoSize = true;
            rGLabel.Location = new System.Drawing.Point(454, 99);
            rGLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            rGLabel.Name = "rGLabel";
            rGLabel.Size = new System.Drawing.Size(39, 18);
            rGLabel.TabIndex = 27;
            rGLabel.Text = "RG :";
            // 
            // ender_medLabel
            // 
            ender_medLabel.AutoSize = true;
            ender_medLabel.Location = new System.Drawing.Point(296, 163);
            ender_medLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            ender_medLabel.Name = "ender_medLabel";
            ender_medLabel.Size = new System.Drawing.Size(129, 18);
            ender_medLabel.TabIndex = 29;
            ender_medLabel.Text = "Endereço médico:";
            // 
            // descr_medLabel
            // 
            descr_medLabel.AutoSize = true;
            descr_medLabel.Location = new System.Drawing.Point(296, 262);
            descr_medLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            descr_medLabel.Name = "descr_medLabel";
            descr_medLabel.Size = new System.Drawing.Size(133, 18);
            descr_medLabel.TabIndex = 31;
            descr_medLabel.Text = "Descrição médico:";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(cod_medLabel);
            this.groupBox1.Controls.Add(this.cod_medTextBox);
            this.groupBox1.Controls.Add(nome_medLabel);
            this.groupBox1.Controls.Add(this.nome_medTextBox);
            this.groupBox1.Controls.Add(tel_medLabel);
            this.groupBox1.Controls.Add(this.tel_medMaskedTextBox);
            this.groupBox1.Controls.Add(data_nascLabel);
            this.groupBox1.Controls.Add(this.data_nascMaskedTextBox);
            this.groupBox1.Controls.Add(cPFLabel);
            this.groupBox1.Controls.Add(this.cPFMaskedTextBox);
            this.groupBox1.Controls.Add(rGLabel);
            this.groupBox1.Controls.Add(this.rGMaskedTextBox);
            this.groupBox1.Controls.Add(ender_medLabel);
            this.groupBox1.Controls.Add(this.ender_medTextBox);
            this.groupBox1.Controls.Add(descr_medLabel);
            this.groupBox1.Controls.Add(this.descr_medTextBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Enabled = false;
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Window;
            this.groupBox1.Location = new System.Drawing.Point(20, 38);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(570, 362);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados:";
            // 
            // cod_medTextBox
            // 
            this.cod_medTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.medicoBindingSource, "cod_med", true));
            this.cod_medTextBox.Enabled = false;
            this.cod_medTextBox.Location = new System.Drawing.Point(36, 84);
            this.cod_medTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.cod_medTextBox.Name = "cod_medTextBox";
            this.cod_medTextBox.Size = new System.Drawing.Size(46, 24);
            this.cod_medTextBox.TabIndex = 1;
            // 
            // medicoBindingSource
            // 
            this.medicoBindingSource.DataMember = "medico";
            this.medicoBindingSource.DataSource = this.clinicaDataSet;
            // 
            // clinicaDataSet
            // 
            this.clinicaDataSet.DataSetName = "ClinicaDataSet";
            this.clinicaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nome_medTextBox
            // 
            this.nome_medTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.medicoBindingSource, "nome_med", true));
            this.nome_medTextBox.Location = new System.Drawing.Point(36, 143);
            this.nome_medTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.nome_medTextBox.Name = "nome_medTextBox";
            this.nome_medTextBox.Size = new System.Drawing.Size(210, 24);
            this.nome_medTextBox.TabIndex = 2;
            // 
            // tel_medMaskedTextBox
            // 
            this.tel_medMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.medicoBindingSource, "tel_med", true));
            this.tel_medMaskedTextBox.Location = new System.Drawing.Point(36, 284);
            this.tel_medMaskedTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.tel_medMaskedTextBox.Mask = "(99) 0000-0000";
            this.tel_medMaskedTextBox.Name = "tel_medMaskedTextBox";
            this.tel_medMaskedTextBox.Size = new System.Drawing.Size(106, 24);
            this.tel_medMaskedTextBox.TabIndex = 3;
            // 
            // data_nascMaskedTextBox
            // 
            this.data_nascMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.medicoBindingSource, "data_nasc", true));
            this.data_nascMaskedTextBox.Location = new System.Drawing.Point(36, 220);
            this.data_nascMaskedTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.data_nascMaskedTextBox.Mask = "00/00/0000";
            this.data_nascMaskedTextBox.Name = "data_nascMaskedTextBox";
            this.data_nascMaskedTextBox.Size = new System.Drawing.Size(82, 24);
            this.data_nascMaskedTextBox.TabIndex = 4;
            this.data_nascMaskedTextBox.ValidatingType = typeof(System.DateTime);
            // 
            // cPFMaskedTextBox
            // 
            this.cPFMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.medicoBindingSource, "CPF", true));
            this.cPFMaskedTextBox.Location = new System.Drawing.Point(296, 121);
            this.cPFMaskedTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.cPFMaskedTextBox.Mask = "000.000.000-00";
            this.cPFMaskedTextBox.Name = "cPFMaskedTextBox";
            this.cPFMaskedTextBox.Size = new System.Drawing.Size(108, 24);
            this.cPFMaskedTextBox.TabIndex = 6;
            // 
            // rGMaskedTextBox
            // 
            this.rGMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.medicoBindingSource, "RG", true));
            this.rGMaskedTextBox.Location = new System.Drawing.Point(454, 121);
            this.rGMaskedTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.rGMaskedTextBox.Mask = "00.000.000-0";
            this.rGMaskedTextBox.Name = "rGMaskedTextBox";
            this.rGMaskedTextBox.Size = new System.Drawing.Size(95, 24);
            this.rGMaskedTextBox.TabIndex = 5;
            // 
            // ender_medTextBox
            // 
            this.ender_medTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.medicoBindingSource, "ender_med", true));
            this.ender_medTextBox.Location = new System.Drawing.Point(296, 185);
            this.ender_medTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.ender_medTextBox.Multiline = true;
            this.ender_medTextBox.Name = "ender_medTextBox";
            this.ender_medTextBox.Size = new System.Drawing.Size(253, 59);
            this.ender_medTextBox.TabIndex = 7;
            // 
            // descr_medTextBox
            // 
            this.descr_medTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.medicoBindingSource, "descr_med", true));
            this.descr_medTextBox.Location = new System.Drawing.Point(296, 284);
            this.descr_medTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.descr_medTextBox.Multiline = true;
            this.descr_medTextBox.Name = "descr_medTextBox";
            this.descr_medTextBox.Size = new System.Drawing.Size(250, 59);
            this.descr_medTextBox.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(225, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 18);
            this.label1.TabIndex = 17;
            this.label1.Text = "Cadastro de Médico";
            // 
            // clienteBindingNavigator
            // 
            this.clienteBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.clienteBindingNavigator.BackColor = System.Drawing.SystemColors.Window;
            this.clienteBindingNavigator.BindingSource = this.medicoBindingSource;
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
            this.clienteBindingNavigator.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.clienteBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.clienteBindingNavigator.Size = new System.Drawing.Size(612, 38);
            this.clienteBindingNavigator.TabIndex = 15;
            this.clienteBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
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
            this.btTratamento.Size = new System.Drawing.Size(100, 35);
            this.btTratamento.Tag = "Localizar Médico";
            this.btTratamento.Text = "Localizar Médico";
            this.btTratamento.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btTratamento.Click += new System.EventHandler(this.btTratamento_Click);
            // 
            // medicoTableAdapter
            // 
            this.medicoTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.cidadeTableAdapter = null;
            this.tableAdapterManager.consultaTableAdapter = null;
            this.tableAdapterManager.conta_receberTableAdapter = null;
            this.tableAdapterManager.itens_vendaTableAdapter = null;
            this.tableAdapterManager.medicoTableAdapter = this.medicoTableAdapter;
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
            // Frm_Cadastro_Medico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.BackgroundImage = global::SystemKenkou.Properties.Resources.Sem_título7;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(612, 419);
            this.Controls.Add(this.clienteBindingNavigator);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Frm_Cadastro_Medico";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_Cadastro_Medico";
            this.Load += new System.EventHandler(this.Frm_Cadastro_Medico_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.medicoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clinicaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingNavigator)).EndInit();
            this.clienteBindingNavigator.ResumeLayout(false);
            this.clienteBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

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
        private System.Windows.Forms.Label label1;
        private ClinicaDataSet clinicaDataSet;
        private System.Windows.Forms.BindingSource medicoBindingSource;
        private ClinicaDataSetTableAdapters.medicoTableAdapter medicoTableAdapter;
        private ClinicaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox cod_medTextBox;
        private System.Windows.Forms.TextBox nome_medTextBox;
        private System.Windows.Forms.MaskedTextBox tel_medMaskedTextBox;
        private System.Windows.Forms.MaskedTextBox data_nascMaskedTextBox;
        private System.Windows.Forms.MaskedTextBox cPFMaskedTextBox;
        private System.Windows.Forms.MaskedTextBox rGMaskedTextBox;
        private System.Windows.Forms.TextBox ender_medTextBox;
        private System.Windows.Forms.TextBox descr_medTextBox;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton btTratamento;
    }
}