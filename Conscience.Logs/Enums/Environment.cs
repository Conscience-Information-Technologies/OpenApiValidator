using System;

namespace Conscience.Logging
{
	[Flags]
	public enum Env
	{
		ALL = PROD|DEV,

		PROD = 2,
		STAGE = PROD,
		TEST = DEV,
		READY = DEV,
		DEV = 1,
		master = 0,
	}
}
