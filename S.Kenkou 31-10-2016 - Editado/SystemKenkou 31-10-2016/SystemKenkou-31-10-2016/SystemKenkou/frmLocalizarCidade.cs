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
    public partial class frmLocalizarCidade : Form
    {
        public frmLocalizarCidade()
        {
            InitializeComponent();
        }

        private void cidadeBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.cidadeBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.clinicaDataSet);

        }

        private void frmLocalizarCidade_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'clinicaDataSet.cidade' table. You can move, or remove it, as needed.
            this.cidadeTableAdapter.Fill(this.clinicaDataSet.cidade);
            this.CancelButton = btn_voltar;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            cidadeBindingSource.Filter = "nome_cid like '" + textBox1.Text + "%'";

        }

        private void cidadeDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                Variaveis_Globais.CodigoLocalizado = int.Parse(cidadeDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString());

            }
            catch (Exception)
            {
                Variaveis_Globais.CodigoLocalizado = 0;
                
            }
            this.Dispose();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Variaveis_Globais.CodigoLocalizado = 0;
            this.Dispose();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            cidadeBindingSource.Filter = "UF_cid like '" + textBox2.Text + "%'";
        }

    }
}
