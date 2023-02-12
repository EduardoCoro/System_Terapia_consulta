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
    public partial class fmr_rel_sessao_alta : Form
    {
        public fmr_rel_sessao_alta()
        {
            InitializeComponent();
        }

        private void fmr_rel_sessao_alta_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'clinicaDataSet.View_sessao_alta' table. You can move, or remove it, as needed.
            this.view_sessao_altaTableAdapter.Fill(this.clinicaDataSet.View_sessao_alta);

            this.reportViewer1.RefreshReport();
           
        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }
    }
}
