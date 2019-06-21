using System.Collections.Generic;
using AutoMapper;
using LearnInc.Common.Services;
using Microsoft.AspNetCore.Mvc;
using Unity;

namespace LearnInc.Common.Web.Controllers
{
	[Route("api/[controller]")]
	public class TestController : Controller
	{
		public ITestService TestService
		{
			get { return IoC.GlobalContainer.Resolve<ITestService>(); }
		}

		[HttpGet("")]
		public IEnumerable<TestViewModel> GetTests()
		{
			var testModels = this.TestService.GetTests();
			var results = Mapper.Map<IEnumerable<TestViewModel>>(testModels);

			return results;
		}
	}
}
