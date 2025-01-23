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
    public partial class TelaInicial : Form
    {

        FormDashboard dashboard;
        CadastroProduto sub2;
        FormRelatorios relatorios;
        CadClient cadClient;
        Estoque estoque;
        FaturaIdTxtBox vendas;



        public TelaInicial()
        {
            InitializeComponent();
            mdiProp();
        }


        private void TelaInicial_Load(object sender, EventArgs e)
        {

        }


       
        bool menuExpand = false;
        private void mdiProp()
        {
            this.SetBevel(false);
            Controls.OfType<MdiClient>().FirstOrDefault().BackColor = Color.FromArgb(232, 234, 237);
        }
        private void menuTrasition_Tick(object sender, EventArgs e)
        {
            if (menuExpand == false)
            {
                containerCadastro.Height += 10;
                if (containerCadastro.Height >= 190)
                {

                    menuTrasition.Stop();
                    menuExpand = true;
                }
            }
            else
            { 
                containerCadastro.Height -= 10;
                if(containerCadastro.Height <= 65)
                {
                    menuTrasition.Stop();
                    menuExpand = false;
                }
                    
            }
        }

        private void bttn_Cadastro_Click_1(object sender, EventArgs e)
        {
            menuTrasition.Start();

            
        }


        bool sidebarExpand = true;
        private void sidebarTransition_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand) 
            {
            sidebar.Width -= 10;
                if(sidebar.Width <= 61)
                {
                    sidebarExpand = false;
                    sidebarTransition.Stop();

                    pnlDashboard.Width = sidebar.Width;
                    pnlPlaceholder.Width = sidebar.Width;
                    pnlRelatorios.Width = sidebar.Width;
                    containerCadastro.Width = sidebar.Width;
                }
            }
            else 
            {
                sidebar.Width += 10;
                if (sidebar.Width >= 214)
                    {
                    sidebarExpand = true;
                    sidebarTransition.Stop();

                    pnlDashboard.Width = sidebar.Width;
                    pnlPlaceholder.Width = sidebar.Width;
                    pnlRelatorios.Width = sidebar.Width;
                    containerCadastro.Width = sidebar.Width;

                }
            }
        }

        private void bttnOpenMenu_Click(object sender, EventArgs e)
        {
            sidebarTransition.Start();
        }

        private void Bttn_Dashboard_Click(object sender, EventArgs e)
        {
            if(dashboard == null)
            {
                dashboard = new FormDashboard();
                dashboard.FormClosed += Dashboard_FormClosed;
                dashboard.MdiParent = this;
                dashboard.Dock = DockStyle.Fill;
                dashboard.Show();
                sidebarTransition.Start();
            }
            else
            {
                dashboard.Activate();
                sidebarTransition.Start();
            }
        }

        private void Dashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            dashboard = null;
        }

        private void bttnCadastroProduto_Click(object sender, EventArgs e)
        {
            if (sub2 == null)
            {
                sub2 = new CadastroProduto();
                sub2.FormClosed += sub2_FormClosed;
                sub2.MdiParent = this;
                sub2.Dock = DockStyle.Fill;
                sub2.Show();
                sidebarTransition.Start();
                menuTrasition.Start();
            }
            else
            {
                sub2.Activate();
                sidebarTransition.Start();
                menuTrasition.Start();
            }
        }

        private void sub2_FormClosed(object sender, FormClosedEventArgs e)
        {
               sub2 = null;
        }


        private void BttnRelatorios_Click(object sender, EventArgs e)
        {
            if (relatorios == null)
            {
                relatorios = new FormRelatorios();
                relatorios.FormClosed += Dashboard_FormClosed;
                relatorios.MdiParent = this;
                relatorios.Dock = DockStyle.Fill;
                relatorios.Show();
                sidebarTransition.Start();
               
            }
            else
            {
                relatorios.Activate();
                sidebarTransition.Start();
                
            }
        }
        private void relatorios_FormClosed(object sender, FormClosedEventArgs e)
        {
            relatorios = null;
        }

        private void bttnCadastroCliente_Click(object sender, EventArgs e)
        {
            if (cadClient == null)
            {
                cadClient = new CadClient();
                cadClient.FormClosed += Dashboard_FormClosed;
                cadClient.MdiParent = this;
                cadClient.Dock = DockStyle.Fill;
                cadClient.Show();
                sidebarTransition.Start();
                menuTrasition.Start();
            }
            else
            {
                cadClient.Activate();
                sidebarTransition.Start();
                menuTrasition.Start();
            }
        }
        private void cadClient_FormClosed(object sender, FormClosedEventArgs e)
        {
            cadClient = null;
        }

        private void bttnPlaceholder_Click(object sender, EventArgs e)
        {
            if (estoque == null)
            {
                estoque = new Estoque();
                estoque.FormClosed += Dashboard_FormClosed;
                estoque.MdiParent = this;
                estoque.Dock = DockStyle.Fill;
                estoque.Show();
                sidebarTransition.Start();

            }
            else
            {
                estoque.Activate();
                sidebarTransition.Start();
            }


        }
        private void estoque_FormClosed(object sender, FormClosedEventArgs e)
        {
            estoque = null;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (vendas == null)
            {
                vendas = new FaturaIdTxtBox();
                vendas.FormClosed += Dashboard_FormClosed;
                vendas.MdiParent = this;
                vendas.Dock = DockStyle.Fill;
                vendas.Show();
                sidebarTransition.Start();

            }
            else
            {
                vendas.Activate();
                sidebarTransition.Start();
            }

        }
        private void vendas_FormClosed(object sender, FormClosedEventArgs e)
        {
            vendas = null;
        }
    }
    
}
