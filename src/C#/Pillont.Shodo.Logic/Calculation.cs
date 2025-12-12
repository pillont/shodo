namespace pillont.Shodo.Logic;

public static class Calculation
{
    /// <summary>
    /// Make a sum of two number
    /// </summary>
    /// <exception cref="ArgumentException">summ bigger than <code>int.MaxValue</code></exception>
    /// <exception cref="ArgumentException">summ smaller than <code>int.MinValue</code></exception>
    public static int Add(int a, int b)
    {
        long aAsLong = a;
        var bAsLong = b;

        long res = aAsLong + bAsLong;

        AssertIsValidAsInt(res);

        return (int)res;
    }

    private static void AssertIsValidAsInt(long res)
    {
        if (res > int.MaxValue)
            throw new ArgumentException("number too big");

        if (res < int.MinValue)
            throw new ArgumentException("number too small");
    }
}
