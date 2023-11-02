using System.Linq;


namespace PhoneBook

{
    class Program
    {

        static void Main(string[] args)
        {
            PhoneBook phoneBook = new PhoneBook();

            Console.WriteLine("\n:::::::::  :::    :::  ::::::::  ::::    ::: :::::::::: :::::::::   ::::::::   ::::::::  :::    ::: \r\n:+:    :+: :+:    :+: :+:    :+: :+:+:   :+: :+:        :+:    :+: :+:    :+: :+:    :+: :+:   :+:  \r\n+:+    +:+ +:+    +:+ +:+    +:+ :+:+:+  +:+ +:+        +:+    +:+ +:+    +:+ +:+    +:+ +:+  +:+   \r\n+#++:++#+  +#++:++#++ +#+    +:+ +#+ +:+ +#+ +#++:++#   +#++:++#+  +#+    +:+ +#+    +:+ +#++:++    \r\n+#+        +#+    +#+ +#+    +#+ +#+  +#+#+# +#+        +#+    +#+ +#+    +#+ +#+    +#+ +#+  +#+   \r\n#+#        #+#    #+# #+#    #+# #+#   #+#+# #+#        #+#    #+# #+#    #+# #+#    #+# #+#   #+#  \r\n###        ###    ###  ########  ###    #### ########## #########   ########   ########  ###    ### ");

            Console.WriteLine("\nWitaj w książce telefonicznej! \n\nWciśnij dowolny klawisz aby przejść do menu. \nMożesz się po nim poruszać za pomocą strzałek (góra/dół oraz enter aby zatwierdzić wybór).\n");
            
            Console.ReadKey();


            var options = new List<Option>
                    {
                    new Option("Dodaj nowy kontakt", () => phoneBook.AddContact()),
                    new Option("Wyszukaj kontakt po numerze telefonu", () => phoneBook.DisplayContact()),
                    new Option("Wyszukaj kontakt po imieniu lub nazwisku", () => phoneBook.DisplayMatchingContact()),
                    new Option("Wyświetl wszystkie kontakty", () => phoneBook.DisplayAllContacts()),
                    new Option("Wyjście z programu", () => Environment.Exit(0))
                    };


            int index = 0;

            WriteMenu(options, options[index]);


            ConsoleKeyInfo keyinfo;
            do
            {
                keyinfo = Console.ReadKey();


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
