
using System.Reflection.Metadata;
using FriendFace;

Console.WriteLine("Welcome to FriendFace!");
Console.WriteLine("Would you like to 1. sign up or 2. log in? please type 1 or 2");
int input = Convert.ToInt32(Console.ReadLine());
switch (input)
{
    case 1: RunSignUp(); break;
    case 2: RunLogIn(); break;
    default:
        Console.WriteLine("that's not 1 or 2"); break;
}

void RunSignUp()
{
    Console.WriteLine("Please type your full name:");
    string username = Console.ReadLine();
    Console.WriteLine("Please type in your email:");
    string email = Console.ReadLine();
    Console.WriteLine("Please type in your password, theres no security here, im just testing stuff <3:");
    string password = Console.ReadLine();
    Console.WriteLine("Please type in your bio:");
    string bio = Console.ReadLine();
    var newUser = new Users(username, email, password, bio);
    var userList = Users.UserList();
    userList.Add(newUser);
    Users.UserList().Add(newUser);
    Console.WriteLine($"{newUser.Name} has been added.");
    RunLogIn();
    
}

void RunLogIn()
{
    Console.WriteLine("Please type your email:");
    string email = Console.ReadLine();
    Console.WriteLine("Please type your password:");
    string password = Console.ReadLine();
    var isValidUser = Users.ValidateUser(email, password);
    if (isValidUser)
    {
        new LoggedInUser(email, password);
        Console.WriteLine("Login successful!");
        RunMenu();
    }
    else
    {
        Console.WriteLine("Login failed. Invalid email or password.");
        RunLogIn();
    }
}

void RunMenu()
{
    Console.WriteLine("What would you like to do?");
    Console.WriteLine("1. View my friends (after you pick this you can choose to remove friend or view their info)");
    Console.WriteLine("2. Add new friend");
    Console.WriteLine("Please type 1 or 2");
    int input = Convert.ToInt32(Console.ReadLine());
    switch (input)
    {
        case 1: RunShowFriends(); break;
        case 2: RunAddFriend(); break;
        default:
            RunMenu(); break;
    }
}

void RunShowFriends()
{

}

void RunAddFriend()
{

}