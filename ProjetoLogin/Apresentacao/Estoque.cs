using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoLogin.Apresentacao
{
    public partial class Estoque : Form
    {
        public Estoque()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-MT382KT\MSSQLSERVER01;Initial Catalog=ProjetoLogin;Integrated Security=True;Encrypt=False");
        private void Estoque_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'projetoLoginDataSet21.Estoque'. Você pode movê-la ou removê-la conforme necessário.
            this.estoqueTableAdapter.Fill(this.projetoLoginDataSet21.Estoque);
            // TODO: esta linha de código carrega dados na tabela 'projetoLoginDataSet.Produtos'. Você pode movê-la ou removê-la conforme necessário.
            this.produtosTableAdapter.Fill(this.projetoLoginDataSet.Produtos);

        }

        private void CadastrarClienteBttn_Click(object sender, EventArgs e)
        {
            
            int IdProdEstoque = int.Parse(EstoqueIdTxtbox.Text);
            string DescProdEstoque = CaracteristicasTextBox.Text;
            DateTime Plantacao = DateTime.Now;//Creio que o erro esteja aqui

            string Colheita = ColheitaDateTime.Value.ToString();//Creio que o erro esteja aqui
            int QuantidadeProd = (int)QuantidadeNumeric.Value;//Creio que o erro esteja aqui
            string Produto = ProdutoEstoqueComboBox.Text;

            con.Open();
            SqlCommand InsertOpen = new SqlCommand("SET IDENTITY_INSERT dbo.Estoque ON;");
            SqlCommand c = new SqlCommand("EXEC InsertEstoque_SP '" + IdProdEstoque + "','" + DescProdEstoque + "','" + Plantacao + "','" + Colheita + "','" + QuantidadeProd + "','" + Produto + "'", con);
            c.ExecuteNonQuery();
            MessageBox.Show("Cadastrado com sucesso!");
            
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.produtosTableAdapter.FillBy(this.projetoLoginDataSet.Produtos);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void SalvarClienteBttn_Click(object sender, EventArgs e)
        {
            int IdProdEstoque = int.Parse(EstoqueIdTxtbox.Text);
            string DescProdEstoque = CaracteristicasTextBox.Text;
            DateTime Plantacao = DateTime.Now;//Creio que o erro esteja aqui
            string Colheita = ColheitaDateTime.Value.ToString();//Creio que o erro esteja aqui
            int QuantidadeProd = (int)QuantidadeNumeric.Value;//Creio que o erro esteja aqui
            string Produto = ProdutoEstoqueComboBox.Text;

            con.Open();
            SqlCommand InsertOpen = new SqlCommand("SET IDENTITY_INSERT dbo.Estoque ON;");
            SqlCommand c = new SqlCommand("EXEC UpdateEstoque_SP '" + IdProdEstoque + "','" + DescProdEstoque + "','" + Plantacao + "','" + Colheita + "','" + QuantidadeProd + "','" + Produto + "'", con);
            c.ExecuteNonQuery();
            MessageBox.Show("Atualizado com sucesso!");
           
        }

        private void ExcluirEstoqueBttn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Você tem certeza que quer apagar este cliente?", "Delet Document", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                int IdProdEstoque = int.Parse(EstoqueIdTxtbox.Text);
                con.Open();
                SqlCommand InsertOpen = new SqlCommand("SET IDENTITY_INSERT dbo.Estoque ON;");
                SqlCommand c = new SqlCommand("EXEC DeleteEstoque_SP '" + IdProdEstoque + "'", con);
                c.ExecuteNonQuery();
                MessageBox.Show("Apagado com sucesso!");          
                con.Close();
            }
        }

        private void PesquisarEstoqueBttn_Click(object sender, EventArgs e)
        {
            int IdProdEstoque = int.Parse(EstoqueIdTxtbox.Text);


            SqlCommand InsertOpen = new SqlCommand("SET IDENTITY_INSERT dbo.Estoque ON;");
            SqlCommand c = new SqlCommand("EXEC LoadEstoque_SP '" + IdProdEstoque + "'", con);
            SqlDataAdapter sd = new SqlDataAdapter(c);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            EstoquedataGridView.DataSource = dt;
        }
    }
    
}
