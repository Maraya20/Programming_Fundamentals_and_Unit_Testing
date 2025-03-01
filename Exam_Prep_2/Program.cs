int number = int.Parse(Console.ReadLine());

List<int> primeNumbers = new List<int>();
List<int> primeDigits = new List<int> { 2, 3, 5, 7 };

for (int num = 1; num < number; num++)
{
    if (isPrimeAndIsAllDigitsDivisibleBy2(
        AllDigitsArePrimeNumbers(num, primeDigits), 
        SumOfAllDigitsIsDivisibleBy2(num))
        )

        { primeNumbers.Add(num); }

}

if (!primeNumbers.Any())
    Console.WriteLine("no");
else
{
    Console.WriteLine(string.Join(" ", primeNumbers)); // { 2, 3, 5, 7 } -> 2 3 5 7

}

static bool AllDigitsArePrimeNumbers(int number, List<int> primeDigits)  // 2, 3, 5, 7
{
    foreach (char digitChar in number.ToString())
    {
        int digit = int.Parse(digitChar.ToString()); // Convert char to int
        if (!primeDigits.Contains(digit))
            return false; // If a digit is not prime, return false
    }

    return true; // All digits are prime
}

static bool SumOfAllDigitsIsDivisibleBy2(int number)
{
    int sum = 0;

    foreach (char digitChar in number.ToString())
    {
        int digit = int.Parse(digitChar.ToString()); // Convert char to int
        sum += digit;
    }

    if (sum % 2 == 0) return true;
    return false;
}

static bool isPrimeAndIsAllDigitsDivisibleBy2(bool isPrime, bool isAllDigitsDivisibleBy2)
{
    if (isPrime && isAllDigitsDivisibleBy2)
        return true;
    return false;
}


















//int number = int.Parse(Console.ReadLine());
//List<int> magicNumbers = new List<int>();

//for (int num = 1; num <= number; num++)
//{
//    if (AllDigitsArePrime(num) && SumOfDigitsIsDivisibleBy2(num))
//    {
//        magicNumbers.Add(num);
//    }
//}

//if (!magicNumbers.Any())
//    Console.WriteLine("no");
//else
//    Console.WriteLine(string.Join(" ", magicNumbers));


//// Check if all digits of a number are prime
//static bool AllDigitsArePrime(int number)
//{
//    while (number > 0)
//    {
//        int digit = number % 10;
//        if (!IsPrime(digit))
//            return false;
//        number /= 10;
//    }
//    return true;
//}

//// Check if sum of digits is divisible by 2
//static bool SumOfDigitsIsDivisibleBy2(int number)
//{
//    int sum = 0;
//    while (number > 0)
//    {
//        sum += number % 10;
//        number /= 10;
//    }
//    return sum % 2 == 0;
//}

//// Check if a number is prime
//static bool IsPrime(int number)
//{
//    if (number < 2) return false;
//    if (number == 2) return true;
//    if (number % 2 == 0) return false;

//    for (int i = 3; i * i <= number; i += 2)
//    {
//        if (number % i == 0) return false;
//    }
//    return true;
//}
