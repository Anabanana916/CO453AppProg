
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

        [TestMethod]
        public void T4Obclass1()
        {
            BMICalculator converter = new BMICalculator();
            converter.WeightUnit = "KG";
            converter.HeightUnit = "metres";
            converter.Weight = 100;
            converter.Height = 1.8;
            converter.BMICalc();

            string expectedBMI = "You are obese class one.";

            Assert.AreEqual(expectedBMI, "You are obese class one.");
        }

        [TestMethod]
        public void T5Obclass2()
        {
            BMICalculator converter = new BMICalculator();
            converter.WeightUnit = "KG";
            converter.HeightUnit = "metres";
            converter.Weight = 120;
            converter.Height = 1.8;
            converter.BMICalc();

            string expectedBMI = "You are obese class two.";

            Assert.AreEqual(expectedBMI, "You are obese class two.");
        }

        [TestMethod]
        public void T6Obclass3()
        {
            BMICalculator converter = new BMICalculator();
            converter.WeightUnit = "KG";
            converter.HeightUnit = "metres";
            converter.Weight = 135;
            converter.Height = 1.8;
            converter.BMICalc();

            string expectedBMI = "You are obese class three.";

            Assert.AreEqual(expectedBMI, "You are obese class three.");
        }

        [TestMethod]
        public void T7Under()
        {
            BMICalculator converter = new BMICalculator();
            converter.WeightUnit = "stone";
            converter.HeightUnit = "metres";
            converter.Weight = 8;
            converter.Height = 1.8;
            converter.BMICalc();

            string expectedBMI = "You are underweight.";

            Assert.AreEqual(expectedBMI, "You are underweight.");
        }

        [TestMethod]
        public void T8Under()
        {
            BMICalculator converter = new BMICalculator();
            converter.WeightUnit = "KG";
            converter.HeightUnit = "feet";
            converter.Weight = 80;
            converter.Height = 6;
            converter.BMICalc();

            string expectedBMI = "You are normal weight.";

            Assert.AreEqual(expectedBMI, "You are normal weight.");
        }

        [TestMethod]
        public void T9Over()
        {
            BMICalculator converter = new BMICalculator();
            converter.WeightUnit = "KG";
            converter.HeightUnit = "metres";
            converter.Weight = 80;
            converter.Height = 1.6;
            converter.BMICalc();

            string expectedBMI = "You are overweight.";

            Assert.AreEqual(expectedBMI, "You are overweight.");
        }
    }
}