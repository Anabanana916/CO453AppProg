
using ConsoleAppProject.App01;
namespace Test_App1
{
    [TestClass]
    public class UnitTest1
    {
        double expectedDistance;
        [TestMethod]
        public void FeetToMiles()
        {
            
            DistanceConverter converter = new DistanceConverter();
            converter.FromUnit = "feet";
            converter.ToUnit = "miles";
            converter.FromDistance = 5280;

            converter.ConvertDistance();

            expectedDistance = 1;

            Assert.AreEqual(expectedDistance, converter.ToDistance);
        }
        [TestMethod]
        public void MilesToFeet()
        {

            DistanceConverter converter = new DistanceConverter();
            converter.FromUnit = "miles";
            converter.ToUnit = "feet";
            converter.FromDistance = 1;

            converter.ConvertDistance();

            expectedDistance = 5280;

            Assert.AreEqual(expectedDistance, converter.ToDistance);
        }
        [TestMethod]
        public void MilesToMetres()
        {

            DistanceConverter converter = new DistanceConverter();
            converter.FromUnit = "miles";
            converter.ToUnit = "metres";
            converter.FromDistance = 2;

            converter.ConvertDistance();

            expectedDistance = 3218.68;

            Assert.AreEqual(expectedDistance, converter.ToDistance);
        }
        [TestMethod]
        public void MetresToMiles()
        {

            DistanceConverter converter = new DistanceConverter();
            converter.FromUnit = "metres";
            converter.ToUnit = "miles";
            converter.FromDistance = 3218.68;

            converter.ConvertDistance();

            expectedDistance = 2;

            Assert.AreEqual(expectedDistance, converter.ToDistance);
        }
        [TestMethod]
        public void MetresToFeet()
        {

            DistanceConverter converter = new DistanceConverter();
            converter.FromUnit = "metres";
            converter.ToUnit = "feet";
            converter.FromDistance = 2;

            converter.ConvertDistance();

            expectedDistance = 6.56168;

            Assert.AreEqual(expectedDistance, converter.ToDistance);
        }
        [TestMethod]
        public void FeetToMetres()
        {

            DistanceConverter converter = new DistanceConverter();
            converter.FromUnit = "feet";
            converter.ToUnit = "metres";
            converter.FromDistance = 6.56168;

            converter.ConvertDistance();

            expectedDistance = 2;

            Assert.AreEqual(expectedDistance, converter.ToDistance);
        }
    }
}