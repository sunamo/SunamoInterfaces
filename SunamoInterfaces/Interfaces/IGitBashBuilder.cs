namespace SunamoInterfaces.Interfaces;

/// <summary>
/// Interface for building Git bash command sequences.
/// </summary>
public interface IGitBashBuilder
{
    /// <summary>
    /// Gets the list of Git commands that have been built.
    /// </summary>
    List<string> Commands { get; }

    /// <summary>
    /// Adds files matching the specified pattern to the staging area.
    /// </summary>
    /// <param name="filePattern">The file pattern to add.</param>
    void Add(string filePattern);

    /// <summary>
    /// Adds a new remote repository.
    /// </summary>
    /// <param name="remoteName">The name of the remote to add.</param>
    void AddNewRemote(string remoteName);

    /// <summary>
    /// Appends text to the current command.
    /// </summary>
    /// <param name="text">The text to append.</param>
    void Append(string text);

    /// <summary>
    /// Appends a new line to the command sequence.
    /// </summary>
    void AppendLine();

    /// <summary>
    /// Appends text followed by a new line.
    /// </summary>
    /// <param name="text">The text to append.</param>
    void AppendLine(string text);

    /// <summary>
    /// Changes the current directory.
    /// </summary>
    /// <param name="directory">The directory to change to.</param>
    void Cd(string directory);

    /// <summary>
    /// Checks out the specified branch.
    /// </summary>
    /// <param name="branchName">The name of the branch to checkout.</param>
    void Checkout(string branchName);

    /// <summary>
    /// Cleans the working directory with the specified options.
    /// </summary>
    /// <param name="options">The clean command options.</param>
    void Clean(string options);

    /// <summary>
    /// Clears all accumulated commands.
    /// </summary>
    void Clear();

    /// <summary>
    /// Clones a repository from the specified URI.
    /// </summary>
    /// <param name="repoUri">The repository URI to clone from.</param>
    /// <param name="args">Additional arguments for the clone command.</param>
    void Clone(string repoUri, string args);

    /// <summary>
    /// Creates a commit with the specified message.
    /// </summary>
    /// <param name="isAddingAllUntrackedFiles">Whether to add all untracked files before committing.</param>
    /// <param name="commitMessage">The commit message.</param>
    void Commit(bool isAddingAllUntrackedFiles, string commitMessage);

    /// <summary>
    /// Sets a Git configuration value.
    /// </summary>
    /// <param name="configValue">The configuration value to set.</param>
    void Config(string configValue);

    /// <summary>
    /// Fetches from the specified remote.
    /// </summary>
    /// <param name="remoteName">The name of the remote to fetch from. Defaults to empty string.</param>
    void Fetch(string remoteName = "");

    /// <summary>
    /// Initializes a new Git repository.
    /// </summary>
    void Init();

    /// <summary>
    /// Merges the specified branch into the current branch.
    /// </summary>
    /// <param name="branchName">The name of the branch to merge.</param>
    void Merge(string branchName);

    /// <summary>
    /// Pulls changes from the remote repository.
    /// </summary>
    void Pull();

    /// <summary>
    /// Pushes changes to the remote repository.
    /// </summary>
    /// <param name="isForcing">Whether to force push.</param>
    void Push(bool isForcing);

    /// <summary>
    /// Pushes changes to the specified remote branch.
    /// </summary>
    /// <param name="remoteBranch">The remote branch to push to.</param>
    void Push(string remoteBranch);

    /// <summary>
    /// Executes a remote command with the specified arguments.
    /// </summary>
    /// <param name="arguments">The arguments for the remote command.</param>
    void Remote(string arguments);

    /// <summary>
    /// Shows the working tree status.
    /// </summary>
    void Status();

    /// <summary>
    /// Converts the command sequence to a string representation.
    /// </summary>
    /// <returns>The string representation of all commands.</returns>
    string ToString();
}