namespace System.Collections.Generic
{
	public static partial class Extensions
	{
		public static IEnumerable<T> Append<T>(this IEnumerable<T> @this, T element)
		{
			foreach(var item in @this)
				yield return item;
			yield return element;
		}

		public static IEnumerable<T> Prepend<T>(this IEnumerable<T> @this, T element)
		{
			yield return element;
			foreach(var item in @this)
				yield return item;
		}

		public static IEnumerable<T> ForEach<T>(this IEnumerable<T> @this, Action<T> action)
		{
			foreach (var item in @this)
			{
				action(item);
				yield return item;
			}
		}
	}
}