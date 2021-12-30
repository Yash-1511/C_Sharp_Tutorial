using System;

namespace Tutorial
{   
    public class person
    {
        public string firstName;
        public string lastName;
        public void intro()
        {
            Console.WriteLine("My name is " + firstName + " " + lastName);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            person p = new person();
            p.firstName = "yash";
            p.lastName = "parmar";
            p.intro();
            //var c = new Calculator();
            Console.WriteLine("addition is: " + Calculator.add(10,20));
        }
    }
}
