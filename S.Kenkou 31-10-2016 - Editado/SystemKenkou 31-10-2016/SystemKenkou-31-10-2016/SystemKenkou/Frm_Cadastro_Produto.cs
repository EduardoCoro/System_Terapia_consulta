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
    public partial class Frm_Cadastro_Produto : Form
    {
        public Frm_Cadastro_Produto()
        {
            InitializeComponent();
        }

        private void produtoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.produtoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.clinicaDataSet);

        }

        private void Frm_Cadastro_Produto_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'clinicaDataSet.produto' table. You can move, or remove it, as needed.
            this.produtoTableAdapter.Fill(this.clinicaDataSet.produto);
            
        }


        private void btnvoltar_Click(object sender, EventArgs e)
        {
            this.Close();
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
                this.produtoBindingSource.EndEdit();
                produtoTableAdapter.Update(clinicaDataSet.produto);
                //this.tableAdapterManager.UpdateAll(this.bANCODataSet);
                MessageBox.Show("Registro Salvo", "KenkouSystem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                groupBox1.Enabled = false;
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao salvar o registro" + ex.Message, "KenkouSystem", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            produtoBindingSource.CancelEdit();
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
                    produtoBindingSource.RemoveCurrent();
                    produtoTableAdapter.Update(clinicaDataSet);
                    groupBox1.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("registro não pode ser excluído " + ex.Message);
                this.produtoTableAdapter.Fill(this.clinicaDataSet.produto);
            }
        }

        private void cod_prodTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void nome_prodTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void prec_prodTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void desc_prodTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void qtd_prodTextBox_TextChanged(object sender, EventArgs e)
        {

        }

       

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btTratamento_Click(object sender, EventArgs e)
        {

            frmLocalizarProduto loca = new frmLocalizarProduto();
            loca.ShowDialog();
            if (Variaveis_Globais.CodigoLocalizado != 0)
            {
                produtoBindingSource.Position = produtoBindingSource.Find("cod_prod", Variaveis_Globais.CodigoLocalizado);
            }
        }

       
    }
}

