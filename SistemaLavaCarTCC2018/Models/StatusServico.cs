using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SistemaLavaCarTCC2018.Models
{
    public class StatusServico
    {
        public int idStatus { get; set; }
        public int idOrdem { get; set; }
        public int idServicoOrdem { get; set; }
        public ServicoOrdem servicoOrdem { get; set; }
        public int status { get; set; }
        public DateTime dataStatus { get; set; }

    }
}