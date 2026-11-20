namespace SunamoInterfaces.Interfaces;

/// <summary>
/// Represents the i git bash builder type.
/// </summary>
public interface IGitBashBuilder
{
    /// <summary>
    /// Gets the commands.
    /// </summary>
    List<string> Commands { get; }

    /// <summary>
    /// Add.
    /// </summary>
    /// <param name="filePattern">The file pattern.</param>
    /// <returns>The add result.</returns>
    void Add(string filePattern);

    /// <summary>
    /// Add new remote.
    /// </summary>
    /// <param name="filePattern">The file pattern.</param>
    void AddNewRemote(string remoteName);

    /// <summary>
    /// Append.
    /// </summary>
    /// <param name="remoteName">The remote name.</param>
    void Append(string text);

    /// <summary>
    /// Append line.
    /// </summary>
    /// <param name="text">The text.</param>
    void AppendLine();

    /// <summary>
    /// Append line.
    /// </summary>
    void AppendLine(string text);

    /// <summary>
    /// Cd.
    /// </summary>
    /// <param name="text">The text.</param>
    void Cd(string directory);

    /// <summary>
    /// Checkout.
    /// </summary>
    /// <param name="directory">The directory.</param>
    void Checkout(string branchName);

    /// <summary>
    /// Clean.
    /// </summary>
    /// <param name="branchName">The branch name.</param>
    void Clean(string options);

    /// <summary>
    /// Clear.
    /// </summary>
    /// <param name="options">The options.</param>
    void Clear();

    /// <summary>
    /// Clone.
    /// </summary>
    void Clone(string repoUri, string args);

    /// <summary>
    /// Commit.
    /// </summary>
    /// <param name="repoUri">The repo uri.</param>
    /// <param name="args">The args.</param>
    void Commit(bool isAddingAllUntrackedFiles, string commitMessage);

    /// <summary>
    /// Config.
    /// </summary>
    /// <param name="isAddingAllUntrackedFiles">The is adding all untracked files.</param>
    /// <param name="commitMessage">The commit message.</param>
    void Config(string configValue);

    /// <summary>
    /// Fetch.
    /// </summary>
    /// <param name="configValue">The config value.</param>
    void Fetch(string remoteName = "");

    /// <summary>
    /// Init.
    /// </summary>
    /// <param name="remoteName">The remote name.</param>
    void Init();

    /// <summary>
    /// Merge.
    /// </summary>
    void Merge(string branchName);

    /// <summary>
    /// Pull.
    /// </summary>
    /// <param name="branchName">The branch name.</param>
    void Pull();

    /// <summary>
    /// Push.
    /// </summary>
    void Push(bool isForcing);

    /// <summary>
    /// Push.
    /// </summary>
    /// <param name="isForcing">The is forcing.</param>
    void Push(string remoteBranch);

    /// <summary>
    /// Remote.
    /// </summary>
    /// <param name="remoteBranch">The remote branch.</param>
    void Remote(string arguments);

    /// <summary>
    /// Status.
    /// </summary>
    /// <param name="arguments">The arguments.</param>
    void Status();

    /// <summary>
    /// To string.
    /// </summary>
    string ToString();
}
