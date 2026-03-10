namespace TestSample
{
    internal class Student
    {
        public string Id { get; private set; }
        public string Name { get; private set; }

        public int ApprovedCredits { get; private set; }

        public Student(string id, string name)
        {
            // ID must be 10 characters long
            // TODO: Validate ID has exactly 10 characters
            // TODO: Add leading 0s if ID is less than 10 characters long
            // TODO: Remove last digits if ID is more than 10 characters long
            Id = id;
            Name = name;
        }

        public bool IDIsValid() =>
            Id.Length == 10;

        public void AddApprovedCredits(int credits)
        {
            ApprovedCredits += credits;
        }
    }
}