using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CsTrainings.CS5
{
    
    public class CallerInfoWithUsing
    {
public void Old()
{
    Console.WriteLine("--> Old");
    //DoStuff
    Console.WriteLine("<--Old");
}

public void New()
{
    using (Utils.LogMethod())
    {
        //DoStuff
    }
}
}

public static class Utils
{
public static IDisposable LogMethod([CallerMemberName] string method = null)
{
    Console.WriteLine("-->" + method);
    return new LogOutputDisposable(method);
}

        internal class LogOutputDisposable : IDisposable
        {
            private readonly string method;

            public LogOutputDisposable(string method)
            {
                this.method = method;
            }

            public void Dispose()
            {
                Console.WriteLine("<--" + method);
            }
        }
    }
}
