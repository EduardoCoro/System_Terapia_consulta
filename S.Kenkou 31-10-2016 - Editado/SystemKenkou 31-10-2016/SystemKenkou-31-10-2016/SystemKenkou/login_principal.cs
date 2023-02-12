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
    public partial class login_principal : Form
    {
        public login_principal()
        {
            InitializeComponent();
        }

        private void login_principal_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'clinicaDataSet.Usuários' table. You can move, or remove it, as needed.
            this.usuáriosTableAdapter.Fill(this.clinicaDataSet.Usuários);
            // TODO: This line of code loads data into the 'clinicaDataSet.Usuários' table. You can move, or remove it, as needed.
            this.usuáriosTableAdapter.Fill(this.clinicaDataSet.Usuários);
            // TODO: This line of code loads data into the 'clinicaDataSet.Usuários' table. You can move, or remove it, as needed.
            this.usuáriosTableAdapter.Fill(this.clinicaDataSet.Usuários);
            this.AcceptButton = btnLogin;
            this.CancelButton = btnSair;
            tbSenha.Clear();
            tbUsuario.Clear();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                string senha = "";



                usuáriosBindingSource.Filter = "user_login like '" + tbUsuario.Text + "'";
                if (usuáriosBindingSource.Count == 1)
                {
                    DataRowView atual = (DataRowView)usuáriosBindingSource.Current;
                    senha = (atual["user_senha"].ToString());
                    Variaveis_Globais.nivel = (atual["user_nivel"].ToString());
                    Variaveis_Globais.usuario = atual["user_nome"].ToString();
                    Variaveis_Globais.foto = (byte[])atual["user_img"];
                   
                    
                   
                   

                    if (senha == tbSenha.Text)
                    {
                        
                        tbSenha.Clear();
                        tbUsuario.Clear();
                        //Frase antes de logar.
                        //MessageBox.Show("Logando...", "KenkouSystem - Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Hide();
                        TelaInicio menu = new TelaInicio();
                        menu.ShowDialog();
                        this.Show();
                        tbUsuario.Focus();

                        this.usuáriosTableAdapter.Fill(this.clinicaDataSet.Usuários);

                    }
                    else
                    {
                       MessageBox.Show("Usuário ou senha inválidos","KenkouSystem - Login",MessageBoxButtons.OK,MessageBoxIcon.Error);
                        tbSenha.Focus();

                    }
                }
                else
                {
                    MessageBox.Show("Login não encontrado", "KenkouSystem - Informa", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    
                }

            }
            catch (Exception Erro)
            {

                MessageBox.Show("Erro: " + Erro.Message, "KenkouSystem - Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

        private void usuáriosBindingNavigatorSaveItem_Click_2(object sender, EventArgs e)
        {
            this.Validate();
            this.usuáriosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.clinicaDataSet);

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
