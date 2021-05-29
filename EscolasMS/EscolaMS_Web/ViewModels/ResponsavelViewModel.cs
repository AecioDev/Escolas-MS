using EscolaMS_Web.Libraries.Lang;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace EscolaMS_Web.ViewModels
{
    public class ResponsavelViewModel
    {
        [Key]
        [Display(Name = "Código")]
        public int ResponsavelId { get; set; }

        [Required(ErrorMessageResourceType = typeof(Mensagens), ErrorMessageResourceName = "MSG_E001")]
        [MaxLength(180, ErrorMessageResourceType = typeof(Mensagens), ErrorMessageResourceName = "MSG_E003")]
        [MinLength(3, ErrorMessageResourceType = typeof(Mensagens), ErrorMessageResourceName = "MSG_E002")]
        [Display(Name = "Nome Completo")]
        public string Nome { get; set; }

        [Required(ErrorMessageResourceType = typeof(Mensagens), ErrorMessageResourceName = "MSG_E001")]
        [Display(Name = "Data de Nascimento")]
        public DateTime DataNascimento { get; set; }

        [Required(ErrorMessageResourceType = typeof(Mensagens), ErrorMessageResourceName = "MSG_E001")]
        [Display(Name = "CPF")]
        public string CPF { get; set; }
        
        public virtual IEnumerable<AlunoViewModel> Alunos { get; set; }
    }
}

/*
[Required(ErrorMessage = "Preencha o campo Nome!")]
[MaxLength(180, ErrorMessage = "Maximo {0} caracteres")]
[MinLength(3, ErrorMessage = "Mínimo {0} caracteres")]
[Display(Name = "Nome Completo")]
public string Nome { get; set; }

[Required(ErrorMessage = "Informe a Data de Nascimento!")]
[Display(Name = "Data de Nascimento")]
public DateTime DataNascimento { get; set; }

[Required(ErrorMessage = "O CPF é obrigatório!")]
[Display(Name = "CPF")]
public string CPF { get; set; }
*/