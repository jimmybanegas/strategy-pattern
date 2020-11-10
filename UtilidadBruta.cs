using System;
using System.Linq;

namespace EjemploPatronEstrategia
{
    public class UtilidadBruta : ICalcularMargenDeUtilidad
    {
        public void Calcular()
        {
            var utilidadBruta = Data.VentasAnuales.Sum(v => v.VentasBrutas - v.Impuestos);

            Console.WriteLine($"La utilidad es: {utilidadBruta}");
        }
    }
}