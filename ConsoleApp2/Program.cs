using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Group groupA = new Group("DevJava");
            Student studentA = new Student("Petro","Gavrilyk",25);
            Student studentB = new Student("Semen", "Werytin", 20);
            studentB.SetStageEvolution(StageEvolution.Demo1);

            groupA.AddStudent(studentA);
            groupA.AddStudent(studentB);

            Console.Write(groupA.ConvString());
            Console.Read();
        }
    }
}
