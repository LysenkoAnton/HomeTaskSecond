using System;
namespace ConsoleApp2
{
    public struct Student : IDisposable
    {
        private static int quantity;
        private String name;
        private String lastName;
        private int id;
        private int age;
        private StageEvolution stageEvolution;
        


        public Student(String name, String lastName, int age)
        {
            quantity += 1;
            this.id = quantity;
            this.name = name;
            this.lastName = lastName;
            this.age = age;
            this.stageEvolution = StageEvolution.None;
        }

        public String GetName()
        {
            return this.name;
        }

        public int GetId()
        {
            return this.id;
        }

        public String GetLastName()
        {
            return this.lastName;
        }

        public int GetAge()
        {
            return this.age;
        }

        public StageEvolution GetStageEvolution()
        {
            return this.stageEvolution;
        }

        public void SetStageEvolution(StageEvolution stageEvolution)
        {
            this.stageEvolution = stageEvolution;
        }

        public void SetName(String name)
        {
            this.name = name;
        }

        public void SetLastName(String lastName)
        {
            this.lastName = lastName;
        }

        public void SetAge(int age)
        {
            this.age = age;
        }

        public void SetId(int id)
        {
            this.id = id;
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public String ConvString()
        {
            String str;
            str = "ID = "+this.GetId().ToString() + ", NAME = "+this.GetName() + ", LAST_NAME = "+this.GetLastName() + ", AGE = "+this.GetAge().ToString()+ ", STAGE = "+this.GetStageEvolution();
            return str;
        }

    }
}