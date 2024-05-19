namespace
#if SunamoGitBashBuilder
SunamoGitBashBuilder
#elif SunamoPS
SunamoPS
#elif SunamoShared
SunamoShared
#elif SunamoTextOutputGenerator
SunamoTextOutputGenerator
#elif SunamoDevCode
SunamoDevCode
#else
SunamoInterfaces
#endif
;
public interface ITextBuilder
{
    bool CanUndo { get; set; }
    List<string> list { get; set; }
    void Append(object s);
    void Append(string s);
    void AppendLine();
    void AppendLine(string s);
    void Clear();
    string ToString();
    void Undo();
    string prependEveryNoWhite { get; set; }
}