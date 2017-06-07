using LibraryApiPOC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace LibraryApiPOC.Controllers
{
    public class BooksController : ApiController
    {
        Book[] Books = new Book[] 
        {
            new Book() { Id = 0, Title = "Atlas Shrugged", Genre = "Philosophical fiction", PublicationYear = 1957, AuthorId = 0},
            new Book() { Id = 1, Title = "The Fountainhead", Genre = "Philosophical fiction", PublicationYear = 1943, AuthorId = 0},
            new Book() { Id = 2, Title = "Harry Potter and the Chamber of Secrets", Genre = "Fantasy", PublicationYear = 1998, AuthorId = 1},
            new Book() { Id = 3, Title = "Leviathan Wakes", Genre = "Science Fiction", PublicationYear = 2011, AuthorId = 2},
            new Book() { Id = 4, Title = "Cibola Burn", Genre = "Science Fiction", PublicationYear = 2014, AuthorId = 2}
        };

        [Route("api/books")]
        [HttpGet]
        public IEnumerable<Book> GetAllBooks()
        {
            return Books; 
        }

        [Route("api/books/{id}")]
        [HttpGet]
        public IHttpActionResult GetBook(int id)
        {
            var book = Books.FirstOrDefault((b) => b.Id == id);
            if (book == null)
            {
                return NotFound(); 
            }
            return Ok(book);
        }

    }
}
