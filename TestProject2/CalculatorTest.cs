using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Testing_p1; 

namespace TestProject2
{
    
    public class CalculatorTest
    {
        [Fact]
        public void SubtractionOkey()
        {
            Calculator calculator = new Calculator();
           // calculator.Subtraction(5, 2);
            Assert.Equal(3, calculator.Subtraction(5, 2));

           // calculator.Division(10,2);
            Assert.Equal(5, calculator.Division(10, 2));
        }
    }
}
