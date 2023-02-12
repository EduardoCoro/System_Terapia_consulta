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
    public partial class Frm_Cadastro_Medico : Form
    {
        public Frm_Cadastro_Medico()
        {
            InitializeComponent();
        }

        private void medicoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.medicoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.clinicaDataSet);

        }

        private void Frm_Cadastro_Medico_Load(object sender, EventArgs e)
        {
            this.medicoTableAdapter.Fill(this.clinicaDataSet.medico);
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
                this.medicoBindingSource.EndEdit();
                medicoTableAdapter.Update(clinicaDataSet.medico);
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
            medicoBindingSource.CancelEdit();
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
                    medicoBindingSource.RemoveCurrent();
                    medicoTableAdapter.Update(clinicaDataSet);
                    groupBox1.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("registro não pode ser excluído " + ex.Message);
                this.medicoTableAdapter.Fill(this.clinicaDataSet.medico);
            }
        }


        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btTratamento_Click(object sender, EventArgs e)
        {
            frmLocalizarMedico loca = new frmLocalizarMedico();
            loca.ShowDialog();     
            if (Variaveis_Globais.CodigoLocalizado != 0)
            {
                medicoBindingSource.Position = medicoBindingSource.Find("cod_med", Variaveis_Globais.CodigoLocalizado);
            }
        }
    }
}
