using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroToOOP
{
    class Superhero
    {
        //4 fields
        private string costume;
        private string name;
        private int strengthLevel;
        private string power;
        private bool hasCape;
        //5 properties
        public string Costume
        {
            get{ return this.costume; }
            set{ this.costume = value; }
        }
        public string Name
        {
            get{ return this.name; }
            set { this.name = value; }

        }
        public int StrengthLevel
        {
            get{ return this.strengthLevel; }
            set{ this.strengthLevel = value; }
        }
        public bool HasCape
        {
            get{ return this.hasCape; }
            set{ this.hasCape = value; }

        }
        //if you make more than 1 constructor, you must declare a default
        //3 constructors
        public Superhero()
        {
            //this is my default constructor

        }

        public Superhero(string name)
        {
            this.name = name;
            this.strengthLevel = 100;//why can you do this?
        }
        public Superhero(string costume, string name, int strengthLevel, string power, bool hasCape)
        {
            this.costume = costume;
            this.name = name;
            this.strengthLevel = strengthLevel;//why can you do this?
            this.power = power;
            this.hasCape = hasCape;
        }
        //2 methods
        public void BattleNemesis()
        {
            this.StrengthLevel -= 10;//same as +10
            this.HasCape = false;
            this.Costume = "tattered";
        }
        public void AllyGained()
        {
            this.StrengthLevel += 10;
            this.HasCape = false;
            Console.WriteLine("Thank you for being a friend");
        }
       // public void GetHealthy(string costume, int strengthLevel)
       //  {
       //    this.Costume = costume;
       //    this.StrengthLevel = strengthLevel;
       //  }

    }
}
