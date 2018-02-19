using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SistemaLavaCarTCC2018.Models
{
    public class Caixa
    {
        public int idCaixa { get; set; }
        public float valorTotal { get; set; }
        public float desconto { get; set; }
        public float debito { get; set; }
        public float credito { get; set; }
        public float dinheiro { get; set; }
        public int idOrdem { get; set; }
        public OrdemServico ordem { get; set; }
    }
}