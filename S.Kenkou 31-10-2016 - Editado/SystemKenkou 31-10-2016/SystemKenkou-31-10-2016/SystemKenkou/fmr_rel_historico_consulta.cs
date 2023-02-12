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
    public partial class fmr_rel_historico_consulta : Form
    {
        public fmr_rel_historico_consulta()
        {
            InitializeComponent();
        }

        private void fmr_rel_historico_consulta_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ClinicaDataSet.paciente' table. You can move, or remove it, as needed.
            this.pacienteTableAdapter.Fill(this.ClinicaDataSet.paciente);
            // TODO: This line of code loads data into the 'ClinicaDataSet.consulta' table. You can move, or remove it, as needed.
            this.consultaTableAdapter.Fill(this.ClinicaDataSet.consulta);

            this.reportViewer1.RefreshReport();
        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void consultaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.consultaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.ClinicaDataSet);

        }
    }
}
