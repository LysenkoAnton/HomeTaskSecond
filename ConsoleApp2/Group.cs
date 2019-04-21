using System;

namespace ConsoleApp2
{
    public struct Group
    {
        private String name;
        private static int quantity;
        private int id;
        private Student[] students;
        private int members;


        public Group(String name)
        {
            quantity += 1;
            this.name = name;
            this.id = quantity;
            this.students = new Student[1];
            this.members = 0;
        }

        public String GetName()
        {
            return this.name;
        }

        public void SetName(String name)
        {
            this.name = name;
        }

        public int GetId()
        {
            return this.id;
        }

        public int GetMembers()
        {
            return this.members;
        }

        public void SetId(int id)
        {
            this.id = id;
        }

        public void AddStudent(Student student)
        {
            if(this.members==0)
            {
                this.students[0] = student;
            }

           else if(this.members == this.students.Length)
            {
                Array.Resize(ref this.students, this.students.Length * 2);
                this.students[this.students.Length / 2] = student;

            }

            else
            {
                this.students[members] = student;
            }

            this.members += 1;
        }

        public void DeleteStudent(Student student)
        {
            for(int i = 0; i<this.students.Length; i++)
            {
                if((this.students[i].GetId() == student.GetId())&(this.students[i].GetName() == student.GetName())&(this.students[i].GetLastName() == student.GetLastName()))
                {
                    this.students[i].Dispose();
                }
            }
        }

        public String ConvString()
        {
            String str = "ID = "+this.GetId().ToString() + ", NAME = "+this.GetName() + ", MEMBERS = "+this.GetMembers().ToString()+'\n';
            for(int i = 0; i < this.GetMembers() ;i++)
            {
                str = str + this.students[i].ConvString() + '\n';
            }

            return str;
        }
    }
}
