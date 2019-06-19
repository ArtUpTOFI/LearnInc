using AutoMapper;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LearnInc.Common.Web.UnitTests
{
	[TestClass]
	public class MappingRegistrarTests
	{
		[TestMethod]
		public void TestRegisterModelMappings()
		{
			// Arrange
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
