using AutoMapper;
using ControleProcessos.DAL.Data.Interface;
using ControleProcessos.DAL.Models;
using FluentResults;

namespace ControleProcessos.DAL.Data
{
    public class ProcessoRepository : IProcessoRepository
    {

        private readonly ControleProcessosContext _context = new ControleProcessosContext();

        public void CreateProcesso(Processo processo)
        {
            _context.Processos.Add(processo);
            _context.SaveChanges();

        }

        public Result DeleteProcesso(int id)
        {
            _context.Processos.Remove(GetProcesso(id));
            _context.SaveChanges();
            return Result.Ok();
        }

        public IEnumerable<Processo> GetAllProcessos()
        {
            return _context.Processos.ToList();
        }

        public Processo GetProcesso(int id)
        {
            return _context.Processos.Find(id);
        }

        public Result UpdateProcesso(Processo processo)
        {
            _context.Processos.Update(processo);
            _context.SaveChanges();
            return Result.Ok();
        }
    }
}

