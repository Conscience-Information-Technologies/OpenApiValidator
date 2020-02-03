using System;

namespace Conscience.OpenApiValidator
{
	/// <summary>
	/// Validator runtime options
	/// </summary> 
	[Serializable]
	public class ValidatorOptions
	{

		//private IStringSource _errorSource;
		//private IStringSource _errorCodeSource;

		/// <summary>
		/// Default cascade mode
		/// </summary>
		public static CascadeMode CascadeMode = CascadeMode.Continue;

		/// <summary>
		/// Default property chain separator
		/// </summary>

		/// <summary>
		/// Default language manager 
		/// </summary>
		//public static ILanguageManager LanguageManager {
		//	get => _languageManager;
		//	set => _languageManager = value ?? throw new ArgumentNullException(nameof(value));
		//}
		//private static ILanguageManager _languageManager = new LanguageManager();

		/// <summary>
		/// Customizations of validator selector
		/// </summary>
		//public static ValidatorSelectorOptions ValidatorSelectors { get; } = new ValidatorSelectorOptions();

		//private static Func<MessageFormatter> _messageFormatterFactory;
		//private static Func<MessageFormatter> MessageFormatterFactory
		//{
		//	get
		//	{
		//		_messageFormatterFactory=_messageFormatterFactory??(() => new MessageFormatter());
		//		return _messageFormatterFactory;
		//	}
		//}
	}
}
