using System;
using AoC22.Solutions.Day1;

namespace AoC22.Tests.Day1;

public class CalorieSumTests
{
    [Fact]
    public void TopThreeElvesWithMostCaloriesIsUsedWhenSummarising()
    {
        var input = @"1000
2000
3000

2000
5000

1500
1000

8000
1500
2000

21000

300
600
";

        var calculator = new ElfCalorieCalculator(input, Environment.NewLine);
        var result = calculator.GetSumOfCaloriesForThreeElvesWithHighest();
        result.Should().Be(39500);
    }
    
    [Fact]
    public void SumOfAllElvesUsedIfLessThanThreeElves()
    {
        var input = @"1000
2000
3000

2000
5000
";

        var calculator = new ElfCalorieCalculator(input, Environment.NewLine);
        var result = calculator.GetSumOfCaloriesForThreeElvesWithHighest();
        result.Should().Be(13000);
    }
}