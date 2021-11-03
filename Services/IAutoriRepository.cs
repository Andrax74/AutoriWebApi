using System.Collections.Generic;
using AutoriWebApi.Models;

namespace AutoriWebApi.Services
{
    public interface IAutoriRepository
    {
        ICollection<Autori> SelAll();
    }
}