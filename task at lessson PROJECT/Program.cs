using System;
using System.Collections.Generic;

namespace task_at_lessson_PROJECT
{
    class Program
    {

        private static Filter_Contacs con = new Filter_Contacs();

        static void Main(string[] args)
        {
            SeedDataBase();
            Console.WriteLine("look at menu below and choose operation");
            Console.WriteLine("1 - Display by Number");
            Console.WriteLine("2 - Add Contact");
            Console.WriteLine("3 - Search By Name");
            Console.WriteLine("4 - View All Contacts");
            int a = int.Parse(Console.ReadLine());

            switch (a)
            {
                case 1:
                    Console.WriteLine("Please add Number to find: ");
                    string b = Console.ReadLine();
                    Console.WriteLine(con.Display_By_Numbers(b).ToString());
                    break;

                case 2:
                    Add_Contact();
                    break;

                case 3:
                    Console.WriteLine("Please add name to find: ");
                    string name = Console.ReadLine();
                    Search_By_Name(name);
                    break;

                case 4:
                    con.ViewAllContacts();
                    break;

            }

        }

        static void SeedDataBase()
        {
            var cont = new Contact("ruslan", "555-55-55");
            var cont1 = new Contact("onur", "444-44-44");
            var cont2 = new Contact("perviz", "333-33-33");

            con.Add_Contact(cont);
            con.Add_Contact(cont1);
            con.Add_Contact(cont2);
        }

        public static Contact Add_Contact()
        {
            Console.WriteLine("Add new name");
            string name = Console.ReadLine();
            Console.WriteLine("Add new number");
            string number = Console.ReadLine();

            Contact contact = new Contact(name, number);

            con.Add_Contact(contact);
            Console.WriteLine(con.Display_By_Numbers(contact.Number).ToString());
            return contact;

        }

        public static void Search_By_Name(string name)
        {
            List<Contact> con1 = con.Search_By_Name(name);

            foreach (Contact item in con1)
            {
                Console.WriteLine(item.ToString());
            }
        }

        


    } 
}
