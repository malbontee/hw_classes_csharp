using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using hw_classes_csharp;

namespace hw_classes_csharp
{
    public class Group
    {
        private List<Student> students;
        private string? groupName;
        private string? groupSpecialization;
        private int groupCourse;


        public Group()
            : this("Unknown", "Unknown", 1) { }

        public Group(string groupName, string groupSpecialization, int groupCourse)
        {
            students = new List<Student>();
            SetGroupInfo(groupName, groupSpecialization, groupCourse);
        }
        public string GroupName { get; set; } = "Unknown";
        public string GroupSpecialization { get; set; } = "Unknown";
        public int GroupCourse
        {
            get { return groupCourse; }
            set
            {
                if (value > 0 && value <= 6)
                    groupCourse = value;
                else
                    throw new ArgumentOutOfRangeException("Invalid value for course!");
            }
        }
        public void SetGroupInfo(string groupName, string groupSpecialization, int groupCourse)
        {
            this.groupName = groupName;
            this.groupSpecialization = groupSpecialization;
            if (groupCourse > 0 && groupCourse <= 6)
                this.groupCourse = groupCourse;
            else
                throw new ArgumentOutOfRangeException("Invalid value for course!");
        }
        public (string groupName, string groupSpecialization, int groupCourse) GetGroupInfo()
        {
            return (groupName, groupSpecialization, groupCourse);
        }
        public void AddStudent(Student student)
        {
            students.Add(student);
        }
        public Student GetStudent(int index)
        {
            if (index >= 0 && index < students.Count)
                return students[index];
            else
                throw new IndexOutOfRangeException("Invalid index!");
        }
        public void PrintGroupInfo()
        {
            Console.WriteLine($"Group name: {groupName}");
            Console.WriteLine($"Group specialization: {groupSpecialization}");
            Console.WriteLine($"Group course: {groupCourse}");
            Console.WriteLine("Students:");
            students.Sort();

            for (int i = 0; i < students.Count; i++) 
            {
                Console.WriteLine($"{i+1}. {students[i].ToString()}");
            }

        }
        public void EditGroupInfo (string groupName, string groupSpecialization, int groupCourse)
        {
            SetGroupInfo(groupName, groupSpecialization, groupCourse);
        }
        public void EditStudentInfo(Student student, string adress, string phoneNumber)
        {
            student.SetAdress(adress);
            student.SetPhoneNumber(phoneNumber);
        }
        public void RemoveStudent(Student student)
        {
            if (!students.Contains(student))
            {
                throw new ArgumentException("There is no such student in the group!");
            }
            students.Remove(student);
        }
        public void TransferStudent(Group group, Student student)
        {
            if (!students.Contains(student))
            {
                throw new ArgumentException("There is no such student in the group!");
            }
            if (group.students.Contains(student))
            {
                throw new ArgumentException("This student is already in this group!");
            }
            students.Remove(student);
            group.AddStudent(student);
        }
        public void ExpelTheWorstStudent()
        {
            Student? theWorstStudent = null;
            double minValue = 12;

            foreach (var student in students)
            {
                double totalGrade = student.GetTotalGrade();
                if (totalGrade < minValue)
                {
                    minValue = totalGrade;
                    theWorstStudent = student;
                }


            }
            Console.WriteLine($"The worst student is:\n\n{theWorstStudent}\n\nwith grade: {minValue}. This student will be expelled from the group!");
            students.Remove(theWorstStudent);
        }
        public void ExpelLowScorers()
        {
            Student? lowScorer = null;

            for (int i = 0; i < students.Count; i++)
            {
                double totalGrade = students[i].GetTotalGrade();
                if (totalGrade < 7)
                {
                    lowScorer = students[i];
                    students.Remove(lowScorer);
                }
            }
        }
        }
}
