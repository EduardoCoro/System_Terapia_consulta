namespace SystemKenkou
{
    partial class Frm_img_opcao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_img_opcao));
            this.clinicaDataSet = new SystemKenkou.ClinicaDataSet();
            this.usuáriosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usuáriosTableAdapter = new SystemKenkou.ClinicaDataSetTableAdapters.UsuáriosTableAdapter();
            this.tableAdapterManager = new SystemKenkou.ClinicaDataSetTableAdapters.TableAdapterManager();
            this.btn_salvar = new System.Windows.Forms.Button();
            this.Btn_load = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.user_imgPictureBox = new System.Windows.Forms.PictureBox();
            this.btnSair = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.clinicaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuáriosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.user_imgPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // clinicaDataSet
            // 
            this.clinicaDataSet.DataSetName = "ClinicaDataSet";
            this.clinicaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usuáriosBindingSource
            // 
            this.usuáriosBindingSource.DataMember = "Usuários";
            this.usuáriosBindingSource.DataSource = this.clinicaDataSet;
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
            // btn_salvar
            // 
            this.btn_salvar.Location = new System.Drawing.Point(251, 283);
            this.btn_salvar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_salvar.Name = "btn_salvar";
            this.btn_salvar.Size = new System.Drawing.Size(111, 34);
            this.btn_salvar.TabIndex = 3;
            this.btn_salvar.Text = "Salvar";
            this.btn_salvar.UseVisualStyleBackColor = true;
            this.btn_salvar.Click += new System.EventHandler(this.btn_salvar_Click);
            // 
            // Btn_load
            // 
            this.Btn_load.Location = new System.Drawing.Point(13, 283);
            this.Btn_load.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Btn_load.Name = "Btn_load";
            this.Btn_load.Size = new System.Drawing.Size(111, 34);
            this.Btn_load.TabIndex = 1;
            this.Btn_load.Text = "Carregar";
            this.Btn_load.UseVisualStyleBackColor = true;
            this.Btn_load.Click += new System.EventHandler(this.Btn_load_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(132, 283);
            this.btn_delete.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(111, 34);
            this.btn_delete.TabIndex = 2;
            this.btn_delete.Text = "Remover";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // user_imgPictureBox
            // 
            this.user_imgPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.user_imgPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.usuáriosBindingSource, "user_img", true));
            this.user_imgPictureBox.Location = new System.Drawing.Point(85, 23);
            this.user_imgPictureBox.Name = "user_imgPictureBox";
            this.user_imgPictureBox.Size = new System.Drawing.Size(197, 250);
            this.user_imgPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.user_imgPictureBox.TabIndex = 5;
            this.user_imgPictureBox.TabStop = false;
            // 
            // btnSair
            // 
            this.btnSair.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSair.Image = global::SystemKenkou.Properties.Resources._1470067030_common_logout_signout_exit_outline_stroke;
            this.btnSair.Location = new System.Drawing.Point(328, 12);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(35, 39);
            this.btnSair.TabIndex = 6;
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // Frm_img_opcao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.BackgroundImage = global::SystemKenkou.Properties.Resources.Sem_título7;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(375, 328);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.user_imgPictureBox);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.Btn_load);
            this.Controls.Add(this.btn_salvar);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Frm_img_opcao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "System Kenkou - Imagem Usuário";
            this.Load += new System.EventHandler(this.Frm_img_opcao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.clinicaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuáriosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.user_imgPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ClinicaDataSet clinicaDataSet;
        private System.Windows.Forms.BindingSource usuáriosBindingSource;
        private ClinicaDataSetTableAdapters.UsuáriosTableAdapter usuáriosTableAdapter;
        private ClinicaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Button btn_salvar;
        private System.Windows.Forms.Button Btn_load;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.PictureBox user_imgPictureBox;
        private System.Windows.Forms.Button btnSair;
    }
}