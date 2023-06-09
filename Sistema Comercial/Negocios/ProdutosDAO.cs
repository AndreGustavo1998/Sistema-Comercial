using Sistema_Comercial.Suporte;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using Sistema_Comercial.Mapeamento;

namespace Sistema_Comercial.Forms
{
    public class ProdutosDAO : Conexao
    {
        public List<Estoque> ListarTodas()
        {
            return conexao.Query<Estoque>("SELECT * FROM Produtos").ToList();
        }

        public void Adicionar( string tipo, string nome_produto, string quantidade, string valor)
        {
            conexao.Execute("INSERT INTO Produtos ( Tipo, Nome_Produto, Quantidade, Valor) VALUES ( @Tipo,@Nome_Produto, @Quantidade, @Valor)",
            new {  tipo ,nome_produto, quantidade, valor });
        }

        public void Atualizar(int id, string tipo, string nome_produto, string quantidade, string valor)
        {
            conexao.Execute("UPDATE Produtos SET Tipo=@Tipo , Nome_Produto=@Nome_Produto, Quantidade=@Quantidade, Valor=@Valor WHERE ID=@ID",
                new { tipo ,nome_produto, quantidade, valor, id });
        }

        public void Excluir(int id)
        {
            conexao.Execute("DELETE FROM Produtos WHERE ID=@ID",
               new { id });
        }
        public Estoque Buscar(int id)
        {
            return conexao.Query<Estoque>("SELECT * FROM Produtos WHERE ID=@ID",
                new { id }).SingleOrDefault();
        }
    }
}
