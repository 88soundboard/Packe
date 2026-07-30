namespace SoundBoard88.Keyboard;

/// <summary>
/// Selectable keyboard layout metadata. Layout variants can share the same physical
/// key geometry while exposing a locale-specific name in settings.
/// </summary>
public sealed record KeyboardLayoutInfo(
    string Code,
    string Label,
    string Geometry,
    string Region
);

public static class KeyboardLayoutCatalog
{
    public static readonly KeyboardLayoutInfo[] Layouts =
    [
        new("system", "System Default", "system", "Auto-detect"),
        new("ja-JP-jis", "Japanese JIS", "jis", "Japan"),
        new("en-US-ansi", "English US (ANSI)", "us", "United States"),
        new("en-GB-iso", "English UK (ISO)", "us", "United Kingdom"),
        new("en-AU-ansi", "English Australia", "us", "Australia"),
        new("en-CA-ansi", "English Canada", "us", "Canada"),
        new("en-IN-ansi", "English India", "us", "India"),
        new("de-DE-qwertz", "German QWERTZ", "us", "Germany"),
        new("de-CH-qwertz", "Swiss German QWERTZ", "us", "Switzerland"),
        new("fr-FR-azerty", "French AZERTY", "us", "France"),
        new("fr-BE-azerty", "Belgian French AZERTY", "us", "Belgium"),
        new("fr-CA-qwerty", "Canadian French QWERTY", "us", "Canada"),
        new("es-ES-qwerty", "Spanish Spain", "us", "Spain"),
        new("es-Latam-qwerty", "Spanish Latin America", "us", "Latin America"),
        new("pt-PT-qwerty", "Portuguese Portugal", "us", "Portugal"),
        new("pt-BR-abnt2", "Portuguese Brazil ABNT2", "us", "Brazil"),
        new("it-IT-qwerty", "Italian", "us", "Italy"),
        new("nl-NL-qwerty", "Dutch", "us", "Netherlands"),
        new("da-DK-qwerty", "Danish", "us", "Denmark"),
        new("sv-SE-qwerty", "Swedish", "us", "Sweden"),
        new("no-NO-qwerty", "Norwegian", "us", "Norway"),
        new("fi-FI-qwerty", "Finnish", "us", "Finland"),
        new("pl-PL-programmers", "Polish Programmers", "us", "Poland"),
        new("cs-CZ-qwertz", "Czech QWERTZ", "us", "Czechia"),
        new("hu-HU-qwertz", "Hungarian QWERTZ", "us", "Hungary"),
        new("tr-TR-q", "Turkish Q", "us", "Türkiye"),
        new("ru-RU-jcuken", "Russian JCUKEN", "us", "Russia"),
        new("uk-UA-jcuken", "Ukrainian", "us", "Ukraine"),
        new("ko-KR-dubeolsik", "Korean Dubeolsik", "us", "Korea"),
        new("zh-CN-pinyin", "Chinese Simplified Pinyin", "us", "China"),
        new("zh-TW-zhuyin", "Chinese Traditional Zhuyin", "us", "Taiwan"),
        new("th-TH-kedmanee", "Thai Kedmanee", "us", "Thailand"),
    ];
}
