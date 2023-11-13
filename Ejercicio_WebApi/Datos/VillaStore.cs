using Ejercicio_WebApi.Modelos.Dto;

namespace Ejercicio_WebApi.Datos
{
    public static class VillaStore
    {
        public static List<VillaDto> villaList = new List<VillaDto>
        {
            new VillaDto{id=1,Nombre="vista a la piscina" },
            new VillaDto{id=2,Nombre="vista a la playa"}
        };

    }
}
