using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsTrainings.CS7
{
    public class Snippets
    {
        public void OutTuples()
        {
            string input = "123";

            if (int.TryParse(input, out var i))
            {
                Console.WriteLine(i);
            }

            if (int.TryParse(input, out int j))
            {
                Console.WriteLine(i);
                Console.WriteLine(j);
            }


        }

public (string firstname, string lastname) GetName()
{
    return ("Klaus", "Linzner");
}

public void Caller()
{
    var x = GetName();
    Console.WriteLine($"{x.firstname} {x.lastname}");
}



    }
}
