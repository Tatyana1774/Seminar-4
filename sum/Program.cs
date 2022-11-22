    /* Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
    452 -> 11
    82 -> 10
    9012 -> 12*/
    Console.WriteLine("Введите любое число ");
    string? n = Console.ReadLine();
    int[] numbers = ConvertToIntArray(n);
    Console.WriteLine($"{n} -> {Sum(numbers)}");

    int[] ConvertToIntArray(string n) {
    int[] numbers = new int[n.Length];
    for(int i = 0; i < n.Length; i++) {
    numbers[i] = (int) Char.GetNumericValue(n[i]);
    }
    return numbers;
    }

    int Sum(int[] numbers)
    {
    int sum = 0;
    for(int i = 0; i < numbers.Length; i++) {
    sum += numbers[i];
    }
    return sum;
    }

