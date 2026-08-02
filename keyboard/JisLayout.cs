namespace SoundBoard88.Keyboard;

/// <summary>1つのパッドキーの定義</summary>
public record KeyDef(
    string Code,    // KeyboardEvent.code 相当（識別子）
    string Label,   // 画面表示ラベル
    float  X,       // 左端位置（1u単位）
    float  W,       // 幅（1u単位）
    float  Row,     // 行番号（小数あり：矢印キーなど半行単位の配置に対応）
    float  H = 1f   // 高さ（1u単位）。デフォルトは通常キーと同じ1行分
);

public static class JisLayout
{
    public static readonly KeyDef[] Keys =
    [
        // ── Fnキー行 ────────────────────────────────────────
        new("Escape",       "ESC",    0f,    1f,    0f),
        new("F1",           "F1",     1.5f,  1f,    0f),
        new("F2",           "F2",     2.5f,  1f,    0f),
        new("F3",           "F3",     3.5f,  1f,    0f),
        new("F4",           "F4",     4.5f,  1f,    0f),
        new("F5",           "F5",     5.75f, 1f,    0f),
        new("F6",           "F6",     6.75f, 1f,    0f),
        new("F7",           "F7",     7.75f, 1f,    0f),
        new("F8",           "F8",     8.75f, 1f,    0f),
        new("F9",           "F9",     10f,   1f,    0f),
        new("F10",          "F10",    11f,   1f,    0f),
        new("F11",          "F11",    12f,   1f,    0f),
        new("F12",          "F12",    13f,   1f,    0f),

        // ── 数字行 ──────────────────────────────────────────
        new("Backquote",    "半/全",  0f,    1f,    1f),
        new("Digit1",       "1",      1f,    1f,    1f),
        new("Digit2",       "2",      2f,    1f,    1f),
        new("Digit3",       "3",      3f,    1f,    1f),
        new("Digit4",       "4",      4f,    1f,    1f),
        new("Digit5",       "5",      5f,    1f,    1f),
        new("Digit6",       "6",      6f,    1f,    1f),
        new("Digit7",       "7",      7f,    1f,    1f),
        new("Digit8",       "8",      8f,    1f,    1f),
        new("Digit9",       "9",      9f,    1f,    1f),
        new("Digit0",       "0",      10f,   1f,    1f),
        new("Minus",        "- =",    11f,   1f,    1f),
        new("Equal",        "^ ~",    12f,   1f,    1f),
        new("IntlYen",      "¥ |",    13f,   1f,    1f),
        new("Backspace",    "BS",     14f,   1.5f,  1f),

        // ── QWERTY行 ────────────────────────────────────────
        new("Tab",          "TAB",    0f,    1.5f,  2f),
        new("KeyQ",         "Q",      1.5f,  1f,    2f),
        new("KeyW",         "W",      2.5f,  1f,    2f),
        new("KeyE",         "E",      3.5f,  1f,    2f),
        new("KeyR",         "R",      4.5f,  1f,    2f),
        new("KeyT",         "T",      5.5f,  1f,    2f),
        new("KeyY",         "Y",      6.5f,  1f,    2f),
        new("KeyU",         "U",      7.5f,  1f,    2f),
        new("KeyI",         "I",      8.5f,  1f,    2f),
        new("KeyO",         "O",      9.5f,  1f,    2f),
        new("KeyP",         "P",      10.5f, 1f,    2f),
        new("BracketLeft",  "@ {",    11.5f, 1f,    2f),
        new("BracketRight", "[ {",    12.5f, 1f,    2f),
        new("Enter",        "ENTER",  13.5f, 2f,    2f),

        // ── ASDF行 ──────────────────────────────────────────
        new("CapsLock",     "英数",   0f,    1.75f, 3f),
        new("KeyA",         "A",      1.75f, 1f,    3f),
        new("KeyS",         "S",      2.75f, 1f,    3f),
        new("KeyD",         "D",      3.75f, 1f,    3f),
        new("KeyF",         "F",      4.75f, 1f,    3f),
        new("KeyG",         "G",      5.75f, 1f,    3f),
        new("KeyH",         "H",      6.75f, 1f,    3f),
        new("KeyJ",         "J",      7.75f, 1f,    3f),
        new("KeyK",         "K",      8.75f, 1f,    3f),
        new("KeyL",         "L",      9.75f, 1f,    3f),
        new("Semicolon",    "; +",    10.75f,1f,    3f),
        new("Quote",        ": *",    11.75f,1f,    3f),
        new("Backslash",    "] }",    12.75f,1.25f, 3f),

        // ── ZXCV行 ──────────────────────────────────────────
        new("ShiftLeft",    "SHIFT",  0f,    2.25f, 4f),
        new("KeyZ",         "Z",      2.25f, 1f,    4f),
        new("KeyX",         "X",      3.25f, 1f,    4f),
        new("KeyC",         "C",      4.25f, 1f,    4f),
        new("KeyV",         "V",      5.25f, 1f,    4f),
        new("KeyB",         "B",      6.25f, 1f,    4f),
        new("KeyN",         "N",      7.25f, 1f,    4f),
        new("KeyM",         "M",      8.25f, 1f,    4f),
        new("Comma",        ", <",    9.25f, 1f,    4f),
        new("Period",       ". >",    10.25f,1f,    4f),
        new("Slash",        "/ ?",    11.25f,1f,    4f),
        new("IntlRo",       "\\ _",   12.25f,1f,    4f),
        new("ShiftRight",   "SHIFT",  13.25f,1.75f, 4f),

        // ── スペース行 ──────────────────────────────────────
        new("ControlLeft",  "CTRL",   0f,    1.25f, 5f),
        new("MetaLeft",     "WIN",    1.25f, 1f,    5f),
        new("Lang2",        "英数",   2.25f, 1f,    5f),
        new("NonConvert",   "無変換", 3.25f, 1f,    5f),
        new("Space",        "SPACE",  4.25f, 3.5f,  5f),
        new("Convert",      "変換",   7.75f, 1f,    5f),
        new("KanaMode",     "かな",   8.75f, 1f,    5f),
        new("AltRight",     "ALT",    9.75f, 1f,    5f),
        new("ControlRight", "CTRL",   10.75f,1.25f, 5f),

        // ── 矢印クラスタ（スペース行と同じ高さ範囲に収まる逆T字配置）──
        // ── 矢印クラスタ（フルサイズ。↑は独立した行にして重なりを回避）──
        new("ArrowUp",      "↑",     17f,   1f,    4f),
        new("ArrowLeft",    "←",     16f,   1f,    5f),
        new("ArrowDown",    "↓",     17f,   1f,    5f),
        new("ArrowRight",   "→",     18f,   1f,    5f),

        // ── ナビクラスタ ────────────────────────────────────
        new("Insert",       "INS",    16f,   1f,    0f),
        new("Home",         "HOME",   17f,   1f,    0f),
        new("PageUp",       "PgUp",   18f,   1f,    0f),
        new("Delete",       "DEL",    16f,   1f,    1f),
        new("End",          "END",    17f,   1f,    1f),
        new("PageDown",     "PgDn",   18f,   1f,    1f),

        // ── テンキー（フル対応：ナビクラスタの右に実機配置）───
        new("NumLock",         "NUM",  20f, 1f, 0f),
        new("NumpadDivide",    "N /",  21f, 1f, 0f),
        new("NumpadMultiply",  "N *",  22f, 1f, 0f),
        new("NumpadSubtract",  "N -",  23f, 1f, 0f),
        new("Numpad7",         "N7",   20f, 1f, 1f),
        new("Numpad8",         "N8",   21f, 1f, 1f),
        new("Numpad9",         "N9",   22f, 1f, 1f),
        new("NumpadAdd",       "N +",  23f, 1f, 1f, 2f),
        new("Numpad4",         "N4",   20f, 1f, 2f),
        new("Numpad5",         "N5",   21f, 1f, 2f),
        new("Numpad6",         "N6",   22f, 1f, 2f),
        new("Numpad1",         "N1",   20f, 1f, 3f),
        new("Numpad2",         "N2",   21f, 1f, 3f),
        new("Numpad3",         "N3",   22f, 1f, 3f),
        new("NumpadEnter",     "N⏎",   23f, 1f, 3f, 2f),
        new("Numpad0",         "N0",   20f, 2f, 4f),
        new("NumpadDecimal",   "N.",   22f, 1f, 4f),
    ];
}

