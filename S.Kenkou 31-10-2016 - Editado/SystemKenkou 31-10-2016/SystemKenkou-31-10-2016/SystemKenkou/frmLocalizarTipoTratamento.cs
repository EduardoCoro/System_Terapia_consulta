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
    public partial class frmLocalizarTratamentocs : Form
    {
        public frmLocalizarTratamentocs()
        {
            InitializeComponent();
        }

        private void tratamentoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tratamentoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.clinicaDataSet);

        }

        private void frmLocalizarTratamentocs_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'clinicaDataSet.tipo_de_tratamento' table. You can move, or remove it, as needed.
            this.tipo_de_tratamentoTableAdapter.Fill(this.clinicaDataSet.tipo_de_tratamento);
            // TODO: This line of code loads data into the 'clinicaDataSet.tratamento' table. You can move, or remove it, as needed.
            this.tratamentoTableAdapter.Fill(this.clinicaDataSet.tratamento);
            this.CancelButton = btn_voltar;
        }

        private void tratamentoDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Variaveis_Globais.CodigoLocalizado = int.Parse(tipo_de_tratamentoDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString());

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
           tipo_de_tratamentoBindingSource.Filter = "nome_tptratamento like '" + textBox1.Text + "%'";
        }

        private void tipo_de_tratamentoDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Variaveis_Globais.CodigoLocalizado = int.Parse(tipo_de_tratamentoDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString());

            }
            catch (Exception)
            {
                Variaveis_Globais.CodigoLocalizado = 0;

            }
            this.Dispose();
        }
    }
}
