﻿using ProjetoLogin.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoLogin.Apresentacao
{
    public partial class CadastreSe : Form
    {
        public CadastreSe()
        {
            InitializeComponent();
        }

        private void BttnCadastrar_Click(object sender, EventArgs e)
        {
            Controle controle = new Controle();
            String mensagem = controle.cadastrar(TxtBox_login1.Text, TxtBox_Senha1.Text, TxtBox_ConfSenha1.Text);
            if (controle.tem)
            {
                MessageBox.Show(mensagem, "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else 
            {
                MessageBox.Show(controle.mensagem);
            }
        }

        private void TxtBox_login_TextChanged(object sender, EventArgs e)
        {

        }

        private void CadastrarBttn1_Click(object sender, EventArgs e)
        {
            Controle controle = new Controle();
            String mensagem = controle.cadastrar(TxtBox_login1.Text, TxtBox_Senha1.Text, TxtBox_ConfSenha1.Text);
            if (controle.tem)
            {
                MessageBox.Show(mensagem, "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(controle.mensagem);
            }
        }

        private void TxtBox_ConfSenha1_TextChanged(object sender, EventArgs e)
        {

        }

        private void BttnSair2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
