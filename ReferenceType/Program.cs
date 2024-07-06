namespace ReferenceType
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            student.Name = "Ali";

            Console.WriteLine("Değiştirilmeden Önceki Hali: "+ student.Name);

            ChangeStudentName(student);

            Console.WriteLine("Değiştirildikten Sonraki Hali: " + student.Name);
        }

       static void ChangeStudentName(Student student) 
        {
            student.Name = "Veli";
        }
    }

    class Student()
    {
        public string Name { get; set; }
    }
}
