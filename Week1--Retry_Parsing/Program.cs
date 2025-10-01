using System;

int attempts = 0;
const int maxAttempts = 3;
int value = 0;
bool success = false;

while (attempts < maxAttempts)
{
    Console.Write($"Enter an integer (attempt {attempts + 1}/{maxAttempts}): ");
    string input = Console.ReadLine();

    if (int.TryParse(input, out value))
    {
        Console.WriteLine($"✅ You entered: {value}");
        success = true;
        break;
    }

    attempts++;
    int remaining = maxAttempts - attempts;
    if (remaining > 0)
        Console.WriteLine($"Invalid input. {remaining} attempt{(remaining > 1 ? "s" : "")} left — please try again.");
    else
        Console.WriteLine("Invalid input.");
}

if (!success)
{
    Console.WriteLine($"\n❌ Sorry — failed to parse an integer after {maxAttempts} attempts. Goodbye!");
}
