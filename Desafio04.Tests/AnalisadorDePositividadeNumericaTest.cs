namespace Desafio04.Tests
{
    public class Tests
    {
        private AnalisadorDePositividadeNumerica analisador;

        [SetUp]
        public void Setup()
        {
            analisador = new AnalisadorDePositividadeNumerica(5);
        }

        [Test]
        public void TestGetPositivoOuNegativo_Positivo()
        {
            string result = analisador.GetPositivoOuNegativo();
            Assert.That(result, Is.EqualTo("POSITIVO"));
        }

        [Test]
        public void TestGetPositivoOuNegativo_Negativo()
        {
            analisador = new AnalisadorDePositividadeNumerica(-5);
            string result = analisador.GetPositivoOuNegativo();
            Assert.That(result, Is.EqualTo("NEGATIVO"));
        }

        [Test]
        public void TestAnalisarPositividade_PositiveNumber()
        {
            bool result = analisador.AnalisarPositividade();
            Assert.That(result, Is.True);
        }

        [Test]
        public void TestAnalisarPositividade_NegativeNumber()
        {
            analisador = new AnalisadorDePositividadeNumerica(-5);
            bool result = analisador.AnalisarPositividade();
            Assert.That(result, Is.False);
        }

        [Test]
        public void TestAnalisarPositividade_ZeroNumber()
        {
            analisador = new AnalisadorDePositividadeNumerica(0);
            Assert.Throws<ArgumentException>(() => analisador.AnalisarPositividade());
        }
    }
}