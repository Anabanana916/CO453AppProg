using ConsoleAppProject.App03;
namespace Test_App_3
{
    [TestClass]
    public class UnitTest1
    {
        private readonly StudentGrades converter = new StudentGrades();
        private int[] Marks = new int[]
            {
                10, 20, 30, 40, 50, 60, 70, 80, 90, 100
            };
        private int[] value;
        [TestMethod]
        public void Test39Fail()
        {
            Grades expectedGrade = Grades.F;
            
            Grades actualGrade = converter.ConvertToGrade(39);

            Assert.AreEqual(expectedGrade, actualGrade);
        }

        [TestMethod]
        public void Test0Fail()
        {
            Grades expectedGrade = Grades.F;

            Grades actualGrade = converter.ConvertToGrade(0);

            Assert.AreEqual(expectedGrade, actualGrade);
        }

        [TestMethod]
        public void TestMinD()
        {
            Grades expectedGrade = Grades.D;

            Grades actualGrade = converter.ConvertToGrade(40);

            Assert.AreEqual(expectedGrade, actualGrade);
        }

        [TestMethod]
        public void TestMaxD()
        {
            Grades expectedGrade = Grades.D;

            Grades actualGrade = converter.ConvertToGrade(49);

            Assert.AreEqual(expectedGrade, actualGrade);
        }

        [TestMethod]
        public void TestMinC()
        {
            Grades expectedGrade = Grades.C;

            Grades actualGrade = converter.ConvertToGrade(50);

            Assert.AreEqual(expectedGrade, actualGrade);
        }

        [TestMethod]
        public void TestMaxC()
        {
            Grades expectedGrade = Grades.C;

            Grades actualGrade = converter.ConvertToGrade(59);

            Assert.AreEqual(expectedGrade, actualGrade);
        }

        [TestMethod]
        public void TestMinB()
        {
            Grades expectedGrade = Grades.B;

            Grades actualGrade = converter.ConvertToGrade(60);

            Assert.AreEqual(expectedGrade, actualGrade);
        }

        [TestMethod]
        public void TestMaxB()
        {
            Grades expectedGrade = Grades.B;

            Grades actualGrade = converter.ConvertToGrade(69);

            Assert.AreEqual(expectedGrade, actualGrade);
        }

        [TestMethod]
        public void TestMinA()
        {
            Grades expectedGrade = Grades.A;

            Grades actualGrade = converter.ConvertToGrade(70);

            Assert.AreEqual(expectedGrade, actualGrade);
        }

        [TestMethod]
        public void TestMaxA()
        {
            Grades expectedGrade = Grades.A;

            Grades actualGrade = converter.ConvertToGrade(100);

            Assert.AreEqual(expectedGrade, actualGrade);
        }

        [TestMethod]
        public void TestInvalidEntry()
        {
            Grades actualGrade = converter.ConvertToGrade(150);

            string expectedGrade = "Error! Please enter a mark between 0 and 100.";

            Assert.AreEqual(expectedGrade, "Error! Please enter a mark between 0 and 100.");
        }

        [TestMethod]
        public void TestNegativeEntry()
        {
            Grades actualGrade = converter.ConvertToGrade(-10);

            string expectedGrade = "Error! Please enter a number between 0 and 100.";

            Assert.AreEqual(expectedGrade, "Error! Please enter a number between 0 and 100.");
        }

        [TestMethod]
        public void TestGradeProfile()
        {
            converter.Marks = Marks;
            bool expectedProfile = false;

            converter.CalculateGradeProfile();

            expectedProfile = (converter.GradeProfile[0] == 3) &&
                              (converter.GradeProfile[1] == 1) &&
                              (converter.GradeProfile[2] == 1) &&
                              (converter.GradeProfile[3] == 1) &&
                              (converter.GradeProfile[4] == 4);

            Assert.IsTrue(expectedProfile);
        }
    }
}