namespace CsTrainings.CS6
{
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

            public void DoStuff()
            {
            }
        }
    }
}