using ModuloAuteticacao.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModuloAuteticacao.Desktop
{
    public partial class TelaAutenticacao : Form
    {
        public TelaAutenticacao()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            /*  Objeto é uma Instância da Classe 
             * ORIENTAÇÃO A  OBJETO  C#
             * 
             * QUATurmaTop Aluno1 = new QUATurmaTop();
             * **************************************************
             * 1-Coloque o Nome da Classe (QuaTurmaTop)
             * 2- Defina o Objeto (Aluno1)
             * 3-Sinal de "="
             * 4-Operador (new)
             * 5-Chamada ao Construtor (QuaTurmaTop(); )
             * **************************************************
             * 
             * 
             Aluno1.Nome = "Bruno";
             Aluno1.telefone = "61991181608";

            QuaTurmaTop Aluno2 = new QuaTurmaTop();
            Aluno2.Nome = "Carioca";
            Aluno2.Telefone = "2212156";

            */

            //Objeto de verdade 

             Usuario usuario = new Usuario();
            
            usuario.Login = txtLogin.Text;
            usuario.Senha = txtSenha.Text;
            if (usuario.Login.Equals(""))
            {
                MessageBox.Show("Digite o Login");
                txtLogin.Focus();
            }else if (usuario.Senha.Equals(""))
            {
                MessageBox.Show("Digite sua Senha");
                txtSenha.Focus();
            }
            else
            {
                MessageBox.Show($" Seja Bem Vindo {usuario.Login}!");
                TelaCadUsuario tcu = new TelaCadUsuario();
                tcu.Show();
            }
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
