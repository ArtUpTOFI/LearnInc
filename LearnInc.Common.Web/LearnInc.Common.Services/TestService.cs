using System.Collections.Generic;
using AutoMapper;
using LearnInc.Common.Repository;
using LearnInc.Common.Services.Models;
using Unity;

namespace LearnInc.Common.Services
{
	public class TestService : ITestService
	{
		public ITestStore TestStore
		{
			get { return Repository.IoC.GlobalContainer.Resolve<ITestStore>(); }
		}

		public IEnumerable<TestModel> GetTests()
		{
			IEnumerable<TestDataModel> tests = this.TestStore.Tests;

			return Mapper.Map<IEnumerable<TestModel>>(tests);
		}
	}
}
