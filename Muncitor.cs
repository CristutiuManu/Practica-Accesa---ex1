using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demoOOP
{
    class Muncitor
    {
        private int _id;
        private string _name;
        private int _age;
        private string _gender;
        private string _sexualOrientation;

       public int Id
        {
            get { return _id;}
            set { _id = value;}
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }

        public string Gender
        {
            get { return _gender; }
            set { _gender = value; }

        }

        public string SexualOrientation
        {
            get { return _sexualOrientation; }
            set { _sexualOrientation = value; }
        }

        public string Religion { get; set; }

    }
}
