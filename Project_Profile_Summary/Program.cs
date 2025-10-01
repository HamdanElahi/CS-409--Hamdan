using System;

// 1. Prompt and validate name
Console.Write("Enter your name: ");
string name = Console.ReadLine()?.Trim() ?? "";
if (string.IsNullOrWhiteSpace(name))
{
    Console.WriteLine("❌ Invalid name. Exiting.");
    return;
}

// 2. Prompt and validate age
Console.Write("Enter your age: ");
string ageText = Console.ReadLine()?.Trim() ?? "";
if (!int.TryParse(ageText, out int age) || age <= 0 || age > 120)
{
    Console.WriteLine("❌ Invalid age. Exiting.");
    return;
}

// 3. Prompt and validate city
Console.Write("Enter your city: ");
string city = Console.ReadLine()?.Trim() ?? "";
if (string.IsNullOrWhiteSpace(city))
{
    Console.WriteLine("❌ Invalid city. Exiting.");
    return;
}

// 4. Print labeled profile
Console.WriteLine("\n--- Profile Summary ---");
Console.WriteLine($"Name: {name}");
Console.WriteLine($"Age:  {age}");
Console.WriteLine($"City: {city}");
