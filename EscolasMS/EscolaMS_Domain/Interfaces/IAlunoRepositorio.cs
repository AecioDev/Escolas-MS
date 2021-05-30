using EscolaMS_Domain.Entities;

namespace EscolaMS_Domain.Interfaces
{
    public interface IAlunoRepositorio : IRepositorioBase<Aluno>
    {
        Aluno GetAlunoByResp(int id);
    }
}
