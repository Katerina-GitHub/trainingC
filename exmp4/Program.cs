Console.Write("Представьтесь, пожалуйста");
string user = Console.ReadLine();
if (user.ToLower() == "маша")
{
    Console.WriteLine("Ура, это же Маша!");
}
else
{
    Console.WriteLine("Привет, " + user);
}