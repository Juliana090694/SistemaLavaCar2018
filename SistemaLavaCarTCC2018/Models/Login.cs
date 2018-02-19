using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SistemaLavaCarTCC2018.Models
{
    public class Login
    {

        public string login { get; set; }

        [DataType(DataType.Password)]
        public string senha { get; set; }
    }
}