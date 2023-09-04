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
            new Contact ( "John Doe", 1234567890 ),
            new Contact ( "Alice Smith", 9876543210),
            new Contact ( "Michael Johnson", 5551234567 ),
            new Contact ( "Anna Lee", 8885551234 ),
            new Contact ( "Michael Jordan", 23 ),
        };


        public void DisplayAllContacts()
        {
            Console.Clear();
            Console.WriteLine("Poniżej wyświetlono wszystkie kontakty.");
            foreach (var contact in contacts)
            {
                Console.WriteLine($"Osoba: {contact.Name},\t   numer telefonu: {contact.Number}");
            }
        }

        public void DisplayContact(long number)
        {
            Console.Clear();
            var contact = contacts.Where(c => c.Number == number);
            //var contactAboutNumber = contact.ToList();
            Console.WriteLine(string.Join(", ", contact));
            Console.WriteLine("XXXXXXXXXXXXXXXXXXXXXXXXXX");


        }

    }
}
