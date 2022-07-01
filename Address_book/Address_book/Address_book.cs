using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day23_CollectionAddressBook
{
    internal class AddressBook
    {
        //Creating Object Of Class
        Contact tempContact = new Contact();
        //Creating Dictionary
        public Dictionary<string, Contact> contacts;

        //Initializing Dictionary
        public AddressBook()
        {
            contacts = new Dictionary<string, Contact>();
        }

        //Method Used To Create Contacts
        public void CreateContact()
        {
            tempContact.GetUserInfo();
            string name = tempContact.GetName();
            if (contacts.ContainsKey(name) is false)
            {
                contacts.Add(name, tempContact);
            }
            else
            {
                Console.WriteLine("erorr");
            }
        }

        //Method Used To Add Contacts
        public void AddContacts()
        {
            tempContact.GetUserInfo();
            string name = tempContact.GetName();
            if (contacts.ContainsKey(name) is false)
            {
                contacts.Add(name, tempContact);
                Console.WriteLine("Successfully Added A New Contact!!!");
            }
            else
            {
                Console.WriteLine("erorr");
            }

        }

        


        //Method Used To Display The Contacts
        public void Display()
        {
            foreach (string name in contacts.Keys)
            {
                contacts[name].Display();
            }
        }
    }
}