namespace SystemKenkou
{
    partial class fmr_rel_historico_consulta
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.consultaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ClinicaDataSet = new SystemKenkou.ClinicaDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_voltar = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.consultaTableAdapter = new SystemKenkou.ClinicaDataSetTableAdapters.consultaTableAdapter();
            this.tableAdapterManager = new SystemKenkou.ClinicaDataSetTableAdapters.TableAdapterManager();
            this.pacienteTableAdapter = new SystemKenkou.ClinicaDataSetTableAdapters.pacienteTableAdapter();
            this.pacienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.consultaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClinicaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacienteBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // consultaBindingSource
            // 
            this.consultaBindingSource.DataMember = "consulta";
            this.consultaBindingSource.DataSource = this.ClinicaDataSet;
            // 
            // ClinicaDataSet
            // 
            this.ClinicaDataSet.DataSetName = "ClinicaDataSet";
            this.ClinicaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.consultaBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "SystemKenkou.Rel_historico_consulta.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(13, 89);
            this.reportViewer1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(805, 331);
            this.reportViewer1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(325, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Nome do Paciente";
            // 
            // btn_voltar
            // 
            this.btn_voltar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_voltar.Location = new System.Drawing.Point(500, 37);
            this.btn_voltar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_voltar.Name = "btn_voltar";
            this.btn_voltar.Size = new System.Drawing.Size(99, 42);
            this.btn_voltar.TabIndex = 7;
            this.btn_voltar.Text = "Voltar";
            this.btn_voltar.UseVisualStyleBackColor = true;
            this.btn_voltar.Click += new System.EventHandler(this.btn_voltar_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(298, 45);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(194, 26);
            this.textBox1.TabIndex = 6;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
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
            // pacienteTableAdapter
            // 
            this.pacienteTableAdapter.ClearBeforeFill = true;
            // 
            // pacienteBindingSource
            // 
            this.pacienteBindingSource.DataMember = "paciente";
            this.pacienteBindingSource.DataSource = this.ClinicaDataSet;
            // 
            // fmr_rel_historico_consulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SystemKenkou.Properties.Resources.Sem_título7;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(831, 436);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_voltar);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.reportViewer1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "fmr_rel_historico_consulta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fmr_rel_historico_consulta";
            this.Load += new System.EventHandler(this.fmr_rel_historico_consulta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.consultaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClinicaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacienteBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private ClinicaDataSet ClinicaDataSet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_voltar;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.BindingSource consultaBindingSource;
        private ClinicaDataSetTableAdapters.consultaTableAdapter consultaTableAdapter;
        private ClinicaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private ClinicaDataSetTableAdapters.pacienteTableAdapter pacienteTableAdapter;
        private System.Windows.Forms.BindingSource pacienteBindingSource;
    }
}