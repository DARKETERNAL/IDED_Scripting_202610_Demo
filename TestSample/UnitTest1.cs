namespace TestSample
{
    public class Tests
    {
        private Student studentA;
        private Student studentB;
        private Student studentC;
        private Student studentD;
        private Student studentE;

        [SetUp]
        public void Setup()
        {
            studentA = new Student("0000000001", "Carolina García");
            studentB = new Student("0000000012", "hdkjashkjdas");
            studentC = new Student("0000000123", "bhdkjsakjdas");
            studentD = new Student("0000001234", "hdkjsahdkjsan");
            studentE = new Student("1234567890", "jdkahjkdhsak");
        }

        [Test]
        public void TestCreateStudent()
        {
            // 0000000001
            // 0000000012
            // 0000000123
            // 0000001234

            // 00-0000001

            Assert.That(studentA.IDIsValid(), "Student ID is invalid");
            Assert.That(studentB.IDIsValid(), "Student ID is invalid");
            Assert.That(studentC.IDIsValid(), "Student ID is invalid");
            Assert.That(studentD.IDIsValid(), "Student ID is invalid");
            Assert.That(studentE.IDIsValid(), "Student ID is invalid");

            Assert.That(studentA.Name, Is.Not.Null);
            Assert.That(studentA.Name, Is.Not.EqualTo(string.Empty));

            Assert.That(studentB.Name, Is.Not.Null);
            Assert.That(studentB.Name, Is.Not.EqualTo(string.Empty));
        }

        [Test]
        public void TestAddStudentToCourse()
        {
            Course courseA = new Course();

            Assert.That(courseA.AddStudent(studentA), "Student was not added to the course");

            studentA.AddApprovedCredits(63);

            Course courseB = new Course("000000012", "Scripting", 64);

            Assert.That(!courseB.AddStudent(studentA), "Student should not be added to the course");

            studentA.AddApprovedCredits(1);

            Assert.That(courseB.AddStudent(studentA), "Student was not added to the course");
        }
    }
}