using System;
using System.Collections.Generic;
using System.Text;

namespace EscolaMS_Domain.Entities
{
    public class Responsavel
    {
        public int ResponsavelId { get; set; }
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public string CPF { get; set; }

        public virtual IEnumerable<Aluno> Alunos { get; set; }
    }
}

//- O Responsável deve ter no mínimo 18 anos de idade;
//- O nome deve ter máximo de 180 e mínimo de 3 caracteres;
//- CPF é obrigatório;