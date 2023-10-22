using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PhoneBook
{
    public class PhoneBook
    {

        public List<Contact> contacts = new List<Contact>
        {
            new Contact ( "John Doe", "1234567890" ),
            new Contact ( "Alice Smith", "9876543210"),
            new Contact ( "Michael Johnson", "5551234567" ),
            new Contact ( "Anna Lee", "8885551234"),
            new Contact ( "Michael Jordan", "23" ),
        };

        public void AddContact()
        {
            //contacts.Add(newContact);
            Console.Clear();
            Console.WriteLine("Podaj imie i nazwisko");
            string? newName = Console.ReadLine();
            Console.WriteLine("Podaj numer telefonu");
            var newNumber = Console.ReadLine();
            var newContact = new Contact(newName, newNumber);
            contacts.Add(newContact);
        }

        public void NowaOsoba()
        {

        }

        public void DisplayContact(string number)
        {
            //Console.Clear();
            var contact = contacts.FirstOrDefault(c => c.Number == number);

            if (contact == null)
            {
                Console.WriteLine("Contact not fonud");
            }
            else
            {
            Console.WriteLine($"Contact name:  {contact.Name},\t contact phone number {contact.Number}");
            }
        }

        public void DisplayAllContacts()
        {
            Console.Clear();
            Console.WriteLine("Poniżej wyświetlono wszystkie kontakty.");
            foreach (var contact in contacts)
            {
                Console.WriteLine($"Osoba: {contact.Name},\t numer telefonu: {contact.Number}");
            }
        }

        public void DisplayMatchingContact(string searchPhrase)
        {
            var matchingContacts = contacts.Where(c => c.Name.Contains(searchPhrase)).ToList();
            foreach (var contact in matchingContacts)
            {
                Console.WriteLine($"Osoba: {contact.Name},\t numer telefonu: {contact.Number}");
            }
        }

    }
}
