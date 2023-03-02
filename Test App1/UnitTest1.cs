
using ConsoleAppProject.App01;
namespace Test_App1
{
    [TestClass]
    public class UnitTest1
    {
        int expectedDistance;
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
    }
}