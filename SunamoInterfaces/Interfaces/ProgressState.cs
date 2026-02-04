namespace SunamoInterfaces.Interfaces;

/// <summary>
/// Manages progress state and progress events.
/// </summary>
public class ProgressState
{
    private int currentCount;

    /// <summary>
    /// Gets or sets a value indicating whether progress events are registered.
    /// </summary>
    public bool IsRegistered { get; set; }

    /// <summary>
    /// Initializes progress tracking with event handlers.
    /// </summary>
    /// <param name="overallSongs">Handler for overall song count updates.</param>
    /// <param name="anotherSong">Handler for individual song progress updates.</param>
    /// <param name="writeProgressBarEnd">Handler for progress completion.</param>
    public void Init(Action<int> overallSongs, Action<int> anotherSong, Action writeProgressBarEnd)
    {
        IsRegistered = true;
        this.AnotherSong += anotherSong;
        this.OverallSongs += overallSongs;
        this.WriteProgressBarEnd += writeProgressBarEnd;
    }

    /// <summary>
    /// Event raised when another song is processed.
    /// </summary>
    public event Action<int>? AnotherSong;

    /// <summary>
    /// Event raised when the overall song count is set.
    /// </summary>
    public event Action<int>? OverallSongs;

    /// <summary>
    /// Event raised when progress bar ends.
    /// </summary>
    public event Action? WriteProgressBarEnd;

    /// <summary>
    /// Increments and raises the another song event with the current count.
    /// </summary>
    public void OnAnotherSong()
    {
        currentCount++;
        OnAnotherSong(currentCount);
    }

    /// <summary>
    /// Raises the another song event with the specified count.
    /// </summary>
    /// <param name="count">The current song count.</param>
    public void OnAnotherSong(int count)
    {
        AnotherSong?.Invoke(count);
    }

    /// <summary>
    /// Sets the overall song count and raises the overall songs event.
    /// </summary>
    /// <param name="totalCount">The total song count.</param>
    public void OnOverallSongs(int totalCount)
    {
        currentCount = 0;
        OverallSongs?.Invoke(totalCount);
    }

    /// <summary>
    /// Raises the progress bar end event.
    /// </summary>
    public void OnWriteProgressBarEnd()
    {
        WriteProgressBarEnd?.Invoke();
    }
}