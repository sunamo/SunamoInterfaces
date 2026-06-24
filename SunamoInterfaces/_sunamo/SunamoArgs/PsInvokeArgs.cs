namespace SunamoInterfaces._sunamo.SunamoArgs;

internal class PsInvokeArgs
{
    internal static readonly PsInvokeArgs Def = new();

    internal List<string>? AddBeforeEveryCommand { get; set; } = null;

    // Immediately write to status (earlier false).
    internal bool IsImmediatelyToStatus { get; set; } = false;

    // Path to save/load PowerShell output.
    // If file exists, performs load to speed up execution.
    // If it doesn't exist, executes commands and saves.
    // Does not work with last modified date.
    internal string? PathToSaveLoadPsOutput { get; set; } = null;

    internal bool IsWritingProgressBar { get; set; } = false;
}