using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Data;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("api/conexion")]
    public class ConexionController : ControllerBase
    {
        private readonly LazaroDbContext _sah;
        private readonly ValleDbContext _sahValle;

        public ConexionController(LazaroDbContext sah, ValleDbContext sahValle)
        {
            _sah = sah;
            _sahValle = sahValle;
        }

        // GET: /api/conexion/sah
        [HttpGet("sah")]
        public async Task<IActionResult> ProbarSah()
        {
            try
            {
                await _sah.Database.OpenConnectionAsync();
                await _sah.Database.ExecuteSqlRawAsync("SELECT 1");
                await _sah.Database.CloseConnectionAsync();

                return Ok(new { baseDeDatos = "sah", conectado = true });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new
                {
                    baseDeDatos = "sah",
                    conectado = false,
                    error = ex.Message,
                    inner = ex.InnerException?.Message
                });
            }
        }

        // GET: /api/conexion/sah_valle
        [HttpGet("sah_valle")]
        public async Task<IActionResult> ProbarSahValle()
        {
            try
            {
                await _sahValle.Database.OpenConnectionAsync();
                await _sahValle.Database.ExecuteSqlRawAsync("SELECT 1");
                await _sahValle.Database.CloseConnectionAsync();

                return Ok(new { baseDeDatos = "sah_hrsj_valle", conectado = true });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new
                {
                    baseDeDatos = "sah_hrsj_valle",
                    conectado = false,
                    error = ex.Message,
                    inner = ex.InnerException?.Message
                });
            }
        }
    }
}
