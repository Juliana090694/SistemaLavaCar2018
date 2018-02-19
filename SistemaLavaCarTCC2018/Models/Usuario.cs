using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SistemaLavaCarTCC2018.Models
{
    public class Usuario
    {
        public int idUsuario { get; set; }
        public string nomeUsuario { get; set; }

        [DataType(DataType.PhoneNumber)]
        public string telefone1 { get; set; }

        [DataType(DataType.PhoneNumber)]
        public string telefone2 { get; set; }

        [DataType(DataType.EmailAddress)]
        public string email { get; set; }
        public string cpf { get; set; }
        [DataType(DataType.Date)]
        public DateTime dataCadastro { get; set; }
        public bool statusUsuario { get; set; }

        [DataType(DataType.Date)]
        public DateTime dataNascimento { get; set; }

        public string endereco { get; set; }

        public string loginUsuario { get; set; }

        [DataType(DataType.Password)]
        public string senhaUsuario { get; set; }

        public int nivelAcesso { get; set; }


    }
}