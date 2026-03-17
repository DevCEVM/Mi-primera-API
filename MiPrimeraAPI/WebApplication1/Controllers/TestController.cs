using Microsoft.AspNetCore.Mvc;
using WebApplication1.Data;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("api/test")]
    public class TestController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public TestController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: /api/test/conexion
        [HttpGet("conexion")]
        public IActionResult ProbarConexion()
        {
            try
            {
                var conectado = _context.Database.CanConnect();
                return Ok(new { conectado });
            }
            catch (Exception ex)
            {
                // Devolvemos el error para diagnosticar si no se conecta
                return StatusCode(500, new { conectado = false, error = ex.Message });
            }
        }
    }
}
