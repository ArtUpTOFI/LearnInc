using Unity;

namespace LearnInc.Common.Services
{
	public static class TypeRegistrar
	{
		public static void RegisterTypes(IUnityContainer container)
		{
			container.RegisterType<ITestService, TestService>();
		}
	}
}
