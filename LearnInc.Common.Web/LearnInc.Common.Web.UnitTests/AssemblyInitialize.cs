using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LearnInc.Common.Web.UnitTests
{
	[TestClass]
	public static class AssemblyInitialize
	{
		[AssemblyInitialize]
		public static void Load(TestContext context)
		{
			// temp solution for fixing global mapping in tests
			new Startup(null).RegisterMappings();
		}
	}
}
