using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroToOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            //When we initialize a new object, it is called instantiating(this means creating a new instance of that object)
            //An object needs to be instantiated before it can be used
            //All objects are of a specific type and are created from the same template Class
            //All objects from a class will have the same number and type of states,
            // but each instance can have it's own unique values. 
            // The forms we use to instantiate an object looks like this:
            //ClassName objectName= new ClassName();
            Cat mittens = new Cat();//red squiggles mean you need a cat class
            //To create a new object, we use a special method called a constructor 
            //Cat(); is us calling our constructor in our main method
            //Thinking about objects in real life, create(either hand handwrite or type)
            //3 examples of objects should have 5 states characteristics and 5 behviours

            Employee Angelo = new Employee();//busy, focused, at lunch, working, is on phone
            Pie Apple = new Pie();//being baked, being made, being eaten, thrown away, being cut
            FamilyMember Son = new MemberFamily();//helpful, kind, calls, gives gifts, cleans, 
            //states and behaviours of a class or states and behaviours of a specific object

        }
    }
}
