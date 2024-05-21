
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
    //Users.UserList().Add(newUser);
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
    Console.WriteLine("2. View all users (after you pick this you can choose to add them as a friend)");
    Console.WriteLine("Please type 1 or 2");
    int input = Convert.ToInt32(Console.ReadLine());
    switch (input)
    {
        case 1: RunShowFriends(); break;
        case 2: RunShowUsers(); break;
        default:
            RunMenu(); break;
    }
}

void RunShowFriends()
{
    var friendList = Users.AddFriendList();
    if (friendList.Count == 0)
    {
        Console.WriteLine("You have no friends added yet.");
        RunMenu();
    }
    else
    {
        foreach (var friend in friendList)
        {
            Console.WriteLine(friend.Name);
        }
        Console.WriteLine("What would you like to do?");
        Console.WriteLine("1. Remove a friend");
        Console.WriteLine("2. See a friends info");
        Console.WriteLine("Please type 1 or 2");
        int input = Convert.ToInt32(Console.ReadLine());
        switch (input)
        {
            case 1: RunDeleteFriend(); break;
            case 2: RunSeeFriendsInfo(); break;
            default:
                RunMenu(); break;
        }
    }
}

void RunShowUsers()
{
    var userList = Users.UserList();
    foreach (var user in userList)
    {
        Console.WriteLine(user.Name);
    }

    Console.WriteLine("Which user would you like to add as a friend? Please type their name:");
    string input = Console.ReadLine();
    Users newFriend = userList.Find(p => p.Name == input);

    if (newFriend != null)
    {
        Users.AddFriendList().Add(newFriend);
        Console.WriteLine($"Successfully added {input} as your friend!");
    }
    else
    {
        Console.WriteLine($"User with name {input} not found.");
    }

    Console.WriteLine("What would you like to do now?");
    Console.WriteLine("1. View my friends");
    Console.WriteLine("2. See user list again");
    Console.WriteLine("Please type 1 or 2");
    int input2 = Convert.ToInt32(Console.ReadLine());
    switch (input2)
    {
        case 1: RunShowFriends(); break;
        case 2: RunShowUsers(); break;
        default:
            RunMenu(); break;
    }
}

