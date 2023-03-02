
using ConsoleAppProject.App02;
namespace Test_App2
{
    [TestClass]
    public class UnitTest2
    {
        double expectedBMI;
        [TestMethod]
        public void T1KGandMetres()
        {

            BMICalculator converter = new BMICalculator();
            converter.WeightUnit = "KG";
            converter.HeightUnit = "metres";
            converter.Weight = 80;
            converter.Height = 1.9;

            converter.BMICalc();

            expectedBMI = 22.16;

            Assert.AreEqual(expectedBMI, Math.Round(converter.BMI, 2));
        }

        [TestMethod]
        public void T2StoneandFeet()
        {

            BMICalculator converter = new BMICalculator();
            converter.WeightUnit = "stone";
            converter.HeightUnit = "feet";
            converter.Weight = 16;
            converter.Height = 6;

            converter.BMICalc();

            expectedBMI = 30.38;

            Assert.AreEqual(expectedBMI, Math.Round(converter.BMI, 2));
        }

        [TestMethod]
        public void T3NegValue()
        {

            BMICalculator converter = new BMICalculator();
            converter.WeightUnit = "KG";
            converter.HeightUnit = "metres";
            converter.Weight = -9;

            string expectedBMI = "Invalid input. Please enter a number greater than 0";

            Assert.AreEqual(expectedBMI, "Invalid input. Please enter a number greater than 0");
        }
    }

}