using ControleProcessos.DAL.Data.Interface;
using ControleProcessos.DAL.Models;

namespace ControleProcessos.DAL.Data
{
    public class ProcessoTipoRepository : IProcessoTipoRepository
    {
        private readonly ControleProcessosContext _context = new ControleProcessosContext();

        public void Add(ProcessoTipo processoTipo)
        {
            _context.ProcessoTipos.Add(processoTipo);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            _context.ProcessoTipos.Remove(GetByID(id)); 
            _context.SaveChanges();
            
        }

        public List<ProcessoTipo> GetAll()
        {
            return _context.ProcessoTipos.ToList();
        }

        public ProcessoTipo GetByID(int id)
        {
            return _context.ProcessoTipos.Find(id);
        }

        public void Update(ProcessoTipo processoTipo)
        {
            _context.ProcessoTipos.Update(processoTipo);
            _context.SaveChanges();
            
        }
    }
}
