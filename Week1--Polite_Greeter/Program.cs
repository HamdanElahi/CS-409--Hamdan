using System;

// 1. Read and validate N
int N = 0;
while (true)
{
    Console.Write("Enter number of temperature readings (N > 0): ");
    string input = Console.ReadLine()?.Trim() ?? "";
    if (int.TryParse(input, out N) && N > 0)
        break;
    Console.WriteLine("❌ Invalid number. Please enter a positive integer.");
}

// 2. Create array
int[] temps = new int[N];

// 3. Read N temperatures with validation
for (int i = 0; i < N; i++)
{
    while (true)
    {
        Console.Write($"Enter temperature #{i + 1}: ");
        string tInput = Console.ReadLine()?.Trim() ?? "";
        if (int.TryParse(tInput, out int value))
        {
            temps[i] = value;
            break;
        }
        Console.WriteLine("❌ Invalid temperature. Please enter an integer.");
    }
}

// 4. Initialize stats
int min = temps[0], max = temps[0], sum = 0;

for (int i = 0; i < N; i++)
{
    int t = temps[i];
    if (t < min) min = t;
    if (t > max) max = t;
    sum += t;
}

// 5. Compute average
double avg = sum / (double)N;

// Print results
Console.WriteLine("\n--- Temperature Report ---");
Console.WriteLine($"Count = {N}");
Console.WriteLine($"Min   = {min}");
Console.WriteLine($"Max   = {max}");
Console.WriteLine($"Avg   = {avg:F2}");

// 6. Simple histogram (exact values)
Console.WriteLine("\n--- Histogram ---");
for (int i = 0; i < N; i++)
{
    Console.Write($"{temps[i],4}°C | ");
    for (int star = 0; star < Math.Abs(temps[i]); star++)
        Console.Write("*");
    Console.WriteLine();
}
