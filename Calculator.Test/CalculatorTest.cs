
using System.Security.Cryptography.X509Certificates;
using Testing_p1;
using NUnit; 

    public class CalculatorTest
    {
        [Test]
        public void SubtractionMustReturnNotNullValue()
        {
            var s = calculator.Subtraction(5, 2);
            Assert.True(3 == s);
        }

        [Test]
        public void DivisionMustReturnNotNullValue()
        {
            var div = calculator.Division(10, 2);
            Assert.True(5 == div);
            //Првоерка на 0
            Assert.Throws<DivideByZeroException>(() => calculator.Division(30, 0));
        }

        [Test]
        public void MiltiplicationMustReturnNotNullValue()
        {
            var mul = calculator.Miltiplication(10, 2);
            Assert.True(20 == mul);
        }

        [Test]
        public void AdditionalMustReturnNotNullValue()
        {
            var add = calculator.Additional(5, 2);
            Assert.True(7 == add);
        }


    }

