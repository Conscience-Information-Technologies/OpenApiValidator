using System;

namespace Conscience.Logging
{
	[Flags]
	public enum LogNature
	{
		Message = -4,
		Info = -2,
		Log = -1,
		Success = 0,
		Warning = 1,
		ErrValidation = 2,
		ErrBusiness = 4,
		Err3 = 8,
		Err4 = 16,
		ExArgument = 32,
		ExBusiness = 64,
		ExRuntime = 256,
		ERROR = ErrValidation|ErrBusiness,
		EXCEPTION = ExArgument|ExBusiness|ExRuntime
	}
}
