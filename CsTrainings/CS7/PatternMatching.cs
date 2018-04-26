using System;

namespace CsTrainings.CS7
{
    public class PatternMatching
    {
        public void DoSomething(object o)
        {
            if (o is A a)
                Console.WriteLine(a.AMember);
            else if (o is B b) Console.WriteLine(b.BMember);
        }

        public void DoSomethingElse(object o)
        {
            switch (o)
            {
                case A a:
                    Console.WriteLine(a.AMember);
                    break;
                case B b:
                    Console.WriteLine(b.BMember);
                    break;
            }
        }
    }

    public class A
    {
        public string AMember { get; set; }
    }

    public class B
    {
        public string BMember { get; set; }
    }

    public class C
    {
        public string CMember { get; set; }
    }
}