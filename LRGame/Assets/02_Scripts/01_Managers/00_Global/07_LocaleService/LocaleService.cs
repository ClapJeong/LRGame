
using System;
using System.Collections.Generic;
using System.Linq;
using TMPro;
using UnityEngine.Localization;
using UnityEngine.Localization.Settings;

public class LocaleService : IDisposable
{
  private readonly LocalizeFonts fonts;

  private readonly List<LocalizeFontEvent> fontEvents = new();

  private Locale currentLocale;
  private TMP_FontAsset currentFont;

  public LocaleService(LocalizeFonts fonts)
  {
    this.fonts = fonts;

    LocalizationSettings.SelectedLocaleChanged += UpdateFont;

    currentLocale = LocalizationSettings.SelectedLocale;
    currentFont = GetLocaleFont(currentLocale);
  }

  public void Register(LocalizeFontEvent localizeFontEvent)
  {
    fontEvents.Add(localizeFontEvent);
    localizeFontEvent.UpdateFont(currentFont);
  }

  public void Unregister(LocalizeFontEvent localizeFontEvent)
    => fontEvents.Remove(localizeFontEvent);

  private void UpdateFont(Locale locale)
  {
    if (currentLocale == locale)
      return;

    currentLocale = locale;
    currentFont = GetLocaleFont(locale);
    foreach (var fontEvent in fontEvents)
      fontEvent.UpdateFont(currentFont);
  }

  private TMP_FontAsset GetLocaleFont(Locale locale)
    => fonts
    .FontSets
    .FirstOrDefault(set => set.Locale.Identifier == locale.Identifier)
    .FontAsset;

  public void Dispose()
  {
    LocalizationSettings.SelectedLocaleChanged -= UpdateFont;
  }
}
