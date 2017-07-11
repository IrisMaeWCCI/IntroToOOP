using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroToOOP
{
    class Cat
    {   //Inside of our class, we create the blueprint for our object
        //Classes are templates in OOP that we use to create objects
        //They should always be named in Pascal case

        //In OOP you have two types of states: 
        //Fields - variables that belong to a class
        //Fields are normally private
        private string name;
        private int age;
        private string furColor;
        private bool isHungry = true;
        //Properties - hybrid between a field and method
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public int Age
        {
            get { return this.age; }
        }
        //We also have Behaviors
        //Methods-Repeatable, Reusable sections of code
        //Constructors- specialized methods that are used when instantiating an object
        //You can have as many properties as you need/want as long as each of them has a unique signature
        public Cat()
        {
            //This is an example of a default constructor
            //Takes no arguments/parameters
        }
        public Cat(string name, int age, string furColor)
        {
            this.name = name;
            this.age = age;
            this.furColor = furColor;
        }
        //whatever is passed in for name- set the same they provide set equal to the fields
        //allow us to control the state of the object upon creation
        // Allow us to perform any actions the object might need upon creation
        //Always share the na,e of the class
        //Cannot reuse class names
        public void Eat()
        {
            if (isHungry)
            {
                isHungry = false;
            }
            Console.WriteLine("Is the cat hungry? " + isHungry);
        }
    }
}
