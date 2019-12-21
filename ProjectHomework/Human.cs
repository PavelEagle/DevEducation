using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectHomework
{
    class Human
    {
        public string name;
        public int age;


        //Конструктор по умолчанию

        public Human()
        {
        }
        public Human(string name)
        {
            this.name = name; 
        }

        public Human(int age)
        {
            this.age = age;
            name = "unnamed";
        }

        public Human(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public void GetInfo()
        {
            Console.WriteLine($"Name: {name}, Age: {age}");
        }
        public void SayHi()
        {
            Console.WriteLine("Hello!");
        }
    
      
    }
}
