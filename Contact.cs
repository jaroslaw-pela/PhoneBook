﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook
{
    public class Contact
    {
        public Contact(string name, long number)
        {
            Name = name;
            Number = number;
        }

        public string Name { get; set; }
        public long Number { get; set; }

    }
}
