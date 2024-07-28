using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace ConnectionMsn.Controllers
{
    [ApiController]
    [Route("Msn/")]

    public class MsnController : ControllerBase
    {
        [EnableCors("AllowAllOrigins")]
        [HttpGet]
        [Route("/Get")]
        public IActionResult GetString()
        {
            var response = new { message = "Pa que me invitan si saben como me pongo" };
            return Ok(response);
        }




        [HttpPost]
        [Route("/validateEmail/{email}/{password}")]
        public IActionResult ValidateEmail(string email, string password)
        {
            // Aqu� puedes agregar tu l�gica de validaci�n
            // Por ejemplo, verifica si el correo est� en una lista predefinida
            var predefinedPass = "20172009";
            var predefinedEmail = "martinsetaro81@gmail.com";

            if (string.Equals(password, predefinedPass, StringComparison.OrdinalIgnoreCase) && string.Equals(email, predefinedEmail, StringComparison.OrdinalIgnoreCase))
            {
                return Ok("Correo v�lido");
            }
            else
            {
                return BadRequest("Correo inv�lido");
            }
        }



    }
}
