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
    public partial class frmLocalizarProduto : Form
    {
        public frmLocalizarProduto()
        {
            InitializeComponent();
        }

        private void produtoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.produtoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.clinicaDataSet);

        }

        private void frmLocalizarProduto_Load(object sender, EventArgs e)
        {
            
            // TODO: This line of code loads data into the 'clinicaDataSet.produto' table. You can move, or remove it, as needed.
            this.produtoTableAdapter.Fill(this.clinicaDataSet.produto);
            this.CancelButton = btn_voltar;
        }

        private void produtoDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Variaveis_Globais.CodigoLocalizado = int.Parse(produtoDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString());

            }
            catch (Exception)
            {
                Variaveis_Globais.CodigoLocalizado = 0;

            }
            this.Dispose();
        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            Variaveis_Globais.CodigoLocalizado = 0;
            this.Dispose();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            produtoBindingSource.Filter = "nome_prod like '" + textBox1.Text + "%'";
        }
    }
}
