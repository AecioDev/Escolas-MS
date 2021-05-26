using System;
using System.Collections.Generic;
using System.Text;

namespace EscolaMS_Domain.Entities
{
    public class Aluno
    {
        public int AlunoId { get; set; }
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public string NumeroCertidaoNova { get; set; }
        public string CPF { get; set; }
        public int ResponsavelId { get; set; }

        public virtual Responsavel Responsavel { get; set; }

    }
}

//- O Aluno deve ter no mínimo 6 anos de idade;
//- O nome deve ter máximo de 200 e mínimo de 3 caracteres;
//- NumeroCertidaoNova é obrigatório caso o CPF não seja informado;
//- CPF é obrigatório caso o NumeroCertidaoNova não seja informado;
//- Responsável é obrigatório para alunos menores de 18 anos de idade;