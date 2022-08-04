Console.Write("Введите имя пользователя:  ");
string username = Console.ReadLine()!;

if(username.ToLower()=="света")
{
     Console.WriteLine("Ура, это СВЕТА!");
}
else
{
     Console.Write("Привет, ");
     Console.WriteLine(username);

}