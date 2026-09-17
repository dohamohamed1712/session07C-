using System;
using System.Collections.Generic;
using System.Text;

namespace session07C_
{
    internal class Engineer :Person
    {
        public string Field { get; set; }
        public int YearsOfExperience { get; set; }

        public Engineer(int id, string name, int age, string field, int yearsOfExperience) : base(id, name, age)
        {
            Field = field;
            YearsOfExperience = yearsOfExperience;
        }

       
        public new void Greet()
        {
            Console.WriteLine("I am an Engineer.");
        }

        
        public override void Display()
        {
            Console.WriteLine("ID: " + ID + ", Name: " + Name + ", Age: " + Age + ", Field: " + Field + ", Years of Experience: " + YearsOfExperience);
        }
    }
}
