using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApiCamaras.Entidades;

namespace WebApiCamaras.Controllers

{

    [ApiController]
    [Route("api/camaras")]
    public class CamarasController : ControllerBase
    {
        private readonly ApplicationDbContext dbContext;

        public CamarasController(ApplicationDbContext context)
        {
            this.dbContext = context;
        }

        [HttpPost]
        public async Task<ActionResult> Post(Camara camara)
        {
            dbContext.Add(camara);
            await dbContext.SaveChangesAsync();
            return Ok();
        }

        [HttpGet]
        public async Task<ActionResult<List<Camara>>> Get()
        {
            return await dbContext.Camaras.Include(x => x.marcas).ToListAsync();
        }
    

        [HttpPut("{id:int}")]
        public async Task<ActionResult> Put(Camara camara, int id)
        {
            if(camara.Id != id)
            {
                return BadRequest("El id de la camara no coincide con el establecido en la url");
            }

            dbContext.Update(camara);
            await dbContext.SaveChangesAsync();
            return Ok();
        }

        [HttpDelete("{id:int}")]
        public async Task<ActionResult> Delete(int id)
        {
            var exist=await dbContext.Camaras.AnyAsync(x => x.Id == id);
            if (!exist)
            {
                return NotFound();
            }

            dbContext.Remove(new Camara()
            {
                Id = id

            });
            await dbContext.SaveChangesAsync();
            return Ok();
        }






    }

}
