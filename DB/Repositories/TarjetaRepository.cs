using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB.Repositories
{
    public interface ITarjetaRepository
    {
        IEnumerable<Tarjeta> GetTarjetas();
        Tarjeta GetTarjetaById(int id);
        void DesactivarTarjeta(int id);
        void UpdateBalance(int id, int amount);
    }
    public class TarjetaRepository : ITarjetaRepository
    {
        private readonly ChallengeContext _context;

        public TarjetaRepository(ChallengeContext context)
        {
            _context = context;
        }

        public IEnumerable<Tarjeta> GetTarjetas()
        {
            return _context.Tarjetas.ToList();
        }

        public Tarjeta GetTarjetaById(int id)
        {
            return _context.Tarjetas.FirstOrDefault(t => t.Id == id);
        }

        public void DesactivarTarjeta(int id)
        {
            var tarjeta = _context.Tarjetas.Find(id);
            tarjeta.Activa = false;
            _context.Tarjetas.Update(tarjeta);
            _context.SaveChanges();
        }

        public void UpdateBalance(int id, int amount)
        {
            var tarjeta = _context.Tarjetas.Find(id);
            tarjeta.Balance -= amount;
            _context.Tarjetas.Update(tarjeta);
            _context.SaveChanges();
        }

        public void DeleteTarjeta(int id)
        {
            var tarjeta = _context.Tarjetas.Find(id);
            _context.Tarjetas.Remove(tarjeta);
            _context.SaveChanges();
        }
    }
}
