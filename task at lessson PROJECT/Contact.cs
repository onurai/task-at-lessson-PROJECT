using System;
using System.Collections.Generic;
using System.Text;

namespace task_at_lessson_PROJECT
{
    class Contact
    {
        public string Name { get; set; }
        public string Number { get; set; }


        public Contact(string name, string number)
        {
            this.Name = name;
            this.Number = number;
        }


        public override string ToString()
        {
            return Name + " " + Number;
        }



    }
}
