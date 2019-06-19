using AutoMapper;
using LearnInc.Common.Web.Controllers;
using LearnInc.Common.Services.Models;

namespace LearnInc.Common.Web
{
	public class MappingRegistrar
	{
		public void RegisterMappings(IProfileExpression profileExpression)
		{
			profileExpression.CreateMap<TestViewModel, TestModel>();
			profileExpression.CreateMap<TestModel, TestViewModel>();
		}
	}
}
