namespace Mindbox.I18n.Abstractions;

/// <summary>
/// Контекст локализации в рамках запроса.
/// </summary>
public interface ILocalizationContext
{
	/// <summary>
	/// Язык пользователя.
	/// </summary>
	public ILocale? UserLocale { get; set; }
}