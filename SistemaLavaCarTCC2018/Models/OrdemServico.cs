using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SistemaLavaCarTCC2018.Models
{
    public class OrdemServico
    {
        public int idOrdem { get; set; }
        public int idCliente { get; set; }
        public Cliente cliente { get; set; }
        public int idUsuario { get; set; }
        public Usuario usuario { get; set; }

        public int idCarro { get; set; }
        public Carro carro { get; set; }

        public string descricaoAntes { get; set; }
        public string descricaoDepois { get; set; }
        public int status { get; set; }
        public float valorTotal { get; set; }

        [DataType(DataType.Date)]
        public DateTime dataRealizacao { get; set; }

    }
}