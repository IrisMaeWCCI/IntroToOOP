using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroToOOP
{
    class Dog
    {
        //Create a DOG class
        //Your dog class should have fields for hair length, height, running speed and weight
        //Your class should have the following behaviours: run, bark, potty, cuddle 
        //You should have at least one constructor
        //Make your fields private
        private string hairLength;
        private int height;
        private int runningSpeed;
        private double weight;
        private bool crap = true;
        //barkVolume under invisibility cloak- this is private, which is the default for the field
        //Properties
        public string HairLength
        {
            get { return this.hairLength; }//you can have conditionals inside of properties
            set { this.hairLength = value; }
        }
        public int Height
        {
            get { return this.height; }
            set { this.height = value; } 
        }
        public int RunningSpeed
        {
            get { return this.runningSpeed; }
            set { this.runningSpeed = value; }
        }
        public double Weight
        {
            get { return this.weight; }
            set { this.weight = value; }
        }
        public Dog(string hairLength, string height, string runningSpeed, string weight)
        {
            this.hairLength = hairLength;
            this.height = height;
            this.runningSpeed = runningSpeed;
            this.weight = weight;
        }
        public double BarkVolume { get; set; }

        public int Run()
        {
            //this is my default constructor
            Console.WriteLine("Go doggy go!!");
            RunningSpeed -= 1;
            return RunningSpeed;
        }
        public void Bark()
        {
            Console.WriteLine("Bork bork bork!!");
        }
        public void Potty()
        {
            if (crap == true)
            {
                Console.WriteLine("You just made a mess.");
                weight -= 1.0;
            }
            else
            {
                Console.WriteLine("Your dog has to relieve itself");
                weight += 1.0;
            }
            return weight;}
        public void Cuddle()
        {
            Console.WriteLine("Aww doggy is so ");
        }
        }
    }
}
