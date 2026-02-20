namespace TimeOutino.Core;

public enum NotificationMode
{
    Generic,
    Phrase,
    LocalAudio
}

public enum RestartPolicy
{
    Never,
    Snooze
}

public sealed record NotificationRequest(
    NotificationMode Mode,
    RestartPolicy Restart,
    string? AudioPath,
    IReadOnlyList<string>? Phrases);
