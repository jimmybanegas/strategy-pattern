namespace EjemploPatronEstrategia
{
    public class Contexto
    {
        ICalcularMargenDeUtilidad _estrategiaMargenDeUtilidad;

        public Contexto()
        {
        }

        public void DefinirEstrategia(ICalcularMargenDeUtilidad estrategiaMargenDeUtilidad)
        {
            _estrategiaMargenDeUtilidad = estrategiaMargenDeUtilidad;
        }

        public void AplicarEstrategia()
        {
            _estrategiaMargenDeUtilidad.Calcular();
        }
    }
}