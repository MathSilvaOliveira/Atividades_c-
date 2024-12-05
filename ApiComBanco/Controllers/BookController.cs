using ApiComBanco.Data;
using ApiComBanco.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiComBanco.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private readonly DataContext _dataContext;

        public BookController(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        [HttpPost]
        public ActionResult<Book> Create([FromBody] Book book)
        {
            _dataContext.Add(book);
            _dataContext.SaveChanges();
            return Ok("Livro adicionado com Sucesso");
        }
        [HttpGet]
        public ActionResult<Book> GetAll()
        {
            var bookEncontrados = _dataContext.Books.ToList();
            if (bookEncontrados == null)
            {
                return NotFound();
            }
            return Ok(bookEncontrados);
        }

        [HttpGet("{id}")]
        public ActionResult<Book> GetById(int id)
        {
            var bookencontrado = _dataContext.Books.FirstOrDefault(x => x.Id == id);
            if (bookencontrado == null)
            {
                return NotFound();
            }
            return Ok(bookencontrado);
        }

        [HttpPut("{id}")]
        public ActionResult<Book> Put(int id, Book book)
        {
            var bookencontrado = _dataContext.Books.FirstOrDefault(x => x.Id == id);
            if (bookencontrado == null)
            { 
                return NotFound();
            }
            bookencontrado.Nome = book.Nome;
            bookencontrado.Autor = book.Autor;
            _dataContext.Update(bookencontrado);
            _dataContext.SaveChanges();
            return Ok(bookencontrado);

        }

        [HttpDelete("{id}")]
        public ActionResult<Book> Delete(int id)
        {
            var bookencontrado = _dataContext.Books.FirstOrDefault(x => x.Id == id);
            if(bookencontrado == null)
            { 
                return NotFound();
            }
            _dataContext.Remove(bookencontrado);
            _dataContext.SaveChanges();
            return Ok("Livro removido com sucesso");
        }
    }
}
