using System;
using System.Linq;

namespace EjemploPatronEstrategia
{
    public class UtilidadNeta : ICalcularMargenDeUtilidad
    {
        public void Calcular()
        {
            var utilidadNeta = Data.VentasAnuales.Sum(v =>
                v.VentasBrutas - v.Impuestos - v.GastosOperativos - v.GastosDeAdministracion);

            Console.WriteLine($"La utilidad es: {utilidadNeta}");
        }
    }
}