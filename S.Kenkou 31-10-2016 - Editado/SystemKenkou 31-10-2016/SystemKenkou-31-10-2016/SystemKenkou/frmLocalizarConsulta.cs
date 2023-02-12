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
    public partial class frmLocalizarConsulta : Form
    {
        public frmLocalizarConsulta()
        {
            InitializeComponent();
        }

        private void consultaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            

        }

        private void frmLocalizarConsulta_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'clinicaDataSet.ViewConsultasHorarios' table. You can move, or remove it, as needed.
            this.viewConsultasHorariosTableAdapter.Fill(this.clinicaDataSet.ViewConsultasHorarios);
            this.CancelButton = btn_voltar;

        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            Variaveis_Globais.CodigoLocalizado = 0;
            this.Dispose();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            viewConsultasHorariosBindingSource.Filter = "nome_pac like '" + textBox1.Text + "%'";
        }

        private void consultaDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void viewConsultasHorariosDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Variaveis_Globais.CodigoLocalizado = int.Parse(viewConsultasHorariosDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString());

            }
            catch (Exception)
            {
                Variaveis_Globais.CodigoLocalizado = 0;

            }
            this.Dispose();
        }

        private void txt_situa_TextChanged(object sender, EventArgs e)
        {
            viewConsultasHorariosBindingSource.Filter = "situacao like '" + txt_situa.Text + "%'";
        }
    }
}
