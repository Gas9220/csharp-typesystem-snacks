// Snack 1: L’utente inserisce due numeri in successione. Il software stampa il maggiore.
using System.Globalization;

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


