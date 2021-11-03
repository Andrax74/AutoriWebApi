using System.Collections.Generic;
using AutoriWebApi.Models;

namespace AutoriWebApi.Services
{
    public class AutoriRepository : IAutoriRepository
    {
        Autori[] autori = new Autori[]
        {
            new Autori {Id = 1, Nome = "Sarah J. Maas", Nazione = "USA", Genere = "Fantasy",  Età = 35 },
            new Autori {Id = 2, Nome = "Leigh Bardugo", Nazione = "USA", Genere = "Fantasy",  Età = 46 },
            new Autori {Id = 3, Nome = "Frank Herbert", Nazione = "USA", Genere = "Fantascenza",  Età = -1 }
        };
        public ICollection<Autori> SelAll()
        {
            return this.autori;
        }
    }
}