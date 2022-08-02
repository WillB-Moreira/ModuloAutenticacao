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
    public partial class TelaCadUsuario : Form
    {
        public TelaCadUsuario()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void TelaCadUsuario_Load(object sender, EventArgs e)
        {
            txtId.Enabled = false;
            txtLogin.Enabled = false;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new TelaNivel().Show();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txtSobreNome_Leave(object sender, EventArgs e)
        {           
            txtLogin.Text = txtNome.Text;
            txtLogin.BackColor = Color.White;
            //Puxar o primeiro nome 
            string[] nome = txtNome.Text.Split(' ');
            //txtLogin.Text = nome[0];  //ESSE CODIGO MOSTRA O PRIMEIRO NOME 

            // puxar o sobre nome -- PUXA O ULTIMO NOME ! 

            string substring = "";

            string[] subs = txtSobreNome.Text.Split();
            foreach (string sub in subs)
            {
                // MessageBox.Show($"Substring: {sub}");
                substring = sub;
            }
            //===================
            txtLogin.Text = $"{nome[0].ToLower()}.{substring.ToLower()}";            
            
        }

        private void txtLogin_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSobreNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtConfSenha_Leave(object sender, EventArgs e)
        {
            if (txtConfSenha.Text.Equals(txtSenha.Text))
            {
                
               
            }
            else
            {
                MessageBox.Show("As Senhas não Confere");
                txtConfSenha.Clear();
                txtSenha.Clear();
                txtSenha.Focus();
            }
        }
    }
}
