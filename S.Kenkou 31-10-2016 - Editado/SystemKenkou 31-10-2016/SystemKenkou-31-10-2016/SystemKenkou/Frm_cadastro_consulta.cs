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
    public partial class Frm_cadastro_consulta : Form
    {
        public Frm_cadastro_consulta()
        {
            InitializeComponent();
        }

        private void consultaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.consultaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.clinicaDataSet);

        }

        private void Frm_cadastro_consulta_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'clinicaDataSet.medico' table. You can move, or remove it, as needed.
            this.medicoTableAdapter.Fill(this.clinicaDataSet.medico);
            // TODO: This line of code loads data into the 'clinicaDataSet.paciente' table. You can move, or remove it, as needed.
            this.pacienteTableAdapter.Fill(this.clinicaDataSet.paciente);
            // TODO: This line of code loads data into the 'clinicaDataSet.conta_receber' table. You can move, or remove it, as needed.
            this.conta_receberTableAdapter.Fill(this.clinicaDataSet.conta_receber);
            // TODO: This line of code loads data into the 'clinicaDataSet.consulta' table. You can move, or remove it, as needed.
            this.consultaTableAdapter.Fill(this.clinicaDataSet.consulta);
            if (Variaveis_Globais.AbrirCadastro==true)
            {
                consultaBindingSource.Position = consultaBindingSource.Find("cod_consult", Variaveis_Globais.CodigoLocalizado);
            }


        }

        private void clienteBindingNavigator_RefreshItems(object sender, EventArgs e)
        {

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
                this.consultaBindingSource.EndEdit();
                consultaTableAdapter.Update(clinicaDataSet.consulta);
                //this.tableAdapterManager.UpdateAll(this.bANCODataSet);
                MessageBox.Show("Registro Salvo", "KenkouSystem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                //if (situacaoComboBox.Text=="Finalizada" && retor_consultMaskedTextBox.Text=="")
                //{
                    

                //}
                groupBox1.Enabled = false;
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao salvar o registro" + ex.Message, "KenkouSystem", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            consultaBindingSource.CancelEdit();
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
                    consultaBindingSource.RemoveCurrent();
                    consultaTableAdapter.Update(clinicaDataSet);
                    groupBox1.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("registro não pode ser excluído " + ex.Message);
                this.consultaTableAdapter.Fill(this.clinicaDataSet.consulta);
            }
        }


        private void btTratamento_Click(object sender, EventArgs e)
        {

            try
            {
                Variaveis_Globais.CodigoLocalizado = int.Parse(comboPaciente.SelectedValue.ToString());
                Variaveis_Globais.codigoConsulta = int.Parse(cod_consultTextBox.Text);
                Frm_Tratamento tratamento = new Frm_Tratamento();
                tratamento.ShowDialog();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Atenção: " + ex.Message, "KenkouSystem", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void anot_consultTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            frmLocalizarConsulta loca = new frmLocalizarConsulta();
            loca.ShowDialog();
            if (Variaveis_Globais.CodigoLocalizado != 0)
            {
                consultaBindingSource.Position = consultaBindingSource.Find("cod_consult", Variaveis_Globais.CodigoLocalizado);
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmLocalizarPaciente pac = new frmLocalizarPaciente();
            pac.ShowDialog();
            if (Variaveis_Globais.CodigoLocalizado !=0)
            {
                comboPaciente.SelectedValue = Variaveis_Globais.CodigoLocalizado;
            }


        }

        private void cod_consultTextBox_TextChanged(object sender, EventArgs e)
        {
 
        }

        private void consultaBindingSource_CurrentChanged(object sender, EventArgs e)
        {
           //if (situacaoComboBox.Text == "Finalizada" && retor_consultMaskedTextBox.Text!="" )
           // {
           //     clienteBindingNavigatorSaveItem.Enabled = false;
           //     bindingNavigatorDeleteItem.Enabled = false;
           //     toolStripButton2.Enabled = false;

           // }
           // else
           // {
           //     clienteBindingNavigatorSaveItem.Enabled = true;
           //     bindingNavigatorDeleteItem.Enabled = true;
           //     toolStripButton2.Enabled = true;
           // }
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            conta_receberTableAdapter.inserir_conta(DateTime.Now, DateTime.Now, Decimal.Parse(con_valorTextBox.Text), Decimal.Parse(con_valorTextBox.Text), int.Parse(cod_consultTextBox.Text), null, null);



            MessageBox.Show("Pagamento registrado", "KenkouSystem", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

       



        
    }
}
