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
    public partial class fmr_rel_estoque : Form
    {
        public fmr_rel_estoque()
        {
            InitializeComponent();
        }

        private void fmr_rel_estoque_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ClinicaDataSet.View_produtos_vendidos' table. You can move, or remove it, as needed.
            this.view_produtos_vendidosTableAdapter.Fill(this.ClinicaDataSet.View_produtos_vendidos);
           
           

            this.reportViewer1.RefreshReport();
        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           // produtoBindingSource.Filter = "nome_prod like '" + textBox1.Text + "%'";
        }

        private void produtoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.produtoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.ClinicaDataSet);

        }
    }
}
