// Types: https://learn.microsoft.com/en-gb/dotnet/csharp/language-reference/builtin-types/integral-numeric-types

var one = 1;
Console.WriteLine("{0}: {1}", one, PrintBits(one, 32));

var two = 2;
Console.WriteLine("{0}: {1}", two, PrintBits(two, 32));

var negOne = -1;
Console.WriteLine("{0}: {1}", negOne, PrintBits(negOne, 32));

var negTwo = -2;
Console.WriteLine("{0}: {1}", negTwo, PrintBits(negTwo, 32));


static string PrintBits(int number, int bits)
{
    var res = new char[bits];

    for (var i = bits - 1; i >= 0; i--)
    {
        var bit = (number & 1) == 1 ? '1' : '0';
        res[i] = bit;
        number >>>= 1; // vs >>
    }

    return new string(res);
}
