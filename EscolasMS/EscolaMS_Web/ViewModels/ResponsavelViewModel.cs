using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace EscolaMS_Web.ViewModels
{
    public class ResponsavelViewModel
    {
        [Key]
        public int ResponsavelId { get; set; }

        [Required(ErrorMessage = "Preencha o campo Nome!")]
        [MaxLength(180, ErrorMessage = "Maximo {0} caracteres")]
        [MinLength(3, ErrorMessage = "Mínimo {0} caracteres")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Informe a Data de Nascimento!")]
        public DateTime DataNascimento { get; set; }

        [Required(ErrorMessage = "O CPF é obrigatório!")]
        public string CPF { get; set; }
        
        public virtual IEnumerable<AlunoViewModel> Alunos { get; set; }
    }
}
