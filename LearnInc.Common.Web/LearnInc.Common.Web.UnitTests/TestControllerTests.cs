using System;
using LearnInc.Common.Services;
using LearnInc.Common.Services.Models;
using LearnInc.Common.Web.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System.Collections.Generic;
using System.Linq;

namespace LearnInc.Common.Web.UnitTests
{
	[TestClass]
	public class TestControllerTests
	{
		private Mock<ITestService> _testServiceMock;

		[TestInitialize]
		public void Init()
		{
			this._testServiceMock = new Mock<ITestService>();
		}

		[TestMethod]
		public void TestsGetTestsReturnTestModels()
		{
			// Arrange
			Guid testId1 = Guid.NewGuid();
			Guid testId2 = Guid.NewGuid();

			List<TestModel> models = new List<TestModel>
			{
				new TestModel { TestId = testId1, TestText = string.Empty },
				new TestModel { TestId = testId2, TestText = string.Empty }
			};

			this._testServiceMock
				.Setup(service => service.GetTests())
				.Returns(models.AsEnumerable())
				.Verifiable();

			// Act
			using (var controller = this.CreateController())
			{
				var result = controller.GetTests().ToList();

				// Assert
				Assert.IsNotNull(result);
				Assert.AreEqual(models.Count, result.Count());

				Assert.AreEqual(models[0].TestId, result.ElementAt(0).TestId);
				Assert.AreEqual(models[1].TestId, result.ElementAt(1).TestId);

				this._testServiceMock.Verify();
			}
		}

		private TestController CreateController()
		{
			return new TestController(this._testServiceMock.Object);
		}
	}
}
