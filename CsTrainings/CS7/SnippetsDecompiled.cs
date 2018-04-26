using System;

namespace CsTrainings.CS7
{
    public class SnippetsDecompiled
    {
        public void OutTuples()
        {
            string s = "123";
            int value;
            bool flag = int.TryParse(s, out value);
            if (flag)
            {
                Console.WriteLine(value);
            }
            int value2;
            bool flag2 = int.TryParse(s, out value2);
            if (flag2)
            {
                Console.WriteLine(value);
                Console.WriteLine(value2);
            }
        }

        public System.ValueTuple<string, string> GetName()
        {
            return new System.ValueTuple<string, string>("Klaus", "Linzner");
        }

        public void Caller()
        {
            System.ValueTuple<string, string> name = this.GetName();
            Console.WriteLine(string.Format("{0} {1}", name.Item1, name.Item2));
        }
    }
}