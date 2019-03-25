using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Versa2._0.Models
{
    public class EnviarEmailContato
    {

        [Required(ErrorMessage = "O E-Mail é Obrigatório", AllowEmptyStrings = false)]
        [Display(Name = "E-Mail")]
        [EmailAddress(ErrorMessage = "E-Mail Inválido!!!")]
        public string Email { get; set; }


        [Required(ErrorMessage = "O Nome é Obrigatório", AllowEmptyStrings = false)]
        [Display(Name = "Nome")]
        public string Nome { get; set; }

        [Display(Name = "Celular")]
        public string Celular { get; set; }

        [Display(Name = "Adicionais")]
        public string Adicionais { get; set; }
    }
}