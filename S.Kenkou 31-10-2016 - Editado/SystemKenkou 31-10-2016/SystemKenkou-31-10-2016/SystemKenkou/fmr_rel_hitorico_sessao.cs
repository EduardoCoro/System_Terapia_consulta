using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SystemKenkou
{
    public partial class fmr_rel_hitorico_sessao : Form
    {
        public fmr_rel_hitorico_sessao()
        {
            InitializeComponent();
        }

        private void fmr_rel_hitorico_sessao_Load(object sender, EventArgs e)
        {
          
            // TODO: This line of code loads data into the 'ClinicaDataSet.View_sessao_alta' table. You can move, or remove it, as needed.
            this.view_sessao_altaTableAdapter.Fill(this.ClinicaDataSet.View_sessao_alta);
            this.sessaoTableAdapter.Fill(this.ClinicaDataSet.sessao);
            this.reportViewer1.RefreshReport();
        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            sessaoBindingSource.Filter = "data_sessao like '" + textBox1.Text + "%'";
        }
    }
}
