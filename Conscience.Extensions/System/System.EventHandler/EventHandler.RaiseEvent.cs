using System;

namespace System
{
	public static partial class Extensions
	{
		public static void RaiseEvent(this EventHandler @this, object sender)
		{
			if(@this!=null)
				@this(sender, null);
		}

		public static void RaiseEvent(this EventHandler @this, object sender, EventArgs e)
		{
			if(@this!=null)
				@this(sender, e);
		}

		public static void RaiseEvent<TEventArgs>(this EventHandler<TEventArgs> @this, object sender) where TEventArgs : EventArgs
		{
			@this.RaiseEvent(sender, Activator.CreateInstance<TEventArgs>());
		}

		public static void RaiseEvent<TEventArgs>(this EventHandler<TEventArgs> @this, object sender, TEventArgs e) where TEventArgs : EventArgs
		{
			if(@this!=null)
				@this(sender, e);
		}
	}
}