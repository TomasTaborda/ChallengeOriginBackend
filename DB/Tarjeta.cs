using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB
{
    public class Tarjeta
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public long NumeroTarjeta { get; set; }
        public int Pin { get; set; }
        public bool Activa { get; set; }
        public int Balance { get; set; }
        public DateOnly FechaVencimiento { get; set; }
        public virtual ICollection<Movimiento> Movimientos { get; set; }

    }
}
