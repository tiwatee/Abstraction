namespace AbstractExamples
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            SchoolInfo schoolOne=new SchoolInfo();
            schoolOne.Dummy();
            schoolOne.Department(12);
            schoolOne.Lecturers();
            

            InterfaceSample sample = new InterfaceSample();
            Console.WriteLine(sample.MethodAddition(2, 3));
            Console.WriteLine(sample.MethodConc("ade is ","a boy."));
        }
    }
}