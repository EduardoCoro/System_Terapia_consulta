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
    public partial class Frm_consultas : Form
    {
        public Frm_consultas()
        {
            InitializeComponent();
        }

        private void consultaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.consultaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.clinicaDataSet);

        }

        private void Frm_consultas_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'clinicaDataSet.consulta' table. You can move, or remove it, as needed.
            this.consultaTableAdapter.Fill(this.clinicaDataSet.consulta);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                consultaBindingSource.Filter = "CLI_NOME LIKE '" + txt_name.Text + "%'";
            }
            catch (Exception)
            {

               consultaBindingSource.RemoveFilter();
            }
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            try
            {
                consultaBindingSource.Filter = "CLI_COD = " + txt_num.Text;
            }
            catch (Exception)
            {

                consultaBindingSource.RemoveFilter();
            }
        }


        private void btnvoltar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void consultaDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
