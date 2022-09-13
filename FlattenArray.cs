using System;
using System.Collections;

public static class FlattenArray
{
    public static IEnumerable Flatten(IEnumerable input)
    {
        throw new NotImplementedException("You need to implement this function.");
    }
}using System;
using System.Linq;
using System.Collections;
public static class FlattenArray
{
    // 9:24-9:28
    public static IEnumerable Flatten(IEnumerable input)
    {
        foreach(var i in input)
        {
            if (i is IEnumerable)
            {
                foreach (var v in Flatten((IEnumerable)i))
                {
                    yield return v;
                }
            }
            else if (i != null)
            {
                yield return i;
            }
        }
    }
}