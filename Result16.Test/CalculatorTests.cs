using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Result16.Test
{
    [TestFixture]
    public class CalculatorTests
    {
        [Test]
        public void AdditionalMustReturnCorrectValue()
        {
            var calculator = new Calculator();
            Assert.That(calculator.Additional(-30, 10) == -20);
        }

        [Test]
        public void SubtractionMustReturnCorrectValue()
        {
            var calculator = new Calculator();
            Assert.That(calculator.Subtraction(150, 120) == 30);
        }

        [Test]
        public void MiltiplicationMustReturnCorrectValue()
        {
            var calculator = new Calculator();
            Assert.That(calculator.Miltiplication(2, 4) == 8);
        }

        [Test]
        public void DivisionMustReturnCorrectValue()
        {
            var calculator = new Calculator();
            Assert.That(calculator.Division(18, 6) == 3);
        }

        [Test]
        public void DivisionMustReturnDivideByZeroException()
        {
            var calculator = new Calculator();
            Assert.Throws<DivideByZeroException>(() => calculator.Division(150, 0));
        }
    }
}