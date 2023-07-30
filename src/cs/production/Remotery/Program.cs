using bottlenoselabs.C2CS.Runtime;
using Remotery;
using static Remotery.PInvoke;

internal sealed class Program
{
    static unsafe void aggregateFunction()
    {
        RmtBeginCPUSample((PInvoke.RmtPStr)(new CString("aggregate")), (PInvoke.RmtU32)(uint)RmtSampleFlags.RMTSFAggregate, null);
        RmtEndCPUSample();
    }

    static unsafe void recursiveFunction(int depth)
    {
        RmtBeginCPUSample((PInvoke.RmtPStr)(new CString("recursive")), (PInvoke.RmtU32)(uint)RmtSampleFlags.RMTSFRecursive, null);
        if (depth < 5)
        {
            recursiveFunction(depth + 1);
        }
        RmtEndCPUSample();
    }

    static unsafe double delay()
    {
        int i, end;
        double j = 0;

        RmtBeginCPUSample((PInvoke.RmtPStr)(new CString("delay")), (PInvoke.RmtU32)(uint)0, null);

        Random random = new Random();

        for (i = 0, end = (int)random.NextInt64() / 100; i < end; ++i)
        {
            j += Math.Sin(i);
        }
        recursiveFunction(0);
        aggregateFunction();
        aggregateFunction();
        aggregateFunction();
        RmtEndCPUSample();
        return j;
    }

    internal unsafe static void Main(string[] args)
    {
        PInvoke.Remotery* rmt;
        PInvoke.RmtError error;

        error = RmtCreateGlobalInstance(&rmt);

        while (true)
        {
            RmtLogText((RmtPStr)(new CString("Start profiling")));
            delay();
            RmtLogText((RmtPStr)(new CString("End profiling")));
        }

        RmtDestroyGlobalInstance(rmt);
        Console.WriteLine("Cleaned up and quit \n");
        return;
    }
}