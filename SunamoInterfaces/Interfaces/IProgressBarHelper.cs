namespace SunamoInterfaces.Interfaces;

// Must be in sunamo because it's needed here, but DispatcherObject is not available in sunamo.
public interface IProgressBarHelper
{
    void Done();
    void DonePartially();
    IProgressBarHelper CreateInstance(object progressBar, double overall, object uiDispatcher);
}
