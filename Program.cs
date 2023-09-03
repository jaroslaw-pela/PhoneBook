using System.Linq;


namespace PhoneBook

{
    class Program
    {

        //public static List<Option> options;
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome in the PhoneBook! \nPlease select what do you want to do.\n");

            PhoneBook phoneBook = new PhoneBook();

            Console.WriteLine(  "podaj numer telefonu");
            var numerek = Convert.ToUInt32(Console.ReadLine());
            phoneBook.DisplayContact(numerek);

            //        // Create options that you want your menu to have
            //        options = new List<Option>
            //        {
            //            //new Option("Wyszukaj kontakt po numerze telefonu", () => WriteTemporaryMessage("Hi")),
            //            //new Option("Wyszukaj kontakt po numerze telefonu", () => phoneBook.DisplayContact(),
            //            new Option("Wyszukaj kontakt po numerze telefonu", () => phoneBook.DisplayContact(1234567890)),
            //            new Option("Dodaj kontakt", () =>  WriteTemporaryMessage("How Are You")),
            //            new Option("Wyświetl wszystkie kontakty", () =>  phoneBook.DisplayAllContacts()),
            //            new Option("Wyjście z programu", () => Environment.Exit(0))
            //        };

            //        // Set the default index of the selected item to be the first
            //        int index = 0;

            //        // Write the menu out
            //        WriteMenu(options, options[index]);

            //        // Store key info in here
            //        ConsoleKeyInfo keyinfo;
            //        do
            //        {
            //            keyinfo = Console.ReadKey();

            //            // Handle each key input (down arrow will write the menu again with a different selected item)
            //            if (keyinfo.Key == ConsoleKey.DownArrow)
            //            {
            //                if (index + 1 < options.Count)
            //                {
            //                    index++;
            //                    WriteMenu(options, options[index]);
            //                }
            //            }
            //            if (keyinfo.Key == ConsoleKey.UpArrow)
            //            {
            //                if (index - 1 >= 0)
            //                {
            //                    index--;
            //                    WriteMenu(options, options[index]);
            //                }
            //            }
            //            // Handle different action for the option
            //            if (keyinfo.Key == ConsoleKey.Enter)
            //            {
            //                options[index].Selected.Invoke();
            //                index = 0;
            //            }
            //        }
            //        while (keyinfo.Key != ConsoleKey.X);

            //        Console.ReadKey();

            //    }
            //    // Default action of all the options. You can create more methods
            //    static void WriteTemporaryMessage(string message)
            //    {
            //        Console.Clear();
            //        Console.WriteLine(message);
            //        Thread.Sleep(3000);
            //        WriteMenu(options, options.First());
            //    }



            //    static void WriteMenu(List<Option> options, Option selectedOption)
            //    {
            //        Console.Clear();

            //        foreach (Option option in options)
            //        {
            //            if (option == selectedOption)
            //            {
            //                Console.Write("> ");
            //            }
            //            else
            //            {
            //                Console.Write(" ");
            //            }
            //            Console.WriteLine(option.Name);
            //        }
            //    }
            //}

            //public class Option
            //{
            //    public string Name { get; }
            //    public Action Selected { get; }

            //    public Option(string name, Action selected)
            //    {
            //        Name = name;
            //        Selected = selected;
            //    }
            //}
        }
    }
}