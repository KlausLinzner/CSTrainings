using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsTrainings.CS7
{
    public class LocalFunctions
    {
        public void DoStuff(Dictionary<string, string> dict)
        {
            foreach (var kvp in dict)
            {
                Console.WriteLine(Format(kvp));
            }

            string Format(KeyValuePair<string, string> kvp)
            {
                return string.IsNullOrEmpty(kvp.Value)
                    ? $"Kvp: {kvp.Key}"
                    : $"Kvp : {kvp.Key} == {kvp.Value}";
            }
        }
    }
}
