﻿using ProjetoLogin.Apresentacao;
using ProjetoLogin.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoLogin
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void bttnCadastrar_Click(object sender, EventArgs e)
        {
            CadastreSe cad = new CadastreSe();
            cad.Show();
        }

        private void BttnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bttnEntrar_Click(object sender, EventArgs e)
        {
            Controle controle = new Controle();
            controle.acessar(TxtBoxLogin1.Text, TxtBoxSenha1.Text);
            if(controle.mensagem.Equals(""))
                if (controle.tem)
                {
                    MessageBox.Show("Logado com sucesso", "Entrando", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    TelaInicial iniciar = new TelaInicial();
                    iniciar.Show();
                }
                else
                {
                    MessageBox.Show("Erro de login encontrado", "Verifique email e senha", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            else
            {
                MessageBox.Show(controle.mensagem);
            }
        }

        private void lblLogin_Click(object sender, EventArgs e)
        {

        }

        private void bttnEntrar_Click_1(object sender, EventArgs e)
        {
            Controle controle = new Controle();
            controle.acessar(TxtBoxLogin1.Text, TxtBoxSenha1.Text);
            if (controle.mensagem.Equals(""))
                if (controle.tem)
                {
                    MessageBox.Show("Logado com sucesso", "Entrando", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    TelaInicial iniciar = new TelaInicial();
                    iniciar.Show();
                }
                else
                {
                    MessageBox.Show("Erro de login encontrado", "Verifique email e senha", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            else
            {
                MessageBox.Show(controle.mensagem);
            }
        }

        private void bttnCadastrar_Click_1(object sender, EventArgs e)
        {
            CadastreSe cad = new CadastreSe();
            cad.Show();
        }

        private void TxtBoxLogin1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
