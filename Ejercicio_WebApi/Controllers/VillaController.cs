using Ejercicio_WebApi.Datos;
using Ejercicio_WebApi.Modelos;
using Ejercicio_WebApi.Modelos.Dto;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Ejercicio_WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VillaController : ControllerBase
    {
        [HttpGet]
        public ActionResult<IEnumerable<VillaDto>> GetVillas()
        {
            return VillaStore.villaList; // se configura de esta manera para apuntar a un almacen de datos, al no tener una BD con informacion

            //return new List<VillaDto> {
            //     new VillaDto { id=1, Nombre = "Vista a la Piscina"},
            //     new VillaDto{ id=2, Nombre = "Vista a la playa "}
            //};
        }

        [HttpGet("id")]
        public ActionResult<VillaDto> GetVilla(int id)
        {
            return VillaStore.villaList.FirstOrDefault(v => v.id == id);
        }


    }
}
