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
    public partial class Frm_Mov_Venda : Form
    {
        public Frm_Mov_Venda()
        {
            InitializeComponent();
        }

        private void vendaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.vendaBindingSource.EndEdit();
                vendaTableAdapter.Update(clinicaDataSet.venda);
                
                //this.tableAdapterManager.UpdateAll(this.bANCODataSet);
                MessageBox.Show("Registro Salvo", "KenkouSystem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                grp_venda.Enabled = false;
               
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao salvar o registro" + ex.Message, "KenkouSystem", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
            
        }

        private void Frm_Venda_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'clinicaDataSet.produto' table. You can move, or remove it, as needed.
            this.produtoTableAdapter.Fill(this.clinicaDataSet.produto);
            // TODO: This line of code loads data into the 'clinicaDataSet.View_itens_Venda' table. You can move, or remove it, as needed.
            this.view_itens_VendaTableAdapter.Fill(this.clinicaDataSet.View_itens_Venda);
            // TODO: This line of code loads data into the 'clinicaDataSet.itens_venda' table. You can move, or remove it, as needed.
            this.itens_vendaTableAdapter.Fill(this.clinicaDataSet.itens_venda);
            // TODO: This line of code loads data into the 'clinicaDataSet.paciente' table. You can move, or remove it, as needed.
            this.pacienteTableAdapter.Fill(this.clinicaDataSet.paciente);
            // TODO: This line of code loads data into the 'clinicaDataSet.venda' table. You can move, or remove it, as needed.
            this.vendaTableAdapter.Fill(this.clinicaDataSet.venda);
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            grp_venda.Enabled = true;
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("confirma exclusão do registro atual", "KenkouSystem", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    vendaBindingSource.RemoveCurrent();
                    vendaTableAdapter.Update(clinicaDataSet);
                    grp_venda.Enabled = false;
                    //groupBox1.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("registro não pode ser excluído " + ex.Message);
                this.vendaTableAdapter.Fill(this.clinicaDataSet.venda);
            }
        }

        private void edit_tool_Click(object sender, EventArgs e)
        {
            grp_venda.Enabled = true;
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            vendaBindingSource.CancelEdit();
            grp_venda.Enabled = false;
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Cb_Produto_Click(object sender, EventArgs e)
        {
            
        }

        private void Cb_Produto_CursorChanged(object sender, EventArgs e)
        {

        }

        private void Cb_Produto_SelectedValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {


            try
            {
                frmLocalizarProduto loca = new frmLocalizarProduto();
                loca.ShowDialog();
                if (Variaveis_Globais.CodigoLocalizado != 0)
                {
                    produtoBindingSource.Position = produtoBindingSource.Find("cod_prod", Variaveis_Globais.CodigoLocalizado);
                   
                    DataRowView produto = (DataRowView)produtoBindingSource.Current;
                    txtCodPRod.Text = produto["cod_prod"].ToString();
                    txtDescPRod.Text=   produto["nome_prod"].ToString();
                    txt_Valor.Text = produto["prec_prod"].ToString();
                    txtQtd.Focus();


                }


            }
            catch (Exception)
            {
                
                
            }
           

        }

        private void txtQtd_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Enter)
            {
                txt_Valor.Focus();
            }
        }

        private void txt_Valor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                itens_vendaTableAdapter.Inserir_Item(int.Parse(cod_vendaTextBox.Text), int.Parse(txtCodPRod.Text), decimal.Parse(txtQtd.Text), decimal.Parse(txt_Valor.Text));
                txtCodPRod.Clear();
                    txtDescPRod.Clear();

                    txtQtd.Clear();
                    txt_Valor.Clear();
                Atualizar_GRID();

            }
        }

        public void Atualizar_GRID()
        {
            view_itens_VendaBindingSource.Filter = "cod_venda = " + cod_vendaTextBox.Text;

        }

        private void txt_Valor_TextChanged(object sender, EventArgs e)
        {

        }

        private void cod_vendaTextBox_TextChanged(object sender, EventArgs e)
        {
            if (cod_vendaTextBox.Text!="")
            {
                Atualizar_GRID();
            }
        }


    }
}
