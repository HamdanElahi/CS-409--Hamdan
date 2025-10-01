using System;

string? lastChoice = null;

while (true)
{
    Console.WriteLine("\n--- Unit Converter Pro ---");
    Console.WriteLine("1. Kilometers → Miles");
    Console.WriteLine("2. Miles → Kilometers");
    Console.WriteLine("3. Kilograms → Pounds");
    Console.WriteLine("4. Pounds → Kilograms");
    Console.WriteLine("5. Celsius → Fahrenheit");
    Console.WriteLine("6. Fahrenheit → Celsius");
    Console.WriteLine("0. Exit");

    if (lastChoice != null)
        Console.WriteLine($"[Press Enter to repeat last choice ({lastChoice})]");

    Console.Write("Choose an option: ");
    string? choice = Console.ReadLine()?.Trim();

    // Reuse last choice if Enter pressed
    if (string.IsNullOrEmpty(choice) && lastChoice != null)
        choice = lastChoice;

    if (choice == "0")
    {
        Console.WriteLine("👋 Goodbye!");
        break;
    }

    double inputValue;
    bool valid = true;

    switch (choice)
    {
        case "1":
            inputValue = ReadDouble("Enter kilometers: ");
            Console.WriteLine($"{inputValue} km = {inputValue * 0.621371:F2} mi");
            break;

        case "2":
            inputValue = ReadDouble("Enter miles: ");
            Console.WriteLine($"{inputValue} mi = {inputValue / 0.621371:F2} km");
            break;

        case "3":
            inputValue = ReadDouble("Enter kilograms: ");
            Console.WriteLine($"{inputValue} kg = {inputValue * 2.20462:F2} lb");
            break;

        case "4":
            inputValue = ReadDouble("Enter pounds: ");
            Console.WriteLine($"{inputValue} lb = {inputValue / 2.20462:F2} kg");
            break;

        case "5":
            inputValue = ReadDouble("Enter Celsius: ");
            Console.WriteLine($"{inputValue} °C = {(inputValue * 9 / 5) + 32:F2} °F");
            break;

        case "6":
            inputValue = ReadDouble("Enter Fahrenheit: ");
            Console.WriteLine($"{inputValue} °F = {(inputValue - 32) * 5 / 9:F2} °C");
            break;

        default:
            Console.WriteLine("❌ Invalid choice, please try again.");
            valid = false;
            break;
    }

    if (valid) lastChoice = choice;
}

// Helper function
double ReadDouble(string prompt)
{
    while (true)
    {
        Console.Write(prompt);
        string? input = Console.ReadLine()?.Trim();
        if (double.TryParse(input, out double value))
            return value;

        Console.WriteLine("❌ Invalid number, please try again.");
    }
}
