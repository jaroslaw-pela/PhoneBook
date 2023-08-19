using System;
using System.Collections.Generic;
using System.Linq;
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
            new Contact ( "Michael Jordan", 2385551534 ),
        };



        // Wyświetlamy listę osób wraz z numerami telefonu
        //Console.WriteLine("Lista osób:");
        //foreach (var person in contacts)
        //{
        //    Console.WriteLine($"Imię: {contact.Name}, Numer telefonu: {contact.Number}");
        //}

    }
}
