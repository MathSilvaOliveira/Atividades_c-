using ApiComBanco.Data;
using ApiComBanco.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiComBanco.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly DataContext userdataContext;

        public UserController(DataContext dataContext)
        {
            userdataContext = dataContext;
        }

        [HttpPost]
        public ActionResult<User> Create([FromBody] User user)
        {
            userdataContext.Add(user);
            userdataContext.SaveChanges();
            return Ok("Usuario adicionado com Sucesso");
        }

        [HttpGet]
        public ActionResult<User> Get()
        {
            var usuarioencontrado = userdataContext.Users.ToList();
            if (usuarioencontrado == null)
            {
                return NotFound();
            }
            return Ok(usuarioencontrado);
        }

        [HttpPut("{id}")]
        public ActionResult<User> Put(int id, User user)
        {
            var userencontrado = userdataContext.Users.FirstOrDefault(u => u.Id == id);
            if (userencontrado == null)
            {
                return NotFound();
            }
            userencontrado.Name = user.Name;
            userencontrado.Email = user.Email;
            userdataContext.Update(userencontrado);
            userdataContext.SaveChanges();
            return Ok(userencontrado);
        }
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            var userencontrado = userdataContext.Users.FirstOrDefault(u =>u.Id == id);
            if (userencontrado == null)
            {
                return NotFound();
            }
            userdataContext.Remove(userencontrado);
            userdataContext.SaveChanges();
            return Ok("Usuario removido com sucesso");
        }
    }
}
