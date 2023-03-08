using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApiCamaras.Entidades;
using WebApiCamaras.Controllers;

namespace WebApiCamaras.Controllers
{
    [ApiController]
    [Route("api/marcas")]
    public class MarcasController : Controller
    {

        private readonly ApplicationDbContext dbContext;

        public MarcasController (ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        [HttpPost]
        public async Task<ActionResult> Post(Marca marca)
        {
            var existeMarca = await dbContext.Marcas.AnyAsync(x => x.Id == marca.CamaraId);
            if (!existeMarca)
            {
                return BadRequest($"No existe la marca con el id: {marca.CamaraId}");

            }
            dbContext.Add(marca);
            await dbContext.SaveChangesAsync();
            return Ok();
        }

        [HttpGet]
        public async Task<ActionResult<List<Marca>>> GetAll()
        {
            return await dbContext.Marcas.ToListAsync();
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult<Marca>> GetById(int id)
        {
            return await dbContext.Marcas.FirstOrDefaultAsync(x => x.Id == id);


        }
        

        [HttpPut]
        public async Task<ActionResult> Put(Marca marca, int id)
        {
            var exist = await dbContext.Marcas.AnyAsync(x => x.Id == id);
            if(!exist)
            {
                return NotFound("La clase no especificada no existe. ");

            }

            if(marca.Id != id)
            {
                return BadRequest("El id de la clase no coinicide con el establecido en la url");

            }
            dbContext.Update(marca);
            await dbContext.SaveChangesAsync();
            return Ok();
        }

        [HttpDelete("{id:int}")]
        public async Task<ActionResult>Delete(int id)
        {
            var exist=await dbContext.Marcas.AnyAsync(x => x.Id == id);
            if (!exist)
            {


                return NotFound("el recurso no fue encontrado");
            }
            dbContext.Remove(new Marca { Id = id });
            await dbContext.SaveChangesAsync();
            return Ok();
        }

        





    }
}
