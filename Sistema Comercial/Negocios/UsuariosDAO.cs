using Sistema_Comercial.Mapeamento;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sistema_Comercial.Suporte;
using Dapper;
namespace Sistema_Comercial.Negocios
{
    public class UsuariosDAO : Conexao
    {
        public Usuario Login(string login, string senha)
        {
            return conexao.Query<Usuario>(
           "SELECT * FROM Usuarios WHERE Login=@pLogin AND Senha=@pSenha",
            new
            {
                @pLogin = login,
                @pSenha = senha
            }).SingleOrDefault();
        }
     
       
        public List<Usuario> ListarTodas()
        {
            return conexao.Query<Usuario>("SELECT * FROM Usuarios order by Nome").ToList();
        }

    }
}



