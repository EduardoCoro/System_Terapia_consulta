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
    public partial class frmLocalizarMedico : Form
    {
        public frmLocalizarMedico()
        {
            InitializeComponent();
        }

        private void medicoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.medicoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.clinicaDataSet);

        }

        private void frmLocalizarMedico_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'clinicaDataSet.medico' table. You can move, or remove it, as needed.
            this.medicoTableAdapter.Fill(this.clinicaDataSet.medico);
            this.CancelButton = btn_voltar;
        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            Variaveis_Globais.CodigoLocalizado = 0;
            this.Dispose();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            medicoBindingSource.Filter = "nome_med like '" + textBox1.Text + "%'";
        }

        private void medicoDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Variaveis_Globais.CodigoLocalizado = int.Parse(medicoDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString());

            }
            catch (Exception)
            {
                Variaveis_Globais.CodigoLocalizado = 0;

            }
            this.Dispose();
        }

        private void medicoDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
