using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MercadoLibre.Data;
using MercadoLibre.Models;

namespace MercadoLibre.Controllers
{
    [ApiController]
    public class CondicionController : ControllerBase
    {
        private readonly MercadoLibreContext _context;
        public CondicionController(MercadoLibreContext context)
        {
            _context = context;
        }
        [HttpPost]
        [Route("[controller]/mutant")]
        public async Task<ActionResult<AdnCondicion>> PostCondicion(AdnCondicion adn)
        {
            ADN validar = new ADN();
            Condicion condicion = new Condicion();
            condicion.Mutante = validar.isMutant(adn.Adn);
            condicion.Adn = adn.Adn.ToString();
            _context.Condicion.Add(condicion);
            await _context.SaveChangesAsync();
            if(condicion.Mutante)
            {
                return Ok();
            }else
            {
                return StatusCode(403);
            }
        }
        [HttpGet]
        [Route("[controller]/stats")]
        public async Task<JsonResult> GetCondicions()
        {
            IEnumerable<Condicion> todos = await _context.Condicion.ToListAsync();            
            int count_mut = todos.Where(m => m.Mutante == true).Count();
            int count_hum = todos.Where(h => h.Mutante == false).Count();
            double ratio = (double)count_mut / (double)count_hum;
            var json = new { Cantidad_mutantes = count_mut, Cantidad_humanos = count_hum, Ratio = ratio };
            return new JsonResult(json);
        }
    }
}
