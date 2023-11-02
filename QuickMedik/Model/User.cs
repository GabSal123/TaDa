namespace QuickMedik.Model
{
    public abstract class User
    {
        public string ID { get; private set; }
        public string Name { get; private set; }

        public string Surname { get; private set; }
        public string Email { get; private set; }
        public string Phone { get; private set; }

        public User(string iD, string name, string surname, string email, string phone)
        {
            ID = iD;
            Name = name;
            Surname = surname;
            Email = email;
            Phone = phone;
        }
    }
}
