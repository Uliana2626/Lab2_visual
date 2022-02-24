using Lab2;

RomanNumber n1 = new((ushort)254);
RomanNumber n2 = new((ushort)7);
Console.WriteLine("254 = " + n1);
Console.WriteLine("7 = " + n2);
Console.WriteLine("254 + 7 = " + RomanNumber.Add(n1, n2));
Console.WriteLine("254 - 7 = " + RomanNumber.Sub(n1, n2));
Console.WriteLine("254 * 7 = " + RomanNumber.Mul(n1, n2));
Console.WriteLine("254 / 7 = " + RomanNumber.Div(n1, n2));

short[] number = new short[]
{ 92, 5, 1327, 4, 3337, 228, 1 };
RomanNumber[] romanArray = new RomanNumber[number.Length];
Console.WriteLine("Array:");
for (int i = 0; i < number.Length; i++)
{
    romanArray[i] = new RomanNumber(((ushort)number[i]));
    Console.Write(number[i] + "(" + romanArray[i].ToString() + ")" + " ");
}
Console.WriteLine("\nSorted Array:");
Array.Sort(romanArray);
Array.Sort(number);
for (int i = 0; i < number.Length; i++)
{
    Console.Write(number[i] + "(" + romanArray[i].ToString() + ")" + " ");
}
