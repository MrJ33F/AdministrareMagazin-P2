using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace AdministrareMagazin.Classes.EF
{
   public class Produs
    {
        public int Id { get; set; }

        [MaxLength(30, ErrorMessage = "Denumirea trebuie sa fie mai mica de 30 de caractere")]
        public string Denumire { get; set; }

        [MaxLength(500, ErrorMessage = "Descriere produsului trebuie sa fie mai mica de 500 de caractere")]
        public string DescriereProdus { get; set; }

        public DateTime DataIntrare { get; set; }
        public DateTime DataValabilitate { get; set; }

        public int Cantitate { get; set; }
    }

    class MagazinDbContext : DbContext
    {
        public DbSet<Produs> Produse { get; set; }
    }
}

