using jwtBearer.Models;
using jwtBearer.Repositories;
using jwtBearer.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace jwtBearer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {

        [HttpPost]
        [Route("login")]
        [AllowAnonymous]
        public async Task<ActionResult<dynamic>> Authenticate([FromBody] User model)
        {
            // Recupera o Usuario
            var user = UserRepository.Get(model.Username, model.Password);

            //Verifica se o usuario existe
            if (user == null)
                return NotFound(new { message = "Usuário ou Senha Inválidos" });

            // Gera o Token
            var token = TokenService.GenerateToken(user);

            //Oculta a senha
            user.Password = "";

            //Retorna os dados
            return new
            {
                user = user,
                token = token
            };
        }

        [HttpGet]
        [Route("anonymous")]
        [AllowAnonymous]
        public string Anonymous() => "Anônimo";

        [HttpGet]
        [Route("authenticated")]
        [Authorize]
        public string Authenticated() => String.Format("Autenticado - {0}", User.Identity.Name);

        [HttpGet]
        [Route("employee")]
        [Authorize(Roles = "employee,manager")]
        public string Employee() => "Funcionário";

        [HttpGet]
        [Route("manager")]
        [Authorize(Roles = "manager")]
        public string Manager() => "Gerente";

    }
}
