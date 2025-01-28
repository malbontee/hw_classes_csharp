using hw_classes_csharp;

public class Program
{
    public static void Main(string[] args)
    {
        var student = new Student(new FullName("Daryna", "Onopko", "Serhiivna"), new BirthdayDate(1, 12, 1980), "вул. Героїв Харкова 86Б", "+380961234567");
        student.AddCourseworkGrade(12);
        student.AddCourseworkGrade(11);
        student.AddCourseworkGrade(12);
        student.AddCreditGrade(10);
        student.AddCreditGrade(11);
        student.AddCreditGrade(12);
        student.AddExamGrade(10);
        student.AddExamGrade(11);
        student.AddExamGrade(12);
        student.PrintStudentInfo();
        string info = student.ToString();
        Console.WriteLine(info);
        Console.WriteLine("----------------------------------------------------------------------------------------------------------------");
        var group = new Group("IP-23", "Computer Science", 2);
        group.AddStudent(student);
        var student2 = new Student(new FullName("Ivan", "Ivanov", "Ivanovych"), new BirthdayDate(21, 1, 1995), "вул. Тракторобудивників 63", "+380681234567");
        group.AddStudent(student2);
        var student3 = new Student(new FullName("Petro", "Petrov", "Petrovych"), new BirthdayDate(15, 5, 1996), "вул. Лісна 12", "+380661234567");
        group.AddStudent(student3);
        var student4 = new Student(new FullName("Olena", "Antonova", "Olehivna"), new BirthdayDate(1, 12, 1980), "вул. Гвардійців-Широнінців 33", "+380551234567");
        var student5 = new Student(new FullName("Bohdan", "Bohdanov", "Bohdanovych"), new BirthdayDate(31, 7, 1990), "вул. Степана Бандери", "+380971234567");
        group.AddStudent(student4);
        group.AddStudent(student5);
        group.PrintGroupInfo();
        student2.AddCourseworkGrade(12);
        student2.AddCourseworkGrade(11);
        student2.AddCourseworkGrade(12);
        student2.AddCreditGrade(10);
        student2.AddCreditGrade(11);
        student2.AddCreditGrade(12);
        student2.AddExamGrade(10);
        student2.AddExamGrade(11);
        student2.AddExamGrade(12);
        student3.AddCourseworkGrade(7);
        student3.AddCourseworkGrade(8);
        student3.AddCourseworkGrade(9);
        student3.AddCreditGrade(10);
        student3.AddCreditGrade(7);
        student3.AddCreditGrade(8);
        student3.AddExamGrade(9);
        student3.AddExamGrade(10);
        student3.AddExamGrade(11);
        student4.AddCourseworkGrade(6);
        student4.AddCourseworkGrade(7);
        student4.AddCourseworkGrade(6);
        student4.AddCreditGrade(5);
        student4.AddCreditGrade(6);
        student4.AddCreditGrade(7);
        student4.AddExamGrade(8);
        student4.AddExamGrade(9);
        student4.AddExamGrade(7);
        student5.AddCourseworkGrade(5);
        student5.AddCourseworkGrade(4);
        student5.AddCourseworkGrade(5);
        student5.AddCreditGrade(6);
        student5.AddCreditGrade(4);
        student5.AddCreditGrade(5);
        student5.AddExamGrade(4);
        student5.AddExamGrade(3);
        student5.AddExamGrade(5);
        Console.WriteLine("----------------------------------------------------------------------------------------------------------------");
        group.ExpelTheWorstStudent();
        var group2 = new Group("PI-19", "Data Science", 1);
        group.TransferStudent(group2, student4);
        Console.WriteLine("\n");
        group2.PrintGroupInfo();
        Console.WriteLine("\n");
        group.PrintGroupInfo();
        var student6 = new Student(new FullName("Anna", "Pavlova", "Olehivna"), new BirthdayDate(1, 10, 2001), "вул. Тараса Шевченка 25в", "+380559871276");
        group2.AddStudent(student6);
        student6.AddCourseworkGrade(12);
        student6.AddCourseworkGrade(11);
        student6.AddCourseworkGrade(12);
        student6.AddCreditGrade(10);
        student6.AddCreditGrade(11);
        student6.AddCreditGrade(12);
        student6.AddExamGrade(10);
        student6.AddExamGrade(11);
        student6.AddExamGrade(12);
        var student7 = new Student(new FullName("Iryna", "Ivanova", "Ivanivna"), new BirthdayDate(21, 12, 2000), "вул. Тракторобудівників 163", "+380991234567");
        group2.AddStudent(student7);
        student7.AddCourseworkGrade(3);
        student7.AddCourseworkGrade(4);
        student7.AddCourseworkGrade(5);
        student7.AddCreditGrade(6);
        student7.AddCreditGrade(4);
        student7.AddCreditGrade(5);
        student7.AddExamGrade(4);
        student7.AddExamGrade(3);
        student7.AddExamGrade(5);
        group2.ExpelTheWorstStudent();
        var test = group2.GetStudent(1);
        Console.WriteLine(test.ToString());
        group2.ExpelLowScorers();
        group.ExpelLowScorers();
        Console.WriteLine("\n");
        group2.PrintGroupInfo();
        Console.WriteLine("\n");
        group.PrintGroupInfo();

        try
        {
            student.GetCourseworkGrade(13);
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }

        var studentCopy = student.Clone() as Student;
        studentCopy.AddCourseworkGrade(12);
        student.PrintStudentInfo();
        studentCopy.PrintStudentInfo();
        var groupCopy = group.Clone() as Group;
        var student8 = new Student(new FullName("Stepan", "Stepanov", "Stepanovych"), new BirthdayDate(5, 10, 1975), "вул. Тракторобудивників 63", "+380681234567");
        groupCopy.AddStudent(student8);
        group.PrintGroupInfo();
        groupCopy.PrintGroupInfo();
    }
}
