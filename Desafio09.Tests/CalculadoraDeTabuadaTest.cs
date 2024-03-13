namespace Desafio09.Tests
{
    public class Tests
    {
        private CalculadoraDeTabuada calculadoraDeTabuada;

        [SetUp]
        public void Setup()
        {
            calculadoraDeTabuada = new CalculadoraDeTabuada(5);
        }

        [Test]
        public void CalcularTabuadaTest()
        {
            List<double> expectedResult = [5, 10, 15, 20, 25, 30, 35, 40, 45, 50];

            List<double> result = calculadoraDeTabuada.CalcularTabuada();

            Assert.That(result, Is.EqualTo(expectedResult));
        }
    }
}