using EscolaMS_Web.Libraries.Lang;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace EscolaMS_Web.ViewModels
{
    public class AlunoViewModel
    {
        [Key]
        [Display(Name = "Código")]
        public int AlunoId { get; set; }

        [Required(ErrorMessageResourceType = typeof(Mensagens), ErrorMessageResourceName = "MSG_E001")]
        [MinLength(3, ErrorMessageResourceType = typeof(Mensagens), ErrorMessageResourceName = "MSG_E002")]
        [MaxLength(200, ErrorMessageResourceType = typeof(Mensagens), ErrorMessageResourceName = "MSG_E003")]
        [Display(Name = "Nome Completo")]
        public string Nome { get; set; }

        [Required(ErrorMessageResourceType = typeof(Mensagens), ErrorMessageResourceName = "MSG_E001")]
        [DataType(DataType.Date)]
        [Display(Name = "Nascimento")]
        public DateTime DataNascimento { get; set; }


        [Display(Name = "Certidão")]
        public string NumeroCertidaoNova { get; set; }

        [Display(Name = "CPF")]
        public string CPF { get; set; }

        [Display(Name = "Responsável")]
        public int? ResponsavelId { get; set; }

        public virtual ResponsavelViewModel Responsavel { get; set; }
    }
}

