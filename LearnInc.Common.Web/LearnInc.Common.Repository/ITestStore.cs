using System.Collections.Generic;

namespace LearnInc.Common.Repository
{
	public interface ITestStore
	{
		IEnumerable<TestDataModel> Tests { get; }
	}
}
