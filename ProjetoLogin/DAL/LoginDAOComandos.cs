using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoLogin.DAL
{
    internal class LoginDAOComandos
    {
        public bool tem = false;
        public String mensagem = "";
        SqlCommand cmd = new SqlCommand(); 
        Conexao con = new Conexao();
        SqlDataReader dr;
        public bool verificarLogin(String login, String senha)
        {
            //comandos SQL para verificar se tem no banco de dados

            cmd.CommandText = "select * from logins where email = @login and senha = @senha";
            cmd.Parameters.AddWithValue("@login", login);
            cmd.Parameters.AddWithValue("@senha", senha);

            try
            {
                cmd.Connection = con.conectar();
                dr = cmd.ExecuteReader();
                if (dr.HasRows)//Se foi encontrado, envia para DAL
                {
                    tem = true;
                }
                con.desconectar();
                dr.Close();
            }
            catch (SqlException)//Se capturado o erro
            {
                this.mensagem = "Erro com Banco de Dados!";
            }

            return tem;
        }

        public String cadastrar(String email, String senha, String confSenha)
        {
            //comandos para inserir no banco
            tem = false;
            if (senha.Equals(confSenha))
            {
                cmd.CommandText = "INSERT INTO logins VALUES (@e,@s);";
                cmd.Parameters.AddWithValue("@e", email);
                cmd.Parameters.AddWithValue("@s", senha);

                try
                {
                    cmd.Connection = con.conectar();
                    cmd.ExecuteNonQuery();
                    con.desconectar();
                    this.mensagem = "Cadastrado com sucesso!";
                    tem = true;
                }

                catch (SqlException)
                {
                    this.mensagem = "Erro de Banco de dados!";
                }

            }
            else
            {
                this.mensagem = "Senhas não correspondem!";
            }
            return mensagem;
        }

    }
}
