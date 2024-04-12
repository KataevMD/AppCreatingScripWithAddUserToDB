// See https://aka.ms/new-console-template for more informatio
using AppCreatingScripWithAddUserToDB.Model;

List<Group> Groups = new List<Group>();

Console.WriteLine("Приложения по созданию скрипта, для добавления пользователей на сервер баз данных MS SQL Server");
Console.WriteLine();
while (true)
{
    bool added = true;
    while (added)
    {
        Console.Write("Введите название группы: ");
        string titleGroup = Console.ReadLine();

        Console.Write("Введите количество человек в группе: ");
        int numberPeopleInGroup = int.Parse(Console.ReadLine());

        Groups.Add(new Group(titleGroup, numberPeopleInGroup));

        Console.Write("Добавить еще одну группу? Введите Y, если да, или N, если нет: ");
        string answear = Console.ReadLine();
        if (answear != "y" || answear != "Y")
        {
            added = false;
        }
    }
    


}