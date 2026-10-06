namespace SunamoInterfaces.Interfaces;

public interface IGitBashBuilder
{
    List<string> Commands { get; }

    void Add(string filePattern);

    void AddNewRemote(string remoteName);

    void Append(string text);

    void AppendLine();

    void AppendLine(string text);

    void Cd(string directory);

    void Checkout(string branchName);

    void Clean(string options);

    void Clear();

    void Clone(string repoUri, string args);

    void Commit(bool isAddingAllUntrackedFiles, string commitMessage);

    void Config(string configValue);

    void Fetch(string remoteName = "");

    void Init();

    void Merge(string branchName);

    void Pull();

    void Push(bool isForcing);

    void Push(string remoteBranch);

    void Remote(string arguments);

    void Status();

    string ToString();
}
