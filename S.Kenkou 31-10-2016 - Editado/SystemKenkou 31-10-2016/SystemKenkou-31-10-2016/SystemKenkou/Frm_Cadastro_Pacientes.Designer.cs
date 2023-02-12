namespace SystemKenkou
{
    partial class Frm_Cadastro_Pacientes
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
            System.Windows.Forms.Label sexo_pacLabel;
            System.Windows.Forms.Label e_mailLabel;
            System.Windows.Forms.Label relig_pacLabel;
            System.Windows.Forms.Label ind_pacLabel;
            System.Windows.Forms.Label prof_pacLabel;
            System.Windows.Forms.Label obs_pacLabel;
            System.Windows.Forms.Label sang_pacLabel;
            System.Windows.Forms.Label end_pacLabel;
            System.Windows.Forms.Label nome_pacLabel;
            System.Windows.Forms.Label cod_pacLabel;
            System.Windows.Forms.Label rGLabel;
            System.Windows.Forms.Label cPFLabel;
            System.Windows.Forms.Label cel_pacLabel;
            System.Windows.Forms.Label data_nascLabel;
            System.Windows.Forms.Label tel_pacLabel;
            System.Windows.Forms.Label cod_cidLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Cadastro_Pacientes));
            this.pacienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clinicaDataSet = new SystemKenkou.ClinicaDataSet();
            this.sexo_pacComboBox = new System.Windows.Forms.ComboBox();
            this.e_mailTextBox = new System.Windows.Forms.TextBox();
            this.relig_pacTextBox = new System.Windows.Forms.TextBox();
            this.ind_pacTextBox = new System.Windows.Forms.TextBox();
            this.prof_pacTextBox = new System.Windows.Forms.TextBox();
            this.obs_pacTextBox = new System.Windows.Forms.TextBox();
            this.sang_pacTextBox = new System.Windows.Forms.TextBox();
            this.end_pacTextBox = new System.Windows.Forms.TextBox();
            this.nome_pacTextBox = new System.Windows.Forms.TextBox();
            this.cod_pacTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.cidadeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.tel_pacMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.data_nascMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.cel_pacMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.cPFMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.rGMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pacienteTableAdapter = new SystemKenkou.ClinicaDataSetTableAdapters.pacienteTableAdapter();
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
            this.cidadeTableAdapter = new SystemKenkou.ClinicaDataSetTableAdapters.cidadeTableAdapter();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_carregar = new System.Windows.Forms.Button();
            this.btn_remov = new System.Windows.Forms.Button();
            this.pac_imgPictureBox = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            sexo_pacLabel = new System.Windows.Forms.Label();
            e_mailLabel = new System.Windows.Forms.Label();
            relig_pacLabel = new System.Windows.Forms.Label();
            ind_pacLabel = new System.Windows.Forms.Label();
            prof_pacLabel = new System.Windows.Forms.Label();
            obs_pacLabel = new System.Windows.Forms.Label();
            sang_pacLabel = new System.Windows.Forms.Label();
            end_pacLabel = new System.Windows.Forms.Label();
            nome_pacLabel = new System.Windows.Forms.Label();
            cod_pacLabel = new System.Windows.Forms.Label();
            rGLabel = new System.Windows.Forms.Label();
            cPFLabel = new System.Windows.Forms.Label();
            cel_pacLabel = new System.Windows.Forms.Label();
            data_nascLabel = new System.Windows.Forms.Label();
            tel_pacLabel = new System.Windows.Forms.Label();
            cod_cidLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pacienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clinicaDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cidadeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingNavigator)).BeginInit();
            this.clienteBindingNavigator.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pac_imgPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // sexo_pacLabel
            // 
            sexo_pacLabel.AutoSize = true;
            sexo_pacLabel.Location = new System.Drawing.Point(187, 167);
            sexo_pacLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            sexo_pacLabel.Name = "sexo_pacLabel";
            sexo_pacLabel.Size = new System.Drawing.Size(42, 18);
            sexo_pacLabel.TabIndex = 28;
            sexo_pacLabel.Text = "Sexo";
            // 
            // e_mailLabel
            // 
            e_mailLabel.AutoSize = true;
            e_mailLabel.Location = new System.Drawing.Point(415, 399);
            e_mailLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            e_mailLabel.Name = "e_mailLabel";
            e_mailLabel.Size = new System.Drawing.Size(115, 18);
            e_mailLabel.TabIndex = 26;
            e_mailLabel.Text = "E-mail Paciente:";
            // 
            // relig_pacLabel
            // 
            relig_pacLabel.AutoSize = true;
            relig_pacLabel.Location = new System.Drawing.Point(415, 334);
            relig_pacLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            relig_pacLabel.Name = "relig_pacLabel";
            relig_pacLabel.Size = new System.Drawing.Size(69, 18);
            relig_pacLabel.TabIndex = 24;
            relig_pacLabel.Text = "Religião :";
            // 
            // ind_pacLabel
            // 
            ind_pacLabel.AutoSize = true;
            ind_pacLabel.ForeColor = System.Drawing.SystemColors.Window;
            ind_pacLabel.Location = new System.Drawing.Point(403, 467);
            ind_pacLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            ind_pacLabel.Name = "ind_pacLabel";
            ind_pacLabel.Size = new System.Drawing.Size(157, 18);
            ind_pacLabel.TabIndex = 22;
            ind_pacLabel.Text = "Indicação do Paciente:";
            // 
            // prof_pacLabel
            // 
            prof_pacLabel.AutoSize = true;
            prof_pacLabel.ForeColor = System.Drawing.SystemColors.Window;
            prof_pacLabel.Location = new System.Drawing.Point(415, 272);
            prof_pacLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            prof_pacLabel.Name = "prof_pacLabel";
            prof_pacLabel.Size = new System.Drawing.Size(76, 18);
            prof_pacLabel.TabIndex = 20;
            prof_pacLabel.Text = "Profissão:";
            // 
            // obs_pacLabel
            // 
            obs_pacLabel.AutoSize = true;
            obs_pacLabel.ForeColor = System.Drawing.SystemColors.Window;
            obs_pacLabel.Location = new System.Drawing.Point(37, 467);
            obs_pacLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            obs_pacLabel.Name = "obs_pacLabel";
            obs_pacLabel.Size = new System.Drawing.Size(183, 18);
            obs_pacLabel.TabIndex = 18;
            obs_pacLabel.Text = "Observações no Paciente:";
            // 
            // sang_pacLabel
            // 
            sang_pacLabel.AutoSize = true;
            sang_pacLabel.ForeColor = System.Drawing.SystemColors.Window;
            sang_pacLabel.Location = new System.Drawing.Point(415, 216);
            sang_pacLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            sang_pacLabel.Name = "sang_pacLabel";
            sang_pacLabel.Size = new System.Drawing.Size(111, 18);
            sang_pacLabel.TabIndex = 16;
            sang_pacLabel.Text = "Tipo Sanguíneo";
            // 
            // end_pacLabel
            // 
            end_pacLabel.AutoSize = true;
            end_pacLabel.ForeColor = System.Drawing.SystemColors.Window;
            end_pacLabel.Location = new System.Drawing.Point(37, 362);
            end_pacLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            end_pacLabel.Name = "end_pacLabel";
            end_pacLabel.Size = new System.Drawing.Size(80, 18);
            end_pacLabel.TabIndex = 14;
            end_pacLabel.Text = "Endereço :";
            // 
            // nome_pacLabel
            // 
            nome_pacLabel.AutoSize = true;
            nome_pacLabel.ForeColor = System.Drawing.SystemColors.Window;
            nome_pacLabel.Location = new System.Drawing.Point(37, 99);
            nome_pacLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            nome_pacLabel.Name = "nome_pacLabel";
            nome_pacLabel.Size = new System.Drawing.Size(53, 18);
            nome_pacLabel.TabIndex = 2;
            nome_pacLabel.Text = "Nome:";
            // 
            // cod_pacLabel
            // 
            cod_pacLabel.AutoSize = true;
            cod_pacLabel.ForeColor = System.Drawing.SystemColors.Window;
            cod_pacLabel.Location = new System.Drawing.Point(37, 42);
            cod_pacLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            cod_pacLabel.Name = "cod_pacLabel";
            cod_pacLabel.Size = new System.Drawing.Size(121, 18);
            cod_pacLabel.TabIndex = 0;
            cod_pacLabel.Text = "Código Paciente:";
            // 
            // rGLabel
            // 
            rGLabel.AutoSize = true;
            rGLabel.ForeColor = System.Drawing.SystemColors.Window;
            rGLabel.Location = new System.Drawing.Point(37, 283);
            rGLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            rGLabel.Name = "rGLabel";
            rGLabel.Size = new System.Drawing.Size(35, 18);
            rGLabel.TabIndex = 10;
            rGLabel.Text = "RG:";
            // 
            // cPFLabel
            // 
            cPFLabel.AutoSize = true;
            cPFLabel.ForeColor = System.Drawing.SystemColors.Window;
            cPFLabel.Location = new System.Drawing.Point(187, 283);
            cPFLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            cPFLabel.Name = "cPFLabel";
            cPFLabel.Size = new System.Drawing.Size(46, 18);
            cPFLabel.TabIndex = 8;
            cPFLabel.Text = "CPF :";
            // 
            // cel_pacLabel
            // 
            cel_pacLabel.AutoSize = true;
            cel_pacLabel.ForeColor = System.Drawing.SystemColors.Window;
            cel_pacLabel.Location = new System.Drawing.Point(187, 225);
            cel_pacLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            cel_pacLabel.Name = "cel_pacLabel";
            cel_pacLabel.Size = new System.Drawing.Size(58, 18);
            cel_pacLabel.TabIndex = 6;
            cel_pacLabel.Text = "Celular:";
            // 
            // data_nascLabel
            // 
            data_nascLabel.AutoSize = true;
            data_nascLabel.ForeColor = System.Drawing.SystemColors.Window;
            data_nascLabel.Location = new System.Drawing.Point(37, 167);
            data_nascLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            data_nascLabel.Name = "data_nascLabel";
            data_nascLabel.Size = new System.Drawing.Size(123, 18);
            data_nascLabel.TabIndex = 31;
            data_nascLabel.Text = "Data Nascimento";
            // 
            // tel_pacLabel
            // 
            tel_pacLabel.AutoSize = true;
            tel_pacLabel.ForeColor = System.Drawing.SystemColors.Window;
            tel_pacLabel.Location = new System.Drawing.Point(37, 225);
            tel_pacLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            tel_pacLabel.Name = "tel_pacLabel";
            tel_pacLabel.Size = new System.Drawing.Size(69, 18);
            tel_pacLabel.TabIndex = 32;
            tel_pacLabel.Text = "Telefone:";
            // 
            // cod_cidLabel
            // 
            cod_cidLabel.AutoSize = true;
            cod_cidLabel.Location = new System.Drawing.Point(415, 97);
            cod_cidLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            cod_cidLabel.Name = "cod_cidLabel";
            cod_cidLabel.Size = new System.Drawing.Size(58, 18);
            cod_cidLabel.TabIndex = 34;
            cod_cidLabel.Text = "Cidade:";
            // 
            // pacienteBindingSource
            // 
            this.pacienteBindingSource.DataMember = "paciente";
            this.pacienteBindingSource.DataSource = this.clinicaDataSet;
            // 
            // clinicaDataSet
            // 
            this.clinicaDataSet.DataSetName = "ClinicaDataSet";
            this.clinicaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sexo_pacComboBox
            // 
            this.sexo_pacComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pacienteBindingSource, "sexo_pac", true));
            this.sexo_pacComboBox.FormattingEnabled = true;
            this.sexo_pacComboBox.Items.AddRange(new object[] {
            "Masculino",
            "Feminino"});
            this.sexo_pacComboBox.Location = new System.Drawing.Point(190, 189);
            this.sexo_pacComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.sexo_pacComboBox.Name = "sexo_pacComboBox";
            this.sexo_pacComboBox.Size = new System.Drawing.Size(122, 26);
            this.sexo_pacComboBox.TabIndex = 6;
            // 
            // e_mailTextBox
            // 
            this.e_mailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pacienteBindingSource, "e_mail", true));
            this.e_mailTextBox.Location = new System.Drawing.Point(418, 421);
            this.e_mailTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.e_mailTextBox.Name = "e_mailTextBox";
            this.e_mailTextBox.Size = new System.Drawing.Size(229, 24);
            this.e_mailTextBox.TabIndex = 16;
            // 
            // relig_pacTextBox
            // 
            this.relig_pacTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pacienteBindingSource, "relig_pac", true));
            this.relig_pacTextBox.Location = new System.Drawing.Point(418, 356);
            this.relig_pacTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.relig_pacTextBox.Name = "relig_pacTextBox";
            this.relig_pacTextBox.Size = new System.Drawing.Size(181, 24);
            this.relig_pacTextBox.TabIndex = 15;
            // 
            // ind_pacTextBox
            // 
            this.ind_pacTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pacienteBindingSource, "ind_pac", true));
            this.ind_pacTextBox.Location = new System.Drawing.Point(40, 489);
            this.ind_pacTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.ind_pacTextBox.Multiline = true;
            this.ind_pacTextBox.Name = "ind_pacTextBox";
            this.ind_pacTextBox.Size = new System.Drawing.Size(240, 62);
            this.ind_pacTextBox.TabIndex = 17;
            // 
            // prof_pacTextBox
            // 
            this.prof_pacTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pacienteBindingSource, "prof_pac", true));
            this.prof_pacTextBox.Location = new System.Drawing.Point(418, 293);
            this.prof_pacTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.prof_pacTextBox.Name = "prof_pacTextBox";
            this.prof_pacTextBox.Size = new System.Drawing.Size(215, 24);
            this.prof_pacTextBox.TabIndex = 14;
            // 
            // obs_pacTextBox
            // 
            this.obs_pacTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pacienteBindingSource, "obs_pac", true));
            this.obs_pacTextBox.Location = new System.Drawing.Point(406, 489);
            this.obs_pacTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.obs_pacTextBox.Multiline = true;
            this.obs_pacTextBox.Name = "obs_pacTextBox";
            this.obs_pacTextBox.Size = new System.Drawing.Size(256, 62);
            this.obs_pacTextBox.TabIndex = 10;
            // 
            // sang_pacTextBox
            // 
            this.sang_pacTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pacienteBindingSource, "sang_pac", true));
            this.sang_pacTextBox.Location = new System.Drawing.Point(418, 238);
            this.sang_pacTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.sang_pacTextBox.Name = "sang_pacTextBox";
            this.sang_pacTextBox.Size = new System.Drawing.Size(46, 24);
            this.sang_pacTextBox.TabIndex = 13;
            // 
            // end_pacTextBox
            // 
            this.end_pacTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pacienteBindingSource, "end_pac", true));
            this.end_pacTextBox.Location = new System.Drawing.Point(40, 384);
            this.end_pacTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.end_pacTextBox.Multiline = true;
            this.end_pacTextBox.Name = "end_pacTextBox";
            this.end_pacTextBox.Size = new System.Drawing.Size(256, 45);
            this.end_pacTextBox.TabIndex = 9;
            // 
            // nome_pacTextBox
            // 
            this.nome_pacTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pacienteBindingSource, "nome_pac", true));
            this.nome_pacTextBox.Location = new System.Drawing.Point(40, 121);
            this.nome_pacTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.nome_pacTextBox.Name = "nome_pacTextBox";
            this.nome_pacTextBox.Size = new System.Drawing.Size(298, 24);
            this.nome_pacTextBox.TabIndex = 2;
            // 
            // cod_pacTextBox
            // 
            this.cod_pacTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pacienteBindingSource, "cod_pac", true));
            this.cod_pacTextBox.Enabled = false;
            this.cod_pacTextBox.Location = new System.Drawing.Point(40, 64);
            this.cod_pacTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.cod_pacTextBox.Name = "cod_pacTextBox";
            this.cod_pacTextBox.Size = new System.Drawing.Size(51, 24);
            this.cod_pacTextBox.TabIndex = 1;
            this.cod_pacTextBox.TextChanged += new System.EventHandler(this.cod_pacTextBox_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(cod_cidLabel);
            this.groupBox1.Controls.Add(tel_pacLabel);
            this.groupBox1.Controls.Add(this.tel_pacMaskedTextBox);
            this.groupBox1.Controls.Add(data_nascLabel);
            this.groupBox1.Controls.Add(this.data_nascMaskedTextBox);
            this.groupBox1.Controls.Add(cod_pacLabel);
            this.groupBox1.Controls.Add(this.cod_pacTextBox);
            this.groupBox1.Controls.Add(nome_pacLabel);
            this.groupBox1.Controls.Add(this.nome_pacTextBox);
            this.groupBox1.Controls.Add(cel_pacLabel);
            this.groupBox1.Controls.Add(this.cel_pacMaskedTextBox);
            this.groupBox1.Controls.Add(cPFLabel);
            this.groupBox1.Controls.Add(this.cPFMaskedTextBox);
            this.groupBox1.Controls.Add(rGLabel);
            this.groupBox1.Controls.Add(this.rGMaskedTextBox);
            this.groupBox1.Controls.Add(end_pacLabel);
            this.groupBox1.Controls.Add(this.end_pacTextBox);
            this.groupBox1.Controls.Add(sang_pacLabel);
            this.groupBox1.Controls.Add(this.sang_pacTextBox);
            this.groupBox1.Controls.Add(obs_pacLabel);
            this.groupBox1.Controls.Add(this.obs_pacTextBox);
            this.groupBox1.Controls.Add(prof_pacLabel);
            this.groupBox1.Controls.Add(this.prof_pacTextBox);
            this.groupBox1.Controls.Add(ind_pacLabel);
            this.groupBox1.Controls.Add(this.ind_pacTextBox);
            this.groupBox1.Controls.Add(relig_pacLabel);
            this.groupBox1.Controls.Add(this.relig_pacTextBox);
            this.groupBox1.Controls.Add(e_mailLabel);
            this.groupBox1.Controls.Add(this.e_mailTextBox);
            this.groupBox1.Controls.Add(sexo_pacLabel);
            this.groupBox1.Controls.Add(this.sexo_pacComboBox);
            this.groupBox1.Enabled = false;
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(276, 32);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(690, 607);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(297, 24);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 18);
            this.label2.TabIndex = 35;
            this.label2.Text = "Cadastro de Paciente";
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.pacienteBindingSource, "cod_cid", true));
            this.comboBox1.DataSource = this.cidadeBindingSource;
            this.comboBox1.DisplayMember = "nome_cid";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(418, 119);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(215, 26);
            this.comboBox1.TabIndex = 11;
            this.comboBox1.ValueMember = "cod_cid";
            // 
            // cidadeBindingSource
            // 
            this.cidadeBindingSource.DataMember = "cidade";
            this.cidadeBindingSource.DataSource = this.clinicaDataSet;
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(445, 153);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(165, 29);
            this.button1.TabIndex = 12;
            this.button1.Text = "Cadastrar Cidade";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tel_pacMaskedTextBox
            // 
            this.tel_pacMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pacienteBindingSource, "tel_pac", true));
            this.tel_pacMaskedTextBox.Location = new System.Drawing.Point(40, 247);
            this.tel_pacMaskedTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.tel_pacMaskedTextBox.Mask = "(99) 0000-0000";
            this.tel_pacMaskedTextBox.Name = "tel_pacMaskedTextBox";
            this.tel_pacMaskedTextBox.Size = new System.Drawing.Size(106, 24);
            this.tel_pacMaskedTextBox.TabIndex = 4;
            // 
            // data_nascMaskedTextBox
            // 
            this.data_nascMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pacienteBindingSource, "data_nasc", true));
            this.data_nascMaskedTextBox.Location = new System.Drawing.Point(40, 189);
            this.data_nascMaskedTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.data_nascMaskedTextBox.Mask = "00/00/0000";
            this.data_nascMaskedTextBox.Name = "data_nascMaskedTextBox";
            this.data_nascMaskedTextBox.Size = new System.Drawing.Size(80, 24);
            this.data_nascMaskedTextBox.TabIndex = 3;
            this.data_nascMaskedTextBox.ValidatingType = typeof(System.DateTime);
            // 
            // cel_pacMaskedTextBox
            // 
            this.cel_pacMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pacienteBindingSource, "cel_pac", true));
            this.cel_pacMaskedTextBox.Location = new System.Drawing.Point(190, 247);
            this.cel_pacMaskedTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.cel_pacMaskedTextBox.Mask = "(99) 00000-0000";
            this.cel_pacMaskedTextBox.Name = "cel_pacMaskedTextBox";
            this.cel_pacMaskedTextBox.Size = new System.Drawing.Size(116, 24);
            this.cel_pacMaskedTextBox.TabIndex = 7;
            // 
            // cPFMaskedTextBox
            // 
            this.cPFMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pacienteBindingSource, "CPF", true));
            this.cPFMaskedTextBox.Location = new System.Drawing.Point(190, 305);
            this.cPFMaskedTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.cPFMaskedTextBox.Mask = "000.000.000-00";
            this.cPFMaskedTextBox.Name = "cPFMaskedTextBox";
            this.cPFMaskedTextBox.Size = new System.Drawing.Size(106, 24);
            this.cPFMaskedTextBox.TabIndex = 8;
            // 
            // rGMaskedTextBox
            // 
            this.rGMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pacienteBindingSource, "RG", true));
            this.rGMaskedTextBox.Location = new System.Drawing.Point(40, 305);
            this.rGMaskedTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.rGMaskedTextBox.Mask = "00.000.000-0";
            this.rGMaskedTextBox.Name = "rGMaskedTextBox";
            this.rGMaskedTextBox.Size = new System.Drawing.Size(100, 24);
            this.rGMaskedTextBox.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(427, 45);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(264, 29);
            this.label1.TabIndex = 34;
            this.label1.Text = "Cadastro de Paciente";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pacienteTableAdapter
            // 
            this.pacienteTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.cidadeTableAdapter = null;
            this.tableAdapterManager.consultaTableAdapter = null;
            this.tableAdapterManager.conta_receberTableAdapter = null;
            this.tableAdapterManager.itens_vendaTableAdapter = null;
            this.tableAdapterManager.medicoTableAdapter = null;
            this.tableAdapterManager.pacienteTableAdapter = this.pacienteTableAdapter;
            this.tableAdapterManager.produtoTableAdapter = null;
            this.tableAdapterManager.sessaoTableAdapter = null;
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
            this.clienteBindingNavigator.BindingSource = this.pacienteBindingSource;
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
            this.clienteBindingNavigator.Size = new System.Drawing.Size(983, 25);
            this.clienteBindingNavigator.TabIndex = 20;
            this.clienteBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.Image = global::SystemKenkou.Properties.Resources._new;
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(78, 22);
            this.bindingNavigatorAddNewItem.Tag = "Adicionar";
            this.bindingNavigatorAddNewItem.Text = "Adicionar";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click_1);
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
            this.clienteBindingNavigatorSaveItem.Image = global::SystemKenkou.Properties.Resources.save1;
            this.clienteBindingNavigatorSaveItem.Name = "clienteBindingNavigatorSaveItem";
            this.clienteBindingNavigatorSaveItem.Size = new System.Drawing.Size(58, 22);
            this.clienteBindingNavigatorSaveItem.Tag = "Salvar";
            this.clienteBindingNavigatorSaveItem.Text = "Salvar";
            this.clienteBindingNavigatorSaveItem.Click += new System.EventHandler(this.clienteBindingNavigatorSaveItem_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = global::SystemKenkou.Properties.Resources.error;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(73, 22);
            this.toolStripButton1.Tag = "Cancelar";
            this.toolStripButton1.Text = "Cancelar";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click_2);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Image = global::SystemKenkou.Properties.Resources.draw;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(57, 22);
            this.toolStripButton2.Tag = "Editar";
            this.toolStripButton2.Text = "Editar";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click_1);
            // 
            // bindingNavigatorDeleteItem
            // 
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
            this.toolStripButton3.Image = global::SystemKenkou.Properties.Resources._1470067030_common_logout_signout_exit_outline_stroke;
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(46, 22);
            this.toolStripButton3.Tag = "Sair";
            this.toolStripButton3.Text = "Sair";
            this.toolStripButton3.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // btTratamento
            // 
            this.btTratamento.ForeColor = System.Drawing.Color.Black;
            this.btTratamento.Image = global::SystemKenkou.Properties.Resources.lupa;
            this.btTratamento.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btTratamento.Name = "btTratamento";
            this.btTratamento.Size = new System.Drawing.Size(121, 22);
            this.btTratamento.Tag = "Localizar Paciente";
            this.btTratamento.Text = "Localizar Paciente";
            this.btTratamento.Click += new System.EventHandler(this.btTratamento_Click);
            // 
            // cidadeTableAdapter
            // 
            this.cidadeTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.btn_carregar);
            this.groupBox2.Controls.Add(this.btn_remov);
            this.groupBox2.Controls.Add(this.pac_imgPictureBox);
            this.groupBox2.Enabled = false;
            this.groupBox2.Location = new System.Drawing.Point(15, 32);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(254, 349);
            this.groupBox2.TabIndex = 35;
            this.groupBox2.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(52, 43);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 18);
            this.label3.TabIndex = 36;
            this.label3.Text = "Imagem do Paciente";
            // 
            // btn_carregar
            // 
            this.btn_carregar.BackColor = System.Drawing.Color.White;
            this.btn_carregar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_carregar.ForeColor = System.Drawing.Color.Black;
            this.btn_carregar.Location = new System.Drawing.Point(46, 272);
            this.btn_carregar.Name = "btn_carregar";
            this.btn_carregar.Size = new System.Drawing.Size(78, 36);
            this.btn_carregar.TabIndex = 18;
            this.btn_carregar.Text = "Carregar";
            this.btn_carregar.UseVisualStyleBackColor = false;
            this.btn_carregar.Click += new System.EventHandler(this.btn_carregar_Click);
            // 
            // btn_remov
            // 
            this.btn_remov.BackColor = System.Drawing.Color.White;
            this.btn_remov.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_remov.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_remov.ForeColor = System.Drawing.Color.Black;
            this.btn_remov.Location = new System.Drawing.Point(133, 272);
            this.btn_remov.Name = "btn_remov";
            this.btn_remov.Size = new System.Drawing.Size(78, 36);
            this.btn_remov.TabIndex = 19;
            this.btn_remov.Text = "Remover";
            this.btn_remov.UseVisualStyleBackColor = false;
            this.btn_remov.Click += new System.EventHandler(this.btn_remov_Click);
            // 
            // pac_imgPictureBox
            // 
            this.pac_imgPictureBox.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.pac_imgPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pac_imgPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.pacienteBindingSource, "pac_img", true));
            this.pac_imgPictureBox.Location = new System.Drawing.Point(46, 64);
            this.pac_imgPictureBox.Name = "pac_imgPictureBox";
            this.pac_imgPictureBox.Size = new System.Drawing.Size(165, 198);
            this.pac_imgPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pac_imgPictureBox.TabIndex = 1;
            this.pac_imgPictureBox.TabStop = false;
            this.pac_imgPictureBox.Tag = "Imagem ";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Frm_Cadastro_Pacientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.BackgroundImage = global::SystemKenkou.Properties.Resources.Sem_título7;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(983, 662);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.clienteBindingNavigator);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Frm_Cadastro_Pacientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_Cadastro_Pacientes";
            this.Load += new System.EventHandler(this.Frm_Cadastro_Pacientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pacienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clinicaDataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cidadeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingNavigator)).EndInit();
            this.clienteBindingNavigator.ResumeLayout(false);
            this.clienteBindingNavigator.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pac_imgPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ClinicaDataSet clinicaDataSet;
        private System.Windows.Forms.BindingSource pacienteBindingSource;
        private ClinicaDataSetTableAdapters.pacienteTableAdapter pacienteTableAdapter;
        private ClinicaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ComboBox sexo_pacComboBox;
        private System.Windows.Forms.TextBox e_mailTextBox;
        private System.Windows.Forms.TextBox relig_pacTextBox;
        private System.Windows.Forms.TextBox ind_pacTextBox;
        private System.Windows.Forms.TextBox prof_pacTextBox;
        private System.Windows.Forms.TextBox obs_pacTextBox;
        private System.Windows.Forms.TextBox sang_pacTextBox;
        private System.Windows.Forms.TextBox end_pacTextBox;
        private System.Windows.Forms.TextBox nome_pacTextBox;
        private System.Windows.Forms.TextBox cod_pacTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MaskedTextBox tel_pacMaskedTextBox;
        private System.Windows.Forms.MaskedTextBox data_nascMaskedTextBox;
        private System.Windows.Forms.MaskedTextBox cel_pacMaskedTextBox;
        private System.Windows.Forms.MaskedTextBox cPFMaskedTextBox;
        private System.Windows.Forms.MaskedTextBox rGMaskedTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingNavigator clienteBindingNavigator;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripButton clienteBindingNavigatorSaveItem;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource cidadeBindingSource;
        private ClinicaDataSetTableAdapters.cidadeTableAdapter cidadeTableAdapter;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton btTratamento;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_carregar;
        private System.Windows.Forms.Button btn_remov;
        private System.Windows.Forms.PictureBox pac_imgPictureBox;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}