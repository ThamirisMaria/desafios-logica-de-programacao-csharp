using NUnit.Framework;
using Desafio02;

namespace Desafio02.Tests
{
    public class Tests
    {
        private CalculadoraDeOperacoesBasicas calculadora;

        [SetUp]
        public void Setup()
        {
            calculadora = new CalculadoraDeOperacoesBasicas(8, 4);
        }

        [Test]
        public void TestSomar()
        {
            double expectedResult = 12;

            double result = calculadora.Somar();

            Assert.That(result, Is.EqualTo(expectedResult));
        }

        [Test]
        public void TestSubtrair()
        {
            double expectedResult = 4;

            double result = calculadora.Subtrair();

            Assert.That(result, Is.EqualTo(expectedResult));
        }

        [Test]
        public void TestMultiplicar()
        {
            double expectedResult = 32;

            double result = calculadora.Multiplicar();

            Assert.That(result, Is.EqualTo(expectedResult));
        }

        [Test]
        public void TestDividir()
        {
            double expectedResult = 2;

            double result = calculadora.Dividir();

            Assert.That(result, Is.EqualTo(expectedResult));
        }       
        
        [Test]
        public void TestDividirPor0()
        {
            calculadora = new CalculadoraDeOperacoesBasicas(8, 0);

            double expectedResult = 0;

            double result = calculadora.Dividir();

            Assert.That(result, Is.EqualTo(expectedResult));
        }
    }
}