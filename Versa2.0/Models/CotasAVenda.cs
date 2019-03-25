using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Versa2._0.Models
{
    [Serializable()]
    public class CotasAVenda
    {

        public CotasAVenda()
        {
            Id = Guid.NewGuid();
        }

        [Key]
        public Guid Id { get; set; }

        [DisplayFormat(ApplyFormatInEditMode = false, DataFormatString = "{0:c}")]
        [Display(Name = "Crédito")]
        public decimal Credito { get; set; }

        [DisplayFormat(ApplyFormatInEditMode = false, DataFormatString = "{0:c}")]
        [Display(Name = "Valor 1º Parcela")]
        public decimal Parcela { get; set; }

        [DisplayFormat(ApplyFormatInEditMode = false, DataFormatString = "{0:c}")]
        [Display(Name = "Demais Parcelas")]
        public decimal DemaisParcelas { get; set; }

        [DisplayFormat(ApplyFormatInEditMode = false, DataFormatString = "{0:c}")]
        [Display(Name = "I.N.C.C.")]
        public string INCC { get; set; }


        [Display(Name = "Parcelas")]
        [Range(1, 500, ErrorMessage = "O Nº de Parcelas deve estar entre 1 e 500")]
        public int NumParcela { get; set; }


        [DataType(DataType.Currency)]
        [Display(Name = "Entrada")]
        public decimal Valor { get; set; }


        [Required(ErrorMessage = "O Tipo da Cota é Obrigatório", AllowEmptyStrings = false)]
        [Range(1, 2, ErrorMessage = "O Tipo da Cota é Obrigatório")]
        [Display(Name = "Tipo da Cota")]
        public string TipoCota { get; set; }

        public char? IdTipoCota { get; set; }

        [ForeignKey("Administradora")]
        [Display(Name = "Administradora")]
        public int AdministradoraId { get; set; }

        [Display(Name = "Administradora")]
        public string Administradora { get; set; }

        [Display(Name = "Grupo")]
        public string Grupo { get; set; }

        [Display(Name = "Cota")]
        public string Cota { get; set; }


    }
}