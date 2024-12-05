using ApiComBanco.Data;
using ApiComBanco.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ApiComBanco.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmprestimoController : ControllerBase
    {
        private readonly DataContext emprestimodataContext;

        public EmprestimoController(DataContext emprestimo_dataContext)
        {
            emprestimodataContext = emprestimo_dataContext;
        }

        [HttpPost]
        public ActionResult<Emprestimo> Create([FromBody] Emprestimo emprestimo)
        {
            var user = emprestimodataContext.Users.FirstOrDefault(u => u.Id == emprestimo.UserId);
            var book = emprestimodataContext.Books.FirstOrDefault(b => b.Id == emprestimo.BookId);

            if (user == null || book == null)
            {
                return NotFound();
            }

            emprestimo.User = user;
            emprestimo.Book = book;

            emprestimodataContext.Add(emprestimo);
            emprestimodataContext.SaveChanges();
            return Ok("Emprestimo realizado com sucesso");
        }

        [HttpGet]
        public ActionResult<IEnumerable<Emprestimo>> GetAll()
        {
            var emprestimos = emprestimodataContext.Emprestimo.Include(e => e.User).Include(e => e.Book).ToList();
            return Ok(emprestimos);
        }
    }
}