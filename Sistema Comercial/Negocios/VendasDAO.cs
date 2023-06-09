using Dapper;
using Sistema_Comercial.Mapeamento;
using Sistema_Comercial.Suporte;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Comercial.Negocios
{
    public class VendasDAO : Conexao
    {
        public List<Vendas> Listar()
        {
            return conexao.Query<Vendas>("SELECT * FROM Vendas ").ToList();
        }
        public void Adicionar( string nome_produto, string qtd_vendidos, string valor_total)
        {
            conexao.Execute("INSERT INTO Vendas (  Nome_Produto, Qtd_Vendidos, Valor_Total) VALUES ( @Nome_Produto, @Qtd_Vendidos, @Valor_Total)",
            new { nome_produto, qtd_vendidos, valor_total });
        }
    }
}
