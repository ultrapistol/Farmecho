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
    public partial class FaturaIdTxtBox : Form
    {
        public FaturaIdTxtBox()
        {
            InitializeComponent();
        }

        private void ExcluirClienteBttn_Click(object sender, EventArgs e)
        {

        }

        private void FaturaIdTxtBox_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'projetoLoginDataSet.Produtos'. Você pode movê-la ou removê-la conforme necessário.
            this.produtosTableAdapter.Fill(this.projetoLoginDataSet.Produtos);

        }
    }
}
