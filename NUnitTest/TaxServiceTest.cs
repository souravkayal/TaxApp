using NUnit.Framework;
using TaxApp.Repository;
using TaxApp.Service;

namespace NUnitTest
{
    [TestFixture]
    public class TaxServiceTest
    {
        public ITaxRepository _taxRepository;
        public ITaxService _taxService;

        [SetUp]
        public void Setup()
        {
            this._taxRepository = new FakeTaxRepository();
            this._taxService = new TaxService(_taxRepository);
        }


        [Test]
        public void Test_Add_Tax_Should_Return_Success()
        {
            var result = this._taxService.AddTax(new TaxApp.Model.TaxEntity { id = 1, municipalityName = "test" });

            Assert.IsNotNull(result);
            Assert.AreEqual(result.Result.message, "1 Tax information added");
        }
    }
}