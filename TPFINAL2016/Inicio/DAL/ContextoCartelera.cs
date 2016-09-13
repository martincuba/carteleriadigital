using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Inicio
{
    public class ContextoCartelera : DbContext
    {
        public DbSet<Evento> Evento { get; set; }
        public DbSet<RangoFecha> RangoFecha { get; set; }
        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<Media> Media { get; set; }
        public DbSet<Cartelera> Cartelera { get; set; }
    }
}
