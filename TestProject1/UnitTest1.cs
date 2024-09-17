using Moq;
using System.Security.Cryptography.X509Certificates;
using Testing_p1;
using static Testing_p1.TicketService;

namespace TestProject1
{
    public class Tests
    {
        Calculator calculator = new Calculator();
       
        [SetUp]
        public void Setup()
        {
        }

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

    /// <summary>
    /// 
    /// </summary>
    [TestFixture]
    public class TicketServiceTests
    {
        [Test]
        public void GetTicketPriceMustReturnExistingPrice()
        {
            var ticketServiceTest = new TicketService();
            Assert.IsNotNull(ticketServiceTest.GetTicketPrice(1));
        }

        [Test]
        public void GetTicketPriceMustThrowException()
        {
            var ticketServiceTest = new TicketService();
            Assert.Throws<TicketNotFoundException>(() => ticketServiceTest.GetTicketPrice(100));
        }


    }
    [TestFixture]
    public class TicketPriceTests
    {
        [Test]
        public void TicketPriceMustReturnNotNullableTicket()
        {
            var mockTicketService = new Mock<ITicketService>();
            mockTicketService.Setup(p => p.GetTicketPrice(1)).Returns(100);
            mockTicketService.Setup(p => p.GetTicketPrice(2)).Returns(500);
            mockTicketService.Setup(p => p.GetTicketPrice(3)).Returns(7800);

            var ticketPriceTest = new TicketPrice(mockTicketService.Object);
            Assert.That(ticketPriceTest.MakeTicketPrice(3) == 7800);
        }
    }
}