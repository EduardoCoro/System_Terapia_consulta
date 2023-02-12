using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
namespace SystemKenkou
{
    public partial class TelaInicio : Form
    {
        public TelaInicio()
        {
            InitializeComponent();
        }

        private void TelaInicio_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'clinicaDataSet.View_Retornos' table. You can move, or remove it, as needed.
            this.view_RetornosTableAdapter.Fill(this.clinicaDataSet.View_Retornos);
            // TODO: This line of code loads data into the 'clinicaDataSet.View_sessoeshorario' table. You can move, or remove it, as needed.
            
            
            // TODO: This line of code loads data into the 'clinicaDataSet.ViewConsultasHorarios' table. You can move, or remove it, as needed.
            
            MessageBox.Show("Bem Vindo: " + Variaveis_Globais.nivel +" "+ Variaveis_Globais.usuario, "KenkouSystem - Informa", MessageBoxButtons.OK, MessageBoxIcon.Information);
            notifyIcon1.Visible = true;
            notifyIcon1.ShowBalloonTip(100);
            
            lbl_user.Text = "Nome: "+ Variaveis_Globais.usuario;            
            lbl_nivel.Text = "Nível: " + Variaveis_Globais.nivel;
           
            CarregarImagem_e_MenuUsuario();    
           

            
        }
        public void CarregarImagem_e_MenuUsuario()
        {
            picture_foto_login.BackgroundImage = null;
            string strfn = Convert.ToString(DateTime.Now.ToFileTime());
            FileStream fs = new FileStream(strfn, FileMode.CreateNew, FileAccess.Write);
            
           fs.Write(Variaveis_Globais.foto, 0, Variaveis_Globais.foto.Length);

            fs.Flush();

            fs.Close();

            picture_foto_login.BackgroundImage = Image.FromFile(strfn);

            if (Variaveis_Globais.nivel == "Comum")
            {
                usuáriosToolStripMenuItem.Enabled = false;
                cadastrosToolStripMenuItem.Enabled = false;
                movimentaçãoToolStripMenuItem.Enabled = false;
                tratamentoToolStripMenuItem.Enabled = false;
                consultaToolStripMenuItem.Enabled = false;
                sessãoToolStripMenuItem.Enabled = false;
            }
            else if (Variaveis_Globais.nivel == "Funcionário")
            {

                usuáriosToolStripMenuItem.Enabled = false;
                
            }
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

       

       
        private void cadastrosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void pacientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Cadastro_Pacientes pac = new Frm_Cadastro_Pacientes();
            pac.ShowDialog();
        }

        private void médicoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Cadastro_Medico medic = new Frm_Cadastro_Medico();
            medic.ShowDialog();
        }

        private void produtoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Cadastro_Produto product = new Frm_Cadastro_Produto();
            product.ShowDialog();
        }

        private void tiposTratamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Cadastro_Tratamento_tipos tratar = new Frm_Cadastro_Tratamento_tipos();
            tratar.ShowDialog();
        }

        private void vendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Mov_Venda venda = new Frm_Mov_Venda();
            venda.ShowDialog();
        }

       

        private void tratamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Tratamento tratar = new Frm_Tratamento();
            tratar.ShowDialog();
        }
               

        
        
      
        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripContainer2_TopToolStripPanel_Click(object sender, EventArgs e)
        {

        }

        private void cidadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Cadastro_Cidade rel = new Frm_Cadastro_Cidade();
            rel.ShowDialog();
        }

        

        private void usuáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_cadastro_Users user = new frm_cadastro_Users();
            user.ShowDialog();

        }

        private void usuáriosToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Frm_img_opcao ph = new Frm_img_opcao();
            ph.ShowDialog();
            CarregarImagem_e_MenuUsuario();
        }

        private void sessãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Sessao tratar = new Frm_Sessao();
            tratar.ShowDialog();
        }

        private void consultaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_cadastro_consulta tratar = new Frm_cadastro_consulta();
            tratar.ShowDialog();
        }

        private void esconderToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        

        private void logoutToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void sairToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Show();
        }

        private void esconderToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void históricoDeConsultaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fmr_rel_historico_consulta frm = new fmr_rel_historico_consulta();
            frm.ShowDialog();

        }

        private void históricoDeVendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fmr_rel_historico_venda frm = new fmr_rel_historico_venda();
            frm.ShowDialog();
        }

        private void históricoDeSessãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fmr_rel_hitorico_sessao frm = new fmr_rel_hitorico_sessao();
            frm.ShowDialog();
        }

        private void produtosEmEstoqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
           fmr_rel_estoque frm = new fmr_rel_estoque();
            frm.ShowDialog();
        
        }

        private void produtosVendidosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fmr_rel_produtos_vendidos frm = new fmr_rel_produtos_vendidos();
            frm.ShowDialog();
        
        }

        private void sessãoEmAltaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fmr_rel_sessao_alta frm = new fmr_rel_sessao_alta();
            frm.ShowDialog();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            //carregar consultas em espera
            this.viewConsultasHorariosTableAdapter.Fill(this.clinicaDataSet.ViewConsultasHorarios);
            viewConsultasHorariosBindingSource.Filter = "situacao like 'Espera'";
            if (viewConsultasHorariosBindingSource.Count==0)
            {
                viewConsultasHorariosDataGridView.Visible = false;
            }
            else
            {
                viewConsultasHorariosDataGridView.Visible = true;
            }

            //carregar RETORNOS
            this.view_RetornosTableAdapter.Fill(this.clinicaDataSet.View_Retornos);
            
    view_RetornosBindingSource.Filter = "retor_consult >= '" +DateTime.Now.ToShortDateString() + "'";
            if (view_RetornosBindingSource.Count == 0)
            {
                view_RetornosDataGridView.Visible = false;
            }
            else
            {
                view_RetornosDataGridView.Visible = true;
            }







            //carregar sessoes abertas
            this.view_sessoeshorarioTableAdapter.Fill(this.clinicaDataSet.View_sessoeshorario);
            view_sessoeshorarioBindingSource.Filter = "data_ence_sessao is null";
            if (view_sessoeshorarioBindingSource.Count==0)
            {
                view_sessoeshorarioDataGridView.Visible = false;
            }
            else
            {
                view_sessoeshorarioDataGridView.Visible = true;
            }


        }

        private void viewConsultasHorariosDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Variaveis_Globais.CodigoLocalizado = int.Parse(viewConsultasHorariosDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString());
                Variaveis_Globais.AbrirCadastro = true;
                Frm_cadastro_consulta japa = new Frm_cadastro_consulta();
                japa.ShowDialog();
                Variaveis_Globais.AbrirCadastro = false;
                Variaveis_Globais.CodigoLocalizado = 0;
               
            }
            catch (Exception)
            {
                Variaveis_Globais.CodigoLocalizado = 0;

            }    
       



        }

        private void button2_Click(object sender, EventArgs e)
        {
            Frm_img_opcao ph = new Frm_img_opcao();
            ph.ShowDialog();
            CarregarImagem_e_MenuUsuario();
        }

        private void view_sessoeshorarioDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Variaveis_Globais.CodigoLocalizado = int.Parse(view_sessoeshorarioDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString());
                Variaveis_Globais.AbrirCadastro = true;
                Frm_Sessao japa = new Frm_Sessao();
                japa.ShowDialog();
                Variaveis_Globais.AbrirCadastro = false;
                Variaveis_Globais.CodigoLocalizado = 0;
            }
            catch (Exception)
            {
                Variaveis_Globais.CodigoLocalizado = 0;
            }    
        }

        private void view_RetornosDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Variaveis_Globais.CodigoLocalizado = int.Parse(view_RetornosDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString());
                Variaveis_Globais.AbrirCadastro = true;
                Frm_cadastro_consulta japa = new Frm_cadastro_consulta();
                japa.ShowDialog();
                Variaveis_Globais.AbrirCadastro = false;
                Variaveis_Globais.CodigoLocalizado = 0;

            }
            catch (Exception)
            {
                Variaveis_Globais.CodigoLocalizado = 0;

            }    
        }

      

       
        
    }
}
