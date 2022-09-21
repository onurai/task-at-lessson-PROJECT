using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace task_at_lessson_PROJECT
{
    class Filter_Contacs
    {
        List<Contact> contacts = new List<Contact>();


        public Contact Display_By_Numbers(string number)
        {
            return contacts.Where(x => x.Number == number).FirstOrDefault();
        }


        public void Add_Contact(Contact contact)
        {
            contacts.Add(contact);
            Console.WriteLine();
            Display_By_Numbers(contact.Number).ToString();
        }


        public List<Contact> Search_By_Name(string name)
        {
            return contacts.Where(c => c.Name == name).ToList();
        }


        public void ViewAllContacts()
        {
            if (contacts != null && contacts.Count != 0)
            {
                foreach (Contact item in contacts)
                {
                    Console.WriteLine(item.ToString());
                }
            }
        }




    }
}
