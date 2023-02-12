namespace SystemKenkou
{
    partial class fmr_rel_historico_venda
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ClinicaDataSet = new SystemKenkou.ClinicaDataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_voltar = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.view_produtos_vendidosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.view_produtos_vendidosTableAdapter = new SystemKenkou.ClinicaDataSetTableAdapters.View_produtos_vendidosTableAdapter();
            this.tableAdapterManager = new SystemKenkou.ClinicaDataSetTableAdapters.TableAdapterManager();
            this.vendaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vendaTableAdapter = new SystemKenkou.ClinicaDataSetTableAdapters.vendaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.ClinicaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.view_produtos_vendidosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.vendaBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "SystemKenkou.Rel_Historico_de_venda.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(13, 92);
            this.reportViewer1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(721, 254);
            this.reportViewer1.TabIndex = 0;
            // 
            // ClinicaDataSet
            // 
            this.ClinicaDataSet.DataSetName = "ClinicaDataSet";
            this.ClinicaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(288, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Nome do Produto";
            // 
            // btn_voltar
            // 
            this.btn_voltar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_voltar.Location = new System.Drawing.Point(463, 38);
            this.btn_voltar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_voltar.Name = "btn_voltar";
            this.btn_voltar.Size = new System.Drawing.Size(99, 42);
            this.btn_voltar.TabIndex = 10;
            this.btn_voltar.Text = "Voltar";
            this.btn_voltar.UseVisualStyleBackColor = true;
            this.btn_voltar.Click += new System.EventHandler(this.btn_voltar_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(261, 46);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(194, 26);
            this.textBox1.TabIndex = 9;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // view_produtos_vendidosBindingSource
            // 
            this.view_produtos_vendidosBindingSource.DataMember = "View_produtos_vendidos";
            this.view_produtos_vendidosBindingSource.DataSource = this.ClinicaDataSet;
            // 
            // view_produtos_vendidosTableAdapter
            // 
            this.view_produtos_vendidosTableAdapter.ClearBeforeFill = true;
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
            // vendaBindingSource
            // 
            this.vendaBindingSource.DataMember = "venda";
            this.vendaBindingSource.DataSource = this.ClinicaDataSet;
            // 
            // vendaTableAdapter
            // 
            this.vendaTableAdapter.ClearBeforeFill = true;
            // 
            // fmr_rel_historico_venda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SystemKenkou.Properties.Resources.Sem_título7;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(747, 360);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_voltar);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.reportViewer1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "fmr_rel_historico_venda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fmr_rel_historico_venda";
            this.Load += new System.EventHandler(this.fmr_rel_historico_venda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ClinicaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.view_produtos_vendidosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private ClinicaDataSet ClinicaDataSet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_voltar;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.BindingSource view_produtos_vendidosBindingSource;
        private ClinicaDataSetTableAdapters.View_produtos_vendidosTableAdapter view_produtos_vendidosTableAdapter;
        private ClinicaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource vendaBindingSource;
        private ClinicaDataSetTableAdapters.vendaTableAdapter vendaTableAdapter;
    }
}