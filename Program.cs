using System.Linq;


namespace PhoneBook

{
    class Program
    {

        //public static List<Option> options;
        static void Main(string[] args)
        {
            PhoneBook phoneBook = new PhoneBook();

            //string? contact = null;
            //string? numerek = null;


            Console.WriteLine("Witaj w książce telefonicznej! \n\nWciśnij dowolny klawisz aby przejść do menu. \nMożesz się po nim poruszać za pomocą strzałek (góra/dół oraz enter aby zatwierdzić wybór).\n");
            Console.WriteLine(
                "::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::\r\n::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::\r\n::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::\r\n::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::\r\n::::::::::::::::::::::::::::.....:::::::::::::::::::::::::::::::::::::\r\n:::::::::::::::::::::......::::^::..::::::::::::::::::::::::::::::::::\r\n::::::::::::::......::::^^~~~~~~~~^::.::::::::::::::::::::::::::::::::\r\n:::::::::....::::^^~~~~~~~~~~~~~~~!~~^::.:::::::::::::::::::::::::::::\r\n:::::..:::^^^~~~~~~~~~~~~~~~~~!!7!~~!!~~^::.::::::::::::::::::::::::::\r\n::::::^~~~~~~~~~~~~~~^^^~~!??Y5PPY?7~!!!!~~^::.:::::::::::::::::::::::\r\n:::::^^~~~~~~~~^^^~~~??55?5P5YYYJY7!!!!!!!!!!~^::.::::::::::::::::::::\r\n:::::^^^^~~~~~~JYY5Y55Y5J?JPJ?YPGP??!!!!!!!!!!!!~^::.:::::::::::::::::\r\n::::::^^^^^~~~!755?7JJ7PJ?5GY?5Y77!!!!!!!!!!!!!!!!!~^:..::::::::::::::\r\n::::::::^:::^~~~~!JGPPP5J?Y?!!!~!~!!!!!!!!!!!!!!!!!!!!~^:..:::::::::::\r\n:::::::::^:::^^~~~~!J?7!~!~~!!!!!!!!!!!!!!!!!!!!!!!!!!!!!~^:..::::::::\r\n:::::::::::^:::^^~~~~~~!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!77!~^:..:::::\r\n:::::::::::::^^::^^~~!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!77??7!!!!~::::::\r\n:::::::::::::::^:!7~^^~!!!!!!!!!!!!!!!!!!!!!!!!!!777?777!!!!!!!77~::::\r\n::::::::::::::::^^!?7~^~~!!!!!!!!!!!!!!!!!!!!77??77!!!!!!!!!777?7~^^::\r\n:::::::::::::::::::^!J?~^~~!!!!!!!!!!!!!!77??77!!!!!!!!!!77????7!~^^^^\r\n::::::::::::::::::::^^77?~^~~!!!!!!!!77???7!!!!!!!!!!777????777!~^^^^^\r\n::::::::::::::::::::::^^7J?~^~~!!!!!????7!!!!!!!!777?????777!~~~^^^^::\r\n::::::::::::::::::::::::^^7JJ~^~~!!!!7!!!!!!!777????7777!!~~^^^^^^::::\r\n:::::::::::::::::::::::::^^~7!~7~~~!!!!!!!77?????7777!~~~^^^^^::::::::\r\n:::::::::::::::::::::::::::^^^!!!^^~~!777????7777!~~~^^^^^^:::::::::::\r\n:::::::::::::::::::::::::::::^~!~^^^!???77777!!~~^^^^^::::::::::::::::\r\n:::::::::::::::::::::::::::::::^^~~~7?777!!~~^^^^^::::::::::::::::::::\r\n:::::::::::::::::::::::::::::::::^^!7!!~^^^^^:::::::::::::::::::::::::\r\n:::::::::::::::::::::::::::::::::::^^:::::::::::::::::::::::::::::::::\r\n::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::\r\n::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::\r\n::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::\r\n::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::");
            Console.ReadKey();


            var options = new List<Option>
                    {
                    new Option("Dodaj nowy kontakt", () => phoneBook.AddContact()),
                    new Option("Wyszukaj kontakt po numerze telefonu", () => phoneBook.DisplayContact()),
                    new Option("Wyszukaj wszystkie kontakty", () => phoneBook.DisplayAllContacts()),
                    new Option("Wyszukaj kontakt po imieniu lub nazwisku", () => phoneBook.DisplayMatchingContact()),
                    new Option("Wyjście z programu", () => Environment.Exit(0))
                    };


            // Create options that you want your menu to have

            // Set the default index of the selected item to be the first
            int index = 0;

            // Write the menu out
            WriteMenu(options, options[index]);


            // Store key info in here
            ConsoleKeyInfo keyinfo;
            do
            {
                keyinfo = Console.ReadKey();

                // Handle each key input (down arrow will write the menu again with a different selected item)
                if (keyinfo.Key == ConsoleKey.DownArrow)
                {
                    if (index + 1 < options.Count)
                    {
                        index++;
                        WriteMenu(options, options[index]);
                    }
                }
                if (keyinfo.Key == ConsoleKey.UpArrow)
                {
                    if (index - 1 >= 0)
                    {
                        index--;
                        WriteMenu(options, options[index]);
                    }
                }
                // Handle different action for the option
                if (keyinfo.Key == ConsoleKey.Enter)
                {
                    options[index].Selected.Invoke();
                    index = 0;
                }
            }
            while (keyinfo.Key != ConsoleKey.X);

            Console.ReadKey();
        }

        static void WriteMenu(List<Option> options, Option selectedOption)
        {
            Console.Clear();

            foreach (Option option in options)
            {
                if (option == selectedOption)
                {
                    Console.Write("> ");
                }
                else
                {
                    Console.Write(" ");
                }
                Console.WriteLine(option.Name);
            }
        }
    }

    public class Option
    {
        public string Name { get; }
        public Action Selected { get; }

        public Option(string name, Action selected)
        {
            Name = name;
            Selected = selected;
        }
    }
}
