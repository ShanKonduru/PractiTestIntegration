using System;
using MyCalc;

namespace TestMyCalc;

[TestClass]
public class UnitTestCalculator
{
    public TestContext? TestContext { get; set; }

    private static TestContext? _testContext;

    [ClassInitialize]
    public static void SetupTests(TestContext testContext)
    {
        _testContext = testContext;
    }

    [TestMethod]
    [TestCategory("PositiveTest")]
    [TestCategory("Add")]
    [TestCategory("Regression")]
    public void TestCalculatorAddMethod()
    {
        int result = MyCalc.Calculator.Add(10, 20);
        Assert.AreEqual(30, result, "Add method failed.");
    }

        [TestMethod]
    [TestCategory("PositiveTest")]
    [TestCategory("Div")]
    [Ignore]
    [TestCategory("Regression")]
    public void TestCalculatorDivMethod()
    {
        float expected = 3.3333F;
        float result = MyCalc.Calculator.Div(10, 3);
        Assert.AreEqual(3.3333, result, "Div method failed.");
        Assert.IsTrue(Calculator.FloatNearlyEqual(expected, result, 0.00001F), "Div method failed.");
    }


    [DataRow(0, 0, 0)]
    [DataRow(1, 1, 2)]
    [DataRow(2, 1, 3)]
    [DataRow(80, 20, 100)]
    [DataRow(800, 200, 1000)]
    [DataRow(8000, 2000, 10000)]
    [DataRow(80000, 20000, 100000)]
    [DataTestMethod]
    [TestCategory("Add")]
    [TestCategory("PositiveTest")]
    [TestCategory("Regression")]
    public void DataTestCalculatorAddMethod(int operand1, int operand2, int expectedresult)
    {
        int result = MyCalc.Calculator.Add(operand1, operand2);
        Assert.AreEqual(expectedresult, result, "Add method failed.");
    }

    [DataTestMethod]
    [TestCategory("Sub")]
    [DynamicData(nameof(SubGetData), DynamicDataSourceType.Method)]
    [TestCategory("PositiveTest")]
    [TestCategory("Regression")]
    public void TestSubDynamicDataMethod(int a, int b, int expected)
    {
        int result = MyCalc.Calculator.Sub(a, b);
        Assert.AreEqual(expected, result, "Sub method failed.");
    }
    public static IEnumerable<object[]> SubGetData()
    {
        yield return new object[] { 10, 5, 5 };
        yield return new object[] { 30, 15, 15 };
        yield return new object[] { 30, 20, 10 };
    }

    [DataTestMethod]
    [TestCategory("Mul")]
    [DynamicData(nameof(MulGetData), DynamicDataSourceType.Method)]
    [TestCategory("PositiveTest")]
    [TestCategory("Regression")]
    public void TestMulDynamicDataMethod(int a, int b, int expected)
    {
        int result = MyCalc.Calculator.Mul(a, b);
        Assert.AreEqual(expected, result, "Mul method failed.");
    }
    public static IEnumerable<object[]> MulGetData()
    {
        yield return new object[] { 10, 5, 50 };
        yield return new object[] { 30, 15, 450 };
        yield return new object[] { 30, 20, 600 };
    }

    [DataTestMethod]
    [TestCategory("Add")]
    [TestCategory("PositiveTest")]
    [DynamicData(nameof(AddGetData), DynamicDataSourceType.Method)]
    [TestCategory("Regression")]
    public void TestAddDynamicDataMethod(int a, int b, int expected)
    {
        int result = MyCalc.Calculator.Add(a, b);
        Assert.AreEqual(expected, result, "Add method failed.");
    }
    public static IEnumerable<object[]> AddGetData()
    {
        yield return new object[] { 1, 1, 2 };
        yield return new object[] { 12, 30, 42 };
        yield return new object[] { 14, 1, 15 };
    }

    [TestMethod]
    [Ignore]
    [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", "DataDrivenTest.csv", "DataDrivenTest#csv", DataAccessMethod.Sequential)]
    [TestCategory("Regression")]
    [TestCategory("PositiveTest")]
    public void DataDrivenTest()
    {
        // int valueA = Convert.ToInt32(_testContext.DataRow["Op1"]);
        // int valueB = Convert.ToInt32(_testContext.DataRow["Op2"]);
        // int expected = Convert.ToInt32(_testContext.DataRow["expectedResult"]);
    }

    [TestMethod]
    [TestCategory("NegativeTest")]
    [TestCategory("Add")]
    [TestCategory("Regression")]
    public void TestCalculatorAddMethod_NegativeNumbers()
    {
        int result = MyCalc.Calculator.Add(-10, -20);
        Assert.AreEqual(-30, result, "Add method failed.");
    }

    [TestMethod]
    [TestCategory("NegativeTest")]
    [TestCategory("Add")]
    [TestCategory("Regression")]
    public void TestCalculatorAddMethod_PositiveAndNegativeNumbers()
    {
        int result = MyCalc.Calculator.Add(-10, 20);
        Assert.AreEqual(10, result, "Add method failed.");
    }

    [TestMethod]
    [TestCategory("PositiveTest")]
    [TestCategory("Sub")]
    [TestCategory("Regression")]
    public void TestCalculatorSubMethod()
    {
        int result = MyCalc.Calculator.Sub(10, 20);
        Assert.AreEqual(-10, result, "Sub method failed.");
    }

    [TestMethod]
    [TestCategory("NegativeTest")]
    [TestCategory("Sub")]
    [TestCategory("Regression")]
    public void TestCalculatorSubMethod_NegativeNumbers()
    {
        int result = MyCalc.Calculator.Sub(-10, -20);
        Assert.AreEqual(10, result, "Sub method failed.");
    }

    [TestMethod]
    [TestCategory("NegativeTest")]
    [TestCategory("Sub")]
    [TestCategory("Regression")]
    public void TestCalculatorSubMethod_PositiveAndNegativeNumbers()
    {
        int result = MyCalc.Calculator.Sub(-10, 20);
        Assert.AreEqual(-30, result, "Sub method failed.");
    }
}