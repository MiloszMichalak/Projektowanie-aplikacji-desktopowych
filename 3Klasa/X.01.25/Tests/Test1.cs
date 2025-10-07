using NUnit.Framework;
using SimpleKalkulator;

namespace Tests
{
    public class Test1
    {
        [Test]
        public void TestIfAddCorrectly()
        {
            // Assign
            Kalkulator kalkulator = new Kalkulator();

            // Act
            int wynik = kalkulator.Dodaj(1, 2);

            // Assert
            Assert.That(wynik, Is.EqualTo(3));
        }
    }
}
