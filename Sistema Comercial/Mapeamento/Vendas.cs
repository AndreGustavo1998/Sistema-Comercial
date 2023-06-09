using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Comercial.Mapeamento
{
    public class Vendas
    {
        public int ID { get; set; }
        
        public string Nome_Produto { get; set; }
        public string Qtd_Vendidos { get; set; }
        public string Valor_Total { get; set; }
    }
}
