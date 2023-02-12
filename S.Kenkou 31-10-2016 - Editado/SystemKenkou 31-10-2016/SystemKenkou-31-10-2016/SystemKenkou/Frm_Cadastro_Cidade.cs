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
    public partial class Frm_Cadastro_Cidade : Form
    {
        public Frm_Cadastro_Cidade()
        {
            InitializeComponent();
        }

        private void cidadeBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.cidadeBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.clinicaDataSet);

        }

        private void Frm_Cadastro_Cidade_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'clinicaDataSet.cidade' table. You can move, or remove it, as needed.
            this.cidadeTableAdapter.Fill(this.clinicaDataSet.cidade);
            
            
           
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = true;          
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("confirma exclusão do registro atual", "KenkouSystem", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cidadeBindingSource.RemoveCurrent();
                    cidadeTableAdapter.Update(clinicaDataSet);
                    groupBox1.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("registro não pode ser excluído " + ex.Message);
                this.cidadeTableAdapter.Fill(this.clinicaDataSet.cidade);
            }
        }

        private void clienteBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.cidadeBindingSource.EndEdit();
                cidadeTableAdapter.Update(clinicaDataSet.cidade);
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
            cidadeBindingSource.CancelEdit();
            groupBox1.Enabled = false;
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.cidadeBindingSource.EndEdit();
                cidadeTableAdapter.Update(clinicaDataSet.cidade);
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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void cidadeDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        

        private void btTratamento_Click(object sender, EventArgs e)
        {
            frmLocalizarCidade loca = new frmLocalizarCidade();
            loca.ShowDialog();            
            if (Variaveis_Globais.CodigoLocalizado != 0)
            {
                cidadeBindingSource.Position = cidadeBindingSource.Find("cod_cid", Variaveis_Globais.CodigoLocalizado);
            }

        }

        private void Frm_Cadastro_Cidade_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void bt_sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
