using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Notes.Core;
using Notes.DB;

namespace NotesWebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class NotesController : ControllerBase
    {
     

        private readonly ILogger<NotesController> _logger;

        private INoteServices _noteServices;
        public NotesController(ILogger<NotesController> logger, INoteServices noteServices)
        {
            _logger = logger;
            _noteServices = noteServices;
        }

        [HttpGet("{id}", Name = "GetNote")]
        public IActionResult GetNote(int id)
        {
            return Ok(_noteServices.GetNote(id));
        }



        [HttpPost]
        public IActionResult  CreateNote(Note note)
        {
            return Ok(_noteServices.CreateNote(note));
        }
    }
}
