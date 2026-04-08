using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestSample
{
    [TestFixture]
    internal class TestCreateStudent
    {
        private static IEnumerable<TestCaseData> StudentsData()
        {
            yield return new TestCaseData("0000000001", "Carolina García").SetName("TestCreateStudent_ValidStudent");
            yield return new TestCaseData("000000012", "hdkjashkjdas").SetName("TestCreateStudent_InvalidID");
            yield return new TestCaseData("0000000123", null).SetName("TestCreateStudent_NullName");
            yield return new TestCaseData("0000000012", "").SetName("TestCreateStudent_EmptyName");
        }

        private static IEnumerable<TestCaseData> StudentObjects()
        {
            yield return new TestCaseData(
                new Student("0000000001", "Carolina García"))
                .SetName("TestCreateStudentB_ValidStudent");

            yield return new TestCaseData(
                new Student("000000012", "hdkjashkjdas"))
                .SetName("TestCreateStudentB_InvalidID");

            yield return new TestCaseData(
                new Student("0000000123", null))
                .SetName("TestCreateStudentB_NullName");

            yield return new TestCaseData(
                new Student("0000000012", ""))
                .SetName("TestCreateStudentB_EmptyName");
        }

        [TestCaseSource(nameof(StudentsData))]
        public void CreateStudent(string id, string name)
        {
            Student student = new Student(id, name);

            Assert.That(student.IDIsValid(), "Student ID is invalid");
            Assert.That(student.Name, Is.Not.Null, "Student name is null");
            Assert.That(student.Name, Is.Not.EqualTo(string.Empty), "Student name is empty");
        }

        [TestCaseSource(nameof(StudentObjects))]
        public void CreateStudentB(Student student)
        {
            Assert.That(student.IDIsValid(), "Student ID is invalid");
            Assert.That(student.Name, Is.Not.Null);
            Assert.That(student.Name, Is.Not.EqualTo(string.Empty));
        }
    }
}