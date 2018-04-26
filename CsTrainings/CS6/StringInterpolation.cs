using System.Text;

namespace CsTrainings.CS6
{
    public class StringInterpolation
    {
        private string a;

        public void DoStuff()
        {
            var x = $"Current value of {nameof(a)} is {a}";
        }

        public void Differences()
        {
            var x = $"Field is called {nameof(a)}";
            var y = "Field is called " + nameof(a);

            var z = $"Field" + $" is called {nameof(a)}";
        }

        public void StringConcatenation()
        {
            var a = "A";
            var b = "B";
            var c = "C";

            var d = a + b + c;
            var e = $"{a}{b}{c}";
            var sb = new StringBuilder();
            sb.Append(a);
            sb.Append(b);
            sb.Append(c);
            var f = sb.ToString();
        }
    }
}