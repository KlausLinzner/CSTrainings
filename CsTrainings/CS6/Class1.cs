using System;

namespace CsTrainings.CS6
{
    public class ReadOnlyProperties
    {
        public ReadOnlyProperties(Guid id)
        {
            ReadOnly = id;
        }

public Guid ReadOnly { get; }
public string WithInitializer { get; } = "Value";
public int InitializerFromMethod { get; } = GetDefault();
public string Property { get; set; } = "DefaultValue";

        private static int GetDefault()
        {
        }
    }

    public class AutoPropertyInitializer
    {
        public string Id { get; } = "MyValue";
    }

    public class NullConditionalCalls
    {
        private Nested nested;
        private object o;

        public override string ToString()
        {
            return o?.ToString() ?? string.Empty;
        }

        public void DoStuff()
        {
            nested?.NestedMember?.NestedMember?.DoStuff();
        }

        public class Nested
        {
            public Nested NestedMember { get; set; }
            public void DoStuff();
        }
    }

    public class ExpressionBodiedMember
    {
        private NullConditionalCalls.Nested nested;

        private object o;
        public string Id => "NoIdea";

        public string GetId()
        {
            return Id;
        }

        public override string ToString()
        {
            return o?.ToString() ?? string.Empty;
        }

        public void DoStuff()
        {
            nested?.NestedMember?.NestedMember?.DoStuff();
        }

        public string WithCs7()
        {
            return nested?.ToString() ?? throw new NotSupportedException();
        }
    }

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

    public class StringInterpolation
    {
private string a;
public void DoStuff()
{
    var x = $"Current value of {nameof(a)} is {a}";
}
    }
}