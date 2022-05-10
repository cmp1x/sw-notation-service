namespace SW.NotationService.Web.Controllers
{
    using AutoMapper;
    using Microsoft.AspNetCore.Mvc;
    using SW.NotationService.Repository.Repositories;
    using SW.NotationService.Web.RequestModels;
    using System.Collections.Generic;

    [ApiController]
    [Route("[Controller]")]
    public class NotationController : ControllerBase
    {
        private readonly INotationRepository notationRepository;
        private readonly IMapper mapper;

        public NotationController(INotationRepository notationRepository, IMapper mapper)
        {
            this.notationRepository = notationRepository;
            this.mapper = mapper;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var notations = this.notationRepository.GetAll();
            var mappedNotations = this.mapper.Map<IEnumerable<NotationGetRequestResult>>(notations);
            return Ok(mappedNotations);
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
