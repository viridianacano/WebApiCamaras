using Microsoft.AspNetCore.Mvc;
using WebApiCamaras.Entidades;

namespace WebApiCamaras.Entidades
{
    public class Camara 
    {
        public int Id { get; set; }

        public string Nombre { get; set; }

        public List <Marca> marcas { get; set; }
    }
}
