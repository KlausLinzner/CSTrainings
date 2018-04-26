using System;

namespace CsTrainings.CS6
{
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
}