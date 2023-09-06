using System.Globalization;

Console.Write("Choose a snack from 1 to 10: ");
string userChoice = Console.ReadLine();

switch (userChoice)
{
    case "1":
        // Snack 1: L’utente inserisce due numeri in successione. Il software stampa il maggiore.

        Console.WriteLine("First Snack");
        Console.WriteLine();

        bool isNumber = false; // used to check if user insert a number
        double firstNumber = 0; // store the first number
        double secondNumber = 0; // store the second number

        // Repeat until user insert a number
        while (!isNumber)
        {
            Console.Write("Insert the first number: ");
            // check if is possible to convert the user input to a double
            isNumber = Double.TryParse(Console.ReadLine(), NumberStyles.Any, CultureInfo.InvariantCulture, out firstNumber); //  NumberStyles.Any, CultureInfo.InvariantCulture are used to recognize numbers with comma and dot
        }

        // switch back to isNumber false to use the same input control to secondNumber
        isNumber = false;

        while (!isNumber)
        {
            Console.Write("Insert the second number: ");
            isNumber = Double.TryParse(Console.ReadLine(), NumberStyles.Any, CultureInfo.InvariantCulture, out secondNumber);
        }

        // Compare the two numbers ( CompareTo can return 0, 1, -1 )
        int compareNumbers = firstNumber.CompareTo(secondNumber);

        // Send the correct output based on compareNumbers
        switch (compareNumbers)
        {
            case 0:
                Console.WriteLine("I due numeri sono uguali");
                break;
            case 1:
                Console.WriteLine($"{firstNumber} è maggiore di {secondNumber}");
                break;
            case -1:
                Console.WriteLine($"{secondNumber} è maggiore di {firstNumber}");
                break;
        }
        break;
    case "2":
        // Snack 2 : L’utente inserisce due parole in successione. Il software stampa prima la parola più corta, poi la parola più lunga.
        Console.WriteLine();
        Console.WriteLine("Second Snack");

        // Array than contains the two string
        string?[] words = new string[2];

        // Get the first string
        Console.Write("Insert the first word: ");
        words[0] = Console.ReadLine();

        Console.WriteLine();

        // Get the second string
        Console.Write("Insert the second word: ");
        words[1] = Console.ReadLine();

        // Sort the array based on string lenght
        Array.Sort(words, (x, y) => x.Length.CompareTo(y.Length));

        // Print in console all the strings in words array
        foreach (string word in words)
        {
            if (words.Last() == word)
            {
                Console.Write(word);
                break;
            }

            Console.Write($"{word}, ");
        }

        break;
    case "3":
        // Snack 3: Il software deve chiedere per 10 volte all’utente di inserire un numero. Il programma stampa la somma di tutti i numeri inseriti.
        Console.WriteLine();
        Console.WriteLine();

        Console.WriteLine("Third Snack");

        // Array than contains 10 numbers
        double[] numbers = new double[10];

        for (int i = 0; i < 10; i++)
        {
            Console.Write($"Insert the {i + 1}° number: ");
            // Parse string to double
            Double.TryParse(Console.ReadLine(), NumberStyles.Any, CultureInfo.InvariantCulture, out numbers[i]);
        }

        // Sum all values inside numbers
        Console.WriteLine(numbers.Sum());

        break;
    case "4":

        // Snack 4: Calcola la somma e la media dei numeri da 2 a 10.

        Console.WriteLine();

        Console.WriteLine("Fourth Snack");

        int[] twoToTen = Enumerable.Range(2, 9).ToArray();

        foreach (int i in twoToTen)
        {
            Console.Write(i);
            Console.Write(",");

        }

        Console.WriteLine($"The sum is {twoToTen.Sum()} and the average is {Enumerable.Average(twoToTen)}");

        break;
    case "5":
        // Snack 5: Il software chiede all’utente di inserire un numero. Se il numero inserito è pari, stampa il numero, se è dispari, stampa il numero successivo.
        Console.WriteLine();

        Console.WriteLine("Fifth Snack");

        Console.Write("Insert a number: ");
        int userNumber = int.Parse(Console.ReadLine());

        if (userNumber % 2 == 0)
        {
            Console.WriteLine($"{userNumber}");
        }
        else
        {
            Console.WriteLine($"{userNumber + 1}");

        }

        break;
    case "6":
        // Snack 6: In un array sono contenuti i nomi degli invitati alla festa del grande Gatsby. Chiedi all’utente il suo nome e comunicagli se può partecipare o meno alla festa.
        Console.WriteLine();

        Console.WriteLine("Sixth Snack");

        string[] invitedPeople = { "Luca", "Giovanni", "Simone", "Sonia", "Lucia", "Emanuela" };
        Console.Write("What's your name? ");
        string userName = Console.ReadLine();

        if (invitedPeople.Contains(userName))
        {
            Console.Write("You can join the party");
        }
        else
        {
            Console.Write("You can't join the party");
        }

        break;
    case "7":
        // Snack 7: Crea un array vuoto. Chiedi per 6 volte all’utente di inserire un numero, se è dispari inseriscilo nell’array.
        Console.WriteLine();
        Console.WriteLine();

        Console.WriteLine("Seventh Snack");

        int[] evenNumbers = new int[6];

        for (int i = 0; i < 6; i++)
        {
            Console.Write("Insert a number: ");
            int number = int.Parse(Console.ReadLine());

            if (number % 2 != 0)
            {
                evenNumbers[i] = number;
            }
        }

        foreach (int evenNumber in evenNumbers)
        {
            Console.Write(evenNumber);
            Console.Write(",");
        }

        break;
    case "8":
        // Snack 8: Crea un array di numeri interi e fai la somma di tutti gli elementi che sono in posizione dispari.
        Console.WriteLine();

        Console.WriteLine("Eighth Snack");

        int[] numbers1 = { 10, 33, 42, 7, 99, 16 };
        int sum = 0;

        for (int i = 0; i < numbers1.Length; i++)
        {
            if (i % 2 != 0)
            {
                sum += numbers1[i];
            }
        }

        Console.WriteLine(sum);

        break;
    case "9":
        // Snack 9: Crea un array vuoto e chiedi all’utente un numero da inserire nell’array. Continua a chiedere i numeri all’utente e a inserirli nell’array, fino a quando la somma degli elementi è minore di 50.
        Console.WriteLine();

        Console.WriteLine("Ninth Snack");

        List<int> numbers2 = new List<int>();

        do
        {
            Console.Write("Insert a number: ");
            int number = int.Parse(Console.ReadLine());
            numbers2.Add(number);
        } while (numbers2.Sum() < 50);

        Console.WriteLine(numbers2.Sum());

        break;
    case "10":
        // Snack 10: Fai inserire un numero, che chiameremo N, all’utente. Genera N array, ognuno formato da 10 numeri casuali tra 1 e 100. Ogni volta che ne crei uno, stampalo a schermo.
        Console.WriteLine();

        Console.WriteLine("Tenth Snack");

        Random rnd = new Random();

        Console.Write("Insert a number: ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            int[] numbersArray = new int[10];

            for (int j = 0; j < 10; j++)
            {
                numbersArray[j] = rnd.Next(10, 100);
            }

            foreach (int number in numbersArray)
            {
                Console.Write($"{number}, ");
            }

            Console.WriteLine();
        }

        break;

}
