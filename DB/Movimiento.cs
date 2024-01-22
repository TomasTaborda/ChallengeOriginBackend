using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB
{
    public class Movimiento
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdOperacion { get; set; }
        // Esta propiedad actúa como clave foránea
        public int TarjetaId { get; set; }
        public int Monto { get; set; }
        public DateTime Fecha { get; set; }

        // Propiedad de navegación. La clave foránea es TarjetaId
        [ForeignKey("TarjetaId")]
        public virtual Tarjeta Tarjeta { get; set; }
    }
}
