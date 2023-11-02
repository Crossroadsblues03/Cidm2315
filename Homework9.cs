namespace Homework9;

class Program
{
    //Attempt at Homework9
    static void Main(string[] args)
    {
        //Student 1
        Student s1 = new Student();
        s1.name = "Alice";
        s1.stuId = 111;
        s1.PrintInfo();


        //Student 2
        Student s2 = new Student();
        s2.name = "Bob";
        s2.stuId = 222;
        s2.PrintInfo();


        //Student 3
        Student s3 = new Student();
        s3.name = "Cathy";
        s3.stuId = 333;
        s3.PrintInfo();


        //Student 4
        Student s4 = new Student();
        s4.name = "David";
        s4.StuId = 444;
        s4.PrintInfo();

        //Attempted Dictionary I don't know if I did it right
        Dictionary<int, string> stu_info = new Dictionary<int, string>();
        stu_info.Add(4.0, "Alice");
        stu_info.Add(3.6, "Bob");
        stu_info.Add(2.5, "Cathy");
        stu_info.Add(1.8, "David");
        stu_info.Insert(3.3, "Tom");
        
        if (stu_info.ContainsValue("Tom") == true)
        {
            Console.WriteLine(" Value is found");
        }
        else{
            Console.WriteLine(" Value is not found");
        }

        double[] = int_1d_array = {4.0, 3.6, 2.5, 1.8, 3.3};
        Average(double[] dou_1d_array);

        if( stu_info > Average){
            Console.WriteLine($"Student ID:{stuId} Student Name: {name}");
        }
    }

    static void Average(double[] int_1d_array){
        Console.WriteLine($"The Avgerage GPA is: {int_1d_array.Average()}");
    }
}



class Student
{

    private int studentID

    private string studentName

    public void PrintInfo()

    public static studentList
    {
        //List for Students
        List<Student> name_list1 = new List<Student>();
        name_list1.Add("Alice");
        name_list1.Add("Bob");
        name_list1.Add("Cathy");
        name_list1.Add("David");
    }

    public Student()

}
