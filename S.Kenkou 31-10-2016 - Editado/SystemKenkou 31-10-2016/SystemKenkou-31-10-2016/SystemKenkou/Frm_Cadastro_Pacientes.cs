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
    public partial class Frm_Cadastro_Pacientes : Form
    {
        public Frm_Cadastro_Pacientes()
        {
            InitializeComponent();
        }

        private void pacienteBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.pacienteBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.clinicaDataSet);

        }

        private void Frm_Cadastro_Pacientes_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'clinicaDataSet.cidade' table. You can move, or remove it, as needed.
            this.cidadeTableAdapter.Fill(this.clinicaDataSet.cidade);
            // TODO: This line of code loads data into the 'clinicaDataSet.paciente' table. You can move, or remove it, as needed.
            this.pacienteTableAdapter.Fill(this.clinicaDataSet.paciente);
            
        }



        private void bindingNavigator1_RefreshItems(object sender, EventArgs e)
        {

        }

        private void btnvoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bindingNavigatorAddNewItem_Click_1(object sender, EventArgs e)
        {
            groupBox1.Enabled = true;
            groupBox2.Enabled = true;
            pac_imgPictureBox.Image = Image.FromFile(System.AppDomain.CurrentDomain.BaseDirectory + "usuario.png");
        }

        private void clienteBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {

            try
            {
                this.Validate();
                this.pacienteBindingSource.EndEdit();
                pacienteTableAdapter.Update(clinicaDataSet.paciente);
                //this.tableAdapterManager.UpdateAll(this.bANCODataSet);
                MessageBox.Show("Registro Salvo", "KenkouSystem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                groupBox1.Enabled = false;
                groupBox2.Enabled = false;
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao salvar o registro" + ex.Message, "KenkouSystem", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void toolStripButton1_Click_2(object sender, EventArgs e)
        {
            pacienteBindingSource.CancelEdit();
            groupBox1.Enabled = false;
            groupBox2.Enabled = false;
        }

        private void toolStripButton2_Click_1(object sender, EventArgs e)
        {
            groupBox1.Enabled = true;
            groupBox2.Enabled = true;
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Confirma exclusão do registro atual", "KenkouSystem", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    pacienteBindingSource.RemoveCurrent();
                    pacienteTableAdapter.Update(clinicaDataSet);
                    groupBox1.Enabled = false;
                    groupBox2.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Registro não pode ser excluído " + ex.Message);
                this.pacienteTableAdapter.Fill(this.clinicaDataSet.paciente);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Frm_Cadastro_Cidade rel = new Frm_Cadastro_Cidade();
            rel.ShowDialog();
            this.cidadeTableAdapter.Fill(this.clinicaDataSet.cidade);
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cod_pacTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void btTratamento_Click(object sender, EventArgs e)
        {
            frmLocalizarPaciente loca = new frmLocalizarPaciente();
            loca.ShowDialog();
            if (Variaveis_Globais.CodigoLocalizado != 0)
            {
                pacienteBindingSource.Position = pacienteBindingSource.Find("cod_pac", Variaveis_Globais.CodigoLocalizado);
            }

        }

        private void btn_carregar_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialog1.ShowDialog();
                pac_imgPictureBox.Image = Image.FromFile(openFileDialog1.FileName);

                //user_imgPictureBox.Image = Image.FromFile(openFileDialog1.FileName);

            }
            catch (Exception)
            {
                /// user_imgPictureBox.Image = null;
                pac_imgPictureBox.Image = Image.FromFile(System.AppDomain.CurrentDomain.BaseDirectory + "usuario.png");
            }

        }

        private void btn_remov_Click(object sender, EventArgs e)
        {
            pac_imgPictureBox.Image = Image.FromFile(System.AppDomain.CurrentDomain.BaseDirectory + "usuario.png");
        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        

    }
}
