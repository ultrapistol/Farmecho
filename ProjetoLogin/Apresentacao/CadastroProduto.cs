using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ProjetoLogin.Apresentacao

{
    public partial class CadastroProduto : Form
    {
        public CadastroProduto()
        {
            InitializeComponent();
        }
        
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-MT382KT\MSSQLSERVER01;Initial Catalog=ProjetoLogin;Integrated Security=True;Encrypt=False");
        
        private void FormSubMenu2_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'projetoLoginDataSet1.GrupoProduto'. Você pode movê-la ou removê-la conforme necessário.
            this.grupoProdutoTableAdapter.Fill(this.projetoLoginDataSet1.GrupoProduto);
            // TODO: esta linha de código carrega dados na tabela 'projetoLoginDataSet.Produtos'. Você pode movê-la ou removê-la conforme necessário.
            this.produtosTableAdapter.Fill(this.projetoLoginDataSet.Produtos);
            this.ControlBox = false;
        }

        private void CadastrarProdBttn_Click(object sender, EventArgs e)
        {
             
            int IdGrupoProduto = 0;
            int Idproduto = int.Parse(IdProdTextBox.Text);
            string IdGrupoprodutoString = ProdCateComboBox.Text;
            string NomeProduto = NomeProdTextBox.Text;
            string ValorProdutoString = ValorProdTextBox.Text;
            decimal ValorProduto= decimal.Parse(ValorProdutoString);
            if (IdGrupoprodutoString == "Verdura") 
            {
                IdGrupoProduto = 1;
            } 
            else if (IdGrupoprodutoString == "Fruta")
            {
                IdGrupoProduto = 2;
            }
            else
            {
                IdGrupoProduto = 3;
            }


            try
            {
                con.Open();
                SqlCommand InsertOpen = new SqlCommand("SET IDENTITY_INSERT dbo.Produtos ON;");
                SqlCommand c = new SqlCommand("EXEC InsertProduto_SP '" + Idproduto + "','" + NomeProduto + "','" + ValorProduto + "','" + IdGrupoProduto + "'", con);
                c.ExecuteNonQuery();
                MessageBox.Show("Cadastrado com sucesso!");
                GetEmpList();
                con.Close();
            }
            catch (SqlException)
            {
                this.mensagem = "Erro de Banco de dados!";
            }

        }

        void GetEmpList()
        {
            SqlCommand c = new SqlCommand("EXEC ListProduto_SP", con);
            SqlDataAdapter sd = new SqlDataAdapter(c);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            ProdutoDataGridView.DataSource = dt;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void aloneTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void AtualizarProdBttn_Click(object sender, EventArgs e)
        {
            int IdGrupoProduto = 0;
            int Idproduto = int.Parse(IdProdTextBox.Text);
            string IdGrupoprodutoString = ProdCateComboBox.Text;
            string NomeProduto = NomeProdTextBox.Text;
            string ValorProdutoString = ValorProdTextBox.Text;
            decimal ValorProduto = decimal.Parse(ValorProdutoString);
            if (IdGrupoprodutoString == "Verdura")
            {
                IdGrupoProduto = 1;
            }
            else if (IdGrupoprodutoString == "Fruta")
            {
                IdGrupoProduto = 2;
            }
            else
            {
                IdGrupoProduto = 3;
            }



            con.Open();
            SqlCommand InsertOpen = new SqlCommand("SET IDENTITY_INSERT dbo.Produtos ON;");
            SqlCommand c = new SqlCommand("EXEC UpdateProduto_SP '" + Idproduto + "','" + NomeProduto + "','" + ValorProduto + "','" + IdGrupoProduto + "'", con);
            c.ExecuteNonQuery();
            MessageBox.Show("Atualizado com sucesso!");
            GetEmpList();
            con.Close();
        }

        private void ExcluirProdBttn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Você tem certeza que quer apagar este produto?", "Delet Document", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                int Idproduto = int.Parse(IdProdTextBox.Text);


                con.Open();
                SqlCommand InsertOpen = new SqlCommand("SET IDENTITY_INSERT dbo.Produtos ON;");
                SqlCommand c = new SqlCommand("EXEC DeleteProduto_SP '" + Idproduto + "'", con);
                c.ExecuteNonQuery();
                MessageBox.Show("Apagado com sucesso!");
                GetEmpList();
                con.Close();


            }
        }

        private void PesquisarProdBttn_Click(object sender, EventArgs e)
        {
            int Idproduto = int.Parse(IdProdTextBox.Text);


            SqlCommand InsertOpen = new SqlCommand("SET IDENTITY_INSERT dbo.Produtos ON;");
            SqlCommand c = new SqlCommand("EXEC LoadProduto_SP '" + Idproduto + "'", con);
            SqlDataAdapter sd = new SqlDataAdapter(c);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            ProdutoDataGridView.DataSource = dt;
        }
    }
}
