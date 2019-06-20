using AutoMapper;
using LearnInc.Common.Repository;
using LearnInc.Common.Services.Models;

namespace LearnInc.Common.Services
{
	public class MappingRegistrar
	{
		public void RegisterMappings(IProfileExpression profileExpression)
		{
			profileExpression.CreateMap<TestModel, TestDataModel>();
			profileExpression.CreateMap<TestDataModel, TestModel>();
		}
	}
}
