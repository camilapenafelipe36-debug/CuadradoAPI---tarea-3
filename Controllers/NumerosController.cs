using Dapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;

namespace CuadradoAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class NumerosController : ControllerBase
    {
        private readonly IConfiguration _configuration;

        public NumerosController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        [HttpGet]
        public async Task<IActionResult> GetProductos()
        {
            try
            {
                string? connectionString =
                    _configuration.GetConnectionString("DefaultConnection");

                if (string.IsNullOrWhiteSpace(connectionString))
                {
                    return StatusCode(500, new
                    {
                        error = "No se encontró la cadena de conexión."
                    });
                }

                using var connection =
                    new SqlConnection(connectionString);

                string sql =
                    "SELECT Id, Nombre, Precio FROM Productos";

                var productos =
                    await connection.QueryAsync<Producto>(sql);

                return Ok(productos);
            }
            catch (Exception ex)
            {
                return StatusCode(500, new
                {
                    error = ex.Message
                });
            }
        }
    }

    public class Producto
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = "";
        public decimal Precio { get; set; }
    }
}
