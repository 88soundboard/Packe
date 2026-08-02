namespace SoundBoard88.SetupLang;

public abstract class SetupLangBase
{
    public abstract string Code { get; }
    public abstract string WelcomeTitle { get; }
    public abstract string InstructionText { get; }
    public abstract string DownloadButtonText { get; }
    public abstract string FetchingListText { get; }
    public abstract string DownloadCompleteText { get; }
    public abstract string DownloadFailedText { get; }
    public abstract string ContinueOfflineText { get; }
}
