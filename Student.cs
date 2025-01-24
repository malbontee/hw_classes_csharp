using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace hw_classes_csharp
{
    public class BirthdayDate
    {
        private int day;
        private int month;
        private int year;

        public BirthdayDate()
            : this(1, 1, 2000) { }

        public BirthdayDate(int day, int month, int year)
        {
            SetBirthdayDate(day, month, year);
        }
        public void SetBirthdayDate(int day, int month, int year)
        {
            if (day > 0 && day <= 31)
                this.day = day;
            else
            {
                Console.WriteLine("Invalid value for day!");
                return;
            }
            if (month > 0 && month <= 12)
                this.month = month;
            else
            {
                Console.WriteLine("Invalid value for month!");
                return;
            }
            if (year > 0 && year <= 2021)
                this.year = year;
            else
            {
                Console.WriteLine("Invalid value for year!");
                return;
            }
        }
        public (int day, int month, int year) GetBirthdayDate()
        {
            return (day, month, year);
        }
    }

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
            public void SetFullName(string firstName, string lastName, string patronymic)
            {
                if (firstName.Length > 0)
                    this.firstName = firstName;
                else
                {
                    Console.WriteLine("Invalid value for first name!");
                    return;
                }
                if (lastName.Length > 0)
                    this.lastName = lastName;
                else
                {
                    Console.WriteLine("Invalid value for last name!");
                    return;
                }
                if (patronymic.Length > 0)
                    this.patronymic = patronymic;
                else
                {
                    Console.WriteLine("Invalid value for patronymic!");
                    return;
                }

            }
            public (string firstName, string lastName, string patronymic) GetFullName()
            {
                return (firstName, lastName, patronymic);
            }

        }
    public class Student : IComparable<Student> 
    {
        private FullName fullName;
        private BirthdayDate birthday;
        private string? address;
        private string? phoneNumber;
        private List<int> courseworks;
        private List<int> credits;
        private List<int> exams;

        public Student()
            : this(new FullName(), new BirthdayDate(), "Unknown", "Unknown") { }
        public Student(FullName fullName, BirthdayDate birthday, string adress, string phoneNumber)
        {
            this.fullName = fullName;
            this.birthday = birthday;
            SetAdress(adress);
            SetPhoneNumber(phoneNumber);
            courseworks = new List<int>();
            credits = new List<int>();
            exams = new List<int>();
        }
        public int CompareTo(Student other)
        {
            return this.fullName.GetFullName().lastName.CompareTo(other.fullName.GetFullName().lastName);
        }
        public void SetAdress(string address)
        {
            if (address.Length > 0)
                this.address = address;
            else
            {
                Console.WriteLine("Invalid value for address!");
                return;
            }
        }
        public string GetAddress()
        {
            return address;
        }
        public void SetPhoneNumber(string phoneNumber)
        {
            if (phoneNumber.Length > 0)
                this.phoneNumber = phoneNumber;
            else
            {
                Console.WriteLine("Invalid value for phone number!");
                return;
            }
        }
        public string GetPhoneNumber()
        {
            return phoneNumber;
        }
        public void AddCourseworkGrade(int courseworkGrade)
        {
            if (courseworkGrade > 0)
                courseworks.Add(courseworkGrade);
            else
            {
                Console.WriteLine("Invalid value for coursework!");
                return;
            }
        }
        public int GetCourseworkGrade(int index)
        {
            if (index >= 0 && index < courseworks.Count)
            {
                Console.WriteLine("Invalid index!");
                return -1;
            }
            return courseworks[index];
        }
        public void AddCreditGrade(int creditGrade)
        {
            if (creditGrade > 0)
                credits.Add(creditGrade);
            else
            {
                Console.WriteLine("Invalid value for credit!");
                return;
            }
        }
        public int GetCreditGrade(int index)
        {
            if (index >= 0 && index < credits.Count)
            {
                Console.WriteLine("Invalid index!");
                return -1;
            }
            return credits[index];
        }
        public void AddExamGrade(int examGrade)
        {
            if (examGrade > 0)
                exams.Add(examGrade);
            else
            {
                Console.WriteLine("Invalid value for exam!");
                return;
            }
        }
        public int GetExamGrade(int index)
        {
            if (index >= 0 && index < exams.Count)
            {
                Console.WriteLine("Invalid index!");
                return -1;
            }
            return exams[index];
        }
        public double GetTotalGrade()
        {
            var courseworksAvg = courseworks.Average();
            var creditsAvg = credits.Average();
            var examsAvg = exams.Average();
            return (courseworksAvg + creditsAvg + examsAvg)/3;
        }
        public void PrintStudentInfo()
        {
            var (firstName, lastName, patronymic) = fullName.GetFullName();
            var (day, month, year) = birthday.GetBirthdayDate();
            Console.WriteLine($"Full name: {lastName} {firstName} {patronymic}");
            Console.WriteLine($"Birthday date: {day}.{month}.{year}");
            Console.WriteLine($"Address: {address}");
            Console.WriteLine($"Phone number: {phoneNumber}");
            
            if (courseworks.Count == 0)
            {
                Console.WriteLine("No coursework grades!");
                return;
            }
            else {
                Console.WriteLine("Grades for courseworks:");
                foreach (var coursework in courseworks)
                {

                    Console.WriteLine(coursework);
                }
            }
            if (credits.Count == 0)
            {
                Console.WriteLine("No credit grades!");
                return;
            }
            else
            {
                Console.WriteLine("Grades for credits:");
                foreach (var credit in credits)
                {
                    Console.WriteLine(credit);
                }
            }
            
            if (exams.Count == 0)
            {
                Console.WriteLine("No exam grades!");
                return;
            }
            else
            {
                Console.WriteLine("Grades for exams:");
                foreach (var exam in exams)
                {
                    Console.WriteLine(exam);
                }
            }
        }
        public override string ToString()
        {
            var (firstName, lastName, patronymic) = fullName.GetFullName();
            var (day, month, year) = birthday.GetBirthdayDate();
            return $"Full name: {lastName} {firstName} {patronymic}\nDate of birthday: {day}.{month}.{year}\nAddress: {address}\nPhone number: {phoneNumber}";
        }
    }
}
    
