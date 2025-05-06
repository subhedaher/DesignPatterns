namespace BuilderDesignPattern.Classes
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string PhoneNumber { get; set; }

        private User(int id, string name, string email, string password, string phoneNumber)
        {
            Id = id;
            Name = name;
            Email = email;
            Password = password;
            PhoneNumber = phoneNumber;
        }

        public class Builder
        {
            private int id;
            private string name;
            private string email;
            private string password;
            private string phoneNumber;

            public User Build()
            {
                if (id == 0 || string.IsNullOrEmpty(name) || string.IsNullOrEmpty(email) ||
                          string.IsNullOrEmpty(password) || string.IsNullOrEmpty(phoneNumber))
                {
                    throw new InvalidOperationException("All fields must be set before building the User.");
                }

                return new User(id, name, email, password, phoneNumber);
            }

            public void SetId(int id)
            {
                this.id = id;
            }

            public void SetName(string name)
            {
                this.name = name;
            }

            public void SetEmail(string email)
            {
                this.email = email;
            }

            public void SetPassword(string password)
            {
                this.password = password;
            }

            public void SetPhoneNumber(string phoneNumber)
            {
                this.phoneNumber = phoneNumber;
            }
        }
    }
}
