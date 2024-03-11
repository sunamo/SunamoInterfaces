namespace SunamoInterfaces.Interfaces;
using SunamoDelegates;


[ComVisible(true)]
[InterfaceType(ComInterfaceType.InterfaceIsDual)]
public interface IControlWithResultDebug : IControlWithResult
{
    int CountOfHandlersChangeDialogResult();
    void AttachChangeDialogResult(VoidBoolNullable a, bool throwException = true);
}