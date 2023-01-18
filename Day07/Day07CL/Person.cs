using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day07CL
{
    public class Person
    {
        private int _age = 0;

        public int Age 
        { 
            get { return _age;} 
            set { 
                if(value >= 0 && value < 122)
                    _age = value; 
            } 
        }
        public string Name { get; set; }

        public Person(int age, string name)
        {
            Age = age;
            //?? - null coalescing operator
            Name = name;
        }
    }
}
