using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SistemaLavaCarTCC2018.Models
{
    public class Contas
    {
        public int idConta { get; set; }
        public string nomeConta { get; set; }

        [DataType(DataType.Date)]
        public DateTime dataVencimento { get; set; }

        [DataType(DataType.Date)]
        public DateTime dataPagamento { get; set; }
        public int statusConta { get; set; }
        public int tipoConta { get; set; }


    }
}