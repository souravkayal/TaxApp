using Microsoft.AspNetCore.Mvc;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using TaxApp.Controllers;

namespace NUnitTest
{

    [TestFixture]
    public class TaxControllerTest
    {
        public FakeTaxService _fakeService;
        public TaxController _taxController;
        
        public TaxControllerTest()
        {
            
        }

        [SetUp]
        public void Init()
        {
            this._fakeService = new FakeTaxService();
            this._taxController = new TaxController(_fakeService);
        }


        [Test]
        public void Test_GetTax_Should_Return_Success_Result()
        {
            var result = _taxController.GetTax(new TaxApp.Model.TaxRequest { municipalityName = "test", date = new DateTime(2016, 1, 5) });
            var response = result.Result as OkObjectResult;

            Assert.IsNotNull(response);
            Assert.AreEqual(response.StatusCode, 200);
        }


        [Test]
        public void Test_GetTax_Should_Return_BadRequest_Result()
        {

            _taxController.ModelState.AddModelError("SomeField", "Mock Error");

            var result = _taxController.GetTax(new TaxApp.Model.TaxRequest { municipalityName = null, date = new DateTime(2016, 1, 5) });
            var response = result.Result as BadRequestObjectResult;

            Assert.IsNotNull(response);
            Assert.AreEqual(response.StatusCode, 400);
        }

        [Test]
        public void Test_AddTax_Should_Return_Success_Result()
        {
            var result = _taxController.AddTax ( new TaxApp.Model.TaxEntity { id = 1, municipalityName = "test", taxType = TaxApp.Enum.TaxType.DAILY, taxAmount = 1.1 });
            var response = result.Result as OkObjectResult;

            Assert.IsNotNull(response);
            Assert.AreEqual(response.StatusCode, 200);
        }

        [Test]
        public void Test_AddTax_Should_Return_BadRequest_Result()
        {
            _taxController.ModelState.AddModelError("SomeField", "Mock Error");

            var result = _taxController.AddTax(new TaxApp.Model.TaxEntity { id = 1, municipalityName = "test", taxType = TaxApp.Enum.TaxType.DAILY, taxAmount = 1.1 });
            var response = result.Result as BadRequestObjectResult;

            Assert.IsNotNull(response);
            Assert.AreEqual(response.StatusCode, 400);
        }



    }
}
