using System;

namespace EjemploPatronEstrategia
{
    class Program
    {
        static void Main(string[] args)
        {
            var contexto = new Contexto();

            contexto.DefinirEstrategia(GetAlgoritmoDeCalculoDeMargenDeUtilidad(AlgoritmosDeMargenDeUtilidad.Bruta));
            contexto.AplicarEstrategia();

            contexto.DefinirEstrategia(GetAlgoritmoDeCalculoDeMargenDeUtilidad(AlgoritmosDeMargenDeUtilidad.Neta));
            contexto.AplicarEstrategia();


            contexto.DefinirEstrategia(GetAlgoritmoDeCalculoDeMargenDeUtilidad(AlgoritmosDeMargenDeUtilidad.Operativa));
            contexto.AplicarEstrategia();
        }

        private static ICalcularMargenDeUtilidad GetAlgoritmoDeCalculoDeMargenDeUtilidad(
            AlgoritmosDeMargenDeUtilidad algoritmo)
        {
            ICalcularMargenDeUtilidad algoritmoDeCalculoDeMargenDeUtilidad = null;

            switch (algoritmo)
            {
                case AlgoritmosDeMargenDeUtilidad.Bruta:
                    algoritmoDeCalculoDeMargenDeUtilidad = new UtilidadBruta();
                    break;
                case AlgoritmosDeMargenDeUtilidad.Neta:
                    algoritmoDeCalculoDeMargenDeUtilidad = new UtilidadNeta();
                    break;
                case AlgoritmosDeMargenDeUtilidad.Operativa:
                    algoritmoDeCalculoDeMargenDeUtilidad = new UtilidadOperativa();
                    break;
            }

            return algoritmoDeCalculoDeMargenDeUtilidad;
        }
    }

    internal enum AlgoritmosDeMargenDeUtilidad
    {
        Bruta,
        Neta,
        Operativa
    }
}