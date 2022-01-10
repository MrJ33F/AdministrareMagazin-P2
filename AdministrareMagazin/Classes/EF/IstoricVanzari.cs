using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.Entity;
using System.ComponentModel.DataAnnotations;


namespace AdministrareMagazin.Classes.EF
{
    public class Istoric
    {
        public int Id { get; set; }
        public int Id_User { get; set; }

        public string DenumireProdus { get; set; }
        public int CantitateProduse { get; set; }
    }

    class IstoricVanzariDbContext : DbContext
    {
        public DbSet<Istoric> IstoricVanzari { get; set; }
    }
}
