using System;
using System.Collections.Generic;
using System.Text;

namespace session07C_
{
    internal class Doctor : Person
    {
        public string Specialty { get; set; }

        public Doctor(int id, string name, int age, string specialty) : base(id, name, age)
        {
            Specialty = specialty;
        }

        
        public new void Greet()
        {
            Console.WriteLine("I am a Doctor.");
        }

       
        public override void Display()
        {
            Console.WriteLine("ID: " + ID + ", Name: " + Name + ", Age: " + Age + ", Specialty: " + Specialty);
        }
    }
}
