using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace AdministrareMagazin.Classes.EF
{
    public class Cos
    {
        public int Id { get; set; }
        public int Id_Produs { get; set; }
        public string NumeProdus { get; set; }
        public int Cantitate { get; set; }
    }

    class CosDbContext : DbContext {

       public DbSet<Cos> CosCumparaturi { get; set; }

    }
}
