using System.Collections.Generic;
using LearnInc.Common.Services.Models;

namespace LearnInc.Common.Services
{
	public interface ITestService
	{
		IEnumerable<TestModel> GetTests();
	}
}
