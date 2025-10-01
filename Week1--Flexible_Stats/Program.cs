using System;

int count = 0;
int sum = 0;
int min = 0, max = 0;
bool firstNumber = true;

while (true)
{
    Console.Write("Enter a whole number (blank to finish): ");
    string input = Console.ReadLine();    // no "string?"

    if (string.IsNullOrWhiteSpace(input))
        break;

    if (int.TryParse(input, out int number))
    {
        count++;
        sum += number;
        if (firstNumber) { min = max = number; firstNumber = false; }
        else { if (number < min) min = number; if (number > max) max = number; }
    }
    else
    {
        Console.WriteLine("❌ Invalid input, please enter a valid integer.");
    }
}

if (count > 0)
{
    double avg = sum / (double)count;
    Console.WriteLine($"\nCount = {count}");
    Console.WriteLine($"Min   = {min}");
    Console.WriteLine($"Max   = {max}");
    Console.WriteLine($"Avg   = {avg:F2}");
}
else
{
    Console.WriteLine("No valid numbers entered.");
}
