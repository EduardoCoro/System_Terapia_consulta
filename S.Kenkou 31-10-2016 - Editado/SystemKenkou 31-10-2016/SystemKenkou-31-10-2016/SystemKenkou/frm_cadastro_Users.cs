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
    public partial class frm_cadastro_Users : Form
    {
        public frm_cadastro_Users()
        {
            InitializeComponent();
        }

        private void usuáriosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.usuáriosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.clinicaDataSet);

        }

        private void usuáriosBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.usuáriosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.clinicaDataSet);

        }

        private void frm_cadastro_Users_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'clinicaDataSet.Usuários' table. You can move, or remove it, as needed.
            this.usuáriosTableAdapter.Fill(this.clinicaDataSet.Usuários);
                       
        }

        private void btnvoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {

            usuáriosBindingSource.AddNew();
            
            
            groupBox1.Enabled = true;
            user_imgPictureBox.Image = Image.FromFile(System.AppDomain.CurrentDomain.BaseDirectory + "usuario.png");

                 

        }

        private void clienteBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.usuáriosBindingSource.EndEdit();
                usuáriosTableAdapter.Update(clinicaDataSet.Usuários);
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
            usuáriosBindingSource.CancelEdit();
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
                    usuáriosBindingSource.RemoveCurrent();
                    usuáriosTableAdapter.Update(clinicaDataSet);
                    groupBox1.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("registro não pode ser excluído " + ex.Message);
                this.usuáriosTableAdapter.Fill(this.clinicaDataSet.Usuários);
            }
        }

        private void btnimg_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialog1.ShowDialog();
                user_imgPictureBox.Image = Image.FromFile(openFileDialog1.FileName);

            }
            catch (Exception)
            {
                user_imgPictureBox.Image = null;

            }
         
        }

        private void button2_Click(object sender, EventArgs e)
        {
            user_imgPictureBox.Image = null;
        }

        

        private void btnimg_Click_1(object sender, EventArgs e)
        {
            try
            {
                openFileDialog1.ShowDialog();
                user_imgPictureBox.Image = Image.FromFile(openFileDialog1.FileName);

            }
            catch (Exception)
            {
                user_imgPictureBox.Image = null;

            }
         
        }      

        

        private void toolStripButton3_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btTratamento_Click(object sender, EventArgs e)
        {
            frmLocalizarUser loca = new frmLocalizarUser();
            loca.ShowDialog();           
            if (Variaveis_Globais.CodigoLocalizado != 0)
            {
                usuáriosBindingSource.Position = usuáriosBindingSource.Find("user_cod", Variaveis_Globais.CodigoLocalizado);
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            user_imgPictureBox.Image = Image.FromFile(System.AppDomain.CurrentDomain.BaseDirectory + "usuario.png");
        }
    }
        }
    
