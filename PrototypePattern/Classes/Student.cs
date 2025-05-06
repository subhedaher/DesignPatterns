namespace PrototypePattern.Classes
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string PhoneNumber { get; set; }

        public Student(int id, string name, string email, string password, string phoneNumber)
        {
            Id = id;
            Name = name;
            Email = email;
            Password = password;
            PhoneNumber = phoneNumber;
        }
        public Student Clone()
        {
            return new Student(Id, Name, Email, Password, PhoneNumber);
        }
    }
}
