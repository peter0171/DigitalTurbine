using Common.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODEL
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public PersonRace Race { get; set; }
        public double Height { get; set; }
        public override string ToString()
        {
            return "My name is '" + Name + "' and I am " + Age + " years old." + "Height:" + Height + "Race:" + Race;
        }



    }
}
