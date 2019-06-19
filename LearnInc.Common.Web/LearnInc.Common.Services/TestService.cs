using System;
using System.Collections.Generic;
using LearnInc.Common.Services.Models;

namespace LearnInc.Common.Services
{
	public class TestService : ITestService
	{
		public IEnumerable<TestModel> GetTests()
		{
			return new[] { new TestModel { TestId = Guid.Empty, TestText = "TEST" } };
		}
	}
}
