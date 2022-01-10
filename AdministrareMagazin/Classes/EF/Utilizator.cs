using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace AdministrareMagazin.Classes.EF
{
    public class Utilizator
    {
        public int Id { get; set; }
        
        [MaxLength(30, ErrorMessage = "Username-ul trebuie sa fie mai mic de 30 de caractere.")]
        public string Username { get; set; }

        [MaxLength(50, ErrorMessage = "Emai-lul trebuie sa fie mai mic de 50 de caractere.")]
        public string Email { get; set; }

        [MaxLength(30, ErrorMessage = "Parola trebuie sa fie mai mica de 30 de caractere.")]
        public string Password { get; set; }

        [MaxLength(50, ErrorMessage = "Numele trebuie sa fie mai mic de 50 de caractere.")]
        public string Nume { get; set; }

        [MaxLength(50, ErrorMessage = "Prenumele trebuie sa fie mai mic de 50 de caractere.")]
        public string Prenume { get; set; }

        [MaxLength(256, ErrorMessage = "Adresa trebuie sa fie mai mica de 256 de caractere.")]
        public string Adresa { get; set; }

        [MaxLength(10, ErrorMessage = "Numarul de telefon terbuie sa fie mai mic de 10 caractere.")]
        public string Telefon { get; set; }
        
    }

    class UtilizatorDbContext : DbContext
    {
        public DbSet<Utilizator> Utilizatori { get; set; }
    }
}

