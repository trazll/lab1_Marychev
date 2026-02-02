// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
// Console.WriteLine("Меня зовут Марычев Е. Н.");
// Console.WriteLine(DateTime.Now);
Console.Write("Введите ваше имя: ");
string name = Console.ReadLine();
Console.WriteLine($"Привет, {name}!");
Console.WriteLine(DateTime.Now);
Console.Write("Хотите продолжить? (y/n): ");
string response = Console.ReadLine();
if (response.ToLower() == "y")
{
Console.WriteLine("Продолжаем работу...");
}
else
{
Console.WriteLine("До свидания");
}