using DesafioDioDotnetETDD;

namespace DesafioDioDotnetETDDTests
{
    public class CalculadoraTest
    {
        public Calculadora calcBuilder()
        {
            string data = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
            Calculadora calc = new Calculadora(data);
            return calc;
        }

        [Theory]
        [InlineData(1, 2, 3)]
        [InlineData(4, 5, 9)]
        public void TestSomar(int num1, int num2, int expected)
        {
            Calculadora calc = calcBuilder();

            int actual = calc.Somar(num1, num2);

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(1, 2, -1)]
        [InlineData(5, 5, 0)]
        public void TestSubtrair(int num1, int num2, int expected)
        {
            Calculadora calc = calcBuilder();

            int actual = calc.Subtrair(num1, num2);

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(1, 2, 2)]
        [InlineData(4, 5, 20)]
        public void TestMultiplicar(int num1, int num2, int expected)
        {
            Calculadora calc = calcBuilder();

            int actual = calc.Multiplicar(num1, num2);

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(10, 2, 5)]
        [InlineData(4, 5, 0)]
        public void TestDividir(int num1, int num2, int expected)
        {
            Calculadora calc = calcBuilder();

            int actual = calc.Dividir(num1, num2);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestDividirPor0()
        {
            Calculadora calc = calcBuilder();

            Assert.Throws<DivideByZeroException>(() => calc.Dividir(10, 0));
        }

        [Fact]
        public void TestHistorico()
        {
            Calculadora calc = calcBuilder();

            calc.Somar(1, 2);
            calc.Subtrair(4, 5);
            calc.Multiplicar(3, 3);
            calc.Dividir(10, 2);

            List<string> historico = calc.Historico();

            Assert.NotEmpty(historico);
            Assert.Equal(3, historico.Count);
        }
    }
}