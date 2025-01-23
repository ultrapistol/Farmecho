using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ProjetoLogin.DAL
{
    public class Produto
    {
        private Produto() { }
        public Produto(int idProduto, string nomeProduto, float valor, int idGrupoProduto)
        {
            IdProduto = idProduto;
            NomeProduto = nomeProduto;
            Valor = valor;
            IdGrupoProduto = idGrupoProduto;
        }

        public int IdProduto { get; set; }
        public string NomeProduto { get; set; }
        public float Valor { get; set; }
        public int IdGrupoProduto { get; set; }
    }
    public class ProdutoDAOComandos
    {
        SqlConnection cn = new SqlConnection("@Data Source=DESKTOP-MT382KT\\MSSQLSERVER01Initial; Catalog=ProjetoLogin;Integrated Security=True;");
        SqlCommand cm = new SqlCommand();
        SqlDataReader dt;
    }
  

}
