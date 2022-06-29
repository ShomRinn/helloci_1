using System;
using Calculator;
using Microsoft.Extensions.Configuration;
using NUnit.Framework;

namespace CalculatorTest
{
    [TestFixture]
    public class TestCalculator
    {
        [OneTimeSetUp]
        public void Setup() => Console.WriteLine("Starting TestHelloWorld tests");

    }
}
