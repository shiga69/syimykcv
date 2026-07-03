using SyimykCV.Models;

namespace SyimykCV.Services;

public class LocalizationService
{
    public string CurrentLang { get; private set; } = "en";
    public event Action? OnChange;

    public string T(string key)
    {
        if (Translations.Data.TryGetValue(CurrentLang, out var dict) && dict.TryGetValue(key, out var val))
            return val;
        return key;
    }

    public void SetLanguage(string lang)
    {
        if (CurrentLang == lang || !Translations.Data.ContainsKey(lang)) return;
        CurrentLang = lang;
        OnChange?.Invoke();
    }

    public void Toggle()
    {
        SetLanguage(CurrentLang == "en" ? "pl" : "en");
    }
}
