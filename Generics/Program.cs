using System;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            var resultado = new OperationResult<Persona>();
            Persona p = resultado.Contenido;

            var resultadoCar = new OperationResult<Car>();
            Car coche = new Car("Opel", "Vectra");
            resultadoCar.SetSuccessResponse(coche);
            Car c = resultadoCar.Contenido;
        }
    }
}
