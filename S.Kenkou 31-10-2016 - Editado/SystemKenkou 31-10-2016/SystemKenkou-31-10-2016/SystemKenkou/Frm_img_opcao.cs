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
    public partial class Frm_img_opcao : Form
    {
        public Frm_img_opcao()
        {
            InitializeComponent();
        }

        private void usuáriosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.usuáriosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.clinicaDataSet);

        }

        private void Frm_img_opcao_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'clinicaDataSet.Usuários' table. You can move, or remove it, as needed.
            this.usuáriosTableAdapter.Fill(this.clinicaDataSet.Usuários);
            usuáriosBindingSource.Filter = "user_nome like '" + Variaveis_Globais.usuario + "'";
            this.CancelButton = btnSair;
            
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.usuáriosBindingSource.EndEdit();
                usuáriosTableAdapter.Update(clinicaDataSet.Usuários);             


                DataRowView atual = (DataRowView)usuáriosBindingSource.Current;                //carrega a foto na variavel
                Variaveis_Globais.foto = (byte[])atual["user_img"]; 

                //this.tableAdapterManager.UpdateAll(this.bANCODataSet);
                MessageBox.Show("Salvo com Sucesso!", "KenkouSystem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao salvar a imagem" + ex.Message, "KenkouSystem", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Btn_load_Click(object sender, EventArgs e)
        {
            try
            {

                openFileDialog1.ShowDialog();
                user_imgPictureBox.Image = Image.FromFile(openFileDialog1.FileName);

            }
            catch (Exception)
            {
                //user_imgPictureBox.Image = Image.FromFile(System.AppDomain.CurrentDomain.BaseDirectory + "usuario.png");
                
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            user_imgPictureBox.Image = Image.FromFile(System.AppDomain.CurrentDomain.BaseDirectory + "usuario.png");
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
    }
}
