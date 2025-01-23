using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TestingProject.ViewModel;

namespace TestingProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthorController : ControllerBase
    {
        private readonly TestDBContext _context;

        public AuthorController(TestDBContext context)
        {
            _context = context;
        }



        [HttpPost]
        public ActionResult AddAuthor([FromBody] Author authors)
        {

            Author author = new Author();
            author.FirstName = "Joydip";
            author.LastName = "";
            author.PhoneNumber = "1234567890";

            author.Email = "joydipkanjilal@yahoo.com";
            return NotFound();
        }

    }
}
