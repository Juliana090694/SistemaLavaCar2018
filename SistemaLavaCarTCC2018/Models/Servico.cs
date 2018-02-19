using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SistemaLavaCarTCC2018.Models
{
    public class Servico
    {
        public int idServico { get; set; }
        public string nome { get; set; }
        public string descricao { get; set; }
        public float valor { get; set; }
    }
}