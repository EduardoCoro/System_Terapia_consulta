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
    public partial class Frm_Cadastro_Tratamento_tipos : Form
    {
        public Frm_Cadastro_Tratamento_tipos()
        {
            InitializeComponent();
        }

        private void tipo_de_tratamentoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tipo_de_tratamentoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.clinicaDataSet);

        }

        private void Frm_Cadastro_Tratamento_tipos_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'clinicaDataSet.tipo_de_tratamento' table. You can move, or remove it, as needed.
            this.tipo_de_tratamentoTableAdapter.Fill(this.clinicaDataSet.tipo_de_tratamento);

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
                this.tipo_de_tratamentoBindingSource.EndEdit();
                tipo_de_tratamentoTableAdapter.Update(clinicaDataSet.tipo_de_tratamento);
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
            tipo_de_tratamentoBindingSource.CancelEdit();
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
                    tipo_de_tratamentoBindingSource.RemoveCurrent();
                    tipo_de_tratamentoTableAdapter.Update(clinicaDataSet);
                    groupBox1.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("registro não pode ser excluído " + ex.Message);
                this.tipo_de_tratamentoTableAdapter.Fill(this.clinicaDataSet.tipo_de_tratamento);
            }
        }

       

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btTratamento_Click(object sender, EventArgs e)
        {

            frmLocalizarTratamentocs loca = new frmLocalizarTratamentocs();
            loca.ShowDialog();
            if (Variaveis_Globais.CodigoLocalizado != 0)
            {
                tipo_de_tratamentoBindingSource.Position = tipo_de_tratamentoBindingSource.Find("cod_tptratamento", Variaveis_Globais.CodigoLocalizado);
            }
        }
    }
}
