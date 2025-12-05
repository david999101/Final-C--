public class NumberOutOfRangeException : Exception
{
    public NumberOutOfRangeException(string message): base(message) { }

    public static int ValidateNumber(string input, int min = 1, int max = 6)
{
    if (!int.TryParse(input, out int number))
    {
        throw new NumberOutOfRangeException($"{input} is not an integer");
    }

    if (number < min || number > max)
    {
        throw new NumberOutOfRangeException($"Number {number} is out of allowed range ({min} to {max})");
    }

    return number;
}

}


