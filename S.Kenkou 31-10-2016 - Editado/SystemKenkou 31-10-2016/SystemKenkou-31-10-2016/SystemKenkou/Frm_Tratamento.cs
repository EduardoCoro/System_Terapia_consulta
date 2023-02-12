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
    public partial class Frm_Tratamento : Form
    {
        public Frm_Tratamento()
        {
            InitializeComponent();
        }

        private void tratamentoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tratamentoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.clinicaDataSet);

        }

        private void Frm_Tratamento_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'clinicaDataSet.sessao' table. You can move, or remove it, as needed.
            //this.sessaoTableAdapter.Fill(this.clinicaDataSet.sessao);
            this.tipo_de_tratamentoTableAdapter.Fill(this.clinicaDataSet.tipo_de_tratamento);
            // TODO: This line of code loads data into the 'clinicaDataSet.View_tratamento_tipos_tratamento' table. You can move, or remove it, as needed.            
            this.pacienteTableAdapter.Fill(this.clinicaDataSet.paciente);
            pacienteBindingSource.Filter = "cod_pac = " + Variaveis_Globais.CodigoLocalizado;
            // TODO: This line of code loads data into the 'clinicaDataSet.tratamento' table. You can move, or remove it, as needed.
            this.tratamentoTableAdapter.Fill(this.clinicaDataSet.tratamento);
            tratamentoBindingSource.Filter = "cod_consulta = " + Variaveis_Globais.codigoConsulta;
     

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = true;
            comboPacientes.SelectedValue = Variaveis_Globais.CodigoLocalizado;
            cod_consultaTextBox.Text = Variaveis_Globais.codigoConsulta.ToString();
            //btnAddTrat.Enabled = true;
            //btSalvarSessoes.Enabled = true;
        }

        private void clienteBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.tratamentoBindingSource.EndEdit();
                tratamentoTableAdapter.Update(clinicaDataSet.tratamento);
                //this.tableAdapterManager.UpdateAll(this.bANCODataSet);
                MessageBox.Show("Registro Salvo", "KenkouSystem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                groupBox1.Enabled = false;
                //btnAddTrat.Enabled = false;
                //btSalvarSessoes.Enabled = false;
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao salvar o registro" + ex.Message, "KenkouSystem", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            tratamentoBindingSource.CancelEdit();
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
                    tratamentoBindingSource.RemoveCurrent();
                    tratamentoTableAdapter.Update(clinicaDataSet);
                    groupBox1.Enabled = false;
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("registro não pode ser excluído " + ex.Message);
                this.tratamentoTableAdapter.Fill(this.clinicaDataSet.tratamento);
            }
        }


        private void BtSalvarItem_Click(object sender, EventArgs e)
        {
            
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddTrat_Click(object sender, EventArgs e)
        {

            try
            {
                tratamento_tipos_tratamentoTableAdapter.Inserir(int.Parse(cod_tratamentoTextBox.Text), int.Parse(comboTratamentos.SelectedValue.ToString()));
                
            }
            catch (Exception)
            {

                MessageBox.Show("Atenção, tratamento já incluido", "KenkouSystem", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            AtualizarGridTipoTratamentos();
        }

        private void view_tratamento_tipos_tratamentoDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                tratamento_tipos_tratamentoTableAdapter.Deletar(int.Parse(cod_tratamentoTextBox.Text), int.Parse(view_tratamento_tipos_tratamentoDataGridView.Rows[e.RowIndex].Cells[1].Value.ToString()));
            }
            catch (Exception)
            {
                
                
            }    
                
         
            AtualizarGridTipoTratamentos();
        }


        public void AtualizarGridTipoTratamentos()
        {
            view_tratamento_tipos_tratamentoTableAdapter.Fill(this.clinicaDataSet.View_tratamento_tipos_tratamento);
            view_tratamento_tipos_tratamentoBindingSource.Filter = "cod_tratamento = " + cod_tratamentoTextBox.Text;

        }

        public void AtualizarGridSessoes()
        {
            this.sessaoTableAdapter.Fill(this.clinicaDataSet.sessao);
            sessaoBindingSource.Filter = "cod_tratamento = " + cod_tratamentoTextBox.Text;
        }


        private void cod_tratamentoTextBox_TextChanged(object sender, EventArgs e)
        {
            if (cod_tratamentoTextBox.Text!="")
            {
                AtualizarGridTipoTratamentos();
                AtualizarGridSessoes();
            }
        }

        private void sessaoBindingSource_AddingNew(object sender, AddingNewEventArgs e)
        {
             
        }

        private void btSalvarSessoes_Click(object sender, EventArgs e)
        {
            try
            {
                sessaoTableAdapter.InserirSessao(null, DateTime.Parse(txtData.Value.ToShortDateString()), TimeSpan.Parse(txtHorario.Text), int.Parse(cod_tratamentoTextBox.Text),decimal.Parse(txtValorSessao.Text),null);
                txtData.Text = "";
                txtHorario.Text = "";
                txtValorSessao.Text = "";
                AtualizarGridSessoes();
                MessageBox.Show("Sessões Registradas", "KenkouSystem", MessageBoxButtons.OK, MessageBoxIcon.Information);    
            }
            catch (Exception ex)
            {
                MessageBox.Show("Atenção: " + ex.Message, "KenkouSystem", MessageBoxButtons.OK, MessageBoxIcon.Error);                
                
            }
        }

        private void sessaoDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                //sessaoTableAdapter.Deletar_sessao(int.Parse(txtValorSessao.Text),int.Parse(sessaoDataGridView.Rows[e.RowIndex].Cells[1].Value.ToString()));
                //tratamento_tipos_tratamentoTableAdapter.Deletar(int.Parse(cod_tratamentoTextBox.Text), int.Parse(view_tratamento_tipos_tratamentoDataGridView.Rows[e.RowIndex].Cells[1].Value.ToString()));
            }
            catch (Exception)
            {


            }
            AtualizarGridSessoes();
        }

        

       
      
    }
}
