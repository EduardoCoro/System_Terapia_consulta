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
    public partial class frmLocalizarPaciente : Form
    {
        public frmLocalizarPaciente()
        {
            InitializeComponent();
        }

        private void pacienteBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.pacienteBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.clinicaDataSet);

        }

        private void frmLocalizarPaciente_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'clinicaDataSet.paciente' table. You can move, or remove it, as needed.
            this.pacienteTableAdapter.Fill(this.clinicaDataSet.paciente);
            this.CancelButton = btn_voltar;
        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            Variaveis_Globais.CodigoLocalizado = 0;
            this.Dispose();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            pacienteBindingSource.Filter = "nome_pac like '" + textBox1.Text + "%'";
        }

        private void pacienteDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Variaveis_Globais.CodigoLocalizado = int.Parse(pacienteDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString());

            }
            catch (Exception)
            {
                Variaveis_Globais.CodigoLocalizado = 0;

            }
            this.Dispose();
        }

        private void pacienteDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
