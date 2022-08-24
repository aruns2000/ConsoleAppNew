global using Microsoft.VisualStudio.TestTools.UnitTesting;

using ConsoleAppNew;
namespace TestProjectForCalculator;

    [TestClass]
    public class TestCalculator
    {
        [TestMethod]
        public void TestAdd()
        {
        Calculator c = new Calculator();
        int result = ConsoleAppNew.Calculator.add(10, 20);
        Assert.AreEqual(30, result);
        }
    }

