namespace SoundBoard88.SetupLang;

public class English : SetupLangBase
{
    public override string Code => "en";
    public override string WelcomeTitle => "Welcome to 88 SOUNDBOARD";
    public override string InstructionText => "Please select your language to download and install.";
    public override string DownloadButtonText => "Download & Start";
    public override string FetchingListText => "Fetching language list...";
    public override string DownloadCompleteText => "Download complete!";
    public override string DownloadFailedText => "Download failed. Please check your internet connection.";
    public override string ContinueOfflineText => "Continue Offline";
}
