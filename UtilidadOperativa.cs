using System;
using System.Linq;

namespace EjemploPatronEstrategia
{
    class UtilidadOperativa : ICalcularMargenDeUtilidad
    {
        public void Calcular()
        {
            var utilidadOperativa = Data.VentasAnuales.Sum(v =>
                v.VentasBrutas - v.GastosOperativos);

            Console.WriteLine($"La utilidad es: {utilidadOperativa}");
        }
    }
}