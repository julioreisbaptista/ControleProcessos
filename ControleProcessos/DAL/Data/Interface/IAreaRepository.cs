using ControleProcessos.DAL.Models;

namespace ControleProcessos.DAL.Data.Interface
{
    public interface IAreaRepository
    {
        void Add(Area area);

        List<Area> GetAll();

        Area GetById(int id);

        void Update(Area area);

        void Delete(int id);


    }
}
