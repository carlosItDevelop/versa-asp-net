using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Versa2._0.Funcoes.Validators;

namespace Versa2._0.Models
{
    public class EnviarEmail
    {
        public CotasAVenda cotasVenda { get; set; }

        [Required(ErrorMessage = "O E-Mail é Obrigatório", AllowEmptyStrings = false)]
        [Display(Name = "E-Mail")]
        [EmailAddress(ErrorMessage = "E-Mail Inválido!!!")]
        public string Email { get; set; }

        public string To { get; set; }
        public string Adicionais { get; set; }
        public string Body { get; set; }

        [Required(ErrorMessage = "O Nome é Obrigatório", AllowEmptyStrings = false)]
        [Display(Name = "Nome")]
        public string Nome { get; set; }


        public string Telefone { get; set; }

        [Required(ErrorMessage = "O Número do Celular é Obrigatório", AllowEmptyStrings = false)]
        [Display(Name = "Celular")]
        public string Celular { get; set; }

        [Display(Name = "Administradora")]
        [Required(ErrorMessage = "A Administradora é Obrigatória", AllowEmptyStrings = false)]
        public string Administradora { get; set; }
        public string TipoConsorcio { get; set; }
        public string Grupo { get; set; }
        public string Cota { get; set; }
        public string Contemplado { get; set; }

        [Display(Name = "Parcelas")]
        //[Range(1, 500, ErrorMessage = "O Nº de Parcelas deve estar entre 1 e 500")]
        public string TotalParcelas { get; set; }
        public string ParcelasPagas { get; set; }
        public string ParcelasEmAtraso { get; set; }

        [DataType(DataType.Currency)]
        [Display(Name = "Valor do Crédito")]
        public string ValorDoBem { get; set; }

        [DisplayFormat(ApplyFormatInEditMode = false, DataFormatString = "{0:c}")]
        [Display(Name = "Valor 1º Parcela")]
        public string ValorDaParcela { get; set; }

        public string SaldoDevedor { get; set; }

        [DisplayFormat(ApplyFormatInEditMode = false, DataFormatString = "{0:c}")]
        [Display(Name = "Crédito")]
        public decimal Credito { get; set; }


        [DisplayFormat(ApplyFormatInEditMode = false, DataFormatString = "{0:c}")]
        [Display(Name = "Entrada")]
        public decimal Entrada { get; set; }


        //[MinimumFileSizeValidator(0.5)]
        [MaximumFileSizeValidator(2.4)]
        [Display(Name = "Anexo")]
        [ValidFileTypeValidator("pdf","doc","docx","jpg","png","bmp")]

        public HttpPostedFileBase Attachment { get; set; }


    }
}