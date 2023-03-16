using ConsoleAppProject.App03;
namespace Test_App_3
{
    [TestClass]
    public class UnitTest1
    {
        double expectedGrade;
        [TestMethod]
        public void FeetToMiles()
        {

            DistanceConverter converter = new DistanceConverter();
            converter.FromUnit = "feet";
            converter.ToUnit = "miles";
            converter.FromDistance = 5280;

            converter.ConvertDistance();

            expectedGrade = 1;

            Assert.AreEqual(expectedDistance, converter.ToDistance);
        }
    }
}