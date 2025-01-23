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
    public partial class CadClient : Form
    {
        public CadClient()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-MT382KT\MSSQLSERVER01;Initial Catalog=ProjetoLogin;Integrated Security=True;Encrypt=False");

        private void CadastrarClienteBttn_Click(object sender, EventArgs e)
        {
            int IdCliente = int.Parse(IdClienteTextBox.Text);
            string NomeCliente = NomeClienteTextBox.Text,
                CNPJCliente = CNPJClienteTextBox.Text,
                EnderecoCliente = EndClienteTextBox.Text,
                EmailCliente = EmailClienteTextBox.Text,
                TelefoneCliente = TelefoneClienteTextbox.Text;

            con.Open();
            SqlCommand InsertOpen = new SqlCommand("SET IDENTITY_INSERT dbo.Clientes ON;");
            SqlCommand c = new SqlCommand("EXEC InsertCliente_SP '" + IdCliente + "','" + NomeCliente + "','" + CNPJCliente + "','" + EnderecoCliente + "','" + EmailCliente + "','" + TelefoneCliente + "'", con);
            c.ExecuteNonQuery();
            MessageBox.Show("Cadastrado com sucesso!");
            GetEmpList();
        }

        void GetEmpList()
        {
            SqlCommand c = new SqlCommand("EXEC ListCliente_SP", con);
            SqlDataAdapter sd = new SqlDataAdapter(c);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            ClienteDataGridView.DataSource = dt;
        }

        private void CadClient_Load(object sender, EventArgs e)
        {
            GetEmpList();
        }

        private void SalvarClienteBttn_Click(object sender, EventArgs e)
        {
            int IdCliente = int.Parse(IdClienteTextBox.Text);
            string NomeCliente = NomeClienteTextBox.Text,
                CNPJCliente = CNPJClienteTextBox.Text,
                EnderecoCliente = EndClienteTextBox.Text,
                EmailCliente = EmailClienteTextBox.Text,
                TelefoneCliente = TelefoneClienteTextbox.Text;

            con.Open();
            SqlCommand InsertOpen = new SqlCommand("SET IDENTITY_INSERT dbo.Clientes ON;");
            SqlCommand c = new SqlCommand("EXEC UpdateCliente_SP '" + IdCliente + "','" + NomeCliente + "','" + CNPJCliente + "','" + EnderecoCliente + "','" + EmailCliente + "','" + TelefoneCliente + "'", con);
            c.ExecuteNonQuery();
            MessageBox.Show("Atualizado com sucesso!");
            GetEmpList();
        }

        private void ExcluirClienteBttn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Você tem certeza que quer apagar este cliente?", "Delet Document", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                int IdCliente = int.Parse(IdClienteTextBox.Text);
                con.Open();
                SqlCommand InsertOpen = new SqlCommand("SET IDENTITY_INSERT dbo.Clientes ON;");
                SqlCommand c = new SqlCommand("EXEC DeleteCliente_SP '" + IdCliente + "'", con);
                c.ExecuteNonQuery();
                MessageBox.Show("Apagado com sucesso!");
                GetEmpList();
                con.Close();
            }
        }

        private void PesquisarClienteBttn_Click(object sender, EventArgs e)
        {
            int IdCliente = int.Parse(IdClienteTextBox.Text);
            SqlCommand InsertOpen = new SqlCommand("SET IDENTITY_INSERT dbo.Clientes ON;");
            SqlCommand c = new SqlCommand("EXEC LoadCliente_SP '" + IdCliente + "'", con);
            SqlDataAdapter sd = new SqlDataAdapter(c);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            ClienteDataGridView.DataSource = dt;
        }
    }
}
