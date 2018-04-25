using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CsTrainings.CS5
{
    public class CallerInfo
    {
public void Log([CallerMemberName] string caller = null)
{
    Console.WriteLine($"Called by {caller}");
}

public void DoStuff()
{
    Log();
}
    }
}
