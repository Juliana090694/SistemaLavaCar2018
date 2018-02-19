using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SistemaLavaCarTCC2018.Models
{
    public class Configuracao
    {

        public int idConfiguracao { get; set; }
        public string nomeCampo { get; set; }
        public bool ativado { get; set; }
        public string descricao { get; set; }
        
    }
}