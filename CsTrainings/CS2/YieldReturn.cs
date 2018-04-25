using System;
using System.Collections.Generic;

namespace CsTrainings.CS2
{
    public class YieldReturn
    {
public IEnumerable<int> GetFromTo(int start, int end)
{
    if (start > end) throw new ArgumentOutOfRangeException();

    for (int i = start; i < end; i++)
        yield return i;
}

public void UseIterator()
{
    var enumerable = GetFromTo(15, 20);

    foreach (var i in enumerable)
        Console.WriteLine(i);
}
    }
}
