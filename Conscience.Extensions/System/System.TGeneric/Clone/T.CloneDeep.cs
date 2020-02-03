using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace System
{
	public static partial class Extensions
	{
		public static T CloneDeep<T>(this T @this)
		{
			if(!typeof(T).IsSerializable)
			{
				throw new ArgumentException("The type must be serializable.", "source");
			}

			// Don't serialize a null object, simply return the default for that object
			if(Object.ReferenceEquals(@this, null))
			{
				return default(T);
			}

			IFormatter formatter = new BinaryFormatter();
			using(var stream = new MemoryStream())
			{
				formatter.Serialize(stream, @this);
				stream.Seek(0, SeekOrigin.Begin);
				return (T)formatter.Deserialize(stream);
			}
		}
	}
}