namespace hw_classes_csharp
{
    public class FullName
        {
            private string? firstName;
            private string? lastName;
            private string? patronymic;
            public FullName()
                : this("Unknown", "Unknown", "Unknown") { }
            public FullName(string firstName, string lastName, string patronymic)
            {
                SetFullName(firstName, lastName, patronymic);
            }
        public string? FirstName
        {
            get { return firstName; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    firstName = value;
                else
                    throw new ArgumentException("First name cannot be null or empty!");
            }
        }
        public string? LastName
        {
            get { return lastName; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    lastName = value;
                else
                    throw new ArgumentException("Last name cannot be null or empty!");
            }
        }
        public string? Patronymic
        {
            get { return patronymic; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    patronymic = value;
                else
                    throw new ArgumentException("Patronymic cannot be null or empty!");
            }
        }
        public void SetFullName(string firstName, string lastName, string patronymic)
            {
                if (!string.IsNullOrEmpty(firstName))
                    this.firstName = firstName;
                else
                    throw new ArgumentException("First name cannot be null or empty!"); 
                if (!string.IsNullOrEmpty(lastName))
                    this.lastName = lastName;
                else
                    throw new ArgumentException("Last name cannot be null or empty!"); 

                if (!string.IsNullOrEmpty(patronymic))
                    this.patronymic = patronymic;
                else
                    throw new ArgumentException("Patronymic cannot be null or empty!");

            }
            public (string? firstName, string? lastName, string? patronymic) GetFullName()
            {
                return (firstName, lastName, patronymic);
            }

        }
}
    
