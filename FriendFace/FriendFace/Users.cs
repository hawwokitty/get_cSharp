namespace FriendFace
{
    internal class Users(string name, string email, string password, string bio)
    {
        public string Name { get; private set; } = name;
        private string Email { get; } = email;
        private string Password { get; } = password;
        private string Bio { get; set; } = bio;
        private static List<Users> friendList = new ();
        private static List<Users> usersList = InitializeUserList();

        internal static List<Users> UserList()
        {
            return usersList;
        }
        private static List<Users> InitializeUserList()
        {
            return new List<Users>
            {
                new Users("Kitty Drage", "hawwokitty@outlook.com", "123", "I love hello kitty :D"),
                new Users("Creature Ash", "cribber@hotmail.com", "321", "Octopus :D"),
                new Users("Lars GB", "lars_GB@gmail.com", "456", "Legend of Zelda :D"),
                new Users("Violine Tries", "viotry@msn.com", "654", "Freja and Luna <3 :D")
            };
        }

        internal static List<Users> AddFriendList()
        {
            return friendList;
        }


        // help from chat gpt to validate below:
        public static bool ValidateUser(string email, string password)
        {
            foreach (var user in usersList)
            {
                if (user.Email == email && user.Password == password)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
