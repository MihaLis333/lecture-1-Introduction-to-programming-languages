Console.Write("Введите имя: ");
string name = Console.ReadLine();

if(name.ToLower == "Маша")
{
    Console.WriteLine("Ура, это же Маша");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(name);
}