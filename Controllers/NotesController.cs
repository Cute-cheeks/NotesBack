using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace NotesApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class NotesController : ControllerBase
    {
        //[Route("CreateNote")]
        [HttpPost(Name ="CreateNote")]
        public IActionResult CreateNote()
        {
            return Created();
        }
        
    }

}
