using ControleProcessos.DAL.Models;
using FluentResults;


namespace ControleProcessos.DAL.Data.Interface
{
    public interface IProcessoRepository
    {
        void CreateProcesso(Processo processo);
        Result UpdateProcesso(Processo processo);
        Result DeleteProcesso(int id);
        Processo GetProcesso(int id);
        IEnumerable<Processo> GetAllProcessos();

    }
}
