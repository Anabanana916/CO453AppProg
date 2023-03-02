
using ConsoleAppProject.App02;
namespace Test_App2
{
    [TestClass]
    public class UnitTest1
    {
        double expectedBMI;
        [TestMethod]
        public void KGMetres()
        {

            BMICalculator converter = new BMICalculator();
            converter.WeightUnit = "KG";
            converter.HeightUnit = "metres";
            converter.Weight = 80;
            converter.Height = 1.9;

            converter.BMICalc();

            expectedBMI = 22.16;

            Assert.AreEqual(expectedBMI, converter.BMI);
        }
    }
}