using System.Timers;
using Timer = System.Timers.Timer;

namespace SunamoInterfaces.Interfaces;

public class SunamoTimer
{
    private readonly Action a;
    protected Timer t;

    public SunamoTimer(int ms, Action a, bool runImmediately)
    {
        t = new Timer(ms);
        t.Elapsed += t_Elapsed;
        t.AutoReset = true;

        this.a = a;
        t.Start();

        if (runImmediately) t_Elapsed(null, null);
    }

    public event Action Tick;

    private void t_Elapsed(object sender, ElapsedEventArgs e)
    {
        try
        {
            a.Invoke();
        }
        catch (Exception)
        {
            // often The calling thread cannot access this object because a different thread owns it.'
        }

        if (Tick != null) Tick();
    }
}