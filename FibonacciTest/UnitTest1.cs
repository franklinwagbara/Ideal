using NUnit.Framework;
using System;
using System.IO;

public class FibonacciSeriesTests
{
    [Test]
    public void PrintFibonacciSeries_SmallValue()
    {
        using (StringWriter sw = new StringWriter())
        {
            Console.SetOut(sw);
            FibonacciSeries.PrintFibonacciSeries(5);
            string expectedOutput = "0\r\n1\r\n1\r\n2\r\n3\r\n";
            Assert.That(sw.ToString(), Is.EqualTo(expectedOutput));
        }
    }

    [Test]
    public void PrintFibonacciSeries_MediumValue()
    {
        using (StringWriter sw = new StringWriter())
        {
            Console.SetOut(sw);
            FibonacciSeries.PrintFibonacciSeries(10);
            string expectedOutput = "0\r\n1\r\n1\r\n2\r\n3\r\n5\r\n8\r\n13\r\n21\r\n34\r\n";
            Assert.That(sw.ToString(), Is.EqualTo(expectedOutput));
        }
    }

    [Test]
    public void PrintFibonacciSeries_EdgeCase_Zero()
    {
        using (StringWriter sw = new StringWriter())
        {
            Console.SetOut(sw);
            FibonacciSeries.PrintFibonacciSeries(0);
            string expectedOutput = "";
            Assert.That(sw.ToString(), Is.EqualTo(expectedOutput));
        }
    }

    [Test]
    public void PrintFibonacciSeries_EdgeCase_One()
    {
        using (StringWriter sw = new StringWriter())
        {
            Console.SetOut(sw);
            FibonacciSeries.PrintFibonacciSeries(1);
            string expectedOutput = "0\r\n";
            Assert.That(sw.ToString(), Is.EqualTo(expectedOutput));
        }
    }

    [Test]
    public void PrintFibonacciSeries_EdgeCase_Two()
    {
        using (StringWriter sw = new StringWriter())
        {
            Console.SetOut(sw);
            FibonacciSeries.PrintFibonacciSeries(2);
            string expectedOutput = "0\r\n1\r\n";
            Assert.That(sw.ToString(), Is.EqualTo(expectedOutput));
        }
    }

    [Test]
    public void PrintFibonacciSeries_NegativeInput()
    {
        using (StringWriter sw = new StringWriter())
        {
            Console.SetOut(sw);
            FibonacciSeries.PrintFibonacciSeries(-5);
            string expectedOutput = "Input must be a non-negative integer.\r\n";
            Assert.That(sw.ToString(), Is.EqualTo(expectedOutput));
        }
    }

    [Test]
    public void PrintFibonacciSeries_LargeValue()
    {
        using (StringWriter sw = new StringWriter())
        {
            Console.SetOut(sw);
            FibonacciSeries.PrintFibonacciSeries(47);
            string expectedOutput = "0\r\n1\r\n1\r\n2\r\n3\r\n5\r\n8\r\n13\r\n21\r\n34\r\n55\r\n89\r\n144\r\n233\r\n377\r\n610\r\n987\r\n1597\r\n2584\r\n4181\r\n6765\r\n10946\r\n17711\r\n28657\r\n46368\r\n75025\r\n121393\r\n196418\r\n317811\r\n514229\r\n832040\r\n1346269\r\n2178309\r\n3524578\r\n5702887\r\n9227465\r\n14930352\r\n24157817\r\n39088169\r\n63245986\r\n102334155\r\n165580141\r\n267914296\r\n433494437\r\n701408733\r\n1134903170\r\n1836311903\r\n";
            Assert.That(sw.ToString(), Is.EqualTo(expectedOutput));
        }
    }
}