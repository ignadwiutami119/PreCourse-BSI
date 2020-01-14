using System;
using PreCourse;
using Xunit;
using System.Collections.Generic;
using System.Collections;

namespace My_pre_test
{
    public class cek1
    {
        [Fact]
        public void Test1()
        {
            Assert.Equal("igna", Program.callname("igna"));
        }
    }

    public class cek2
    {
        [Fact]
        public void Test2()
        {
            Assert.NotEqual(30, year.gapYear("1997/03/19"));
        }
    }

    public class cek3
    {
        [Fact]
        public void Test3()
        {
            Assert.Equal(5, panjangKata.CountString("abcde"));
        }
    }

    public class cek4
    {
        [Fact]
        public void Test4()
        {
            var censoredWords = new ArrayList();
            censoredWords.Add("imperdiet");
            censoredWords.Add("dolor");
            censoredWords.Add("duo");
            Assert.Equal("Lorem ipsum ***** sit amet, ********* vituperata *** in, nonumy.", Subs.Cek("Lorem ipsum dolor sit amet, imperdiet vituperata duo in, nonumy.", censoredWords));
        }
    }

    public class cek5
    {
        [Fact]
        public void Test5()
        {
            Assert.True(EvenOdd.isOdd(5));
            Assert.True(EvenOdd.isEven(6));
        }
    }
}

public class cek6
{
    [Fact]
    public void Test6()
    {
        Assert.Equal('A', Grade.Grading(95));
        Assert.Equal('B', Grade.Grading(85));
        Assert.Equal('C', Grade.Grading(75));
        Assert.Equal('D', Grade.Grading(65));
        Assert.Equal('E', Grade.Grading(55));
    }
}

public class cek7
{
    [Fact]
    public void Test7()
    {
        Assert.Equal(212, Temperature.CelciusToFahrenheit(100));
        Assert.Equal(373.15, Temperature.CelciusToKelvin(100));
        Assert.Equal(-173.15, Temperature.KelvinToCelcius(100));
        Assert.Equal(-279.67, Temperature.KelvinToFahrenheit(100));
        Assert.Equal(37.78, Temperature.FahrenheitToCelcius(100));
        Assert.Equal(310.928, Temperature.FahrenheitToKelvin(100));
    }
}

public class cek8
{
    [Fact]
    public void Test8()
    {
        Assert.True(LeapYear.IsLeapYear(2024));
    }
}

public class cek9
{
    [Fact]
    public void Test9()
    {
        var jakarta = Tuple.Create("Jakarta", 7);
        var bali = Tuple.Create("Bali", 8);
        var london = Tuple.Create("London", 0);
        var cairo = Tuple.Create("Cairo", 2);
        var denver = Tuple.Create("Denver", -6);
        var chicago = Tuple.Create("Chicago", -5);
        Assert.Equal(7, Timezone.TimezoneDiff(jakarta, london));
    }
}

public class cek10
{
    [Fact]
    public void Test10()
    {
        Assert.Equal(20, Calculator.Sum(10, 10));
        Assert.Equal(100, Calculator.Multiply(10, 10));
        Assert.Equal(0, Calculator.Substract(10, 10));
        Assert.Equal(1, Calculator.Divide(10, 10));
    }
}


public class cek11
{
    [Fact]
    public void Test11()
    {
        Assert.Equal(3, CountWords.Count("berlian sistem informasi"));
    }
}

public class cek12
{
    [Fact]
    public void Test12()
    {
        Assert.Equal("ABCDEFG", Uppercase.cekUpper("abcdefg"));
    }
}

public class cek13
{
    int[] num = {1,2,3,4,5};
    [Fact]
    public void Test13()
    {
        Assert.Equal(15, Sum.jumlah(num));
    }
}


public class cek14
{
    [Fact]
    public void Test14()
    {
        Assert.True(Palindrom.IsPalindrome("kasur rusak"));
    }
}

public class cek15
{
    [Fact]
    public void Test15()
    {
        Assert.Equal("bookkoob", MirrorClass.Mirror("book"));
    }
}

public class cek16
{
    [Fact]
    public void Test16()
    {
        string[] fruits = {
                "Jeruk",
                "Apel",
                "Anggur",
                "Pepaya",
                "Pisang",
                "Kiwi",
                "Markisa",
            };
            Assert.Equal(5, FruitFinder.IndexFinder(fruits, "Kiwi"));
    }
}

public class cek17
{
    [Fact]
    public void Test17()
    {
        Assert.Equal("Baz", foobarbaz.value(100));
        Assert.Equal("Foo", foobarbaz.value(25));
        Assert.Equal("Bar", foobarbaz.value(40));
    }
}

public class cek18
{
    int[] numbers = { 2, 4, 54, 12, -65, 19, 40, 92, 88, 330, -4, 54 };
    [Fact]
    public void Test18()
    {
        Assert.Equal(330, MinMaxAvg.FindMax(numbers));
        Assert.Equal(-65, MinMaxAvg.FindMin(numbers));
        Assert.Equal(52, MinMaxAvg.FindAverage(numbers));
    }
}

public class cek19
{
     int[] number = { 2, 4, 54, 12, -65, 19, 40, 92, 88, 330, -4, 56 };
     int[] expected = {-65, -4, 2, 4, 12, 19, 40, 54, 56, 88, 92, 330};
     [Fact]
    public void Test19()
    {
        Assert.Equal(expected, Sorter.Sort(number));
    }
}

// public class cek20
// {
//      [Fact]
//     public void Test20()
//     {
//         Assert.Equal(10000, Item.print(15000));
//     }
// }