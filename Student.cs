using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace hw_classes_csharp
{
    public class Student : IComparable<Student>, ICloneable
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
        public object Clone()
        {
            return new Student
            {
                fullName = this.fullName,
                birthday = this.birthday,
                address = this.address,
                phoneNumber = this.phoneNumber,
                courseworks = new List<int>(this.courseworks),
                credits = new List<int>(this.credits),
                exams = new List<int>(this.exams)
            };
        }
        public int CompareTo(Student? other)
        {
            return this.fullName.GetFullName().lastName.CompareTo(other?.fullName.GetFullName().lastName);
        }
        public string? Adress
        {
            get { return address; }
            set
            {
                if (!string.IsNullOrEmpty(value)) 
                    address = value;
                else 
                    throw new ArgumentException("Address cannot be null or empty!");
            }
        }
        public string? PhoneNumber
        {
            get { return phoneNumber; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    phoneNumber = value;
                else
                    throw new ArgumentException("Phone number cannot be null or empty!");
            }
        }
        public void SetAdress(string address)
        {
            if (!string.IsNullOrEmpty(address))
                this.address = address;
            else
                throw new ArgumentException("Address cannot be null or empty!");
        }
        public string? GetAddress()
        {
            return address;
        }
        public void SetPhoneNumber(string phoneNumber)
        {
            if (!string.IsNullOrEmpty(phoneNumber))
                this.phoneNumber = phoneNumber;
            else
                throw new ArgumentException("Phone number cannot be null or empty!");
        }
        public string? GetPhoneNumber()
        {
            return phoneNumber;
        }
        public void AddCourseworkGrade(int courseworkGrade)
        {
            if (courseworkGrade > 0)
                courseworks.Add(courseworkGrade);
            else
                throw new ArgumentException("Invalid value for coursework!");
        }
        public int GetCourseworkGrade(int index)
        {
            if (index >= 0 && index < courseworks.Count)
            {
                throw new ArgumentOutOfRangeException();
            }
            return courseworks[index];
        }
        public void AddCreditGrade(int creditGrade)
        {
            if (creditGrade > 0)
                credits.Add(creditGrade);
            else
                throw new ArgumentException();
        }
        public int GetCreditGrade(int index)
        {
            if (index >= 0 && index < credits.Count)
            {
                throw new ArgumentOutOfRangeException();
            }
            return credits[index];
        }
        public void AddExamGrade(int examGrade)
        {
            if (examGrade > 0)
                exams.Add(examGrade);
            else
                throw new ArgumentException();
        }
        public int GetExamGrade(int index)
        {
            if (index >= 0 && index < exams.Count)
            {
                throw new ArgumentOutOfRangeException();
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
    
