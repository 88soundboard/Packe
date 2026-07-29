namespace SoundBoard88.SetupLang;

public class Japan : SetupLangBase
{
    public override string Code => "ja";
    public override string WelcomeTitle => "88 SOUNDBOARD へようこそ";
    public override string InstructionText => "ダウンロードしてインストールする言語を選択してください。";
    public override string DownloadButtonText => "ダウンロードして開始";
    public override string FetchingListText => "言語リストを取得中...";
    public override string DownloadCompleteText => "ダウンロード完了！";
    public override string DownloadFailedText => "ダウンロードに失敗しました。インターネット接続を確認してください。";
    public override string ContinueOfflineText => "オフラインで続行";
}
