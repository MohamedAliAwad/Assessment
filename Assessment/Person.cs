using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment
{
    internal struct Person
    {
        string name;
        public int age;

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public string Name
        {
            get { return name; }
            set { if (value != null) name = value; else name = "Empty"; }

        }
        public int Age
        {
            get { return age; }
            set
            {
                if (value >= 20 && value <= 50)
                {
                    age = value;
                }
                else
                {
                    age = 20;
                }
            }

        }

        public override string ToString()
        {
            return $"Name {name}, Age {age}";
        }
    }
}
