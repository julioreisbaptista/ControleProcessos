using ControleProcessos.DAL.Models;

namespace ControleProcessos.DAL.Data.Interface
{
    public interface IProcessoTipoRepository
    {
        void Add(ProcessoTipo processoTipo);

        List<ProcessoTipo> GetAll();

        ProcessoTipo GetByID(int id);

        void Update(ProcessoTipo processoTipo);

        void Delete(int id);


    }
}
