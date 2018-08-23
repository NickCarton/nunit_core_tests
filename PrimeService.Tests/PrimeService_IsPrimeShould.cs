using NUnit.Framework;
using Prime.Services;

namespace Prime.UnitTests.Services
{
    [TestFixture]
    public class PrimeService_IsPrimeShould
    {
        private readonly PrimeService _primeService;

        public PrimeService_IsPrimeShould()
        {
            _primeService = new PrimeService();
        }

        [Test]
        public void ReturnFalseGivenValueOf1()
        {
            var result = _primeService.IsPrime(1);

            Assert.IsFalse(result, $"1 should not be prime");
        }


        [Test]
        public void IsTom()
        {
            var actual = "Jeff";

            Assert.AreEqual("Tom", actual, "Should be Tom");
        }

        [Test]
        public void IsJeff()
        {
            var actual = "Jeff";

            Assert.AreEqual("Jeff", actual, "Should be Jeff");
        }
    }
}
