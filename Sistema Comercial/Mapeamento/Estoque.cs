using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Comercial.Mapeamento
{
    public class Estoque
    {
        public int ID { get; set; }
        public string Tipo { get; set; }
        public string Nome_Produto { get; set;}
        public string Quantidade { get; set; }
        public string Valor { get; set; }
    }
}
