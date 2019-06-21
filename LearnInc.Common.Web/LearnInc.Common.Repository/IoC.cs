using Unity;

namespace LearnInc.Common.Repository
{
	public static class IoC
	{
		public static IUnityContainer GlobalContainer { get; private set; }

		static IoC()
		{
			IoC.GlobalContainer = new UnityContainer();
			TypeRegistrar.RegisterTypes(GlobalContainer);

			// add locator
			//IoC.globalLocator = new UnityServiceLocator(IoC.globalContainer);
		}
	}
}
