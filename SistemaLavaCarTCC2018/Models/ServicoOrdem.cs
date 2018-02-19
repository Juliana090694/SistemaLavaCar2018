using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SistemaLavaCarTCC2018.Models
{
    public class ServicoOrdem
    {
        public int idServicoOrdem { get; set; }
        public int idServico { get; set; }
        public Servico servico { get; set; }
        public int idOrdem { get; set; }
        public OrdemServico ordem { get; set; }
        public DateTime horarioInicio { get; set; }
        public DateTime horarioConclusao { get; set; }
        public int status { get; set; }
    }
}