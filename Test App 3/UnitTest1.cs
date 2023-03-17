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

            StudentGrades converter = new StudentGrades();
            converter.Marks = "68";


            converter.ConvertDistance();

            expectedGrade = 1;

            Assert.AreEqual(expectedDistance, converter.ToDistance);
        }
    }
}