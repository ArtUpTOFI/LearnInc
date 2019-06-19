using Unity;

namespace LearnInc.Common.Services
{
	// to be removed or populated
	public static class IoC
	{
		private static IUnityContainer _globalContainer;

		public static IUnityContainer GlobalContainer {
			get { return _globalContainer; }
		}

		public static void InitializeContainerAndLocator()
		{
			IoC._globalContainer = new UnityContainer();

			// add locator
			//IoC.globalLocator = new UnityServiceLocator(IoC.globalContainer);
		}
	}
}
