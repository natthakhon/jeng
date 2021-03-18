using System;
using System.Collections.Generic;
using System.Text;

namespace JengLib
{
    public class Person
    {
        public int age;
        public string Greet()
        {
            return "Hello";
        }
        public void SetAge(int age)
        {
            this.age = age;
        }
        public int GetAge()
        {
            return this.age;
        }
    }
    public class Professor : Person
    {
        public string Explain()
        {
            return "I'm explaining.";
        }
    }
    public class Student : Person
    {
        public string Study()
        {            
            return "I'm studying.";
        }
        
    }
}
