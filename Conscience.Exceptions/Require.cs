
using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Threading.Tasks;

namespace Conscience.Exceptions
{
	public static class Require
	{
		public static Exception NotNull<T>(T @object) where T : class
		{
			return NotNull(@object, @object.GetType().Name);
		}

		public static Exception NotNull<T>(T @object, string parameterName) where T : class
		{
			if(@object==null)
				return new ArgumentNullException(parameterName);
			return null;
		}

		public static Exception NotNull(Task value, string parameterName)
		{
			if(value==null)
				return new ArgumentNullException(parameterName);
			return null;
		}

		public static Exception NotNull<T>(Task<T> value, string parameterName)
		{
			if(value==null)
				return new ArgumentNullException(parameterName);
			return null;
		}

		public static Exception NotNullEmpty(string value, string parameterName)
		{
			if(value==null)
				return new ArgumentNullException(parameterName);

			if(value.Length==0||value[0]=='\0')
				return new ArgumentException(Format(ValidationMessage.Argument_EmptyString, parameterName), parameterName);
			return null;

		}

		public static Exception NotNullEmptyWhitespace(string value, string parameterName)
		{
			if(value==null)
				return new ArgumentNullException(parameterName);

			if(value.Length==0||value[0]=='\0')
				return new ArgumentException(Format(ValidationMessage.Argument_EmptyString, parameterName), parameterName);

			if(string.IsNullOrWhiteSpace(value))
				return new ArgumentException(Format(ValidationMessage.Argument_Whitespace, parameterName), parameterName);
			return null;
		}

		public static Exception NotNullEmpty(IEnumerable values, string parameterName)
		{
			NotNull(values);

			ICollection collection = values as ICollection;

			if(collection!=null&&collection.Count>0)
				return null;

			return new ArgumentException(Format(ValidationMessage.Argument_EmptyArray, parameterName), parameterName);
		}

		public static Exception NotNullEmptyAndNullElement<T>(IEnumerable<T> values, string parameterName) where T : class
		{
			NotNullEmpty(values, parameterName);

			foreach(T value in values)
			{
				if(value==null)
				{
					return new ArgumentException(Format(ValidationMessage.Argument_NullElement, parameterName), parameterName);
				}
			}

			return null;
		}

		//public static Exception CanTypeCast<T, Y>(T item, Y type)
		//{
		//	if(item is type)
		//		return new InvalidCastException();

		//	return null;
		//}

		internal static string Format(string format, params object[] args)
		{
			return string.Format(CultureInfo.CurrentCulture, format, args);
		}

		//public static ArgumentException Argument(string messageFormat, params object[] messageArgs)
		//{
		//	return new ArgumentException(Format(messageFormat, messageArgs));
		//}

		//public static ArgumentException Argument(string parameterName, string messageFormat, params object[] messageArgs)
		//{
		//	return new ArgumentException(Format(messageFormat, messageArgs), parameterName);
		//}

		//public static NotSupportedException NotSupported(string messageFormat, params object[] messageArgs)
		//{
		//	return new NotSupportedException(Format(messageFormat, messageArgs));
		//}
	}
}