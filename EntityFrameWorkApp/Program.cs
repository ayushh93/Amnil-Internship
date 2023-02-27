using EntityFrameWorkApp;

UserService user = new UserService();

Console.WriteLine("Welcome to Entity Framework!");
bool repeat = true;
do
{
    Console.WriteLine("The list of users:");
    user.DisplayUser();
    Console.WriteLine("Choose an operation from the list below:(1/2/3/4)");
    Console.WriteLine("1.Insert User \n2.Update User \n3.Delete User \n4.Display all users");
    int operation = Convert.ToInt32(Console.ReadLine());

    switch (operation)
    {
        case 1:
            user.InsertUser();
            
            break;

        case 2:
            user.UpdateUser();
            
            break;

        case 3:
            user.DeleteUser();
            break;

        case 4:
            user.DisplayUser();
            break;

        default:
            Console.WriteLine("Invalid request!");
            break;
    }
    Console.WriteLine("Do you want to close this application?(yes/no)");
    string response = Console.ReadLine();
    if (response.ToLower() == "yes" || string.IsNullOrEmpty(response))
    {
        repeat = false;
    }
} while(repeat);
//user.InsertUser();
