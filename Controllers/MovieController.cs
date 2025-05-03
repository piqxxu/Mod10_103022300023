using Microsoft.AspNetCore.Mvc;


// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace modul10_103022300023.Controllers
{
    [Route("api/Movies")]
    [ApiController]
    public class MovieController : ControllerBase
    {
        public static List<string> stars1 = new List<string>
        {
            new string("Tim Robbins"),
            new string("Morgan Freeman"),
            new string("Bob Gunton")
        };

        public static List<string> stars2 = new List<string>
        {
            new string("Marlon Brando"),
            new string("Al Pacino"),
            new string("James Caan")
        };

        public static List<string> stars3 = new List<string>
        {
            new string("Christian Bale"),
            new string("Heath Ledger"),
            new string("Aaron Eckhart")
        };

        public static List<Movie> dataMovies = new List<Movie>
        {
            new Movie("The Shawshank Redemption", stars1, "A banker convicted of uxoricide forms a friendship over a quarter century with a hardened convict, while maintaining his innocence and trying to remain hopeful through simple compassion.", "Frank Darabont"),
            new Movie("The Godfather", stars2, "The aging patriarch of an organized crime dynasty transfers control of his clandestine empire to his reluctant son.", "Francis Ford Coppola"),
            new Movie("The Dark Knight", stars3, "When a menace known as the Joker wreaks havoc and chaos on the people of Gotham, Batman, James Gordon and Harvey Dent must work together to put an end to the madness.", "Christopher Nolan")
        };
        // GET: api/<MovieController>
        [HttpGet]
        public IEnumerable<Movie> Get()
        {
            return dataMovies;
        }

        // GET api/<MovieController>/5
        [HttpGet("{id}")]
        public Movie Get(int id)
        {
            return dataMovies[id];
        }

        // POST api/<MovieController>
        [HttpPost]
        public void Post([FromBody] Movie value)
        {
            dataMovies.Add(value);
        }

        // DELETE api/<MovieController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            dataMovies.RemoveAt(id);
        }
    }
}
