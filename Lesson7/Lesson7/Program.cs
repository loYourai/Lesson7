
using System.Text;
/*
char c = 'A';
Console.WriteLine(c);

void GetCharInfo(char c)
{
    Console.WriteLine($"Value: {c}" );
    Console.WriteLine($"IsDigigt: { char.IsDigit(c)}");
    Console.WriteLine($"IsLetter: {char.IsLetter(c)}");
    Console.WriteLine($"IsLower: {char.IsLower(c)}");
    Console.WriteLine($"IsUpper: {char.IsUpper(c)}");
    Console.WriteLine($"IsSymbol: {char.IsSymbol(c)}");
    Console.WriteLine($"IsAscii: {char.IsAscii(c)}");
}

string s1 = "AA";
string  address = "Zaporozskaya"; //  ""
string s2 = "BB";


string[] cities = { "Kyiv", "Lviv", "Dnipro", "Odesa" };
*/
/*
StringBuilder allCities = new StringBuilder();

var allCitites = new StringBuilder();
foreach (var item in cities)
{
    allCitites.AppendLine(item);

}
Console.WriteLine(allCitites);

*/


/*
string newString = address.Replace("Zaporozskaya", "Chreshatik", StringComparison.InvariantCultureIgnoreCase);
Console.WriteLine(address);

newString = newString.Insert(newString.Length, ",Planet Earth");
newString = newString.Substring(0, 2);
Console.WriteLine(newString);
*/
/*
if (!string.IsNullOrWhiteSpace(address))
{
    Console.WriteLine(address);
}



if (!string.IsNullOrEmpty(address))
{
    Console.WriteLine(address);
}
*/
/*
if ( s1.ToLower() == s2.ToLower() )
{
    Console.WriteLine("s1 == s2 ");
}
*/
/*
var splitResult = address.Split(", ");

foreach(var item in splitResult)
{
    Console.WriteLine(item);
}

foreach (var item in address)
{
    GetCharInfo(item);
}
*/
//Console.WriteLine(address.IndexOf('k')); // проверяет позицию буквы

//Console.WriteLine(address.Contains("zaporozskaya"));

//Console.WriteLine(s1.EndsWith(s2)); разные методы EndsWith..Contains
//Console.WriteLine(s1);
//Console.WriteLine(s2);

//GetCharInfo(c);
/*
var inputString = Console.ReadLine();

var splittedInput = inputString.Trim().Split(" ");
int[] resultArray = new int[splittedInput.Length];
int i = 0;

foreach (var item in splittedInput)
{
   if (int.TryParse(item, out var parsedResult))
    {
        resultArray[i++] = parsedResult;  
    }
}
*/











//HOMEWORK
//1 задание
Console.Write($"Напишите 1 значение:  ") ;
string s1 = Console.ReadLine();
Console.Write($"Напишите 2 значение:  ");
string s2 = Console.ReadLine();

Console.WriteLine(String.Equals(s1, s2));


// 2 задание
Console.WriteLine($"Напишите значение:  ");
string s3 = Console.ReadLine();
Console.WriteLine("1) The length of '{0}' is {1}", s3, s3.Length);
// int length = s3.Length;

//3 задание
Console.Write($"Напишите 1 значение:  ");
string s4 = Console.ReadLine();
s4 = String.Concat(s4.OrderBy(ch => ch));
Console.WriteLine(s4);


// 4 задание (не знаю как решить)
Console.Write($"Напишите 1 значение:  ");
string s5 = Console.ReadLine();
Console.WriteLine(String.ToLower(s5));









