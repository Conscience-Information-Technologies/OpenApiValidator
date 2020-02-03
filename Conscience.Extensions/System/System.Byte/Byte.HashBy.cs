using System;
using System.Collections.Generic;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;

namespace System
{
	public static partial class Extensions
	{
		public static byte[] HashBy<T>(this byte[] x) where T : HashAlgorithm
		{
			HashAlgorithm algo;
			try
			{
				algo=typeof(T)
				    .GetMethod("Create", BindingFlags.Public|BindingFlags.Static, null, new Type[] { }, null)
					.Invoke(null, null) as HashAlgorithm;
			}
			catch
			{
				algo=Activator.CreateInstance<T>();
			}
			return algo.ComputeHash(x);
		}
	}
}