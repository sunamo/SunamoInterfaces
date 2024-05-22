namespace SunamoInterfaces;


/// <summary>
///     Must be in shared because desktop reference PathEditor and therefore this class cant be in desktop
/// </summary>
internal class ValidateData
{
    internal static readonly ValidateData Default = new ValidateData();
    internal bool allowEmpty = false;
    /// <summary>
    ///     Strings which are not allowed
    /// </summary>
    internal List<string> excludedStrings = new List<string>();
    internal string messageToReallyShow;
    internal string messageWhenValidateMethodFails = null;
    internal bool trim = true;
    internal Func<string, bool> validateMethod;
    // https://stackoverflow.com/a/43707185
    //[MethodImpl(MethodImplOptions.NoInlining)]
    internal int ValidateNotInline()
    {
        int i = 0;
        return i;
    }
}