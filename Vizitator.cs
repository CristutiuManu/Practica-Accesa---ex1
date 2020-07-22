using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demoOOP
{
    class Vizitator
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }

        public Vizitator(string name, int age, string gender)
        {
            this.Name = name ;
            this.Age = age;
            this.Gender = gender;
        }
    }
}
