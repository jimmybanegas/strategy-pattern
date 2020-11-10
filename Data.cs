using System.Collections.Generic;

namespace EjemploPatronEstrategia
{
    public static class Data
    {
        public static IEnumerable<ReporteMensualDeVentas> VentasAnuales => new List<ReporteMensualDeVentas>
        {
            new ReporteMensualDeVentas
            {
                Mes = 1,
                VentasBrutas = 5000,
                Impuestos = 200,
                GastosDeAdministracion = 24,
                GastosOperativos = 450
            },
            new ReporteMensualDeVentas
            {
                Mes = 2,
                VentasBrutas = 1000,
                Impuestos = 400,
                GastosDeAdministracion = 424,
                GastosOperativos = 50
            },
            new ReporteMensualDeVentas
            {
                Mes = 3,
                VentasBrutas = 15000,
                Impuestos = 900,
                GastosDeAdministracion = 2004,
                GastosOperativos = 407
            }
        };
    }
}