namespace SystemKenkou
{
    partial class frmLocalizarConsulta
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLocalizarConsulta));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.viewConsultasHorariosDataGridView = new System.Windows.Forms.DataGridView();
            this.viewConsultasHorariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clinicaDataSet = new SystemKenkou.ClinicaDataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_voltar = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.viewConsultasHorariosTableAdapter = new SystemKenkou.ClinicaDataSetTableAdapters.ViewConsultasHorariosTableAdapter();
            this.tableAdapterManager = new SystemKenkou.ClinicaDataSetTableAdapters.TableAdapterManager();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_situa = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.viewConsultasHorariosDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewConsultasHorariosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clinicaDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.groupBox1.Controls.Add(this.txt_situa);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.viewConsultasHorariosDataGridView);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btn_voltar);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Window;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(818, 447);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Localizar Consulta";
            // 
            // viewConsultasHorariosDataGridView
            // 
            this.viewConsultasHorariosDataGridView.AllowUserToAddRows = false;
            this.viewConsultasHorariosDataGridView.AllowUserToDeleteRows = false;
            this.viewConsultasHorariosDataGridView.AutoGenerateColumns = false;
            this.viewConsultasHorariosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.viewConsultasHorariosDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10});
            this.viewConsultasHorariosDataGridView.DataSource = this.viewConsultasHorariosBindingSource;
            this.viewConsultasHorariosDataGridView.Location = new System.Drawing.Point(6, 92);
            this.viewConsultasHorariosDataGridView.Name = "viewConsultasHorariosDataGridView";
            this.viewConsultasHorariosDataGridView.ReadOnly = true;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.viewConsultasHorariosDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.viewConsultasHorariosDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.viewConsultasHorariosDataGridView.Size = new System.Drawing.Size(806, 349);
            this.viewConsultasHorariosDataGridView.TabIndex = 8;
            this.viewConsultasHorariosDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.viewConsultasHorariosDataGridView_CellDoubleClick);
            // 
            // viewConsultasHorariosBindingSource
            // 
            this.viewConsultasHorariosBindingSource.DataMember = "ViewConsultasHorarios";
            this.viewConsultasHorariosBindingSource.DataSource = this.clinicaDataSet;
            // 
            // clinicaDataSet
            // 
            this.clinicaDataSet.DataSetName = "ClinicaDataSet";
            this.clinicaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(153, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Nome do Paciente";
            // 
            // btn_voltar
            // 
            this.btn_voltar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_voltar.Location = new System.Drawing.Point(715, 25);
            this.btn_voltar.Name = "btn_voltar";
            this.btn_voltar.Size = new System.Drawing.Size(82, 38);
            this.btn_voltar.TabIndex = 7;
            this.btn_voltar.Text = "Voltar";
            this.btn_voltar.UseVisualStyleBackColor = true;
            this.btn_voltar.Click += new System.EventHandler(this.btn_voltar_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(150, 48);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(144, 26);
            this.textBox1.TabIndex = 6;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // viewConsultasHorariosTableAdapter
            // 
            this.viewConsultasHorariosTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.cidadeTableAdapter = null;
            this.tableAdapterManager.Connection = null;
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
            this.tableAdapterManager.vendaTableAdapter = null;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "cod_consult";
            this.dataGridViewTextBoxColumn11.HeaderText = "Cod. Consulta";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "cod_pac";
            this.dataGridViewTextBoxColumn1.HeaderText = "cod_pac";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "nome_pac";
            this.dataGridViewTextBoxColumn2.HeaderText = "Paciente";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "tel_pac";
            this.dataGridViewTextBoxColumn3.HeaderText = "Telefone";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "cel_pac";
            this.dataGridViewTextBoxColumn4.HeaderText = "Celular";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "data_consult";
            this.dataGridViewTextBoxColumn5.HeaderText = "Data da consulta";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "hr_consult";
            this.dataGridViewTextBoxColumn6.HeaderText = "Horário da consulta";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "situacao";
            this.dataGridViewTextBoxColumn7.HeaderText = "Situação";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "retor_consult";
            this.dataGridViewTextBoxColumn8.HeaderText = "Dia do retorno";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "horario_retorno";
            this.dataGridViewTextBoxColumn9.HeaderText = "Horário do retorno";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "nome_med";
            this.dataGridViewTextBoxColumn10.HeaderText = "Médico";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(419, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Situação";
            // 
            // txt_situa
            // 
            this.txt_situa.Location = new System.Drawing.Point(403, 48);
            this.txt_situa.Name = "txt_situa";
            this.txt_situa.Size = new System.Drawing.Size(130, 26);
            this.txt_situa.TabIndex = 10;
            this.txt_situa.TextChanged += new System.EventHandler(this.txt_situa_TextChanged);
            // 
            // frmLocalizarConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SystemKenkou.Properties.Resources.Sem_título7;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(842, 471);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmLocalizarConsulta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmLocalizarConsulta";
            this.Load += new System.EventHandler(this.frmLocalizarConsulta_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.viewConsultasHorariosDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewConsultasHorariosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clinicaDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_voltar;
        private System.Windows.Forms.TextBox textBox1;
        private ClinicaDataSet clinicaDataSet;
        private System.Windows.Forms.BindingSource viewConsultasHorariosBindingSource;
        private ClinicaDataSetTableAdapters.ViewConsultasHorariosTableAdapter viewConsultasHorariosTableAdapter;
        private ClinicaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView viewConsultasHorariosDataGridView;
        private System.Windows.Forms.TextBox txt_situa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
    }
}