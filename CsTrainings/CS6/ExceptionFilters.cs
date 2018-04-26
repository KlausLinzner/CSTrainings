using System;

namespace CsTrainings.CS6
{
    public class ExceptionFilters
    {
        public void DoStuff()
        {
        }

        public void Caller()
        {
            try
            {
                DoStuff();
            }
            catch (NotSupportedException nex) when (nex.Message == "It's OK after all")
            {
            }


            try
            {
                DoStuff();
            }
            catch (NotSupportedException nex)
            {
                if (nex.Message != "It's OK after all") throw;
            }
        }
    }
}