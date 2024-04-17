using ControleProcessos.DAL.Data.Interface;
using ControleProcessos.DAL.Models;

namespace ControleProcessos.DAL.Data
{
    public class AreaRepository : IAreaRepository
    {

        private readonly ControleProcessosContext _context  = new ControleProcessosContext();
        public void Add(Area area)
        {
            _context.Areas.Add(area);
            _context.SaveChanges();
            
        }

        public void Delete(int id)
        {
            _context.Areas.Remove(GetById(id));
            _context.SaveChanges();
            
        }

        public List<Area> GetAll()
        {
            return _context.Areas.ToList();
            
        }

        public Area GetById(int id)
        {

            return _context.Areas.Find(id);
            
        }

        public void Update(Area area)
        {
            _context.Areas.Update(area);
            _context.SaveChanges();
        }
    }
}

