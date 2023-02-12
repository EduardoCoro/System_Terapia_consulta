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
    public partial class Frm_Sessao : Form
    {
        public Frm_Sessao()
        {
            InitializeComponent();
        }

        private void Frm_Sessao_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'clinicaDataSet.tratamento' table. You can move, or remove it, as needed.
            this.tratamentoTableAdapter.Fill(this.clinicaDataSet.tratamento);
            
            // TODO: This line of code loads data into the 'clinicaDataSet.tipo_de_tratamento' table. You can move, or remove it, as needed.
            
            // TODO: This line of code loads data into the 'clinicaDataSet.sessao' table. You can move, or remove it, as needed.
            this.sessaoTableAdapter.Fill(this.clinicaDataSet.sessao);
            if (Variaveis_Globais.AbrirCadastro == true)
            {
                sessaoBindingSource.Position = sessaoBindingSource.Find("cod_sessao", Variaveis_Globais.CodigoLocalizado);
            }
        }


        private void sessaoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.sessaoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.clinicaDataSet);

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = true;
        }

        private void clienteBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.sessaoBindingSource.EndEdit();
                sessaoTableAdapter.Update(clinicaDataSet.sessao);
                //this.tableAdapterManager.UpdateAll(this.bANCODataSet);
                MessageBox.Show("Registro Salvo", "KenkouSystem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                groupBox1.Enabled = false;
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao salvar o registro" + ex.Message, "KenkouSystem", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            groupBox1.Enabled = false;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            sessaoBindingSource.CancelEdit();
            groupBox1.Enabled = false;
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
           groupBox1.Enabled = true;
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {            
            try
            {
                if (MessageBox.Show("confirma exclusão do registro atual", "KenkouSystem", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    sessaoBindingSource.RemoveCurrent();
                    sessaoTableAdapter.Update(clinicaDataSet);
                    groupBox1.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("registro não pode ser excluído " + ex.Message);
                this.sessaoTableAdapter.Fill(this.clinicaDataSet.sessao);
            }
        }

        

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btTratamento_Click(object sender, EventArgs e)
        {
            frmLocalizarSessao loca = new frmLocalizarSessao();
            loca.ShowDialog();
            if (Variaveis_Globais.CodigoLocalizado != 0)
            {
               sessaoBindingSource.Position = sessaoBindingSource.Find("cod_sessao", Variaveis_Globais.CodigoLocalizado);
            }
        }

        private void cod_sessaoTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
