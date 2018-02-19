using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Web;

namespace SistemaLavaCarTCC2018.Models
{
    public class Cliente
    {
        public int idCliente { get; set; }
        public string nomeCliente { get; set; }

        [DataType(DataType.PhoneNumber)]
        public string telefone1 { get; set; }

        [DataType(DataType.PhoneNumber)]
        public string telefone2 { get; set; }

        [DataType(DataType.EmailAddress)]
        public string email { get; set; }
        public string cpf { get; set; }

        public bool statusCliente { get; set; }

        [DataType(DataType.Date)]
        public DateTime dataCadastro { get; set; }

        [DataType(DataType.Date)]
        public DateTime dataNascimento { get; set; }


    }
}