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
    public partial class frmLocalizarSessao : Form
    {
        public frmLocalizarSessao()
        {
            InitializeComponent();
        }

        private void sessaoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.sessaoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.clinicaDataSet);

        }

        private void frmLocalizarSessao_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'clinicaDataSet.View_sessao_alta' table. You can move, or remove it, as needed.
            this.view_sessao_altaTableAdapter.Fill(this.clinicaDataSet.View_sessao_alta);
            // TODO: This line of code loads data into the 'clinicaDataSet.sessao' table. You can move, or remove it, as needed.

            this.CancelButton = btn_voltar;
        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            Variaveis_Globais.CodigoLocalizado = 0;
            this.Dispose();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
               
       

        private void sessaoDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Variaveis_Globais.CodigoLocalizado = int.Parse(view_sessao_altaDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString());

            }
            catch (Exception)
            {
                Variaveis_Globais.CodigoLocalizado = 0;

            }
            this.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                view_sessao_altaBindingSource.Filter = "data_sessao = " + textBox1.Text;
            }
            catch (Exception)
            {

                this.view_sessao_altaTableAdapter.Fill(this.clinicaDataSet.View_sessao_alta);
            }
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txt_pac_TextChanged(object sender, EventArgs e)
        {
            view_sessao_altaBindingSource.Filter = "nome_pac like '" + txt_pac.Text+ "%'";
        }
    }
}
