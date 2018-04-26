using System;
using System.Runtime.CompilerServices;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CsTrainings.CS5
{
    [TestClass]
    public class CallerInfo
    {
        public void Log([CallerMemberName] string caller = null)
        {
            Console.WriteLine($"Called by {caller}");
            //Called by DoStuff
        }

        [TestMethod]
        public void DoStuff()
        {
            Log();
        }

        public void LogDetailed([CallerMemberName] string caller = null,
            [CallerFilePath] string file = null,
            [CallerLineNumber] int line = 0)
        {
            Console.WriteLine($"Called by {caller} ({file} line {line})");
            //Called by DoDetailedStuff (C:\Github\CSTrainings\CsTrainings\CS5\CallerInfo.cs line 30)
        }

        [TestMethod]
        public void DoDetailedStuff()
        {
            LogDetailed();
        }

    }
}