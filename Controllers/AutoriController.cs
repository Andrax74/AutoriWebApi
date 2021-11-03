using System;
using System.Collections.Generic;
using AutoriWebApi.Models;
using AutoriWebApi.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AutoriWebApi.Controllers
{
    [ApiController]
    [Produces("application/json")]
    [Route("api/autori")]
    public class AutoriController : Controller
    {
        private readonly IAutoriRepository autoriRepository;

        public AutoriController(IAutoriRepository autoriRepository)
        {
            this.autoriRepository = autoriRepository;
        }

        [HttpGet("")]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<Autori>))]
        public ActionResult<IEnumerable<Autori>> GetAutoriAsync()
        {
            Console.WriteLine(DateTime.Now);
            Console.WriteLine($"***** Ottenimento dati autori *****");

            var libri =  this.autoriRepository.SelAll();
            
            if (libri.Count == 0)
            {
                return NotFound(new ErrMsg(string.Format("Non è stato trovato alcun autore!"),"404"));
            }
            else
            {
                Console.WriteLine($"Numero di record: {libri.Count}");
                return Ok(libri);
            }

        }
    }
}