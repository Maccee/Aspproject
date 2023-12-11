using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using webapi.Models;

namespace webapi.Controllers_
{
    [ApiController]
    [Route("[controller]")]
    public class LolController : Controller
    {
        private readonly AspProjectDatabaseContext _context;

        public LolController(AspProjectDatabaseContext context)
        {
            _context = context;
        }

        // GET: Person
        [HttpGet(Name = "GetPersons")]
        public IEnumerable<Person> Indexxx()
        {
            // Fetch all persons from database
            Person[] allPeople = _context.Persons.ToArray();

            return allPeople;

            //  return _context.Persons != null ? 
            //              View(await _context.Persons.ToListAsync()) :
            //              Problem("Entity set 'FreeAzureSqlContext.Persons'  is null.");
        }



        private bool PersonExists(int id)
        {
            return _context.Persons.Any(e => e.Personid == id);
        }
    }
}
