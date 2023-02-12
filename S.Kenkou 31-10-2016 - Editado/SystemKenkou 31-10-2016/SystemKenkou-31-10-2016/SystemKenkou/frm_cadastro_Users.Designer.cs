namespace SystemKenkou
{
    partial class frm_cadastro_Users
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
            System.Windows.Forms.Label user_codLabel;
            System.Windows.Forms.Label user_nomeLabel;
            System.Windows.Forms.Label user_telefoneLabel;
            System.Windows.Forms.Label user_loginLabel;
            System.Windows.Forms.Label user_senhaLabel;
            System.Windows.Forms.Label user_nivelLabel;
            System.Windows.Forms.Label user_imgLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_cadastro_Users));
            this.Menu_binding = new System.Windows.Forms.BindingNavigator(this.components);
            this.usuáriosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clinicaDataSet = new SystemKenkou.ClinicaDataSet();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.add = new System.Windows.Forms.ToolStripButton();
            this.clienteBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.cancel = new System.Windows.Forms.ToolStripButton();
            this.edi = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.btTratamento = new System.Windows.Forms.ToolStripButton();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.btnimg = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.user_codTextBox = new System.Windows.Forms.TextBox();
            this.user_nomeTextBox = new System.Windows.Forms.TextBox();
            this.user_telefoneMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.user_loginTextBox = new System.Windows.Forms.TextBox();
            this.user_senhaTextBox = new System.Windows.Forms.TextBox();
            this.user_nivelComboBox = new System.Windows.Forms.ComboBox();
            this.user_imgPictureBox = new System.Windows.Forms.PictureBox();
            this.usercodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usernomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usertelefoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userloginDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usersenhaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usernivelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userimgDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.usuáriosTableAdapter = new SystemKenkou.ClinicaDataSetTableAdapters.UsuáriosTableAdapter();
            this.tableAdapterManager = new SystemKenkou.ClinicaDataSetTableAdapters.TableAdapterManager();
            user_codLabel = new System.Windows.Forms.Label();
            user_nomeLabel = new System.Windows.Forms.Label();
            user_telefoneLabel = new System.Windows.Forms.Label();
            user_loginLabel = new System.Windows.Forms.Label();
            user_senhaLabel = new System.Windows.Forms.Label();
            user_nivelLabel = new System.Windows.Forms.Label();
            user_imgLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Menu_binding)).BeginInit();
            this.Menu_binding.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usuáriosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clinicaDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.user_imgPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // user_codLabel
            // 
            user_codLabel.AutoSize = true;
            user_codLabel.Location = new System.Drawing.Point(25, 82);
            user_codLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            user_codLabel.Name = "user_codLabel";
            user_codLabel.Size = new System.Drawing.Size(144, 20);
            user_codLabel.TabIndex = 0;
            user_codLabel.Text = "Código do Usuário:";
            // 
            // user_nomeLabel
            // 
            user_nomeLabel.AutoSize = true;
            user_nomeLabel.Location = new System.Drawing.Point(33, 144);
            user_nomeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            user_nomeLabel.Name = "user_nomeLabel";
            user_nomeLabel.Size = new System.Drawing.Size(136, 20);
            user_nomeLabel.TabIndex = 2;
            user_nomeLabel.Text = "Nome do Usuário:";
            // 
            // user_telefoneLabel
            // 
            user_telefoneLabel.AutoSize = true;
            user_telefoneLabel.Location = new System.Drawing.Point(13, 209);
            user_telefoneLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            user_telefoneLabel.Name = "user_telefoneLabel";
            user_telefoneLabel.Size = new System.Drawing.Size(156, 20);
            user_telefoneLabel.TabIndex = 4;
            user_telefoneLabel.Text = "Telefone do Usuário:";
            // 
            // user_loginLabel
            // 
            user_loginLabel.AutoSize = true;
            user_loginLabel.Location = new System.Drawing.Point(36, 273);
            user_loginLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            user_loginLabel.Name = "user_loginLabel";
            user_loginLabel.Size = new System.Drawing.Size(133, 20);
            user_loginLabel.TabIndex = 6;
            user_loginLabel.Text = "Login do Usuário:";
            // 
            // user_senhaLabel
            // 
            user_senhaLabel.AutoSize = true;
            user_senhaLabel.Location = new System.Drawing.Point(28, 338);
            user_senhaLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            user_senhaLabel.Name = "user_senhaLabel";
            user_senhaLabel.Size = new System.Drawing.Size(141, 20);
            user_senhaLabel.TabIndex = 8;
            user_senhaLabel.Text = "Senha do Usuário:";
            // 
            // user_nivelLabel
            // 
            user_nivelLabel.AutoSize = true;
            user_nivelLabel.Location = new System.Drawing.Point(42, 399);
            user_nivelLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            user_nivelLabel.Name = "user_nivelLabel";
            user_nivelLabel.Size = new System.Drawing.Size(127, 20);
            user_nivelLabel.TabIndex = 10;
            user_nivelLabel.Text = "Nivel do Usuário:";
            // 
            // user_imgLabel
            // 
            user_imgLabel.AutoSize = true;
            user_imgLabel.Location = new System.Drawing.Point(522, 63);
            user_imgLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            user_imgLabel.Name = "user_imgLabel";
            user_imgLabel.Size = new System.Drawing.Size(152, 20);
            user_imgLabel.TabIndex = 12;
            user_imgLabel.Text = "Imagem do Usuário:";
            // 
            // Menu_binding
            // 
            this.Menu_binding.AddNewItem = null;
            this.Menu_binding.BackColor = System.Drawing.SystemColors.Window;
            this.Menu_binding.BindingSource = this.usuáriosBindingSource;
            this.Menu_binding.CountItem = this.bindingNavigatorCountItem;
            this.Menu_binding.DeleteItem = null;
            this.Menu_binding.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.add,
            this.clienteBindingNavigatorSaveItem,
            this.cancel,
            this.edi,
            this.bindingNavigatorDeleteItem,
            this.toolStripButton3,
            this.btTratamento});
            this.Menu_binding.Location = new System.Drawing.Point(0, 0);
            this.Menu_binding.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.Menu_binding.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.Menu_binding.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.Menu_binding.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.Menu_binding.Name = "Menu_binding";
            this.Menu_binding.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.Menu_binding.PositionItem = this.bindingNavigatorPositionItem;
            this.Menu_binding.Size = new System.Drawing.Size(792, 25);
            this.Menu_binding.TabIndex = 16;
            this.Menu_binding.Text = "bindingNavigator1";
            // 
            // usuáriosBindingSource
            // 
            this.usuáriosBindingSource.DataMember = "Usuários";
            this.usuáriosBindingSource.DataSource = this.clinicaDataSet;
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
            // add
            // 
            this.add.ForeColor = System.Drawing.SystemColors.InfoText;
            this.add.Image = global::SystemKenkou.Properties.Resources._new;
            this.add.Name = "add";
            this.add.RightToLeftAutoMirrorImage = true;
            this.add.Size = new System.Drawing.Size(78, 22);
            this.add.Tag = "Adicionar";
            this.add.Text = "Adicionar";
            this.add.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
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
            // cancel
            // 
            this.cancel.ForeColor = System.Drawing.SystemColors.InfoText;
            this.cancel.Image = global::SystemKenkou.Properties.Resources.error;
            this.cancel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(73, 22);
            this.cancel.Tag = "Cancelar";
            this.cancel.Text = "Cancelar";
            this.cancel.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // edi
            // 
            this.edi.ForeColor = System.Drawing.SystemColors.InfoText;
            this.edi.Image = global::SystemKenkou.Properties.Resources.draw;
            this.edi.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.edi.Name = "edi";
            this.edi.Size = new System.Drawing.Size(57, 22);
            this.edi.Tag = "Editar";
            this.edi.Text = "Editar";
            this.edi.Click += new System.EventHandler(this.toolStripButton2_Click);
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
            this.toolStripButton3.Click += new System.EventHandler(this.toolStripButton3_Click_1);
            // 
            // btTratamento
            // 
            this.btTratamento.ForeColor = System.Drawing.Color.Black;
            this.btTratamento.Image = global::SystemKenkou.Properties.Resources.lupa;
            this.btTratamento.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btTratamento.Name = "btTratamento";
            this.btTratamento.Size = new System.Drawing.Size(121, 22);
            this.btTratamento.Tag = "Localizar Usuários";
            this.btTratamento.Text = "Localizar Usuários";
            this.btTratamento.Click += new System.EventHandler(this.btTratamento_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.btnimg);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(user_codLabel);
            this.groupBox1.Controls.Add(this.user_codTextBox);
            this.groupBox1.Controls.Add(user_nomeLabel);
            this.groupBox1.Controls.Add(this.user_nomeTextBox);
            this.groupBox1.Controls.Add(user_telefoneLabel);
            this.groupBox1.Controls.Add(this.user_telefoneMaskedTextBox);
            this.groupBox1.Controls.Add(user_loginLabel);
            this.groupBox1.Controls.Add(this.user_loginTextBox);
            this.groupBox1.Controls.Add(user_senhaLabel);
            this.groupBox1.Controls.Add(this.user_senhaTextBox);
            this.groupBox1.Controls.Add(user_nivelLabel);
            this.groupBox1.Controls.Add(this.user_nivelComboBox);
            this.groupBox1.Controls.Add(user_imgLabel);
            this.groupBox1.Controls.Add(this.user_imgPictureBox);
            this.groupBox1.Enabled = false;
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Window;
            this.groupBox1.Location = new System.Drawing.Point(23, 32);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(747, 446);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados:";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button2.Location = new System.Drawing.Point(614, 378);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(96, 43);
            this.button2.TabIndex = 8;
            this.button2.Text = "Remover";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // btnimg
            // 
            this.btnimg.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnimg.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnimg.Location = new System.Drawing.Point(484, 378);
            this.btnimg.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnimg.Name = "btnimg";
            this.btnimg.Size = new System.Drawing.Size(96, 43);
            this.btnimg.TabIndex = 7;
            this.btnimg.Text = "Carregar";
            this.btnimg.UseVisualStyleBackColor = false;
            this.btnimg.Click += new System.EventHandler(this.btnimg_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(277, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "Cadastro de Usuários";
            // 
            // user_codTextBox
            // 
            this.user_codTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuáriosBindingSource, "user_cod", true));
            this.user_codTextBox.Enabled = false;
            this.user_codTextBox.Location = new System.Drawing.Point(177, 79);
            this.user_codTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.user_codTextBox.Name = "user_codTextBox";
            this.user_codTextBox.Size = new System.Drawing.Size(45, 26);
            this.user_codTextBox.TabIndex = 1;
            // 
            // user_nomeTextBox
            // 
            this.user_nomeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuáriosBindingSource, "user_nome", true));
            this.user_nomeTextBox.Location = new System.Drawing.Point(177, 141);
            this.user_nomeTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.user_nomeTextBox.Name = "user_nomeTextBox";
            this.user_nomeTextBox.Size = new System.Drawing.Size(191, 26);
            this.user_nomeTextBox.TabIndex = 2;
            // 
            // user_telefoneMaskedTextBox
            // 
            this.user_telefoneMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuáriosBindingSource, "user_telefone", true));
            this.user_telefoneMaskedTextBox.Location = new System.Drawing.Point(177, 206);
            this.user_telefoneMaskedTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.user_telefoneMaskedTextBox.Mask = "(99) 0000-0000";
            this.user_telefoneMaskedTextBox.Name = "user_telefoneMaskedTextBox";
            this.user_telefoneMaskedTextBox.Size = new System.Drawing.Size(120, 26);
            this.user_telefoneMaskedTextBox.TabIndex = 3;
            // 
            // user_loginTextBox
            // 
            this.user_loginTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuáriosBindingSource, "user_login", true));
            this.user_loginTextBox.Location = new System.Drawing.Point(177, 270);
            this.user_loginTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.user_loginTextBox.Name = "user_loginTextBox";
            this.user_loginTextBox.Size = new System.Drawing.Size(171, 26);
            this.user_loginTextBox.TabIndex = 4;
            // 
            // user_senhaTextBox
            // 
            this.user_senhaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuáriosBindingSource, "user_senha", true));
            this.user_senhaTextBox.Location = new System.Drawing.Point(177, 335);
            this.user_senhaTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.user_senhaTextBox.Name = "user_senhaTextBox";
            this.user_senhaTextBox.Size = new System.Drawing.Size(171, 26);
            this.user_senhaTextBox.TabIndex = 5;
            // 
            // user_nivelComboBox
            // 
            this.user_nivelComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuáriosBindingSource, "user_nivel", true));
            this.user_nivelComboBox.FormattingEnabled = true;
            this.user_nivelComboBox.Items.AddRange(new object[] {
            "Administrador",
            "Funcionário",
            "Comum"});
            this.user_nivelComboBox.Location = new System.Drawing.Point(177, 396);
            this.user_nivelComboBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.user_nivelComboBox.Name = "user_nivelComboBox";
            this.user_nivelComboBox.Size = new System.Drawing.Size(131, 28);
            this.user_nivelComboBox.TabIndex = 6;
            // 
            // user_imgPictureBox
            // 
            this.user_imgPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.usuáriosBindingSource, "user_img", true));
            this.user_imgPictureBox.Location = new System.Drawing.Point(485, 93);
            this.user_imgPictureBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.user_imgPictureBox.Name = "user_imgPictureBox";
            this.user_imgPictureBox.Size = new System.Drawing.Size(225, 265);
            this.user_imgPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.user_imgPictureBox.TabIndex = 13;
            this.user_imgPictureBox.TabStop = false;
            // 
            // usercodDataGridViewTextBoxColumn
            // 
            this.usercodDataGridViewTextBoxColumn.DataPropertyName = "user_cod";
            this.usercodDataGridViewTextBoxColumn.HeaderText = "user_cod";
            this.usercodDataGridViewTextBoxColumn.Name = "usercodDataGridViewTextBoxColumn";
            this.usercodDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // usernomeDataGridViewTextBoxColumn
            // 
            this.usernomeDataGridViewTextBoxColumn.DataPropertyName = "user_nome";
            this.usernomeDataGridViewTextBoxColumn.HeaderText = "user_nome";
            this.usernomeDataGridViewTextBoxColumn.Name = "usernomeDataGridViewTextBoxColumn";
            // 
            // usertelefoneDataGridViewTextBoxColumn
            // 
            this.usertelefoneDataGridViewTextBoxColumn.DataPropertyName = "user_telefone";
            this.usertelefoneDataGridViewTextBoxColumn.HeaderText = "user_telefone";
            this.usertelefoneDataGridViewTextBoxColumn.Name = "usertelefoneDataGridViewTextBoxColumn";
            // 
            // userloginDataGridViewTextBoxColumn
            // 
            this.userloginDataGridViewTextBoxColumn.DataPropertyName = "user_login";
            this.userloginDataGridViewTextBoxColumn.HeaderText = "user_login";
            this.userloginDataGridViewTextBoxColumn.Name = "userloginDataGridViewTextBoxColumn";
            // 
            // usersenhaDataGridViewTextBoxColumn
            // 
            this.usersenhaDataGridViewTextBoxColumn.DataPropertyName = "user_senha";
            this.usersenhaDataGridViewTextBoxColumn.HeaderText = "user_senha";
            this.usersenhaDataGridViewTextBoxColumn.Name = "usersenhaDataGridViewTextBoxColumn";
            // 
            // usernivelDataGridViewTextBoxColumn
            // 
            this.usernivelDataGridViewTextBoxColumn.DataPropertyName = "user_nivel";
            this.usernivelDataGridViewTextBoxColumn.HeaderText = "user_nivel";
            this.usernivelDataGridViewTextBoxColumn.Name = "usernivelDataGridViewTextBoxColumn";
            // 
            // userimgDataGridViewImageColumn
            // 
            this.userimgDataGridViewImageColumn.DataPropertyName = "user_img";
            this.userimgDataGridViewImageColumn.HeaderText = "user_img";
            this.userimgDataGridViewImageColumn.Name = "userimgDataGridViewImageColumn";
            // 
            // usuáriosTableAdapter
            // 
            this.usuáriosTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.UsuáriosTableAdapter = this.usuáriosTableAdapter;
            this.tableAdapterManager.vendaTableAdapter = null;
            // 
            // frm_cadastro_Users
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.BackgroundImage = global::SystemKenkou.Properties.Resources.Sem_título7;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(792, 501);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Menu_binding);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.Window;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frm_cadastro_Users";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_cadastro_Users";
            this.Load += new System.EventHandler(this.frm_cadastro_Users_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Menu_binding)).EndInit();
            this.Menu_binding.ResumeLayout(false);
            this.Menu_binding.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usuáriosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clinicaDataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.user_imgPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ClinicaDataSet clinicaDataSet;
        private System.Windows.Forms.BindingSource usuáriosBindingSource;
        private ClinicaDataSetTableAdapters.UsuáriosTableAdapter usuáriosTableAdapter;
        private ClinicaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator Menu_binding;
        private System.Windows.Forms.ToolStripButton add;
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
        private System.Windows.Forms.ToolStripButton cancel;
        private System.Windows.Forms.ToolStripButton edi;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnimg;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox user_codTextBox;
        private System.Windows.Forms.TextBox user_nomeTextBox;
        private System.Windows.Forms.MaskedTextBox user_telefoneMaskedTextBox;
        private System.Windows.Forms.TextBox user_loginTextBox;
        private System.Windows.Forms.TextBox user_senhaTextBox;
        private System.Windows.Forms.ComboBox user_nivelComboBox;
        private System.Windows.Forms.PictureBox user_imgPictureBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn usercodDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usernomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usertelefoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userloginDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usersenhaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usernivelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn userimgDataGridViewImageColumn;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton btTratamento;

    }
}