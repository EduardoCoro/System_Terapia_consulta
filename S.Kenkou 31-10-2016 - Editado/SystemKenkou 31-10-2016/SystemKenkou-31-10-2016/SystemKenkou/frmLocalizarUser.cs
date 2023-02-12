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
    public partial class frmLocalizarUser : Form
    {
        public frmLocalizarUser()
        {
            InitializeComponent();
        }

        private void usuáriosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.usuáriosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.clinicaDataSet);

        }

        private void frmLocalizarUser_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'clinicaDataSet.Usuários' table. You can move, or remove it, as needed.
            this.usuáriosTableAdapter.Fill(this.clinicaDataSet.Usuários);
            this.CancelButton = btn_voltar;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            usuáriosBindingSource.Filter = "user_nome like '" + textBox1.Text + "%'";
        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            Variaveis_Globais.CodigoLocalizado = 0;
            this.Dispose();
        }

        private void usuáriosDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Variaveis_Globais.CodigoLocalizado = int.Parse(usuáriosDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString());

            }
            catch (Exception)
            {
                Variaveis_Globais.CodigoLocalizado = 0;

            }
            this.Dispose();
        }

        private void txt_nlv_TextChanged(object sender, EventArgs e)
        {
            usuáriosBindingSource.Filter = "user_nivel like '" + txt_nlv.Text + "%'";
        }
    }
}
