namespace SW.NotationService.Web.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using SW.NotationService.Repository.Repositories;

    [ApiController]
    [Route("[Controller]")]
    public class NotationController : ControllerBase
    {
        private readonly INotationRepository notationRepository;

        public NotationController(INotationRepository notationRepository)
        {
            this.notationRepository = notationRepository;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(this.notationRepository.GetAll());
        }

        [HttpGet("id")]
        public IActionResult GetNotation(string id)
        {
            var targetNotation = this.notationRepository.Get(id);

            if (targetNotation is null)
            {
                return NotFound();
            }

            return Ok(targetNotation);
        }
    }
}
