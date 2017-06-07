using LibraryApiPOC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace LibraryApiPOC.Controllers
{
    public class AuthorsController : ApiController
    {
        Author[] Authors = new Author[]
            {
                new Author() { Id = 0, Name = "Ayn Rand" },
                new Author() { Id = 1, Name = "J. K. Rowling" },
                new Author() { Id = 2, Name = "James A. Corey" },
            };

        [Route("api/authors")]
        [HttpGet]
        public IEnumerable<Author> GetAllAuthors()
        {
            return Authors; 
        }

        [Route("api/authors/{id}")]
        [HttpGet]
        public IHttpActionResult GetAuthor(int id)
        {
            var author = Authors.FirstOrDefault((a) => a.Id == id);
            if (author == null)
            {
                return NotFound();
            }
            return Ok(author);
        }

    }
}
