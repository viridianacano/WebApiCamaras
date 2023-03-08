using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;
using System.Globalization;
using WebApiCamaras.Entidades;

namespace WebApiCamaras.Entidades
{
    public class Marca
    {

      public int Id { get; set; }

      public string Nombre { get; set; }

      public string Modelo { get; set; }

      public int CamaraId { get; set; }

      public Camara Camara { get; set; }




    }
}
