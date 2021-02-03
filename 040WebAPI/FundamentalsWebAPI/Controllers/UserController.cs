using Microsoft.AspNetCore.Mvc;
using FundamentalsWebAPI.Models;
using System.Text.Json;

namespace FundamentalsWebAPI.Controllers
{
    [ApiController]
    [Route("api/v1/[Controller]")]
    public class UserController : ControllerBase
    {
        [HttpPost]
        public IActionResult CreateUser(
            [FromHeader(Name = "username")] string username,
            [FromBody] User user
        )
        {
            if (!user.Email.Contains("@"))
            {
                return StatusCode(500, new
                {
                    message = "Erro interno do servidor"
                });
            }

            if (user.Username.Length < 5) return BadRequest(new
            {
                message = "Erro de parametros"
            });

            return Ok(user);
            // var user2 = JsonSerializer.Deserialize<User>("{\"username\":\"test\",\"email\":\"test@gmail.com\",\"age\":0}", new JsonSerializerOptions {
            //     PropertyNameCaseInsensitive = true
            // });

            // return JsonSerializer.Serialize(user2, new JsonSerializerOptions {
            //     PropertyNamingPolicy = JsonNamingPolicy.CamelCase
            // });
            //return $"Criando usuario... {user.Username} / {user.Email} / {user.Age} - do header {username}";
        }

        [HttpGet]
        public string Filter(
            [FromQuery(Name = "q")] string query,
            [FromQuery(Name = "oq")] string oQuery
        )
        {
            return $"Buscando por \"{query}\"...\"{oQuery}\"";
        }

        [HttpPost("category/{categoryId}/create/{userId}")]
        public string CreateUserCategory(int categoryId, int userId)
        {
            return $"Categoria id: {categoryId}, Usuário id: {userId} Created...";
        }

        [HttpDelete("{id:int}")]
        public string DeleteUser(int id)
        {
            return $"Deletando usario do id {id} ...";
        }
    }
}