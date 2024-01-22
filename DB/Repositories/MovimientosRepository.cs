using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB.Repositories
{
    public interface IMovimientoRepository
    {
        IEnumerable<Movimiento> GetMovimientos();
        Movimiento GetMovimientoByIdTarjeta(int id);
        Movimiento AddMovimiento(Movimiento movimiento);

    }
    public class MovimientoRepository : IMovimientoRepository
    {
        private readonly ChallengeContext _context;

        public MovimientoRepository(ChallengeContext context)
        {
            _context = context;
        }

        public IEnumerable<Movimiento> GetMovimientos()
        {
            return _context.Movimientos.ToList();
        }

        public Movimiento GetMovimientoByIdTarjeta(int id)
        {
            return _context.Movimientos.FirstOrDefault(m => m.TarjetaId == id);
        }

        public Movimiento AddMovimiento(Movimiento movimiento)
        {
            _context.Movimientos.Add(movimiento);
            _context.SaveChanges();
            return movimiento;
        }

    }
}
