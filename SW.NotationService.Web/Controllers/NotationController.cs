namespace SW.NotationService.Web.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using SW.NotationService.Core.Model;
    using System.Collections.Generic;
    using System.Linq;

    [ApiController]
    [Route("[Controller]")]
    public class NotationController : ControllerBase
    {
        private IEnumerable<Notation> exampleNotations;

        public NotationController()
        {
            this.exampleNotations = new List<Notation>()
            {
                new Notation()
                {
                    Id = "1",
                    SongName = "Vo Lusiyah",
                    ArtistName = "Natalia"
                }
            };
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(this.exampleNotations);
        }

        [HttpGet("id")]
        public IActionResult GetNotation(string id)
        {
            var targetNotation = this.exampleNotations.FirstOrDefault(n => n.Id == id);
            
            if (targetNotation is null)
            {
                return NotFound();
            }
            
            return Ok(this.exampleNotations.FirstOrDefault(n => n.Id == id));
        }
    }
}
