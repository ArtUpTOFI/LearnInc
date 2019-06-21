using AutoMapper;
using LearnInc.Common.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Learning.Common.Services.UnitTests
{
	[TestClass]
	public class MappingRegistrarTests
	{
		[TestMethod]
		public void TestRegisterModelMappings()
		{
			//Arrange
			MappingRegistrar registrar = new MappingRegistrar();

			MapperConfiguration config = new MapperConfiguration(cfg =>
			{
				registrar.RegisterMappings(cfg);
			});

			// Act
			IMapper mapper = config.CreateMapper();

			// Assert
			mapper.ConfigurationProvider.AssertConfigurationIsValid();
		}
	}
}
