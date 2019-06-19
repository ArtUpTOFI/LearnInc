using LearnInc.Common.Services;
using Unity;
using Unity.Injection;

namespace LearnInc.Common.Web
{
	// to be removed or populated later
	public static class TypeRegistrar
	{
		public static void RegisterTypes(IUnityContainer container)
		{
			container.RegisterType<ITestService, TestService>(new InjectionConstructor()); //add lifetime manager later
		}
	}
}
