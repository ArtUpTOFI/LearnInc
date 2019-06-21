﻿using Unity;

namespace LearnInc.Common.Repository
{
	public static class TypeRegistrar
	{
		public static void RegisterTypes(IUnityContainer container)
		{
			container.RegisterType<ITestStore, TestStore>();
		}
	}
}
