namespace TestSample
{
    internal class Course
    {
        public string Id { get; private set; }
        public string Name { get; private set; } = string.Empty;

        public int RequiredCredits { get; private set; } = 0;

        public List<Student> Students { get; private set; } = new List<Student>();

        public Course(string id, string name, int requiredCredits)
        {
            Id = id;
            Name = name;
            RequiredCredits = requiredCredits;
        }

        public Course(int requiredCredits)
        {
            Id = "0000000000";
            Name = "Default course";

            RequiredCredits = requiredCredits;
        }

        public Course()
        {
            new Course(0);
        }

        public bool AddStudent(Student student)
        {
            if (Students == null)
            {
                Students = new List<Student>();
            }

            if (student.ApprovedCredits >= RequiredCredits)
            {
                Students.Add(student);
                return true;
            }

            return false;
        }
    }
}