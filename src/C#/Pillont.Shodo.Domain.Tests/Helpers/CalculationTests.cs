
using Pillont.Shodo.Domain.Helpers;

namespace Pillont.Shodo.Domain.Tests.Helpers;

public class CalculationTests
{
    [Fact]
    public void Add_PositiveNumber_ShouldMakeSum()
    {
        var res = Calculation.Add(1, 1);
        Assert.Equal(2, res);

        res = Calculation.Add(5, 8);
        Assert.Equal(13, res);


        res = Calculation.Add(100, 10);
        Assert.Equal(110, res);
    }


    [Fact]
    public void Add_NegatifNumber_ShouldMakeSubtract()
    {
        var res = Calculation.Add(1, -1);
        Assert.Equal(0, res);

        res = Calculation.Add(-5, 8);
        Assert.Equal(3, res);

        res = Calculation.Add(-100, 10);
        Assert.Equal(-90, res);

        res = Calculation.Add(-10, -10);
        Assert.Equal(-20, res);
    }

    [Fact]
    public void Add_Zero_ShouldReturnTheOtherNumber()
    {
        var res = Calculation.Add(1, 0);
        Assert.Equal(1, res);

        res = Calculation.Add(-5, 0);
        Assert.Equal(-5, res);


        res = Calculation.Add(0, 10);
        Assert.Equal(10, res);

        res = Calculation.Add(0, 0);
        Assert.Equal(0, res);
    }

    [Fact]
    public void Add_MaxValue_ShouldThrowIfUpper()
    {
        Assert.Throws<ArgumentException>(() => Calculation.Add(1, int.MaxValue));

        Assert.Throws<ArgumentException>(() => Calculation.Add(8, int.MaxValue));

        var res = Calculation.Add(-5, int.MaxValue);
        Assert.Equal(2147483642, res);
    }

    [Fact]
    public void Add_MinValue_ShouldThrowIfLower()
    {
        Assert.Throws<ArgumentException>(() => Calculation.Add(-5, int.MinValue));
        Assert.Throws<ArgumentException>(() => Calculation.Add(-8, int.MinValue));
    }

    [Fact]
    public void Add_MinValue_ShouldReturnIfIsExactlyTheValue()
    {
        var res = Calculation.Add(0, int.MinValue);
        Assert.Equal(-2147483648, res);


        res = Calculation.Add(-2147483638, -10);
        Assert.Equal(-2147483648, res);
    }

    [Fact]
    public void Add_MaxValue_ShouldReturnIfIsExactlyTheValue()
    {
        var res = Calculation.Add(0, int.MaxValue);
        Assert.Equal(2147483647, res);


        res = Calculation.Add(2147483637, 10);
        Assert.Equal(2147483647, res);
    }
}
