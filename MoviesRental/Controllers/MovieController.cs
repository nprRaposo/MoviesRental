using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MoviesRental.Models;

namespace MoviesRental.Controllers
{
    [Produces("application/json")]
    [Route("api/Movie")]
    public class MovieController : Controller
    {

        private readonly MoviesRentalContext _context;

        public MovieController(MoviesRentalContext context)
        {
            this._context = context;
        }

        // GET: api/Movie
        [HttpGet(Name = "GetAll")]
        public IEnumerable<Movie> Get()
        {
            return this._context.Movies.ToList();
        }

        // GET: api/Movie/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }
        
        // POST: api/Movie
        [HttpPost]
        public IActionResult Create([FromBody] Movie aMovie)
        {

            if (aMovie == null)
                return BadRequest();

            this._context.Movies.Add(aMovie);
            this._context.SaveChanges();

            return CreatedAtRoute("GetAll",null);

        }
    }
}
