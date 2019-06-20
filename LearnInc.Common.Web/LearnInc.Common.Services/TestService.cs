using System.Collections.Generic;
using AutoMapper;
using LearnInc.Common.Repository;
using LearnInc.Common.Services.Models;

namespace LearnInc.Common.Services
{
	public class TestService : ITestService
	{
		// add injection here
		private readonly TestStore _store = new TestStore();

		public IEnumerable<TestModel> GetTests()
		{
			IEnumerable<TestDataModel> tests = this._store.Tests;

			return Mapper.Map<IEnumerable<TestModel>>(tests);
		}
	}
}
