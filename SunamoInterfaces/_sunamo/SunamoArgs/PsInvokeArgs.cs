namespace SunamoInterfaces._sunamo.SunamoArgs;

internal class PsInvokeArgs
{
    internal static readonly PsInvokeArgs Def = new();

    internal List<string>? AddBeforeEveryCommand { get; set; } = null;

    /// <summary>
    /// Immediately write to status (earlier false).
    /// </summary>
    internal bool IsImmediatelyToStatus { get; set; } = false;

    /// <summary>
    /// Path to save/load PowerShell output.
    /// If file exists, performs load to speed up execution.
    /// If it doesn't exist, executes commands and saves.
    /// Does not work with last modified date.
    /// </summary>
    internal string? PathToSaveLoadPsOutput { get; set; } = null;

    internal bool IsWritingProgressBar { get; set; } = false;
}