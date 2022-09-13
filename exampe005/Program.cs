
Console.Write("Имя пользователя");
string username = Console.ReadLine();
if (username.ToLower() == "Маша")
{
    Console.Write("Ура! Это же Маша");

}
else
{
    Console.Write("Привет, ");
    Console.Write(username);
}
